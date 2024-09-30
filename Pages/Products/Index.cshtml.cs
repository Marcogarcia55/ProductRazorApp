using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductRazorApp.Models;
using ProductRazorApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductRazorApp.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ProductService _productService;
        public List<Product> Products { get; set; }

        public IndexModel(ProductService productService)
        {
            _productService = productService;
        }

        public async Task OnGetAsync()
        {
            Products = await _productService.GetProductsAsync();
        }
    }
}
