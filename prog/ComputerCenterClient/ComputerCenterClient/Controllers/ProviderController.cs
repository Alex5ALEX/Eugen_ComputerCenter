using ComputerCenterClient.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ComputerCenterClient.Controllers;

public class ProviderController
{
    private HttpClient httpClient;
    private readonly Uri url;


    public ProviderController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7036/api/provider");

    }



    public async Task<List<Provider>> GetAllProvidersAsync()
    {
        List<Provider> providers = new List<Provider>(); // Initialize the list of customers
        string content;

        try
        {
            var response = await httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode(); // Check for a successful status

            content = await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null; // Return null on error
        }

        var contentArray = JArray.Parse(content);

        foreach (var provider in contentArray)
        {
            providers.Add(new Provider()
            {
                Id = Guid.Parse(provider["id"].ToString()),
                Company = provider["company"].ToString(),
                ContactPerson = provider["contactPerson"].ToString(),
                Phone = provider["phone"].ToString(),
                Email = provider["email"].ToString(),
                Address = provider["address"].ToString()
            });
        }

        return providers; // Return the populated list of customers
    }



    public async Task<Provider> GetProviderById(Guid Id)
    {
        var response = await httpClient.GetAsync(url + $"/{Id.ToString()}");


        if (!response.IsSuccessStatusCode)
        {
            return new Provider();
            //throw new Exception($"Ошибка при получении данных: {response.StatusCode}");
        }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Provider>(data);

        return content;
    }





    public Task<HttpResponseMessage> PostProvider(Provider provider)
    {
        return httpClient.PostAsJsonAsync(url, provider);
    }


    public Task<HttpResponseMessage> PutProviderById(Provider provider)
    {
        return httpClient.PutAsJsonAsync($"{url}/{provider.Id.ToString()}", provider);
    }


    public Task<HttpResponseMessage> DelProvider(Provider provider)
    {
        return httpClient.DeleteAsync($"{url}/{provider.Id.ToString()}");
    }



}
