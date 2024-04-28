using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace Star_Wars_API
{
    public class JSONHelper
    {
        //https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netcore-3.1
        static readonly HttpClient client = new HttpClient();
        public static async Task<Planet> GetPlanet(string ID)
        {
            Planet myDeserializedClass = new Planet();
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://swapi.py4e.com/api/planets/" + ID + "/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                myDeserializedClass = JsonConvert.DeserializeObject<Planet>(responseBody);
                //Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return myDeserializedClass;
        }

        public static async Task<Person> GetPerson(string ID)
        {
            Person myDeserializedClass = new Person();
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://swapi.py4e.com/api/people/" + ID + "/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                myDeserializedClass = JsonConvert.DeserializeObject<Person>(responseBody);
                //Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return myDeserializedClass;
        }

        public static async Task<AllSpecies> GetAllSpecies()
        {
            AllSpecies myDeserializedClass = new AllSpecies();
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://swapi.py4e.com/api/species/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                myDeserializedClass = JsonConvert.DeserializeObject<AllSpecies>(responseBody);
                //Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return myDeserializedClass;
        }
    }
}
