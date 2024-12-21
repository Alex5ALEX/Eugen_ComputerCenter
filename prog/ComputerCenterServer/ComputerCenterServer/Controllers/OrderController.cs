using ComputerCenterServer.Data;
using ComputerCenterServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComputerCenterServer.Controllers;




[ApiController]
[Route("api/order")]
public class OrderController : Controller
{
    private readonly ApplicationDbContext _context;

    public OrderController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllOrders()
    {
        var orders = await _context.Orders.ToListAsync();
        return Ok(orders);
    }




    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var order = await _context.Orders.FindAsync(id);

        if (order == null) { return NotFound(); }

        return Ok(order);

    }

    [HttpGet("id_customer/{id}")]
    public async Task<IActionResult> GetByIdCustomer(Guid id)
    {
        var  orders = await _context.Orders.Where(p => p.Id_Customer == id).ToListAsync();

        if (orders == null) { return NotFound(); }

        return Ok(orders);

    }


    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] Order order)
    {
        //order.Id = new Guid();

        _context.Orders.Add(order);
        _context.SaveChanges();

        return Ok(order);
    }




    [HttpPut("{Id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] Order orderGet)
    {
        var order = _context.Orders.FirstOrDefault(c => c.Id == Id);

        if (order == null)
        {
            return NotFound();
        }


        order.Date = orderGet.Date;
        order.Id_Customer = orderGet.Id_Customer;

        _context.SaveChanges();

        return Ok(order);
    }



    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var order = _context.Orders.FirstOrDefault(c => c.Id == Id);

        if (order == null) { return NotFound(); }

        _context.Orders.Remove(order);
        _context.SaveChanges();

        return Ok("Order deleted");
    }

    [HttpDelete("customer/{Id}")]
    public async Task<IActionResult> DeleteByCustomer(Guid Id)
    {
        var orders = await _context.Orders.Where(c => c.Id_Customer == Id).ToListAsync();
        foreach (var order in orders)
        {
            _context.Orders.Remove(order);
        }
        _context.SaveChanges();
        return Ok();
    }
}
