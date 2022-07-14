using Newtonsoft.Json;
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

        [Obsolete]
        public async Task<string> GetARadomName()
        {
            string? name =null;

            var options = new RestClientOptions(_Configuration["APIAddr"])
            {
                ThrowOnAnyError = true,
                Timeout = 1000
            };
            var client = new RestClient(options);
             RestRequest?  restRequest = null;
            restRequest = new RestRequest($"?api_key={_Configuration["api_key_main"]}&endpoint={_Configuration["endpoint"]}&country_code={_Configuration["country_code"]}&results={_Configuration["results"]}");
            RestResponse? response = null;
            try
            {
                response = await client.ExecuteGetAsync(restRequest);
            }
            catch (Exception e)
            {
                try
                {
                    restRequest = new RestRequest($"?api_key={_Configuration["api_key_backup"]}&endpoint={_Configuration["endpoint"]}&country_code={_Configuration["country_code"]}&results={_Configuration["results"]}");
                    response = await client.ExecuteGetAsync(restRequest);
                }
                catch (Exception ex)
                { 
                // need to do something here 
                }
            }
            if (response != null&& response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                dynamic details = JsonConvert.DeserializeObject<ExpandoObject>(response.Content, new ExpandoObjectConverter());            
                name = ((IEnumerable<dynamic>)details.data).First().name.firstname.name;                                     
            }
           
#pragma warning disable CS8603 // Possible null reference return.
            return name;
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
