using ComputerCenterServer.Data;
using ComputerCenterServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComputerCenterServer.Controllers;




[ApiController]
[Route("api/manufacture")]
public class ManufactureController : Controller
{
    private readonly ApplicationDbContext _context;

    public ManufactureController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllManufactures()
    {
        var manufactures = await _context.Manufactures.ToListAsync();
        return Ok(manufactures);
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var manufacture = await _context.Manufactures.FindAsync(id);

        if (manufacture == null) { return NotFound(); }

        return Ok(manufacture);
    }


    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] Manufacture manufacture)
    {
        manufacture.Id = new Guid();

        _context.Manufactures.Add(manufacture);
        _context.SaveChanges();

        return Ok("Manufacture created");
    }




    [HttpPut("{Id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] Manufacture manufactureGet)
    {
        var manufacture = _context.Manufactures.FirstOrDefault(c => c.Id == Id);

        if (manufacture == null)
        {
            return NotFound();
        }

        manufacture.Company = manufactureGet.Company;
        manufacture.Description = manufactureGet.Description;


        _context.SaveChanges();

        return Ok("Manufacture updated");
    }



    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var provider = _context.Manufactures.FirstOrDefault(c => c.Id == Id);

        if (provider == null) { return NotFound(); }

        _context.Manufactures.Remove(provider);
        _context.SaveChanges();

        return Ok("Manufacture deleted");
    }
}