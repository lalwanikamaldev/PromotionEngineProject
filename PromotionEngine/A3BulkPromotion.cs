using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine
{

    public class A3BulkProduct : BulkPromotionOffer
    {
        public override int NumberOfItems { get; set; } = 3;

        public override decimal OfferPrice { get; set; } = 130;

        protected override IEnumerable<IProduct> Filtertems(IList<IProduct> products)
        {
            return products.OfType<ProductA>();
        }
    }
}