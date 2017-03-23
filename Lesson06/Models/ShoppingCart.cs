using System.Collections.Generic;

namespace Lesson06.Models
{
    public class ShoppingCart
    {
        private List<string> _cart = new List<string>();

        public void AddItem(params string[] items)
        {
            foreach (var item in items)
            {
                _cart.Add(item);
            }
        }
    }
}