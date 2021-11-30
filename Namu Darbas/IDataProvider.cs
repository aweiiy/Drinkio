using Namu_Darbas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namu_Darbas
{
    interface IDataProvider
    {
        IList<CategoriesModel> GetCategories();
        IList<GlassModel> GetGlasses();
        IList<IngredientModel> GetIngredients();
        IList<AlcoholModel> GetAlcohol();
        IList<DrinkModel> GetDrinkByCategory(string Category);
        IList<DrinkModel> GetDrinkByGlass(string Glass);
        IList<DrinkModel> GetDrinkByIngredients(string Ingredients);
        IList<DrinkModel> GetDrinkByAlcohol(string Alcohol);
        IList<DrinkModel> GetDrinkDATA(string DATA);
    }

}
