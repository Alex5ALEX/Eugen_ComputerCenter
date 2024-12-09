using ComputerCenterServer.Data;
using ComputerCenterServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComputerCenterServer.Controllers;


[ApiController]
[Route("api/purchased_servides")]
public class PurchasedServicesController : Controller
{
    private readonly ApplicationDbContext _context;

    public PurchasedServicesController(ApplicationDbContext context)
    {
        _context = context;
    }



    [HttpGet]
    public async Task<IActionResult> GetAllPurchasedServices()
    {
        var compaunds = await _context.PurchasedServices.ToListAsync();
        return Ok(compaunds);
    }




    [HttpGet("by_order/{id_order}")]
    public async Task<IActionResult> GetByIdOrder(Guid id_order)
    {
        var purchased = await _context.PurchasedServices.Where(o => o.Id_Order == id_order).ToListAsync();

        if (purchased == null) { return NotFound(); }

        return Ok(purchased);
    }


    [HttpGet("by_services/{id_services}")]
    public async Task<IActionResult> GetByIdServices(Guid id_services)
    {
        var purchased = await _context.PurchasedServices.Where(o => o.Id_Services == id_services).ToListAsync();

        if (purchased == null) { return NotFound(); }

        return Ok(purchased);
    }



    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] PurchasedServices purchased)
    {

        _context.PurchasedServices.Add(purchased);
        _context.SaveChanges();

        return Ok("Purchased Services created");
    }




    [HttpPut]
    public async Task<IActionResult> Put([FromBody] PurchasedServices purchasedGet)
    {
        var purchased = _context.PurchasedServices.FirstOrDefault(c => c.Id_Order == purchasedGet.Id_Order && c.Id_Services == purchasedGet.Id_Services);

        if (purchased == null)
        {
            return NotFound();
        }


        purchased.Quantity = purchasedGet.Quantity;
        purchased.Id_Order = purchasedGet.Id_Order;
        purchased.Id_Services = purchasedGet.Id_Services;

        _context.SaveChanges();

        return Ok("Purchased Services updated");
    }



    [HttpDelete("{id_order}/{id_services}")]
    public async Task<IActionResult> Delete(Guid id_order, Guid id_services)
    {
        var purchased = _context.PurchasedServices.FirstOrDefault(c => c.Id_Order == id_order && c.Id_Services == id_services);

        if (purchased == null) { return NotFound(); }

        _context.PurchasedServices.Remove(purchased);
        _context.SaveChanges();

        return Ok("Purchased Services deleted");
    }
}