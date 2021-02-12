using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using ModioX.Constants;
using ModioX.Models.Database;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ModioX.Database
{
    public class GitHubData
    {
        /// <summary>
        /// Initialization of the class.
        /// </summary>
        /// <returns> instance of the class. </returns>
        public static async Task<GitHubData> InitializeAsync()
        {
            GitHubData data = new GitHubData
            {
                CategoriesData = await GetCategoriesAsync(),
                ModsPS3 = await GetModsPS3Async(),
                ModsXBOX = await GetModsXBOXAsync()
            };

            data.CategoriesData.Categories = data.CategoriesData.Categories.OrderBy(o => o.Title).ToList();
            return data;
        }

        /// <summary>
        /// Contains the categories from the database.
        /// </summary>
        public CategoriesData CategoriesData { get; private set; }

        /// <summary>
        /// Contains the mods from the PS3 database.
        /// </summary>
        public ModsData ModsPS3 { get; private set; }

        /// <summary>
        /// Contains the mods from the Xbox database.
        /// </summary>
        public ModsData ModsXBOX { get; private set; }

        /// <summary>
        /// Download and return the data for categories and games.
        /// </summary>
        /// <returns> CategoriesData </returns>
        /// <exception cref="HttpException"> Thrown when getting a Bad Response </exception>
        /// <exception cref="JsonSerializationException">
        /// Thrown when failing to deserialize the json data.
        /// </exception>
        private static async Task<CategoriesData> GetCategoriesAsync()
        {
            using HttpClient client = new HttpClient();
            using Stream stream = await client.GetStreamAsync(Urls.CategoriesData).ConfigureAwait(true);
            using StreamReader streamReader = new StreamReader(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<CategoriesData>(jsonReader);
        }

        /// <summary>
        /// Download and return the data for mods.
        /// </summary>
        /// <returns> </returns>
        /// <exception cref="Exception"> </exception>
        private static async Task<ModsData> GetModsPS3Async()
        {
            using HttpClient client = new HttpClient();
            using Stream stream = await client.GetStreamAsync(Urls.ModsDataPS3).ConfigureAwait(true);
            using StreamReader streamReader = new StreamReader(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<ModsData>(jsonReader);
        }

        /// <summary>
        /// Download and return the data for mods.
        /// </summary>
        /// <returns> </returns>
        /// <exception cref="Exception"> </exception>
        private static async Task<ModsData> GetModsXBOXAsync()
        {
            using HttpClient client = new HttpClient();
            using Stream stream = await client.GetStreamAsync(Urls.ModsDataXBOX).ConfigureAwait(true);
            using StreamReader streamReader = new StreamReader(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<ModsData>(jsonReader);
        }
    }
}
