using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ClassDemoKageRestConsumer.model;
using Newtonsoft.Json;

namespace ClassDemoKageRestConsumer
{
    internal class AWorker
    {
        //private const String URI = "http://localhost:62107/api/Kager/";
        private const String URI = "http://pele-zealand-rest.azurewebsites.net/api/kager/";

        public async void Start()
        {
            IList<Kage> kager = await GetAllKagerAsync();
            foreach (Kage kage in kager)
            {
                Console.WriteLine(kage);
            }

        }

        public async Task<IList<Kage>> GetAllKagerAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(URI);
                IList<Kage> cList = JsonConvert.DeserializeObject<IList<Kage>>(content);
                return cList;
            }
        }
    }
}