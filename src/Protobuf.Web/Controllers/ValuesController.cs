using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Protobuf.Contracts;

namespace Protobuf.Web.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public async Task<IEnumerable<Person>> Get()
        {
            return GetPersons();
        }

        // GET api/values/5
        public async Task<Person> Get(int id)
        {
            return GetPersons()[0];
        }

        // POST api/values
        public async Task Post([FromBody]Person person)
        {
            return;
        }

        // PUT api/values/5
        public async Task Put(int id, [FromBody]Person person)
        {
            return;
        }

        // DELETE api/values/5
        public async Task Delete(int id)
        {
            return;
        }

        private IList<Person> GetPersons()
        {
            var list = new List<Person>();

            for (var i = 0; i < 1000; i++)
            {
                list.Add(new Person
                {
                    PersonId = i,
                    FirstName = $"Person{i}",
                    LastName = "Person{i}",
                    Gender = Gender.Male,
                    BirthDate = DateTime.Now.AddYears(-25).Date,
                    IsActive = true,
                    PhoneNumbers = new List<Phone>
                    {
                        new Phone
                        {
                            AreaCode = $"{i}{i}{i}",
                            Number = $"{i}{i}{i}-{i}{i}{i}{i}",
                            Extension = $"{i}",
                            Type = PhoneType.Mobile
                        }
                    },
                    Addresses = new List<Address>
                    {
                        new Address
                        {
                            AddressLine1 = $"Address{i}",
                            AddressLine2 = $"Address{i}",
                            AddressLine3 = $"Address{i}",
                            City = $"City{i}",
                            StateProvince = $"StateProvince{i}",
                            PostalCode = $"PostalCode{i}",
                            Country = $"Country{i}",
                            Type = AddressType.Home
                        }
                    }
                });
            }

            return list;
        }
    }
}
