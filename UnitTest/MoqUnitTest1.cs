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

            provider.Setup(m => m.GetDrinkByIngredients("Vodka")).Returns(new List<DrinkModel>
            {
                new DrinkModel {strDrink = "Black Russian", strInstructions = "Pour the ingredients into an old fashioned glass filled with ice cubes.", strIngredient1 = "Vodka", strIngredient2 = "Coffee liqueur" },
                new DrinkModel {strDrink = "Bloody Mary", strInstructions = "Stirring gently, pour all ingredients into highball glass.", strIngredient1 = "Vodka", strIngredient2 = "Tomato juice" },
                new DrinkModel {strDrink = "Blue Lagoon", strInstructions = "Pour vodka and curacao over ice in a highball glass.", strIngredient1 = "Vodka", strIngredient2 = "Blue curacao" },
                new DrinkModel {strDrink = "Blue Mountain", strInstructions = "In a shaker half-filled with ice cubes, combine all of the ingredients.", strIngredient1 = "Vodka", strIngredient2 = "Tia maria" },
                new DrinkModel {strDrink = "Godchild", strInstructions = "Shake all ingredients well with cracked ice, strain into a champagne flute, and serve.", strIngredient1 = "Vodka", strIngredient2 = "Amaretto" }
            });
            Assert.AreEqual(5, repository.CountDrinksByIngredient("Vodka"));

            provider.Setup(m => m.GetDrinkByIngredients("Gin")).Returns(new List<DrinkModel>
            {
                new DrinkModel {strDrink = "Abbey Cocktail", strInstructions = "Shake all ingredients (except for the cherry) with ice and strain into a cocktail glass.", strIngredient1 = "Gin", strIngredient2 = "Orange bitters" },
                new DrinkModel {strDrink = "Alaska Cocktail", strInstructions = "Stir all ingredients with ice, strain contents into a cocktail glass.", strIngredient1 = "Gin", strIngredient2 = "Chartreuse" },
                new DrinkModel {strDrink = "Alexander", strInstructions = "Shake all ingredients with ice and strain contents into a cocktail glass.", strIngredient1 = "Gin", strIngredient2 = "Creme de Cacao" },
                new DrinkModel {strDrink = "Archbishop", strInstructions = "In an old-fashioned glass almost filled with ice cubes, combine all of the ingredients.", strIngredient1 = "Gin", strIngredient2 = "Ginger wine" }
            });
            Assert.AreEqual(4, repository.CountDrinksByIngredient("Gin"));

            provider.Setup(m => m.GetDrinkByIngredients("Poison")).Returns(new List<DrinkModel>());
            Assert.AreEqual(0, repository.CountDrinksByIngredient("Poison"));
        }
    }
}