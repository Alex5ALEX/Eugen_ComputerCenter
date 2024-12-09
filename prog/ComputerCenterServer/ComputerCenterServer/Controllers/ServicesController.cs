using ComputerCenterServer.Data;
using ComputerCenterServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComputerCenterServer.Controllers;



[ApiController]
[Route("api/services")]
public class ServicesController : Controller
{
    private readonly ApplicationDbContext _context;

    public ServicesController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllServices()
    {
        var services = await _context.Services.ToListAsync();
        return Ok(services);
    }




    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var services = await _context.Services.FindAsync(id);

        if (services == null) { return NotFound(); }

        return Ok(services);

    }


    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] Services services)
    {
        services.Id = new Guid();

        _context.Services.Add(services);
        _context.SaveChanges();

        return Ok("Services created");
    }




    [HttpPut("{Id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] Services servicesGet)
    {
        var services = _context.Services.FirstOrDefault(c => c.Id == Id);

        if (services == null)
        {
            return NotFound();
        }

        services.Name = servicesGet.Name;
        services.Description = servicesGet.Description;
        services.Price = servicesGet.Price;

        _context.SaveChanges();

        return Ok("Services updated");
    }



    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var services = _context.Services.FirstOrDefault(c => c.Id == Id);

        if (services == null) { return NotFound(); }

        _context.Services.Remove(services);
        _context.SaveChanges();

        return Ok("Services deleted");
    }
}
