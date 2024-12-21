using ComputerCenterClient.DTO;
using ComputerCenterClient.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace ComputerCenterClient.Controllers;

public class AdminController
{
    private HttpClient httpClient;
    private readonly Uri urlAdmin;
    private readonly Uri urlPerson;


    public AdminController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        urlAdmin = new Uri("https://localhost:7036/api/admin");
        urlPerson = new Uri("https://localhost:7036/api/person");

    }

    public async Task<List<AdminDTO>> GetAll()
    {
        List<AdminDTO> admins = new List<AdminDTO>();


        var response = await httpClient.GetAsync(urlAdmin);

        string content = await response.Content.ReadAsStringAsync();

        var contentArray = JArray.Parse(content);

        foreach (var item in contentArray)
        {
            Admin admin = new Admin() 
            {
                Id = Guid.Parse(item["id"].ToString()),
                Jobtitle = item["jobtitle"].ToString(),
                Id_Person = Guid.Parse(item["id_Person"].ToString())
            };



            var responsePerson = await httpClient.GetAsync($"{urlPerson}/{admin.Id_Person}");

            var contentPerson = await responsePerson.Content.ReadAsStringAsync();

            Person person = JsonConvert.DeserializeObject<Person>(contentPerson);

            if (person == null)
            {
                Environment.Exit(0);
            }

            admins.Add(new AdminDTO(person, admin));

        }


        return admins;
    }


    public async Task<Admin> GetById(Guid Id)
    {
        var response = await httpClient.GetAsync(urlAdmin + $"/{Id}");


        if (!response.IsSuccessStatusCode)
        {
            return new Admin();
            //throw new Exception($"Ошибка при получении данных: {response.StatusCode}");
        }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Admin>(data);

        return content;
    }





    public async Task<bool> Post(AdminDTO person)
    {
        var response = await httpClient.PostAsJsonAsync(urlPerson, person.Person);


        if (!response.IsSuccessStatusCode) { return false; }

        var data = await response.Content.ReadAsStringAsync();

        person.Person = JsonConvert.DeserializeObject<Person>(data);

        person.Admin.Id_Person = person.Person.Id;

        var response1 = await httpClient.PostAsJsonAsync(urlAdmin, person.Admin);

        if (!response1.IsSuccessStatusCode) { return false; }

        return true;
    }


    public async Task<bool> Put(AdminDTO admin)
    {
        var response = await httpClient.PutAsJsonAsync(urlPerson, admin.Person);

        if (!response.IsSuccessStatusCode) { return false; }

        var response1 = await httpClient.PutAsJsonAsync(urlAdmin, admin.Admin);

        if (!response1.IsSuccessStatusCode) { return false; }

        return true;
    }


    public Task<HttpResponseMessage> Del(AdminDTO admin)
    {
        httpClient.DeleteAsync($"{urlAdmin}/{admin.Admin.Id.ToString()}");
        return httpClient.DeleteAsync($"{urlPerson}/{admin.Person.Id.ToString()}");
    }
}
