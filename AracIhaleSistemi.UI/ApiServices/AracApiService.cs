using AracIhaleSistemi.DataAccess.Mapping.Core;
using AracIhaleSistemi.UI.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.ApiServices
{
    public class AracApiService
    {
        private readonly HttpClient _httpClient;
        public AracApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<AracVM>> GetAllAracsAsync(/*string token*/)
        {
            //_httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer" + token);
            IEnumerable<AracVM> VMs;
            var response = await _httpClient.GetAsync("AracListe");
            if (response.IsSuccessStatusCode)
            {
                VMs = JsonConvert.DeserializeObject<IEnumerable<AracVM>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                VMs = null;
            }
            return VMs;
        }
        public async Task<int> AddArac(AracAddVM aracModel)
        {
            AracVM arac = new AracVM(){TramerTutari=aracModel.TramerTutari,Yil=aracModel.Yil,KayitZamani=DateTime.Now};
            var aracContent = new StringContent(JsonConvert.SerializeObject(arac));
            var responseArac = await _httpClient.PostAsync(string.Format($"AracListe"), aracContent);           

            return JsonConvert.DeserializeObject<int>(await responseArac.Content.ReadAsStringAsync()); ;
        }
        public async Task<IEnumerable<AracVM>> Filtre(AracFiltreVM filtre)
        {
            IEnumerable<AracVM> VMs;
            var response = await _httpClient.GetAsync("AracListe");
            if (response.IsSuccessStatusCode)
            {
                VMs = JsonConvert.DeserializeObject<IEnumerable<AracVM>>(await response.Content.ReadAsStringAsync());
                VMs = VMs.Where(a => a.Marka == filtre.Marka && a.Model == filtre.Model && a.BireyselMi == filtre.BireyselMi && a.Durum ==filtre.Durum);
                return VMs;
            }
            else
            {
                VMs = null;
            }
            return VMs;
        }
        public async Task<IEnumerable<AracDetayVM>> GetDetay(/*string token*/)
        {
            //_httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer" + token);
            IEnumerable<AracDetayVM> VMs;
            var response = await _httpClient.GetAsync("AracDetay");
            if (response.IsSuccessStatusCode)
            {
                VMs = JsonConvert.DeserializeObject<IEnumerable<AracDetayVM>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                VMs = null;
            }
            return VMs;
        }
        public async Task<IEnumerable<TramerVM>> GetTramer()
        {
            IEnumerable<TramerVM> VMs;
            var response = await _httpClient.GetAsync(string.Format($"Tramer"));
            if (response.IsSuccessStatusCode)
            {
                VMs = JsonConvert.DeserializeObject<IEnumerable<TramerVM>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                VMs = null;
            }
            return VMs;
        }
        public async Task<List<AracOzellikVM>> GetOzellik(int id)
        {
            List<AracOzellikVM> VMs;
            var response = await _httpClient.GetAsync(string.Format($"AracOzellik?id={id}"));
            if (response.IsSuccessStatusCode)
            {
                VMs = JsonConvert.DeserializeObject<List<AracOzellikVM>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                VMs = null;
            }
            return VMs;
        }

    }
}
