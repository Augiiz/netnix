using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace netnix.Models
{
    public class Movie
    {
        public string id { get; set; }
        public string name { get; set; }
        public string releaseDate { get; set; }
        public string shortDescription { get; set; }
        public string description { get; set; }
        [JsonProperty(PropertyName = "image:")]
        public string image { get; set; }
        public Director director { get; set; }
        public Likes likes { get; set; }

    }

}
