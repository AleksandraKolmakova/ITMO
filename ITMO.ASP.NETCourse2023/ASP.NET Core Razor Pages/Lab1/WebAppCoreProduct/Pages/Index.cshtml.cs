using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreProduct.Models;

namespace WebAppCoreProduct.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet(string name, decimal? price)
        {
           
        }
        /* Ex1-3
        public Product Product { get; set; }
        public string? MessageRezult { get; set; }
        */

        /* Ex1-2
        public bool IsCorrect { get; set; } = true;
        
        public void OnGet(string name, decimal? price)
        {
            Product = new Product();
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                IsCorrect = false;
                return;
            }
            Product.Price = price;
            Product.Name = name;

            var result = price * (decimal?)0.18;
            MessageRezult = $"For product {name} with price {price} dicsount is {result}";
        }*/

        /*Ex3
        public void OnGet(string name, decimal? price)
        {
            MessageRezult = "You can have a discount for this product";
        }

        public void OnPost(string name, decimal? price)
        {
            Product = new Product();
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                MessageRezult = $"Wrong data. Try again";
                return;
            }
            var result = price * (decimal?)0.18;
            MessageRezult = $"For product {name} with price {price} dicsount is {result}";

            Product.Price = price;
            Product.Name = name;
        }
        */
    }
}
