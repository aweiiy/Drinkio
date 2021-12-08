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

            provider.Setup(m => m.GetDrinkByAlcohol("Non alcoholic")).Returns(new List<DrinkModel>
            {
                new DrinkModel {strDrink = "Afterglow", strInstructions = "Mix.", strIngredient1 = "Grenadine", strIngredient2 = "Orange Juice", strAlcoholic = "Non alcoholic" },
                new DrinkModel {strDrink = "Alice Cocktail", strInstructions = "Shake well, strain into a large cocktail glass.", strIngredient1 = "Grenadine", strIngredient2 = "Pineapple juice", strAlcoholic = "Non alcoholic" },
                new DrinkModel {strDrink = "Aloha Fruit punch", strInstructions = "Combine with juices and pineapple.", strIngredient1 = "Guava juice", strIngredient2 = "Ginger", strAlcoholic = "Non alcoholic" },
                new DrinkModel {strDrink = "Apello", strInstructions = "Stirr.", strIngredient1 = "Orange juice", strIngredient2 = "Grapefruit juice", strAlcoholic = "Non alcoholic" },
                new DrinkModel {strDrink = "Apple Berry Smoothie", strInstructions = "Throw everything into a blender and liquify.", strIngredient1 = "Berries", strIngredient2 = "Apple", strAlcoholic = "Non alcoholic" }
            });
            Assert.AreEqual(5, repository.CountDrinksByAlcoholType("Non alcoholic"));

            provider.Setup(m => m.GetDrinkByAlcohol("Alcoholic")).Returns(new List<DrinkModel>
            {
                new DrinkModel {strDrink = "50/50", strInstructions = "fill glass with crushed ice, add vodka, fill with oj", strIngredient1 = "Vodka", strIngredient2 = "Orange Juice", strAlcoholic = "Alcoholic" },
                new DrinkModel {strDrink = "Adam", strInstructions = "In a shaker half-filled with ice cubes, combine all of the ingredients.", strIngredient1 = "Rum", strIngredient2 = "Lemon juice", strAlcoholic = "Alcoholic" }
            });
            Assert.AreEqual(2, repository.CountDrinksByAlcoholType("Alcoholic"));

        }
        [TestMethod]
        public void TestMethod3()
        {
            var provider = new Mock<IDataProvider>(MockBehavior.Strict);
            var repository = new Repository(provider.Object);

            provider.Setup(m => m.GetDrinkByCategory("Soft Drink")).Returns(new List<DrinkModel>
            {
                new DrinkModel {strDrink = "Butterfly Effect", strInstructions = "Grab your boston tin, fill it with cubes ice and then simply chuck in all your ingredients apart from your lemonade.", strIngredient1 = "Vodka", strIngredient2 = "Cranberry Juice", strAlcoholic = "Alcoholic" },
                new DrinkModel {strDrink = "Afternoonz", strInstructions = "Build into a suiting glass, with no ice.", strIngredient1 = "Kahlua", strIngredient2 = "Cream", strAlcoholic = "Non alcoholic" },
                new DrinkModel {strDrink = "Pink Moon", strInstructions = "Slowly shake in a shaker with ice, strain into a square whiskey glass.", strIngredient1 = "Gin", strIngredient2 = "Coconut Liquer", strAlcoholic = "Alcoholic" },
                new DrinkModel {strDrink = "Apple Highball", strInstructions = "Add ice in a highball glass.", strIngredient1 = "Cognac", strIngredient2 = "Lime", strAlcoholic = "Alcoholic" },
                new DrinkModel {strDrink = "Mountain Bramble", strInstructions = "Mix the Gin, lemon juice and sugar syrup in a shaker and strain over chopped ice.", strIngredient1 = "Gin", strIngredient2 = "Lemon", strAlcoholic = "Alcoholic" }
            });
            Assert.AreEqual(1, repository.CountDrinksByAlcoholType("Soft Drink", "Non alcoholic"));
            Assert.AreEqual(4, repository.CountDrinksByAlcoholType("Soft Drink", "Alcoholic"));
        }
    }
}