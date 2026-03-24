using System;

namespace OnLineShop2026.Models
{
    public class Cart
    {
       

        public Guid Id { get; set; }
        public int UserId { get; set; }
        public List<CartItem> CartItems { get; set; }
        public decimal Cost { get; set; }

        public Cart()
        {
            CartItems = new List<CartItem>();
        }
    }
}
