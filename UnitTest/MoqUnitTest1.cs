using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Namu_Darbas;
using Namu_Darbas.Models;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class MoqUnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var provider = new Mock<IDataProvider>(MockBehavior.Strict);
            var repository = new Repository(provider.Object);

            provider.Setup(m => m.GetDrinkByIngredients("Nuodai")).Returns(new List<DrinkModel>
            {
                new DrinkModel {strDrink = "AAA", strInstructions = "Ipilti AAA i vandeni ir ismaisyti", strIngredient1 = "AAA", strIngredient2 = "Vanduo" },
                new DrinkModel {strDrink = "BBB", strInstructions = "Ipilti nuodus i vandeni ir ismaisyti", strIngredient1 = "Nuodai", strIngredient2 = "Vanduo" },
                new DrinkModel {strDrink = "CCC", strInstructions = "Ipilti CCC i vandeni ir ismaisyti", strIngredient1 = "CCC", strIngredient2 = "Vanduo" },
                new DrinkModel {strDrink = "DDD", strInstructions = "Ipilti DDD i vandeni ir ismaisyti", strIngredient1 = "DDD", strIngredient2 = "Vanduo" },
                new DrinkModel {strDrink = "EEE", strInstructions = "Ipilti nuodus i vandeni ir ismaisyti", strIngredient1 = "Nuodai", strIngredient2 = "Vanduo" }
            });
            Assert.AreEqual(2, repository.CountDrinksByMainIngredient("Nuodai"));
        }
    }
}