using DAL.Repository;
using model = Model.Models;
using dal = DAL.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Model.Tools;
using System.Linq;
using Model.Models;
using DAL.Interface;
using Model.Services.Interface;

namespace Model.Services
{
    public class MovieService : IMovieService
    {
        private IMovieRepository<dal.Movie, dal.Actor> _movieRepo;
        private IPersonRepository<dal.Person, dal.Cast> _personRepo;

        public MovieService(IMovieRepository<dal.Movie, dal.Actor> movieRepo, IPersonRepository<dal.Person, dal.Cast> PersonRepo)
        {
            _movieRepo = movieRepo;
            _personRepo = PersonRepo;
        }

        public void Delete(int Id)
        {
            _movieRepo.Delete(Id);
        }

        public void Update(NewMovie m)
        {
            _movieRepo.Update(m.toDal());
        }

        public int Create(NewMovie m)
        {
            return _movieRepo.Insert(m.toDal());
        }

        public model.Movie GetOne(int Id)
        {
            return _movieRepo.GetOne(Id).toModel(_movieRepo, _personRepo);
        }

        public IEnumerable<model.Movie> GetAll()
        {
            return _movieRepo.GetAll().Select(x => x.toModel(_movieRepo, _personRepo));
        }

        public IEnumerable<model.Movie> GetByRealisatorId(int Id)
        {
            return _movieRepo.GetByRealisatorId(Id).Select(x => x.toModel(_movieRepo, _personRepo));
        }

        public IEnumerable<model.Movie> GetByScenaristId(int Id)
        {
            return _movieRepo.GetByScenaristId(Id).Select(x => x.toModel(_movieRepo, _personRepo));
        }

        public IEnumerable<model.Actor> GetActors(int Id)
        {
            return _movieRepo.GetActorsByFilmId(Id).Select(x => x.toModel());
        }

        public void SetAsActor(int MovieId, int PersonId, string Role)
        {
            _movieRepo.SetAsActor(MovieId, PersonId, Role);
        }
    }
}