using ApiOefening.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiOefening.Logic
{
    class CocktailLogic
    {
        public async static Task<List<Drink>> GetCocktailsByName(string name)
        {
            List<Drink> cocktails = new List<Drink>();

            var url = Cocktail.GenerateURLName(name);
            HttpClient client = new HttpClient();
            
            
                var response = await client.GetAsync(url);

                var json = await response.Content.ReadAsStringAsync();

                var cocktailByNameResponse = JsonConvert.DeserializeObject<CocktailByNameResponse>(json);

                cocktails = cocktailByNameResponse.Drinks as List<Drink>;
            

            return cocktails;
        }
    }
}
