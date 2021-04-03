using NUnit.Framework;
using PromotionEngine;

namespace CartTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ScenarioA()
        {
            var myCart = new CartItem();

            myCart.AddItem(new ProductA());
            myCart.AddItem(new ProductB());
            myCart.AddItem(new ProductC());
            Assert.IsTrue(myCart.CalculatePrice() == 100);
        }

        [Test]
        public void ScenarioB()
        {
            var myCart = new CartItem();

            myCart.AddItem(new ProductA());
            myCart.AddItem(new ProductA());
            myCart.AddItem(new ProductA());
            myCart.AddItem(new ProductA());
            myCart.AddItem(new ProductA());
            myCart.AddItem(new ProductB());
            myCart.AddItem(new ProductB());
            myCart.AddItem(new ProductB());
            myCart.AddItem(new ProductB());
            myCart.AddItem(new ProductB());
            myCart.AddItem(new ProductC());
            Assert.IsTrue(myCart.CalculatePrice() == 370);
        }

        [Test]
        public void ScenarioC()
        {
            var myCart = new CartItem();

            myCart.AddItem(new ProductA());
            myCart.AddItem(new ProductA());
            myCart.AddItem(new ProductA());
            myCart.AddItem(new ProductB());
            myCart.AddItem(new ProductB());
            myCart.AddItem(new ProductB());
            myCart.AddItem(new ProductB());
            myCart.AddItem(new ProductB());
            myCart.AddItem(new ProductC());
            myCart.AddItem(new ProductD());
            Assert.IsTrue(myCart.CalculatePrice() == 280);
        }
    }
}