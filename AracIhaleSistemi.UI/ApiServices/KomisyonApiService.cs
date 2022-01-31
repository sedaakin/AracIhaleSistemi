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
    public class KomisyonApiService
    {
        private readonly HttpClient _httpClient;
        public KomisyonApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<KomisyonVM>> GetAll()
        {
            IEnumerable<KomisyonVM> VMs;
            var response = await _httpClient.GetAsync(string.Format($"Komisyon"));
            if (response.IsSuccessStatusCode)
            {
                VMs = JsonConvert.DeserializeObject<IEnumerable<KomisyonVM>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                VMs = null;
            }
            return VMs;
        }
        public async Task<string> PostKomisyon(KomisyonVM kom)
        {
            var sonuc = "";
            var strContent = new StringContent(JsonConvert.SerializeObject(kom));
            strContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await _httpClient.PostAsync("Komisyon", strContent);
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
