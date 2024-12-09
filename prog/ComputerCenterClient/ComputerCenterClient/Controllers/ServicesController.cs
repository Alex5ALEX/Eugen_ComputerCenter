using ComputerCenterClient.Models;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ComputerCenterClient.Controllers;

public class ServicesController
{

    private HttpClient httpClient;
    private readonly Uri url;


    public ServicesController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        url = new Uri("https://localhost:7036/api/services");
    }



    public async Task<List<Services>> GetAllServicesAsync()
    {
        List<Services> services = new List<Services>(); 
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

        foreach (var serv in contentArray)
        {
            services.Add(new Services()
            {
                Id = Guid.Parse(serv["id"].ToString()),
                Name = serv["name"].ToString(),
                Description = serv["description"].ToString(),
                Price = decimal.Parse(serv["price"].ToString())
            });
        }

        return services; // Return the populated list of customers
    }



    public async Task<Services> GetServicesById(Guid Id)
    {
        var response = await httpClient.GetAsync(url + $"/{Id}");
  

        if (!response.IsSuccessStatusCode)
        {
            return new Services();
        }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Services>(data);

        return content;

    }





    public Task<HttpResponseMessage> PostServices(Services services)
    {
        return httpClient.PostAsJsonAsync(url, services);
    }


    public Task<HttpResponseMessage> PutServicesById(Services services)
    {
        return httpClient.PutAsJsonAsync($"{url}/{services.Id.ToString()}", services);
    }


    public Task<HttpResponseMessage> DelServices(Services services)
    {
        return httpClient.DeleteAsync($"{url}/{services.Id.ToString()}");
    }

}


