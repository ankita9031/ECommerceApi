using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommerceApi.Data;
using ECommerceApi.Models;

namespace ECommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // GET: api/GetProductsByName/shirt
        [HttpGet("GetProductsByName/{name}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsByName(string name)
        {
            var products = await _context.Products.Where(x => x.Name == name)?.ToListAsync();

            if (products == null)
            {
                return NotFound();
            }

            return products;
        }

        // GET: api/GetProductsByName/shirt
        [HttpGet("GetProductsByNameAndCategory/{filter}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsByNameAndCategory(string filter)
        {
            var products = await _context.Products.Where(x => x.Name.Contains(filter) || x.Category.Contains(filter))?.ToListAsync();

            if (products == null)
            {
                return NotFound();
            }

            return products;
        }


    }
}
