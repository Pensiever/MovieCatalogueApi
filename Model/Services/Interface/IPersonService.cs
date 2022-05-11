using Model.Models;
using System.Collections.Generic;

namespace Model.Services.Interface
{
    public interface IPersonService
    {
        void Create(Person p);
        bool Delete(int Id);
        IEnumerable<Cast> GetActs(int Id);
        IEnumerable<Person> GetAll();
        CompletePerson GetDetails(int Id);
        Person GetOne(int Id);
        void Update(Person p);
        void SetAsActor(int movieId, int personId, string Role);
    }
}