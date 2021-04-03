using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine
{
    public class B2BulkProduct : BulkPromotionOffer
    {
        public override int NumberOfItems { get; set; } = 2;

        public override decimal OfferPrice { get; set; } = 45;

        protected override IEnumerable<IProduct> Filtertems(IList<IProduct> products)
        {
            return products.OfType<ProductB>();
        }
    }
}
