using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praticum.Tests
{
    /// <summary>
    /// Tests to validate night orders
    /// </summary>
    [TestClass]
    public class InOrderToValidateNightOrders
    {
        #region Night Tests

        [TestMethod]
        public void When_IsNightAndOrder1234_Then_ReturnSteakPotatoWineCake()
        {
            string input = "night, 1, 2, 3, 4";
            string expectedOutput = "steak, potato, wine, cake";

            BaseDishParser dishParser = DishParserFactory.GetDishParser(input);

            string producedOutput = dishParser.Parse();

            Assert.AreEqual(expectedOutput, producedOutput);
        }

        [TestMethod]
        public void RepeatedPotatoOrderedNightTest()
        {
            string input = "night, 1, 2, 2, 4";
            string expectedOutput = "steak, potato(x2), cake";

            BaseDishParser dishParser = DishParserFactory.GetDishParser(input);

            string producedOutput = dishParser.Parse();

            Assert.AreEqual(expectedOutput, producedOutput);
        }

        [TestMethod]
        public void UnrepeatedOrderedNightErrorTest()
        {
            string input = "night, 1, 2, 3, 5";
            string expectedOutput = "steak, potato, wine, error";

            BaseDishParser dishParser = DishParserFactory.GetDishParser(input);

            string producedOutput = dishParser.Parse();

            Assert.AreEqual(expectedOutput, producedOutput);
        }

        [TestMethod]
        public void RepeatedSteakOrderedNightErrorTest()
        {
            string input = "night, 1, 1, 2, 3, 5";
            string expectedOutput = "steak, error";

            BaseDishParser dishParser = DishParserFactory.GetDishParser(input);

            string producedOutput = dishParser.Parse();

            Assert.AreEqual(expectedOutput, producedOutput);
        }


        [TestMethod]
        public void RepeatedWineOrderedNightErrorTest()
        {
            string input = "night, 1, 2, 2, 3, 3, 5";
            string expectedOutput = "steak, potato(x2), wine, error";

            BaseDishParser dishParser = DishParserFactory.GetDishParser(input);

            string producedOutput = dishParser.Parse();

            Assert.AreEqual(expectedOutput, producedOutput);
        }
        #endregion
    }
}
