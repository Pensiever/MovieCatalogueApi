using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface IPersonRepository<Person, Cast>
    {
        IEnumerable<Person> GetAll();
        Person GetOne(int Id);
        void Insert(Person c);
        void Update(Person c);
        bool Delete(int Id);
        IEnumerable<Cast> GetMovieByPersonId(int Id);
        void SetAsActor(int movieId, int personId, string Role);
    }
}