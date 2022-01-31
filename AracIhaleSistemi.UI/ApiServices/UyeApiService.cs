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
    public class UyeApiService
    {
        private readonly HttpClient _httpClient;
        public UyeApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<RolVM>> GetAllRol()
        {
            IEnumerable<RolVM> VMs;
            var response = await _httpClient.GetAsync(string.Format($"Rol"));
            if (response.IsSuccessStatusCode)
            {
                VMs = JsonConvert.DeserializeObject<IEnumerable<RolVM>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                VMs = null;
            }
            return VMs;
        }
        public async Task<string> PostUye(UyeAddVM uye)
        {
            var sonuc="";
            var strContent = new StringContent(JsonConvert.SerializeObject(uye));
            strContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await _httpClient.PostAsync("Auth/register", strContent);
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
        public async Task<IEnumerable<UyeVM>> GetAllUye()
        {
            IEnumerable<UyeVM> VMs;
            var response = await _httpClient.GetAsync("Uye");
            if (response.IsSuccessStatusCode)
            {
                VMs = JsonConvert.DeserializeObject<IEnumerable<UyeVM>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                VMs = null;
            }
            return VMs;
        }
        public async Task<string> PutUye(UyeUpdateVM uye)
        {
            var sonuc = "";
            var strContent = new StringContent(JsonConvert.SerializeObject(uye));
            strContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await _httpClient.PutAsync("Uye", strContent);
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
        public async Task<string> DeleteUye(int id)
        {
            var sonuc = "";
            var response = await _httpClient.DeleteAsync("Uye?id="+id);
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
