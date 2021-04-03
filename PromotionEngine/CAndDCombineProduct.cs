using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine
{
    public class CAndDCombineProduct : IPromotionOffer
    {
        public string OfferId { get ; set; }
        public string OfferName { get; set; }
        public int NumberOfItems { get; set; } = 2;
        public decimal OfferPrice { get; set; } = 30;

        public void Apply(IList<IProduct> products)
        {
            var cItems = products.OfType<ProductC>().ToArray();
            var dItems = products.OfType<ProductD>().ToArray();

            if (cItems.Count() == 0 || dItems.Count() == 0)
            {
                return;
            }

            if (cItems.Length <= dItems.Length)
            {
                for (int i = 0; i < cItems.Length; i++)
                {
                    cItems[i].Price = 0;
                    dItems[i].Price = OfferPrice;
                }
            }
            else
            {
                for (int i = 0; i < dItems.Length; i++)
                {
                    cItems[i].Price = 0;
                    dItems[i].Price = OfferPrice;
                }
            }


        }

     
    }
}