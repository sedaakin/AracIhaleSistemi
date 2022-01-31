using AracIhaleSistemi.UI.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.ApiServices
{
    public class PaketTipApiService
    {
        private readonly HttpClient _httpClient;
        public PaketTipApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<PaketTipVM>> GetAll()
        {
            IEnumerable<PaketTipVM> VMs;
            var response = await _httpClient.GetAsync(string.Format($"PaketTip"));
            if (response.IsSuccessStatusCode)
            {
                VMs = JsonConvert.DeserializeObject<IEnumerable<PaketTipVM>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                VMs = null;
            }
            return VMs;
        }
    }
}

