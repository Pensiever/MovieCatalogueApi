using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalogueApi.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int PersonId { get; set; }
        public string Role { get; set; }
    }
}