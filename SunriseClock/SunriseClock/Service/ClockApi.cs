﻿using RestSharp;
using SunriseClock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunriseClock.Service
{
    class ClockApi
    {
        System.Uri BaseUrl = new Uri("http://clock.fh2.ch/api/v2/");

        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient();
            client.BaseUrl = BaseUrl;
            var response = client.Execute<T>(request);

            if(response.ErrorException != null)
            {
                throw response.ErrorException;
            }
            return response.Data;
        }

        public Configuration GetConfiguration()
        {
            var request = new RestRequest();
            request.Resource = "configuration";
            return Execute<Configuration>(request);
        }

        public void SetConfiguration(Configuration config)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "configuration";
            request.AddJsonBody(config);
            var response = Execute<Configuration>(request);
        }
    }
}
