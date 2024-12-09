using ComputerCenterServer.Data;
using ComputerCenterServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComputerCenterServer.Controllers;



[ApiController]
[Route("api/purchased_product")]
public class PurchasedProductController : Controller
{
    private readonly ApplicationDbContext _context;

    public PurchasedProductController(ApplicationDbContext context)
    {
        _context = context;
    }



    [HttpGet]
    public async Task<IActionResult> GetAllPurchasedProduct()
    {
        var compaunds = await _context.PurchasedProducts.ToListAsync();
        return Ok(compaunds);
    }



    
    [HttpGet("by_order/{id_order}")]
    public async Task<IActionResult> GetByIdOrder(Guid id_order)
    {
        var purchased = await _context.PurchasedProducts.Where(o => o.Id_Order == id_order).ToListAsync();

        if (purchased == null) { return NotFound(); }

        return Ok(purchased);
    }


    [HttpGet("by_product/{id_product}")]
    public async Task<IActionResult> GetByIdProducts(Guid id_product)
    {
        var purchased = await _context.PurchasedProducts.Where(o => o.Id_Product == id_product).ToListAsync();

        if (purchased == null) { return NotFound(); }

        return Ok(purchased);
    }
    


    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] PurchasedProduct purchased)
    {

        _context.PurchasedProducts.Add(purchased);
        _context.SaveChanges();

        return Ok("Purchased Product created");
    }




    [HttpPut]
    public async Task<IActionResult> Put([FromBody] PurchasedProduct purchasedGet)
    {
        var purchased = _context.PurchasedProducts.FirstOrDefault(c => c.Id_Order == purchasedGet.Id_Order && c.Id_Product == purchasedGet.Id_Product);

        if (purchased == null)
        {
            return NotFound();
        }


        purchased.Quantity = purchasedGet.Quantity;
        purchased.Id_Order = purchasedGet.Id_Order;
        purchased.Id_Product = purchasedGet.Id_Product;

        _context.SaveChanges();

        return Ok("Purchased Product updated");
    }



    [HttpDelete("{id_order}/{id_product}")]
    public async Task<IActionResult> Delete(Guid id_order, Guid id_product)
    {
        var purchased = _context.PurchasedProducts.FirstOrDefault(c => c.Id_Order == id_order && c.Id_Product == id_product);

        if (purchased == null) { return NotFound(); }

        _context.PurchasedProducts.Remove(purchased);
        _context.SaveChanges();

        return Ok("Purchased Product deleted");
    }
}
