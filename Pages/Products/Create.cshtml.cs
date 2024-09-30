using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductRazorApp.Models;
using ProductRazorApp.Services;
using System.Threading.Tasks;

namespace ProductRazorApp.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly ProductService _productService;
        [BindProperty]
        public Product Product { get; set; }

        public CreateModel(ProductService productService)
        {
            _productService = productService;
        }

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _productService.CreateProductAsync(Product);
            return RedirectToPage("Index");
        }
    }
}
