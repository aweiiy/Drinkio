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
        public Repository(IDataProvider provider)
        {
            m_provider = provider;
        }

        public int CountDrinksByIngredient(string ingredient)
        {
            return m_provider.GetDrinkByIngredients(ingredient).Count();
        }

        public int CountDrinksByAlcoholType(string Category, string alcoholType)
        {
            return m_provider.GetDrinkByCategory(Category).Where(o => o.strAlcoholic.StartsWith(alcoholType)).Count();
        }

        public int CountDrinksByAlcoholType(string alcoholType)
        {
            return m_provider.GetDrinkByAlcohol(alcoholType).Count();
        }
    }
}
