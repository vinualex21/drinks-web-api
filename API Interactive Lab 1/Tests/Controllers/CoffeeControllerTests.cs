using API_Interactive_Lab_1.Controllers;
using NUnit.Framework;


namespace API_Interactive_Lab_1.Tests.Controllers
{
    public class CoffeeControllerTests
    {
        [Test]
        public void TestGetCoffeeLover()
        {
            string expectedContent = "I like coffee!";

            var controller = new CoffeeController();
            var result = controller.Get();
            Assert.AreEqual(expectedContent, result);
        }

        [Test]
        public void TestGetCoffee()
        {
            string expectedContent = "We've got fresh brewing coffee!";

            var controller = new CoffeeController();
            var result = controller.GetCoffee();
            Assert.AreEqual(expectedContent, result);
        }

        [Test]
        public void TestGetCoffee_GivenCoffeeName_ReturnsCoffeeNameAndId()
        {
            string coffeeName = "cappucino";

            var controller = new CoffeeController();
            var result = controller.Get(coffeeName);

            Assert.AreEqual(coffeeName, result.Value.Name);
        }

        [Test]
        public void TestGetCoffee_GivenNoQueryParams_ReturnsLatteAndId()
        {
            var expectedCoffeeName = "latte";

            var controller = new CoffeeController();
            var result = controller.Get(null);

            Assert.AreEqual(expectedCoffeeName, result.Value.Name);
        }
    }
}
