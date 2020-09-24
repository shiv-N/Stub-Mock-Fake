using CoffeeMaker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CoffeeMakerTestcase
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// Using Mock.
        /// </summary>
        [TestMethod]
        public void OrderACoffee_Should_Return_Received_MessageUsingMock()
        {
            var service = new Mock<IMakeACoffee>();
            service.Setup(x => x.CheckIngridentAvalability()).Returns(true);
            service.Setup(x => x.CoffeeMaking(It.IsAny<int>(), It.IsAny<int>())).Returns("Your Order is received.");
            var store = new StarbuckStore(service.Object);
            var result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is received.", result);
            service.Verify(x => x.CheckIngridentAvalability());
            service.Verify(x => x.CoffeeMaking(It.IsAny<int>(), It.IsAny<int>()));
        }

        /// <summary>
        ///  Using Fake
        /// </summary>
        [TestMethod]
        public void OrderACoffee_Should_Return_Received_Message()
        {
            StarbuckStore store = new StarbuckStore(new FakeStarbucksStore());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is received.",result);
        }


        /// <summary>
        ///  Using Stub
        /// </summary>
        [TestMethod]
        public void OrderACoffee_Should_Return_Received_MessageUsingStub()
        {
            StarbuckStore store = new StarbuckStore(new StubStarbucks());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is received.", result);
        }
    }
}
