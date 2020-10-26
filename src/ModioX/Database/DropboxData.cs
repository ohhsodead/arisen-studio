using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using ModioX.Constants;
using ModioX.Models.Database;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ModioX.Database
{
    public class DropboxData
    {
        public DropboxData()
        {
            Categories = GetCategories();
            Mods = GetMods();

            //Categories.Categories = Categories.Categories.OrderBy(o => o.Title).ToList();
        }

        /// <summary>
        ///     Contains the categories from the database.
        /// </summary>
        public CategoriesData Categories { get; private set; }

        /// <summary>
        ///     Contains the mods from database.
        /// </summary>
        public ModsData Mods { get; private set; }

        /// <summary>
        ///     Download and return the data for categories and games.
        /// </summary>
        /// <returns></returns>
        private static CategoriesData GetCategories()
        {
            using (var client = new HttpClient())
            {
                using (var response = client.GetAsync(Urls.CategoriesData).Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception($"Bad response {response.StatusCode}");
                    }

                    var responseData = response.Content.ReadAsStringAsync().Result;

                    if (IsValidJson(responseData))
                    {
                        return JsonConvert.DeserializeObject<CategoriesData>(responseData);
                    }

                    dynamic data = JsonConvert.DeserializeObject(responseData);

                    throw new Exception(data.data.Message.ToString());
                }
            }
        }

        /// <summary>
        ///     Download and return the data for mods.
        /// </summary>
        /// <returns></returns>
        private static ModsData GetMods()
        {
            using (var client = new HttpClient())
            {
                using (var response = client.GetAsync(Urls.ModsData).Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception($"Bad response {response.StatusCode}");
                    }

                    var responseData = response.Content.ReadAsStringAsync().Result;

                    if (IsValidJson(responseData))
                    {
                        return JsonConvert.DeserializeObject<ModsData>(responseData);
                    }

                    dynamic data = JsonConvert.DeserializeObject(responseData);

                    throw new Exception(data.data.Message.ToString());
                }
            }
        }


        /// <summary>
        ///     Determines a valid json response
        /// </summary>
        /// <param name="data">Json data to validate</param>
        /// <returns>Whether text is valid json format</returns>
        private static bool IsValidJson(string data)
        {
            try
            {
                var unused = JToken.Parse(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}