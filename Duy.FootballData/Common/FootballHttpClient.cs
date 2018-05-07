using Duy.FootballData.Models;
using System;
using System.Net.Http;

namespace Duy.FootballData.Common
{
    public class FootballHttpClient : HttpClient
    {
        private FootballHttpClient()
        {
        }

        public FootballHttpClient(FootballDataOption option) : this()
        {
            if(!string.IsNullOrEmpty(option.ApiKey))
                this.DefaultRequestHeaders.Add("X-Auth-Token", option.ApiKey);

            this.DefaultRequestHeaders.Add("X-Response-Control", option.ResponseControl.ToString());
            this.BaseAddress = new Uri(option.BaseUrl);
        }
    }
}
