using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public interface IPromotionOffer
    {
        string OfferId { get; set; }
        string OfferName { get; set; }
        int NumberOfItems { get; set; }
         decimal OfferPrice { get; set; }
        void Apply(IList<IProduct> products);

    }
}
