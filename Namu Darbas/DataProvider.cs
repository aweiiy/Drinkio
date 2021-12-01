using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Namu_Darbas.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Namu_Darbas
{
    class DataProvider : IDataProvider
    {
        string API_URL = "https://www.thecocktaildb.com/api/json/v1/1/";

        public IList<CategoriesModel> GetCategories()
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string str = ApiClient.GetStringAsync("list.php?c=list").Result;
                JObject o = JObject.Parse(str);
                List<CategoriesModel> list = JsonConvert.DeserializeObject<List<CategoriesModel>>(o["drinks"].ToString());
                return list;
            }

        }
        public IList<GlassModel> GetGlasses()
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string str = ApiClient.GetStringAsync("list.php?g=list").Result;
                JObject o = JObject.Parse(str);
                List<GlassModel> list = JsonConvert.DeserializeObject<List<GlassModel>>(o["drinks"].ToString());
                return list;
            }

        }


        public IList<IngredientModel> GetIngredients()
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string str = ApiClient.GetStringAsync("list.php?i=list").Result;
                JObject o = JObject.Parse(str);
                List<IngredientModel> list = JsonConvert.DeserializeObject<List<IngredientModel>>(o["drinks"].ToString());
                return list;
            }

        }
        public IList<AlcoholModel> GetAlcohol()
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string str = ApiClient.GetStringAsync("list.php?a=list").Result;
                JObject o = JObject.Parse(str);
                List<AlcoholModel> list = JsonConvert.DeserializeObject<List<AlcoholModel>>(o["drinks"].ToString());
                return list;
            }

        }

        public IList<DrinkModel> GetDrinkByCategory(string Category)
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string str = ApiClient.GetStringAsync($"filter.php?c={Category}").Result;
                JObject o = JObject.Parse(str);
                List<DrinkModel> list = JsonConvert.DeserializeObject<List<DrinkModel>>(o["drinks"].ToString());
                return list;
            }

        }
        public IList<DrinkModel> GetDrinkByGlass(string Glass)
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string str = ApiClient.GetStringAsync($"filter.php?g={Glass}").Result;
                JObject o = JObject.Parse(str);
                List<DrinkModel> list = JsonConvert.DeserializeObject<List<DrinkModel>>(o["drinks"].ToString());
                return list;
            }

        }
        public IList<DrinkModel> GetDrinkByIngredients(string Ingredients)
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string str = ApiClient.GetStringAsync($"filter.php?i={Ingredients}").Result;
                JObject o = JObject.Parse(str);
                List<DrinkModel> list = JsonConvert.DeserializeObject<List<DrinkModel>>(o["drinks"].ToString());
                return list;
            }

        }
        public IList<DrinkModel> GetDrinkByAlcohol(string Alcohol)
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string str = ApiClient.GetStringAsync($"filter.php?a={Alcohol}").Result;
                JObject o = JObject.Parse(str);
                List<DrinkModel> list = JsonConvert.DeserializeObject<List<DrinkModel>>(o["drinks"].ToString());
                return list;
            }

        }
        public IList<DrinkModel> GetDrinkDATA(string DATA)
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string str = ApiClient.GetStringAsync($"search.php?s={DATA}").Result;
                JObject o = JObject.Parse(str);
                List<DrinkModel> list = JsonConvert.DeserializeObject<List<DrinkModel>>(o["drinks"].ToString());
                return list;
            }

        }

        public IList<DrinkModel> GetRandom()
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string str = ApiClient.GetStringAsync("random.php").Result;
                JObject o = JObject.Parse(str);
                List<DrinkModel> list = JsonConvert.DeserializeObject<List<DrinkModel>>(o["drinks"].ToString());
                return list;
            }

        }



    }
}
