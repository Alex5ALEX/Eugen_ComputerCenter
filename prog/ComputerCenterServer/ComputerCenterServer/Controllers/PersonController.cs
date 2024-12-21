using ComputerCenterServer.Data;
using ComputerCenterServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComputerCenterServer.Controllers;



[ApiController]
[Route("api/person")]
public class PersonController : Controller
{

    private readonly ApplicationDbContext _context;

    public PersonController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var persons = await _context.Persons.ToListAsync();
        return Ok(persons);
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var person = await _context.Persons.FindAsync(id);

        if (person == null) { return NotFound(); }

        return Ok(person);
    } 


    [HttpGet("login/{login}/{password}")]
    public async Task<IActionResult> Login(string login, string password)
    {
        var person = await _context.Persons.FirstOrDefaultAsync(p => p.Login == login && p.Password == password);

        if (person == null)
        {
            return BadRequest("Not found");
        }

        var customer = await _context.Customers.FirstOrDefaultAsync(p => p.Id_Person == person.Id);
        var admin = await _context.Admins.FirstOrDefaultAsync(p => p.Id_Person == person.Id);

        if (customer != null)
        {
            return Ok("Customer");
        }
        else if (admin != null)
        {
            return Ok("Admin");
        }

        return BadRequest("Not found");
    }



    [HttpGet("input_login/{login}/pass/{password}")]
    public async Task<IActionResult> InputLogin(string login, string password)
    {
        var person = await _context.Persons.FirstOrDefaultAsync(p => p.Login == login && p.Password == password);

        if (person == null)
        {
            return BadRequest("Not found");
        }

        return Ok(person);
    }



    [HttpPost]
    public async Task<IActionResult> Set([FromBody] Person person)
    {
        person.Id = new Guid();

        var error = await _context.Persons.FirstOrDefaultAsync(p => p.Login == person.Login);

        if(error != null)
        {
            return BadRequest();
        }

        _context.Persons.Add(person);
        _context.SaveChanges();

        return Ok(person);
    }



      
    [HttpPut]
    public async Task<IActionResult> Put([FromBody] Person personGet)
    {
        
        var person = _context.Persons.FirstOrDefault(c => c.Id == personGet.Id);

        if (person == null)
        {
            return NotFound();
        }

        var error = await _context.Persons.FirstOrDefaultAsync(p => p.Login == personGet.Login);

        if (error != null && error.Id != person.Id)
        {
            return BadRequest();
        }


        person.Name = personGet.Name;
        person.Surname = personGet.Surname;
        person.Phone = personGet.Phone;
        person.Email = personGet.Email;
        person.Address = personGet.Address;
        person.Login = personGet.Login;
        person.Password = personGet.Password;

        _context.SaveChanges();
        
        return Ok("Person updated");
    }



    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var person = _context.Persons.FirstOrDefault(c => c.Id == Id);

        if (person == null) { return NotFound(); }

        _context.Persons.Remove(person);
        _context.SaveChanges();

        return Ok("Person deleted");
    }


}
