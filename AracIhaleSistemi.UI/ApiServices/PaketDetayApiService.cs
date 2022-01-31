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
    public class PaketDetayApiService
    {
        private readonly HttpClient _httpClient;
        public PaketDetayApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<PaketDetayVM>> GetAll()
        {
            IEnumerable<PaketDetayVM> VMs;
            var response = await _httpClient.GetAsync(string.Format($"PaketDetay"));
            if (response.IsSuccessStatusCode)
            {
                VMs = JsonConvert.DeserializeObject<IEnumerable<PaketDetayVM>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                VMs = null;
            }
            return VMs;
        }
        public async Task<string> PostPaket(PaketDetayAddVM detay)
        {
            var sonuc = "";
            var strContent = new StringContent(JsonConvert.SerializeObject(detay));
            strContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await _httpClient.PostAsync("PaketDetay", strContent);
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
