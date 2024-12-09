using ComputerCenterServer.Data;
using ComputerCenterServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComputerCenterServer.Controllers;



[ApiController]
[Route("api/provider")]
public class ProviderController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProviderController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllProviders()
    {
        var providers = await _context.Providers.ToListAsync();
        return Ok(providers);
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var provider = await _context.Providers.FindAsync(id);

        if (provider == null) { return NotFound(); }

        return Ok(provider);

    }


    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] Provider provider)
    {
        provider.Id = new Guid();

        _context.Providers.Add(provider);
        _context.SaveChanges();

        return Ok("provider created");
    }




    [HttpPut("{Id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] Provider providerGet)
    {
        var provider = _context.Providers.FirstOrDefault(c => c.Id == Id);

        if (provider == null)
        {
            return NotFound();
        }


        provider.Company = providerGet.Company;
        provider.ContactPerson = providerGet.ContactPerson;
        provider.Phone = providerGet.Phone;
        provider.Email = providerGet.Email;
        provider.Address = providerGet.Address;

        _context.SaveChanges();

        return Ok("Provider updated");
    }



    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var provider = _context.Providers.FirstOrDefault(c => c.Id == Id);

        if (provider == null) { return NotFound(); }

        _context.Providers.Remove(provider);
        _context.SaveChanges();

        return Ok("Provider deleted");
    }
}
