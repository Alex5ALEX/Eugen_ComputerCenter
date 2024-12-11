using ComputerCenterServer.Data;
using ComputerCenterServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComputerCenterServer.Controllers;




[ApiController]
[Route("api/product")]
public class ProductController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProductController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await _context.Products.ToListAsync();
        return Ok(products);
    }




    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var product = await _context.Products.FindAsync(id);

        if (product == null) { return NotFound(); }

        return Ok(product);

    }


    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] Product product)
    {
        product.Id = new Guid();

        _context.Products.Add(product);
        _context.SaveChanges();

        return Ok("Product created");
    }




    [HttpPut("{Id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] Product productGet)
    {
        var product = _context.Products.FirstOrDefault(c => c.Id == Id);

        if (product == null)
        {
            return NotFound();
        }

        product.Name = productGet.Name;
        product.Type = productGet.Type;
        product.Description = productGet.Description;
        product.Price = productGet.Price;
        product.Id_Manufacture = productGet.Id_Manufacture;
        product.Id_Provider = productGet.Id_Provider;

        _context.SaveChanges();

        return Ok("Product updated");
    }



    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var product = _context.Products.FirstOrDefault(c => c.Id == Id);

        if (product == null) { return NotFound(); }

        _context.Products.Remove(product);
        _context.SaveChanges();

        return Ok("Customer deleted");
    }
}