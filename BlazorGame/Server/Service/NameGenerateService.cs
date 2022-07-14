﻿using Newtonsoft.Json;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Dynamic;
using Newtonsoft.Json.Converters;

namespace BlazorGame.Server.Service
{
    public class NameGenerateService : INameGenerateService
    {
        private IConfiguration _Configuration { get; }
        public NameGenerateService(IConfiguration Configuration)
        {
            _Configuration = Configuration;
       
        }

        public async Task<string> GetARadomName()
        {
            string name=null;

            var options = new RestClientOptions(_Configuration["APIAddr"])
            {
                ThrowOnAnyError = true,
                Timeout = 1000
            };
            var client = new RestClient(options);

            var request = new RestRequest("?api_key=17a5ab11a134d7598f7280ef71a752f4&endpoint=generate&country_code=ca&results=1");
            var response = await client.ExecuteGetAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                

                dynamic details = JsonConvert.DeserializeObject<ExpandoObject>(response.Content, new ExpandoObjectConverter());
              
                name = ((IEnumerable<dynamic>)details.data).First().name.firstname.name;
                         
             
            }
            return name;
        }
    }
}
