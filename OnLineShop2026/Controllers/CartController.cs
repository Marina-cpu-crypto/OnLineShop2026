using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class CartController : Controller
    {

        IProductRepository productRepository;
        Cart userCart = new Cart();
        public CartController(IProductRepository prodRep)
        {
            this.productRepository = prodRep;
        }

        public string Index(Guid id)
        {
            Product pr = productRepository.TryGetById(id);
            CartItem cartItem = new CartItem() 
            { 
                Product = pr,
                Amount = 3
            };
            userCart.CartItems.Add(cartItem);

            return cartItem.ToString() + "  " + userCart.CartItems.Count.ToString();
        }
    }
}
