using MovieCatalogueApi.Models;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalogueApi.Tools
{
    public static class Mappers
    {
        public static User toModel(this NewUserInfo newUser)
        {
            return new User
            {
                Email = newUser.Email,
                LastName = newUser.LastName,
                FirstName = newUser.FirstName,
                Password = newUser.Password,
                BirthDate = newUser.BirthDate
            };
        }

        public static Model.Models.Person toModel(this Models.Person p)
        {
            return new Model.Models.Person
            {
                LastName = p.LastName,
                FirstName = p.FirstName
            };
        }
    }
}