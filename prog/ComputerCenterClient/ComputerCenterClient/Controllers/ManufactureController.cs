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

public class ManufactureController
{

    private HttpClient httpClient;
    private readonly Uri url;


    public ManufactureController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7036/api/manufacture");
    }



    public async Task<List<Manufacture>> GetAllManufacturesAsync()
    {
        List<Manufacture> manufacture = new List<Manufacture>(); // Initialize the list of customers
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

        foreach (var manufact in contentArray)
        {
            manufacture.Add(new Manufacture()
            {
                Id = Guid.Parse(manufact["id"].ToString()),
                Company = manufact["company"].ToString(),
                Description = manufact["description"].ToString()
            });
        }

        return manufacture; // Return the populated list of customers
    }



    public async Task<Manufacture> GetManufactureById(Guid Id)
    {
        var response = await httpClient.GetAsync(url + $"/{Id.ToString()}");


        if (!response.IsSuccessStatusCode)
        {
            return new Manufacture();
            //throw new Exception($"Ошибка при получении данных: {response.StatusCode}");
        }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Manufacture>(data);

        return content;
    }





    public Task<HttpResponseMessage> PostManufacture(Manufacture manufacture)
    {
        return httpClient.PostAsJsonAsync(url, manufacture);
    }


    public Task<HttpResponseMessage> PutManufactureById(Manufacture manufacture)
    {
        return httpClient.PutAsJsonAsync($"{url}/{manufacture.Id.ToString()}", manufacture);
    }


    public Task<HttpResponseMessage> DelManufacture(Manufacture manufacture)
    {
        return httpClient.DeleteAsync($"{url}/{manufacture.Id.ToString()}");
    }
}
