using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namu_Darbas
{
    public class Repository
    {
        private readonly IDataProvider m_provider;
        public Repository(IDataProvider privider)
        {
            m_provider = privider;
        }

        public int CountDrinksByMainIngredient(string ingredient)
        {
            return m_provider.GetDrinkByIngredients(ingredient).Where(o => o.strIngredient1.StartsWith(ingredient)).Count();
        }

        public int CountDrinksByAlcoholType(string Category, string alcoholType)
        {
            return m_provider.GetDrinkByCategory(Category).Where(o => o.strAlcoholic.StartsWith(alcoholType)).Count();
        }

    }
}
