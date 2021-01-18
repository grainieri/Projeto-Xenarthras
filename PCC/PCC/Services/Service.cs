using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace PCC.Services
{
    public abstract class Service
    {
        protected HttpClient _client;
        protected string BaseApiUrl = "https://apixenartras20201126021930.azurewebsites.net/";

        public Service()
        {
            _client = new HttpClient();
        }
    }
}
