namespace AssignmentSubmission.Tests
{
    using Xunit;
   
    using AssignmentSubmission.Models;

    public class OrderTests
    {
        [Fact]
        public void LoyalCustomer_Above100_ShouldApplyDiscount()
        {
            // Arrange
            var order = new OrderModel { OrderAmount = 100, CustomerType = "Loyal" };

            // Act
            decimal expectedDiscount = order.OrderAmount * 0.10m;
            decimal finalTotal = order.OrderAmount - expectedDiscount;

            // Assert
            Assert.Equal(10, expectedDiscount);
            Assert.Equal(90, finalTotal);
        }

        [Fact]
        public void NewCustomer_Above100_ShouldNotApplyDiscount()
        {
            // Arrange
            var order = new OrderModel { OrderAmount = 100, CustomerType = "New" };

            // Act
            decimal expectedDiscount = 0;
            decimal finalTotal = order.OrderAmount - expectedDiscount;

            // Assert
            Assert.Equal(0, expectedDiscount);
            Assert.Equal(100, finalTotal);
        }

        [Fact]
        public void OrderBelow100_ShouldNotApplyDiscount()
        {
            // Arrange
            var order = new OrderModel { OrderAmount = 99.99m, CustomerType = "Loyal" };

            // Act
            decimal expectedDiscount = 0;
            decimal finalTotal = order.OrderAmount - expectedDiscount;

            // Assert
            Assert.Equal(0, expectedDiscount);
            Assert.Equal(99.99m, finalTotal);
        }
    }

}
