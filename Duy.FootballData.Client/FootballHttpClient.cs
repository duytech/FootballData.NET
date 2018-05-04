using Duy.FootballData.Models;
using System;
using System.Net.Http;

namespace Duy.FootballData.Client
{
    public class FootballHttpClient : HttpClient
    {
        public FootballHttpClient()
        {
        }

        public FootballHttpClient(FootballDataOption option) : this()
        {
            if(!string.IsNullOrEmpty(option.Token))
                this.DefaultRequestHeaders.Add("X-Auth-Token", option.Token);

            this.DefaultRequestHeaders.Add("X-Response-Control", option.ResponseControl.ToString());
            this.BaseAddress = new Uri(option.BaseUrl);
        }
    }
}
