using ModioX.Constants;
using ModioX.Models.Database;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace ModioX.Database
{
    public class DropboxData
    {
        public ModsData Mods { get; set; }

        public CategoriesData Categories { get; set; }

        public DropboxData()
        {
            Mods = GetMods();
            Categories = GetCategories();

            Categories.Categories = Categories.Categories.OrderBy(o => o.Title).ToList();
        }

        /// <summary>
        ///     Download and return the data for mods.
        /// </summary>
        /// <returns></returns>
        private static ModsData GetMods()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(Urls.ModsData).Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception($"Bad response {response.StatusCode}");
                    }

                    string responseData = response.Content.ReadAsStringAsync().Result;

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
        ///     Download and return the data for categories and games.
        /// </summary>
        /// <returns></returns>
        private static CategoriesData GetCategories()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(Urls.CategoriesData).Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception($"Bad response {response.StatusCode}");
                    }

                    string responseData = response.Content.ReadAsStringAsync().Result;

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
        ///     Determines a valid json response
        /// </summary>
        /// <param name="data">Json data to validate</param>
        /// <returns>Whether text is valid json format</returns>
        private static bool IsValidJson(string data)
        {
            try
            {
                JToken unused = JToken.Parse(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}