using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
     public interface IProduct
    {
        public string SKUID { get; }

        public decimal Price { get; set; }

    }

    public class ProductA : IProduct
    {
        public ProductA()
        {
            Price = 50;
        }
        public string SKUID { get => "A"; }

        public decimal Price { get; set; }

    }

    public class ProductB : IProduct
    {
        public ProductB()
        {
            Price = 30;
        }
        public string SKUID { get => "B"; }

        public decimal Price { get; set; }

    }

    public class ProductC : IProduct
    {
        public ProductC()
        {
            Price = 20;
        }
        public string SKUID { get => "C"; }

        public decimal Price { get; set; }

    }

    public class ProductD : IProduct
    {
        public ProductD()
        {
            Price = 15;
        }
        public string SKUID { get => "D"; }

        public decimal Price { get; set; }

    }

}
