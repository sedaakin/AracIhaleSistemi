using AracIhaleSistemi.Service.DTOs;
using AracIhaleSistemi.UI.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.ApiServices
{

    public class LoginApiService
    {
        public static string aktifToken;
        private readonly HttpClient _client;
        public LoginApiService(HttpClient httpClient)
        {
            _client = httpClient;
        }
        public async Task<string> Login(string email, string Password)
        {
            var strContent = new StringContent(JsonConvert.SerializeObject(new UserVM() { Email = email, Password = Password }));
            strContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await _client.PostAsync("Auth/login", strContent);
            if (response.IsSuccessStatusCode)
            {
                aktifToken = response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                aktifToken = null;
            }
            return aktifToken;
        }
    }
}
