using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Protobuf.Contracts;
using WebApiContrib.Formatting;

namespace Protobuf.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProtoBufValues();
            RunJsonPersons();
        }

        static void RunProtoBufValue()
        {
            var run = true;

            while (run)
            {
                var client = new HttpClient { BaseAddress = new Uri("http://localhost:53700/") };
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-protobuf"));

                HttpResponseMessage response = client.GetAsync("api/Values/1").Result;

                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body. Blocking!
                    var person = response.Content.ReadAsAsync<Person>(new[] { new ProtoBufFormatter() }).Result;

                    Console.WriteLine($"{person.PersonId}\t{person.FirstName}\t{person.LastName}\t{person.Gender}");
                }
                else
                {
                    Console.WriteLine($"{(int)response.StatusCode} ({response.ReasonPhrase})");
                }

                var result = Console.ReadLine();
                if (result == "quit")
                {
                    run = false;
                }
            }
        }

        static void RunProtoBufValues()
        {
            var run = true;

            while (run)
            {
                var client = new HttpClient { BaseAddress = new Uri("http://localhost:53700/") };
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-protobuf"));

                HttpResponseMessage response = client.GetAsync("api/Values").Result;

                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body. Blocking!
                    var persons = response.Content.ReadAsAsync<IEnumerable<Person>>(new[] { new ProtoBufFormatter() }).Result;

                    foreach (var p in persons)
                    {
                        Console.WriteLine($"{p.PersonId}\t{p.FirstName}\t{p.LastName}\t{p.Gender}");
                    }
                }
                else
                {
                    Console.WriteLine($"{(int)response.StatusCode} ({response.ReasonPhrase})");
                }

                var result = Console.ReadLine();
                if (result == "quit")
                {
                    run = false;
                }
            }
        }

        static void RunJsonPerson()
        {
            var run = true;

            while (run)
            {
                var client = new HttpClient { BaseAddress = new Uri("http://localhost:53700/") };
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("api/Person/1").Result;

                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body. Blocking!
                    var person = response.Content.ReadAsAsync<Person>().Result;

                    Console.WriteLine($"{person.PersonId}\t{person.FirstName}\t{person.LastName}\t{person.Gender}");
                }
                else
                {
                    Console.WriteLine($"{(int)response.StatusCode} ({response.ReasonPhrase})");
                }

                var result = Console.ReadLine();
                if (result == "quit")
                {
                    run = false;
                }
            }
        }

        static void RunJsonPersons()
        {
            var run = true;

            while (run)
            {
                var client = new HttpClient { BaseAddress = new Uri("http://localhost:53700/") };
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("api/Person").Result;

                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body. Blocking!
                    var persons = response.Content.ReadAsAsync<IEnumerable<Person>>().Result;

                    foreach (var p in persons)
                    {
                        Console.WriteLine($"{p.PersonId}\t{p.FirstName}\t{p.LastName}\t{p.Gender}");
                    }
                }
                else
                {
                    Console.WriteLine($"{(int)response.StatusCode} ({response.ReasonPhrase})");
                }

                var result = Console.ReadLine();
                if (result == "quit")
                {
                    run = false;
                }
            }
        }
    }
}
