using ComputerCenterClient.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ComputerCenterClient.Controllers;

public class PurchasedServicesController
{
    private HttpClient httpClient;
    private readonly Uri url;

    public PurchasedServicesController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7036/api/purchased_servides");

    }



    public async Task<List<PurchasedServices>> GetAllPurchasedServicesAsync()
    {
        List<PurchasedServices> compaund = new List<PurchasedServices>(); // Initialize the list of customers
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

        foreach (var token in contentArray)
        {
            compaund.Add(new PurchasedServices()
            {
                Quantity = int.Parse(token["quantity"].ToString()),
                Id_Order = Guid.Parse(token["id_Order"].ToString()),
                Id_Services = Guid.Parse(token["id_Services"].ToString())

            });
        }

        return compaund;
    }



    public async Task<List<PurchasedServices>> GetPurchasedServicesByIdOrder(Guid Id)
    {
        List<PurchasedServices> compaund = new List<PurchasedServices>();
        string content;

        try
        {
            var response = await httpClient.GetAsync(url + $"/by_order/{Id}");

            response.EnsureSuccessStatusCode(); // Check for a successful status

            content = await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null; // Return null on error
        }

        var contentArray = JArray.Parse(content);

        foreach (var token in contentArray)
        {
            compaund.Add(new PurchasedServices()
            {
                Quantity = int.Parse(token["quantity"].ToString()),
                Id_Order = Guid.Parse(token["id_Order"].ToString()),
                Id_Services = Guid.Parse(token["id_Services"].ToString())

            });
        }

        return compaund;
    }


    public async Task<List<PurchasedServices>> GetPurchasedServicesByIdServices(Guid Id)
    {
        List<PurchasedServices> compaund = new List<PurchasedServices>();
        string content;

        try
        {
            var response = await httpClient.GetAsync(url + $"/by_product/{Id}");

            response.EnsureSuccessStatusCode(); // Check for a successful status

            content = await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null; // Return null on error
        }

        var contentArray = JArray.Parse(content);

        foreach (var token in contentArray)
        {
            compaund.Add(new PurchasedServices()
            {
                Quantity = int.Parse(token["quantity"].ToString()),
                Id_Order = Guid.Parse(token["id_Order"].ToString()),
                Id_Services = Guid.Parse(token["id_Services"].ToString())

            });
        }

        return compaund;
    }





    public async Task<HttpResponseMessage> PostPurchasedServices(PurchasedServices order)
    {
        return await httpClient.PostAsJsonAsync(url, order);
    }


    public Task<HttpResponseMessage> PutPurchasedServices(PurchasedServices order)
    {
        return httpClient.PutAsJsonAsync(url, order);
    }


    public Task<HttpResponseMessage> DelPurchasedServices(PurchasedServices order)
    {
        return httpClient.DeleteAsync($"{url}/{order.Id_Order.ToString()}/{order.Id_Services.ToString()}");
    }



}
