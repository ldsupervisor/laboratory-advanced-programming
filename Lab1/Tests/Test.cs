using Bakery.Core.Plan;
using Bakery.Infrastructure.Factories;

namespace Bakery.Tests
{
    [TestClass]
    public class BakingPlanTest
    {
        [TestMethod]
        public void DisplayBakingCakePlan()
        {
            // Arrange
            var bakingPlan = new BakingPlan();
            var chocklateCakeFactory = new ChocklateCakeFactory();
            var appleCakeFactory = new AppleCakeFactory();

            // Act
            bakingPlan.AddCake(chocklateCakeFactory);
            bakingPlan.AddCake(appleCakeFactory);

            // Assert
            Assert.AreEqual(2, bakingPlan.Count(), "Quantity of cakes in plan should be 2");
        }

        [TestMethod]
        public void DisplayPlan_DisplaysCakeDetails()
        {
            // Arrange
            var bakingPlan = new BakingPlan();
            var cakeFactory_1 = new AppleCakeFactory();
            var cakeFactory_2 = new ChocklateCakeFactory();
            bakingPlan.AddCake(cakeFactory_1);
            bakingPlan.AddCake(cakeFactory_2);

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                bakingPlan.DisplayPlan_1();
                string result = sw.ToString();

                // Assert
                StringAssert.Contains(result, "Apple");
                StringAssert.Contains(result, "Apples, Cinammon, Flour, Sugar");
            }
        }
    }
}