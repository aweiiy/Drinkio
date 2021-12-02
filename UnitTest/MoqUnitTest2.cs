using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Namu_Darbas;
using Namu_Darbas.Models;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class MoqUnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            var provider = new Mock<IDataProvider>(MockBehavior.Strict);
            var repository = new Repository(provider.Object);

            provider.Setup(m => m.GetDrinkByCategory("Coffee")).Returns(new List<DrinkModel>
            {
                new DrinkModel {strDrink = "AAA", strInstructions = "Ipilti AAA i vandeni ir ismaisyti", strIngredient1 = "AAA", strIngredient2 = "Vanduo", strAlcoholic = "Non alcoholic" },
                new DrinkModel {strDrink = "BBB", strInstructions = "Ipilti BBB i vandeni ir ismaisyti", strIngredient1 = "BBB", strIngredient2 = "Vanduo", strAlcoholic = "Non alcoholic" },
                new DrinkModel {strDrink = "CCC", strInstructions = "Ipilti CCC i vandeni ir ismaisyti", strIngredient1 = "CCC", strIngredient2 = "Vanduo", strAlcoholic = "Alcoholic" },
                new DrinkModel {strDrink = "DDD", strInstructions = "Ipilti DDD i vandeni ir ismaisyti", strIngredient1 = "DDD", strIngredient2 = "Vanduo", strAlcoholic = "Non alcoholic" },
                new DrinkModel {strDrink = "EEE", strInstructions = "Ipilti EEE i vandeni ir ismaisyti", strIngredient1 = "EEE", strIngredient2 = "Vanduo", strAlcoholic = "Alcoholic" }
            });
            Assert.AreEqual(3, repository.CountDrinksByAlcoholType("Coffee", "Non alcoholic"));
            Assert.AreEqual(2, repository.CountDrinksByAlcoholType("Coffee" , "Alcoholic"));
        }
    }
}