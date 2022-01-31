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
    public class NoterApiService
    {
        private readonly HttpClient _httpClient;
        public NoterApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<NoterVM>> GetAll()
        {
            IEnumerable<NoterVM> VMs;
            var response = await _httpClient.GetAsync(string.Format($"Noter"));
            if (response.IsSuccessStatusCode)
            {
                VMs = JsonConvert.DeserializeObject<IEnumerable<NoterVM>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                VMs = null;
            }
            return VMs;
        }
        public async Task<string> PostKomisyon(NoterVM noter)
        {
            var sonuc = "";
            var strContent = new StringContent(JsonConvert.SerializeObject(noter));
            strContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await _httpClient.PostAsync("Noter", strContent);
            if (response.IsSuccessStatusCode)
            {
                sonuc = response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                sonuc = null;
            }
            return sonuc;
        }
    }
}
