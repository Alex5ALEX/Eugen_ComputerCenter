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
    public async Task<IActionResult> GetAll()
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

    [HttpGet("id_person/{id}")]
    public async Task<IActionResult> GetByIdPerson(Guid id)
    {
        var customer = await _context.Customers.FirstOrDefaultAsync(p => p.Id_Person == id);

        if (customer == null) { return NotFound(); }

        return Ok(customer);
    }


    [HttpPost]
    public async Task<IActionResult> Set([FromBody] Customer customer)
    {
        customer.Id = new Guid();

        _context.Customers.Add(customer);
        _context.SaveChanges();

        return Ok(customer);
    }




    [HttpPut]
    public async Task<IActionResult> Put([FromBody] Customer customerGet)
    {/*
        var customer = _context.Customers.FirstOrDefault(c => c.Id == customerGet.Id);

        if (customer == null)
        {
            return NotFound();
        }


        customer.Name = customerGet0.Name;
        customer.Surname = customerGet.Surname;
        customer.Phone = customerGet.Phone;
        customer.Email = customerGet.Email;
        customer.Address = customerGet.Address;

        _context.SaveChanges();
        */
        return Ok("Customer updated");
    }



    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var customer = _context.Customers.FirstOrDefault(c => c.Id == Id);

        if (customer == null) { return NotFound(); }

        _context.Customers.Remove(customer);
        _context.SaveChanges();

       await new OrderController(_context).DeleteByCustomer(Id);

        return Ok("Customer deleted");
    }
}
