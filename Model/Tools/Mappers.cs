using System;
using System.Collections.Generic;
using System.Text;
using model = Model.Models;
using dal = DAL.Models;
using System.Runtime.CompilerServices;
using Model.Services;
using DAL.Interface;
using DAL.Models;
using Model.Services.Interface;
using System.Linq;

namespace Model.Tools
{
    public static class Mappers
    {


        public static model.Movie toModel(this dal.Movie m, IMovieRepository<dal.Movie, dal.Actor> _movieService, IPersonRepository<dal.Person, dal.Cast> _personService)
        {
            return new model.Movie
            {
                Id = m.Id,
                Title = m.Title,
                Description = m.Description,
                ReleaseYear = m.ReleaseYear,
                Realisator = _personService.GetOne(m.RealisatorID).toModel(),
                Scenarist = _personService.GetOne(m.ScenaristID).toModel(),
                Actors = _movieService.GetActorsByFilmId(m.Id).Select(x => x.toModel())
            };
        }

        public static model.Person toModel(this dal.Person p)
        {
            return new model.Person
            {
                Id = p.Id,
                LastName = p.LastName,
                FirstName = p.FirstName
            };
        }

        public static dal.Person toDal(this model.Person p)
        {
            return new dal.Person
            {
                Id = p.Id,
                LastName = p.LastName,
                FirstName = p.FirstName
            };
        }

        public static model.CompletePerson toCPerson(this dal.Person p, IMovieRepository<dal.Movie, dal.Actor> _movieService, IPersonRepository<dal.Person, dal.Cast> _personService)
        {
            return new model.CompletePerson
            {
                Id = p.Id,
                LastName = p.LastName,
                FirstName = p.FirstName,
                RealisatorMovies = _movieService.GetByRealisatorId(p.Id).Select(x => x.toModel(_movieService, _personService)),
                ScenaristMovies = _movieService.GetByScenaristId(p.Id).Select(x => x.toModel(_movieService, _personService)),
                CastedAs = _personService.GetMovieByPersonId(p.Id).Select(x => x.toModel())
            };
        }



        public static dal.Movie toDal(this model.NewMovie m)
        {
            return new dal.Movie
            {
                Id = m.Id,
                Title = m.Title,
                Description = m.Description,
                ReleaseYear = m.ReleaseYear,
                RealisatorID = m.RealisatorID,
                ScenaristID = m.ScenaristID
            };
        }

        public static model.Actor toModel(this dal.Actor a)
        {
            return new model.Actor
            {
                Id = a.Id,
                Role = a.Role,
                LastName = a.LastName,
                FirstName = a.FirstName
            };
        }

        public static model.Cast toModel(this dal.Cast a)
        {
            return new model.Cast
            {
                Role = a.Role,
                MovieTitle = a.MovieTitle,
                MovieID = a.MovieId
            };
        }

        public static model.User toModel(this dal.User u)
        {
            return new model.User
            {
                Id = u.Id,
                Email = u.Email,
                Password = u.Password,
                LastName = u.LastName,
                FirstName = u.FirstName,
                BirthDate = u.BirthDate,
                IsActive = u.IsActive,
                IsAdmin = u.IsAdmin
            };
        }

        public static dal.User toDal(this model.User u)
        {
            return new dal.User
            {
                Id = u.Id,
                Email = u.Email,
                Password = u.Password,
                LastName = u.LastName,
                FirstName = u.FirstName,
                BirthDate = u.BirthDate,
                IsActive = u.IsActive,
                IsAdmin = u.IsAdmin
            };
        }

        public static model.Comment toModel(this dal.Comment c)
        {
            return new model.Comment
            {
                Id = c.Id,
                Content = c.Content,
                PostDate = c.PostDate,
                MovieID = c.MovieID,
                UserID = c.UserID
            };
        }

        public static dal.Comment toDal(this model.Comment c)
        {
            return new dal.Comment
            {
                Id = c.Id,
                Content = c.Content,
                PostDate = c.PostDate,
                MovieID = c.MovieID,
                UserID = c.UserID
            };
        }
    }
}