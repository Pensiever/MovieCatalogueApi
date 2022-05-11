using DAL.Repository;
using model = Model.Models;
using dal = DAL.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Model.Tools;
using System.Linq;
using DAL.Models;
using DAL.Interface;
using Model.Services.Interface;

namespace Model.Services
{
    public class PersonService : IPersonService
    {
        private IMovieRepository<dal.Movie, dal.Actor> _movieRepo;
        private IPersonRepository<dal.Person, dal.Cast> _repo;
        public PersonService(IPersonRepository<dal.Person, dal.Cast> PersonRepo, IMovieRepository<dal.Movie, dal.Actor> movieRepository)
        {
            _repo = PersonRepo;
            _movieRepo = movieRepository;
        }

        public model.Person GetOne(int Id)
        {
            return _repo.GetOne(Id).toModel();
        }

        public model.CompletePerson GetDetails(int Id)
        {

            return _repo.GetOne(Id).toCPerson(_movieRepo, _repo);
        }

        public IEnumerable<model.Person> GetAll()
        {
            return _repo.GetAll().Select(x => x.toModel());
        }

        public void Create(model.Person p)
        {
            _repo.Insert(p.toDal());
        }

        public IEnumerable<model.Cast> GetActs(int Id)
        {
            return _repo.GetMovieByPersonId(Id).Select(x => x.toModel());
        }

        public bool Delete(int Id)
        {
            return _repo.Delete(Id);
        }

        public void Update(model.Person p)
        {
            _repo.Update(p.toDal());
        }

        public void SetAsActor(int movieId, int personId, string Role)
        {
            _repo.SetAsActor(movieId, personId, Role);
        }

    }
}