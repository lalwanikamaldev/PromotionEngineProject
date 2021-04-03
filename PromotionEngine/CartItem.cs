using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
   public class CartItem
    {
        public IList<IProduct> products = new List<IProduct>();

        //TODO:: we can use dependecy Injection
        public IPromotionEngine _engine = new PromotionEngine();

        public void AddItem(IProduct product)
        {
            products.Add(product);
        }

        public decimal CalculatePrice()
        {
            _engine.CalculatePromotion(products);
            var totalPrice = _engine.CalculateTotalPriceAfterPromotion(products);
            return totalPrice;
        }
    }
}
