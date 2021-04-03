using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Welcome TO shopping promotional Engine , Please add the product by pressing the key , ex:- 3 A product selected as AAA");

            var inputItems = Console.ReadLine();

            CartItem cartItem = new CartItem();


            foreach(var c in inputItems)
            {
                switch (char.ToUpper(c))
                {
                    case'A':
                        cartItem.AddItem(new ProductA());
                        break;
                    case 'B':
                        cartItem.AddItem(new ProductB());
                        break;
                    case 'C':
                        cartItem.AddItem(new ProductC());
                        break;
                    case 'D':
                        cartItem.AddItem(new ProductD());
                        break;
                    default:
                        break;
                }
            }

          var totalPrice  =  cartItem.CalculatePrice();

            Console.WriteLine("Your Total Product Price is "+ totalPrice);
        }
    }

}
