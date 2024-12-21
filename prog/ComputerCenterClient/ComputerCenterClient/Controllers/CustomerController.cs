using ComputerCenterClient.Models;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ComputerCenterClient.DTO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ComputerCenterClient.View.CustomerView;


namespace ComputerCenterClient.Controllers;

public class CustomerController
{
    private HttpClient httpClient;
    private readonly Uri urlCustomer;
    private readonly Uri urlPerson;


    public CustomerController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        urlCustomer = new Uri("https://localhost:7036/api/customer");
        urlPerson = new Uri("https://localhost:7036/api/person");

    }

    public async Task<List<CustomerDTO>> GetAll()
    {
        List<CustomerDTO> customers = new List<CustomerDTO>();


        var response = await httpClient.GetAsync(urlCustomer);

        string content = await response.Content.ReadAsStringAsync();

        var contentArray = JArray.Parse(content);

        foreach (var item in contentArray) {
            
            Customer customer = new Customer() 
            {
                Id = Guid.Parse(item["id"].ToString()),
                Id_Person = Guid.Parse(item["id_Person"].ToString())
            };

            var responsePerson = await httpClient.GetAsync($"{urlPerson}/{customer.Id_Person}");

            var contentPerson = await responsePerson.Content.ReadAsStringAsync(); 

            Person person = JsonConvert.DeserializeObject<Person>(contentPerson);

            if (person == null)
            {
                Environment.Exit(0);
            }

            customers.Add(new CustomerDTO(person, customer));
       
        }


        return customers;
    }


    public async Task<CustomerDTO> GetById(Guid Id)
    {
        var response = await httpClient.GetAsync(urlCustomer + $"/{Id}");
        //var response = await httpClient.GetAsync(url + $"/{Id.ToString()}");


        if (!response.IsSuccessStatusCode)
        {
            return new CustomerDTO();
            //throw new Exception($"Ошибка при получении данных: {response.StatusCode}");
        }

        var data = await response.Content.ReadAsStringAsync();

        var customer = JsonConvert.DeserializeObject<Customer>(data);

        var responsePerson = await httpClient.GetAsync(urlPerson + $"/{customer.Id_Person}");

        if (!responsePerson.IsSuccessStatusCode)
        {
            return new CustomerDTO();
            //throw new Exception($"Ошибка при получении данных: {response.StatusCode}");
        }

        data = await responsePerson.Content.ReadAsStringAsync();

        var person = JsonConvert.DeserializeObject<Person>(data);

        return new CustomerDTO(person, customer);
        
        
    }

    public async Task<Customer> GetByIdPerson(Guid Id)
    {
        var response = await httpClient.GetAsync(urlCustomer + $"/id_person/{Id}");
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



    public async Task<bool> Post(Person person)
    {
        var response = await httpClient.PostAsJsonAsync(urlPerson, person);


        if (!response.IsSuccessStatusCode) { return false; }
        
        var data = await response.Content.ReadAsStringAsync();

        person = JsonConvert.DeserializeObject<Person>(data);

        
        
        
        Customer customer = new Customer() { Id_Person = person.Id };

        var response1 = await httpClient.PostAsJsonAsync(urlCustomer, customer);

        if (!response1.IsSuccessStatusCode) { return false; }

        return true;
    }


    public async Task<bool> Put(CustomerDTO customer)
    {
        var response = await httpClient.PutAsJsonAsync(urlPerson, customer.Person);

        if (!response.IsSuccessStatusCode) { return false; }

        return true;
    }


    public Task<HttpResponseMessage> Del(CustomerDTO customer)
    {
        httpClient.DeleteAsync($"{urlCustomer}/{customer.Customer.Id.ToString()}");
        return httpClient.DeleteAsync($"{urlPerson}/{customer.Person.Id.ToString()}");
    }


}
