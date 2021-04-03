using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{

public interface IPromotionEngine
    {
         void CalculatePromotion(IList<IProduct> products);
         decimal CalculateTotalPriceAfterPromotion(IList<IProduct> products);

    }

   public class PromotionEngine : IPromotionEngine
    {
        private IList<IPromotionOffer> promotions = new List<IPromotionOffer>();
        public PromotionEngine()
        {
            promotions.Add(new A3BulkProduct());
            promotions.Add(new B2BulkProduct());
            promotions.Add(new CAndDCombineProduct());
        }

        public void CalculatePromotion(IList<IProduct> products)
        {
            foreach (var promotion in promotions)
            {
                promotion.Apply(products);
            }
        }

        public decimal CalculateTotalPriceAfterPromotion(IList<IProduct> products)
        {
            decimal total = 0;
            foreach (var item in products)
            {
                total += item.Price;
            }

            return total;
        }
    }


}
