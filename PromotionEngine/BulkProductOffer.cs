using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine
{
    public abstract class BulkPromotionOffer : IPromotionOffer
    {
        public string OfferId { get; set; }
        public string OfferName { get; set; }
        public abstract int NumberOfItems { get; set; }
        public abstract decimal OfferPrice { get; set; }

        protected abstract IEnumerable<IProduct> Filtertems(IList<IProduct> items);

        public void Apply(IList<IProduct> cartItems)
        {

            IEnumerable<IProduct> items = Filtertems(cartItems);

            int currentIndex = 0;

            while (true)
            {
                var selectedItems = items.Skip(currentIndex).Take(NumberOfItems);
                if (selectedItems.Count() < NumberOfItems)
                {
                    break;
                }

                int index = 1;
                foreach (var item in selectedItems)
                {
                    if (index == 1)
                    {
                        item.Price = this.OfferPrice;
                    }
                    else
                    {
                        item.Price = 0;
                    }

                    index++;
                }

                currentIndex += NumberOfItems;
            }

        }
    }
}   
