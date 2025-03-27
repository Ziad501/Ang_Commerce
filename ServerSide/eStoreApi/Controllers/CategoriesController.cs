using eStoreApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eStoreApi.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }


[HttpGet]
public async Task<IActionResult> GetCategories()
{
    try
    {
        var categories = await _context.Categories.ToListAsync();

        // Log the results
        Console.WriteLine($"Categories Count: {categories.Count}");
        foreach (var category in categories)
        {
            Console.WriteLine($"Category ID: {category.Id}, Name: {category.Category1}");
        }

        if (!categories.Any()) return NotFound("No categories found.");
        
        return Ok(categories);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error fetching categories: {ex.Message}");
        return StatusCode(500, $"Internal server error: {ex.Message}");
    }
}


}}
