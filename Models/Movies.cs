using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netnix.Models
{

    public class Movies
    {
        public string id { get; set; }
        public string name { get; set; }
        public DateTime releaseDate { get; set; }
        public Director director { get; set; }
    }
}
