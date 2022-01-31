using AracIhaleSistemi.UI.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.ApiServices
{
    public class DurumApiService
    {
        private readonly HttpClient _httpClient;
        public DurumApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<DurumVM>> GetAsync(int id)
        {
            IEnumerable<DurumVM> VMs;
            var response = await _httpClient.GetAsync(string.Format($"Durum?Id={id}"));
            if (response.IsSuccessStatusCode)
            {
                VMs = JsonConvert.DeserializeObject<IEnumerable<DurumVM>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                VMs = null;
            }
            return VMs;
        }
    }
}
