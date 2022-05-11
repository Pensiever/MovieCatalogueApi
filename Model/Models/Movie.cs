﻿using DAL.Interface;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Model.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public Person Realisator { get; set; }
        public Person Scenarist { get; set; }
        public IEnumerable<Actor> Actors { get; set; }

    }
}