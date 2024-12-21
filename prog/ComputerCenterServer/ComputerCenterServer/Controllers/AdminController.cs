using ComputerCenterServer.Data;
using ComputerCenterServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComputerCenterServer.Controllers;



[ApiController]
[Route("api/admin")]
public class AdminController : Controller
{
    private readonly ApplicationDbContext _context;

    public AdminController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var admins = await _context.Admins.ToListAsync();
        return Ok(admins);
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var admin = await _context.Admins.FindAsync(id);

        if (admin == null) { return NotFound(); }

        return Ok(admin);
    }



    [HttpPost]
    public async Task<IActionResult> Set([FromBody] Admin admin)
    {
        admin.Id = new Guid();

        _context.Admins.Add(admin);
        _context.SaveChanges();

        return Ok(admin);
    }




    [HttpPut]
    public async Task<IActionResult> Put([FromBody] Admin adminGet)
    {

        var admin = _context.Admins.FirstOrDefault(c => c.Id == adminGet.Id);

        if (admin == null)
        {
            return NotFound();
        }

        admin.Jobtitle = adminGet.Jobtitle;

        _context.SaveChanges();

        return Ok("Person updated");
    }



    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var admin = _context.Admins.FirstOrDefault(c => c.Id == Id);

        if (admin == null) { return NotFound(); }

        _context.Admins.Remove(admin);
        _context.SaveChanges();

        return Ok("Person deleted");
    }




}
