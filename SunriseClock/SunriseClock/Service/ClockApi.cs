using RestSharp;
using SunriseClock.Model;
using System;

namespace SunriseClock.Service
{
    public class ClockApi
    {
        public ClockApi(Uri baseUri)
        {
            this._baseUrl = baseUri;
        }

        private readonly Uri _baseUrl;

        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient {BaseUrl = _baseUrl};

            // Override with Newtonsoft JSON Handler
            client.AddHandler("application/json", Serializer.JsonSerializer.Default);
            client.AddHandler("text/json", Serializer.JsonSerializer.Default);
            client.AddHandler("text/x-json", Serializer.JsonSerializer.Default);
            client.AddHandler("text/javascript", Serializer.JsonSerializer.Default);
            client.AddHandler("*+json", Serializer.JsonSerializer.Default);

            var response = client.Execute<T>(request);

            if(response.ErrorException != null)
            {
                throw response.ErrorException;
            }
            return response.Data;
        }

        public Configuration GetConfiguration()
        {
            var request = new RestRequest { Resource = "configuration" };
            return Execute<Configuration>(request);
        }

        public void SetConfiguration(Configuration config)
        {
            var request = new RestRequest(Method.POST)
            {
                Resource = "configuration",
                JsonSerializer = Serializer.JsonSerializer.Default
            };
            request.AddJsonBody(config);
            var response = Execute<Configuration>(request);
        }
    }
}
