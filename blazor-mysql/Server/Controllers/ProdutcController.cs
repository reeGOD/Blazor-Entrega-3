using blazor_mysql.Server;
using Microsoft.AspNetCore.Mvc;
using blazor_mysql.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class ProductController : Controller
{
    private readonly ApplicationDbContext db;

    public ProductController(ApplicationDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var products = await db.Products.ToListAsync();
        return Ok(products);
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var product = await db.Products.SingleOrDefaultAsync(x => x.Id == Convert.ToInt32(id));
        return Ok(product);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Product product)
    {
        try
        {
            var newProduct = new Product
            {
                Nome = product.Nome,
                Descricao = product.Descricao,
                Valor = product.Valor
            };

            db.Add(newProduct);
            await db.SaveChangesAsync();//INSERT INTO
            return Ok();
        }
        catch (Exception e)
        {
            return View(e);
        }
    }

     [HttpPut]
    [Route("Update")]
    public async Task<IActionResult> Put([FromBody] Product product)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        db.Entry(product).State = EntityState.Modified;
        try
        {
            await db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            throw (ex);
        }
        return NoContent();
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<ActionResult<Product>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var product = await db.Products.FindAsync(id);
        if (product == null)
        {
            return NotFound();
        }
        db.Products.Remove(product);
        await db.SaveChangesAsync();
        return product;
    }

    private bool UserExists(int id)
    {
        return db.Users.Any(e => e.Id == id);
    }

}