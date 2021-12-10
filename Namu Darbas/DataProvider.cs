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

                string result = ApiClient.GetStringAsync("list.php?c=list").Result;
                JObject jResults = JObject.Parse(result);
                List<CategoriesModel> list = JsonConvert.DeserializeObject<List<CategoriesModel>>(jResults["drinks"].ToString());
                return list;
            }

        }
        public IList<GlassModel> GetGlasses()
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string result = ApiClient.GetStringAsync("list.php?g=list").Result;
                JObject jResults = JObject.Parse(result);
                List<GlassModel> list = JsonConvert.DeserializeObject<List<GlassModel>>(jResults["drinks"].ToString());
                return list;
            }

        }


        public IList<IngredientModel> GetIngredients()
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string result = ApiClient.GetStringAsync("list.php?i=list").Result;
                JObject jResults = JObject.Parse(result);
                List<IngredientModel> list = JsonConvert.DeserializeObject<List<IngredientModel>>(jResults["drinks"].ToString());
                return list;
            }

        }
        public IList<AlcoholModel> GetAlcohol()
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string result = ApiClient.GetStringAsync("list.php?a=list").Result;
                JObject jResults = JObject.Parse(result);
                List<AlcoholModel> list = JsonConvert.DeserializeObject<List<AlcoholModel>>(jResults["drinks"].ToString());
                return list;
            }

        }

        public IList<DrinkModel> GetDrinkByCategory(string Category)
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string result = ApiClient.GetStringAsync($"filter.php?c={Category}").Result;
                JObject jResults = JObject.Parse(result);
                List<DrinkModel> list = JsonConvert.DeserializeObject<List<DrinkModel>>(jResults["drinks"].ToString());
                return list;
            }

        }
        public IList<DrinkModel> GetDrinkByGlass(string Glass)
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string result = ApiClient.GetStringAsync($"filter.php?g={Glass}").Result;
                JObject jResults = JObject.Parse(result);
                List<DrinkModel> list = JsonConvert.DeserializeObject<List<DrinkModel>>(jResults["drinks"].ToString());
                return list;
            }

        }
        public IList<DrinkModel> GetDrinkByIngredients(string Ingredients)
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string result = ApiClient.GetStringAsync($"filter.php?i={Ingredients}").Result;
                JObject jResults = JObject.Parse(result);
                List<DrinkModel> list = JsonConvert.DeserializeObject<List<DrinkModel>>(jResults["drinks"].ToString());
                return list;
            }

        }
        public IList<DrinkModel> GetDrinkByAlcohol(string Alcohol)
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string result = ApiClient.GetStringAsync($"filter.php?a={Alcohol}").Result;
                JObject jResults = JObject.Parse(result);
                List<DrinkModel> list = JsonConvert.DeserializeObject<List<DrinkModel>>(jResults["drinks"].ToString());
                return list;
            }

        }
        public IList<DrinkModel> GetDrinkDATA(string DATA)
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string result = ApiClient.GetStringAsync($"search.php?s={DATA}").Result;
                JObject jResults = JObject.Parse(result);
                List<DrinkModel> list = JsonConvert.DeserializeObject<List<DrinkModel>>(jResults["drinks"].ToString());
                return list;
            }

        }

        public IList<DrinkModel> GetRandom()
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                ApiClient.BaseAddress = new Uri(API_URL);

                string result = ApiClient.GetStringAsync("random.php").Result;
                JObject jResults = JObject.Parse(result);
                List<DrinkModel> list = JsonConvert.DeserializeObject<List<DrinkModel>>(jResults["drinks"].ToString());
                return list;
            }

        }



    }
}
