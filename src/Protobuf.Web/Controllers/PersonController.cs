using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Protobuf.Contracts;

namespace Protobuf.Web.Controllers
{
    public class PersonController : ApiController
    {
        public async Task<IEnumerable<Person>> Get()
        {
            return GetPersons();
        }

        // GET api/values/5
        public async Task<Person> Get(int id)
        {
            return GetPersons()[0];
        }

        private IList<Person> GetPersons()
        {
            return new Person[] {
                new Person
                {
                    PersonId = 1,
                    FirstName = "Person1",
                    LastName = "Person1",
                    Gender = Gender.Male,
                    BirthDate = DateTime.Now.AddYears(-25).Date,
                    IsActive = true,
                    PhoneNumbers = new List<Phone>
                    {
                        new Phone
                        {
                            AreaCode = "809",
                            Number = "1231234",
                            Extension = string.Empty,
                            Type = PhoneType.Mobile
                        }
                    },
                    Addresses = new List<Address>
                    {
                        new Address
                        {
                            AddressLine1 = "Address1",
                            AddressLine2 = "Address1",
                            AddressLine3 = "Address1",
                            City = "City1",
                            StateProvince = "StateProvince1",
                            PostalCode = "PostalCode1",
                            Country = "Country1",
                            Type = AddressType.Home
                        }
                    }
                },
                new Person
                {
                    PersonId = 2,
                    FirstName = "Person2",
                    LastName = "Person2",
                    Gender = Gender.Male,
                    BirthDate = DateTime.Now.AddYears(-30).Date,
                    IsActive = true,
                    PhoneNumbers = new List<Phone>
                    {
                        new Phone
                        {
                            AreaCode = "801",
                            Number = "9879876",
                            Extension = string.Empty,
                            Type = PhoneType.Mobile
                        }
                    },
                    Addresses = new List<Address>
                    {
                        new Address
                        {
                            AddressLine1 = "Address2",
                            AddressLine2 = "Address2",
                            AddressLine3 = "Address2",
                            City = "City2",
                            StateProvince = "StateProvince2",
                            PostalCode = "PostalCode2",
                            Country = "Country2",
                            Type = AddressType.Home
                        }
                    }
                },
                new Person
                {
                    PersonId = 3,
                    FirstName = "Person3",
                    LastName = "Person3",
                    Gender = Gender.Male,
                    BirthDate = DateTime.Now.AddYears(-30).Date,
                    IsActive = true,
                    PhoneNumbers = new List<Phone>
                    {
                        new Phone
                        {
                            AreaCode = "801",
                            Number = "9879876",
                            Extension = string.Empty,
                            Type = PhoneType.Mobile
                        }
                    },
                    Addresses = new List<Address>
                    {
                        new Address
                        {
                            AddressLine1 = "Address3",
                            AddressLine2 = "Address3",
                            AddressLine3 = "Address3",
                            City = "City3",
                            StateProvince = "StateProvince3",
                            PostalCode = "PostalCode3",
                            Country = "Country3",
                            Type = AddressType.Home
                        }
                    }
                }
            };
        }
    }
}