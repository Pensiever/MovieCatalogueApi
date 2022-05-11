using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class CompletePerson
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public IEnumerable<Movie> RealisatorMovies { get; set; }
        public IEnumerable<Movie> ScenaristMovies { get; set; }
        public IEnumerable<Cast> CastedAs { get; set; }

    }
}