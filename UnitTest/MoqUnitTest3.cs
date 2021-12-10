using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Namu_Darbas;
using Namu_Darbas.Models;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class MoqUnitTest3
    {
        [TestMethod]
        public void TestMethod4()
        {
            var provider = new Mock<IDataProvider>(MockBehavior.Strict);
            var repository = new Repository(provider.Object);

            provider.Setup(m => m.GetCategories()).Returns(new List<CategoriesModel>
            {
                new CategoriesModel {strCategory = "test"},
                new CategoriesModel {strCategory = "test1"},
                new CategoriesModel {strCategory = "test2"},
                new CategoriesModel {strCategory = "test"},
            });
            Assert.AreEqual(2, repository.CountDrinksCategories("test"));

            provider.Setup(m => m.GetGlasses()).Returns(new List<GlassModel>
            {
                new GlassModel {strGlass = "test"},
                new GlassModel {strGlass = "test1"},
                new GlassModel {strGlass = "test2"},
                new GlassModel {strGlass = "test"},
                new GlassModel {strGlass = "test1"}
            });
            Assert.AreEqual(2, repository.CountDrinksGlasses("test1"));
        }
    }
}