using ComputerCenterClient.Models;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ComputerCenterClient.Controllers;

public class CustomerController
{
    private HttpClient httpClient;
    private readonly Uri url;


    public CustomerController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        url = new Uri("https://localhost:7036/api/customer");
    }


    public async Task<List<Customer>> GetAllCustomersAsync()
    {
        List<Customer> customers = new List<Customer>(); // Initialize the list of customers
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

        foreach (var customer in contentArray)
        {
            customers.Add(new Customer()
            {
                Id = Guid.Parse(customer["id"].ToString()),
                Name = customer["name"].ToString(),
                Surname = customer["surname"].ToString(),
                Phone = customer["phone"].ToString(),
                Email = customer["email"].ToString(),
                Address = customer["address"].ToString()
            });
        }

        return customers; // Return the populated list of customers
    }



    public async Task<Customer> GetCustomerById(Guid Id)
    {
        var response = await httpClient.GetAsync(url + $"/{Id}");
        //var response = await httpClient.GetAsync(url + $"/{Id.ToString()}");


        if (!response.IsSuccessStatusCode)
        {
            return new Customer();
            //throw new Exception($"Ошибка при получении данных: {response.StatusCode}");
        }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Customer>(data);

        return content;

    }





    public Task<HttpResponseMessage> PostCustomer(Customer customer)
    {
        return httpClient.PostAsJsonAsync(url, customer);
    }


    public Task<HttpResponseMessage> PutCustomerById(Customer customer)
    {
        return httpClient.PutAsJsonAsync($"{url}/{customer.Id.ToString()}", customer);
    }


    public Task<HttpResponseMessage> DelCustomer(Customer customer)
    {
        return httpClient.DeleteAsync($"{url}/{customer.Id.ToString()}");
    }


}
