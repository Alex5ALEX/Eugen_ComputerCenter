using ComputerCenterClient.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ComputerCenterClient.Controllers;

public class PurchasedProductController
{

    private HttpClient httpClient;
    private readonly Uri url;

    public PurchasedProductController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7036/api/purchased_product");

    }



    public async Task<List<PurchasedProduct>> GetAllPurchasedProductsAsync()
    {
        List<PurchasedProduct> compaund = new List<PurchasedProduct>(); // Initialize the list of customers
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
            compaund.Add(new PurchasedProduct()
            {
                Quantity = int.Parse(token["quantity"].ToString()),
                Id_Order = Guid.Parse(token["id_Order"].ToString()),
                Id_Product = Guid.Parse(token["id_Product"].ToString())

            });
        }

        return compaund;
    }



    public async Task<List<PurchasedProduct>> GetPurchasedProductsByIdOrder(Guid Id)
    {
        List<PurchasedProduct> compaund = new List<PurchasedProduct>();
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
            compaund.Add(new PurchasedProduct()
            {
                Quantity = int.Parse(token["quantity"].ToString()),
                Id_Order = Guid.Parse(token["id_Order"].ToString()),
                Id_Product = Guid.Parse(token["id_Product"].ToString())

            });
        }

        return compaund;
    }


    public async Task<List<PurchasedProduct>> GetPurchasedProductsByIdServices(Guid Id)
    {
        List<PurchasedProduct> compaund = new List<PurchasedProduct>();
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
            compaund.Add(new PurchasedProduct()
            {
                Quantity = int.Parse(token["quantity"].ToString()),
                Id_Order = Guid.Parse(token["id_Order"].ToString()),
                Id_Product = Guid.Parse(token["id_Product"].ToString())

            });
        }

        return compaund;
    }





    public async Task<HttpResponseMessage> PostPurchasedProduct(PurchasedProduct order)
    {
        return await httpClient.PostAsJsonAsync(url, order);
    }


    public Task<HttpResponseMessage> PutPurchasedProduct(PurchasedProduct order)
    {
        return httpClient.PutAsJsonAsync(url, order);
    }


    public Task<HttpResponseMessage> DelPurchasedProduct(PurchasedProduct order)
    {
        return httpClient.DeleteAsync($"{url}/{order.Id_Order.ToString()}/{order.Id_Product.ToString()}");
    }
}
