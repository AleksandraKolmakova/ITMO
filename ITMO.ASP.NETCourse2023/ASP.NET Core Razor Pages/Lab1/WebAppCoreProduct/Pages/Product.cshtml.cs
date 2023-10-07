using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreProduct.Models;

namespace WebAppCoreProduct.Pages
{
    public class ProductModel : PageModel
    {
        public Product Product { get; set; }
        public string? MessageRezult { get; set; }

        
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
            MessageRezult = $"For product {name} with price {price}$ dicsount is {result}$";

            Product.Price = price;
            Product.Name = name;
        }
        public void OnPostDiscount(string name, decimal? price, double discount)
        {
            Product = new Product();
            var result = price - (price * (decimal?)discount / 100);
            MessageRezult = $"For product {name} with price {price}$ " +
                $"and dicsount {discount}% result price is {result}$";
            Product.Price = price;
            Product.Name = name;
        }
        public void OnPostSaveYourMoney(string name, decimal? price, double discount)
        {
            Product = new Product();
            var result = price - (price - (price * (decimal?)discount / 100));
            MessageRezult = $"For product {name} with price {price}$ " +
                $"and dicsount {discount}% you save {result}$";
            Product.Price = price;
            Product.Name = name;
        }
    }
}
