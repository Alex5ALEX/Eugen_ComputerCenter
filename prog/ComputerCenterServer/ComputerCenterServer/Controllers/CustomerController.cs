using ComputerCenterServer.Data;
using ComputerCenterServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ComputerCenterServer.Controllers;


[ApiController]
[Route("api/customer")]
public class CustomerController : Controller
{


    private readonly ApplicationDbContext _context;

    public CustomerController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllCustomers()
    {
        var сustomers = await _context.Customers.ToListAsync();
        return Ok(сustomers);
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var customer = await _context.Customers.FindAsync(id);

        if (customer == null) { return NotFound(); }

        return Ok(customer);

    }


    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] Customer customer)
    {
        customer.Id = new Guid();

        _context.Customers.Add(customer);
        _context.SaveChanges();

        return Ok("Customer created");
    }




    [HttpPut("{Id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] Customer customerGet)
    {
        var customer = _context.Customers.FirstOrDefault(c => c.Id == Id);

        if (customer == null)
        {
            return NotFound();
        }


        customer.Name = customerGet.Name;
        customer.Surname = customerGet.Surname;
        customer.Phone = customerGet.Phone;
        customer.Email = customerGet.Email;
        customer.Address = customerGet.Address;

        _context.SaveChanges();

        return Ok("Customer updated");
    }



    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var customer = _context.Customers.FirstOrDefault(c => c.Id == Id);

        if (customer == null) { return NotFound(); }

        _context.Customers.Remove(customer);
        _context.SaveChanges();

        return Ok("Customer deleted");
    }



}
