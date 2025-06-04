using Bakery.Core.Plan;
using Bakery.Infrastructure.Factories;

namespace Bakery.Tests
{
    [TestClass]
    public class PlanPieczeniaTests
    {
        [TestMethod]
        public void WyswietlPlan_DodawaniaCiasta()
        {
            // Arrange
            var planPieczenia = new BakingPlan();
            var fabrykaCiastaCzekoladowego = new ChocklateCakeFactory();
            var fabrykaCiastaJabłkowego = new AppleCakeFactory();

            // Act
            planPieczenia.AddCake(fabrykaCiastaCzekoladowego);
            planPieczenia.AddCake(fabrykaCiastaJabłkowego);

            // Assert
            Assert.AreEqual(2, planPieczenia.Count(), "Ilość ciast w planie powinna być równa 2");
        }


        [TestMethod]
        public void WyświetlPlan_WyświetlaInformacjeOCiastach()
        {
            // Arrange
            var planPieczenia = new BakingPlan();
            var fabrykaCiasta1 = new AppleCakeFactory();
            var fabrykaCiasta2 = new ChocklateCakeFactory();
            planPieczenia.AddCake(fabrykaCiasta1);
            planPieczenia.AddCake(fabrykaCiasta2);

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                planPieczenia.DisplayPlan_1();
                string result = sw.ToString();

                // Assert
                StringAssert.Contains(result, "Jabłkowe");
                StringAssert.Contains(result, "Czekoladowe");
                StringAssert.Contains(result, "Składniki: Jabłka, Cynamon, Mąka, Cukier");
                StringAssert.Contains(result, "Czekolada", "Mąka", "Jajka", "Masło");
            }
        }
    }
}