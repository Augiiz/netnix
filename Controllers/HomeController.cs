using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using netnix.Models;
using Polly;
using System.Net.Http.Json;

namespace netnix.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        private async Task<IEnumerable<Movies>> GetMoviesList()
        {
            // instance of HttpClient factor from startup.cs
            var client = _httpClientFactory.CreateClient("API Client");

            // call api and wait for response
            var result = await client.GetAsync("https://virtserver.swaggerhub.com/BartvdPost/NetNix/0.2.0/soon/");

            if (result.IsSuccessStatusCode)
            {
                // read response and deserialise
                var content = await result.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<IEnumerable<Movies>>(content);
            }
            return null;
        }

        [HttpGet]
        private async Task<Movie> GetMovieData(string id)
        {
            // instance of HttpClient factor from startup.cs
            var client = _httpClientFactory.CreateClient("API Client");

            // call api and wait for response
            var result = await client.GetAsync("https://virtserver.swaggerhub.com/BartvdPost/NetNix/0.2.0/movie/" + id);
            if (result.IsSuccessStatusCode)
            {
                // read response and deserialise
                var content = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Movie>(content);
            }
            return null;
        }


        [HttpGet]
        private async Task<Likes> GetLikes(string id)
        {
            // instance of HttpClient factor from startup.cs
            var client = _httpClientFactory.CreateClient("API Client");

            // call api and wait for response
            var result = await client.GetAsync("https://virtserver.swaggerhub.com/BartvdPost/NetNix/0.2.0/like/" + id);
            if (result.IsSuccessStatusCode)
            {
                // read response and deserialise
                var content = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Likes>(content);
            }
            return null;
        }

        [HttpGet]
        private async Task<DirectorFull> GetDirectorData(string id)
        {
            // instance of HttpClient factor from startup.cs
            var client = _httpClientFactory.CreateClient("API Client");

            // call api and wait for response
            var result = await client.GetAsync("https://virtserver.swaggerhub.com/BartvdPost/NetNix/0.2.0/director/" + id);

            if (result.IsSuccessStatusCode)
            {
                // read response and deserialise
                var content = await result.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<DirectorFull>(content);
            }
            return null;
        }
        private async Task<Like> CreateLike(string id)
        {
            return null;
        }

        //[HttpPost]
        //private async Task<Like> CreateLike(string id, string username)
        //{
        //    // instance of HttpClient factor from startup.cs
        //    var client = _httpClientFactory.CreateClient("API Client");

        //    var result = await client.PostAsync("https://virtserver.swaggerhub.com/BartvdPost/NetNix/0.2.0/like/", id);

        //    if (result.IsSuccessStatusCode)
        //    {
        //        return View(like);
        //    }
        //    return View(Index);
        //}

        public async Task<IActionResult> Index()
        {
            var model = await GetMoviesList();
            // Pass the data into the View
            return View(model);
        }

        public async Task<IActionResult> Movie(string id)
        {
            var model = await GetMovieData(id);
            var likes = GetLikes(model.id).Result;
            model.likes = likes;
            // Pass the data into the View
            return View(model);
        }
        public async Task<IActionResult> Like(string id)
        {
            var model = await CreateLike(id);
            return View(new Like
            {
                movieId = id
            });
        }

        public async Task<IActionResult> Director(string id)
        {
            var model = await GetDirectorData(id);
            // Pass the data into the View
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
