using ComputerCenterClient.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ComputerCenterClient.Controllers;

public class OrderController
{

    private HttpClient httpClient;
    private readonly Uri url;

    public OrderController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7262/api/order");

    }

    public async Task<List<Order>> GetAllOrdersAsync()
    {
        List<Order> orders = new List<Order>(); // Initialize the list of customers
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
            orders.Add(new Order()
            {
                Id = Guid.Parse(token["id"].ToString()),
                Date = DateTime.Parse(token["date"].ToString()),
                Id_Customer = Guid.Parse(token["id_Customer"].ToString()),
            });
        }

        return orders;
    }



    public async Task<string> GetOrderById(Guid Id)
    {
        var response = await httpClient.GetAsync(url + $"/{Id}");

        //response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }



    public async Task<HttpResponseMessage> PostOrder(Order order)
    {
        return await httpClient.PostAsJsonAsync(url, order);
    }


    public Task<HttpResponseMessage> PutOrder(Order order)
    {
        return httpClient.PutAsJsonAsync($"{url}/{order.Id.ToString()}", order);
    }


    public Task<HttpResponseMessage> DelOrder(Order order)
    {
        return httpClient.DeleteAsync($"{url}/{order.Id.ToString()}");
    }


}
