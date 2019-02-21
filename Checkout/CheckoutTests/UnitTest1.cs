using System;
using System.Linq;
using Xunit;

namespace CheckoutTests
{
    public class UnitTest1
    {
        [Fact]
        public void When_AnItemIsScannedItIsAddedToTheBasket()
        {
            //--ARRANGE--
            var checkout = new Checkout.Checkout();

            //--ACT--
            checkout.Scan("A");

            //--ASSERT--
            Assert.True(checkout.Basket.Items.Any());
        }

        [Fact]
        public void When_TheTotalIsRequestedItReturnsTheTotalAmount()
        {
            //--ARRANGE--
            var checkout = new Checkout.Checkout();
            checkout.Scan("A");
            checkout.Scan("B");

            //--ACT--
            var total = checkout.GetTotalPrice();

            //--ASSERT--
            Assert.True(total > 0);
        }

        [Fact]
        public void When_AnOfferISAvailableItShouldBeApplied()
        {
            //--ARRANGE--
            var checkout = new Checkout.Checkout();
            checkout.Scan("B");
            checkout.Scan("A");
            checkout.Scan("B");

            //--ACT--
            var total = checkout.GetTotalPrice();

            //--ASSERT--
            Assert.True(total > 0);
            Assert.Equal(95, total);
        }
    }
}
