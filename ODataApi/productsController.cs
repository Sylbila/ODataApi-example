using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.AspNetCore.OData.Query;

[Route("odata/[controller]")]
public class ProductsController : ODataController
{
    private static List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "Lip Balm", Price = 25000 },
        new Product { Id = 2, Name = "Serum", Price = 75000 }
    };

    [EnableQuery]
    public IActionResult Get()
    {
        return Ok(products);
    }
}
