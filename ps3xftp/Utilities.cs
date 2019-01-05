using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using ps3xftp.Extensions;
using System;
using System.ComponentModel;
using System.Net;
using System.Net.Http;
using System.Reflection;

namespace ps3xftp
{
    internal static class Utilities
    {
        /// <summary>
        /// Web address link pointing to the project repo hosted on GitHub
        /// </summary>
        internal const string URL_GITUBPROJECT = "https://github.com/HerbL27/ps3xftp/";

        /// <summary>
        /// Web address link pointing to the database file containing the mods data
        /// </summary>
        internal const string URL_MODSDATA = "https://www.dropbox.com/s/428l3axwg1h68ch/database.json?raw=true";

        /// <summary>
        /// Gets the game details database file
        /// </summary>
        /// <returns></returns>
        internal static Models.GamesData GetGameData()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(URL_GAMEDATA).Result;

                if (response.StatusCode != HttpStatusCode.OK) throw new Exception($"Bad response {response.StatusCode}");

                var responseData = response.Content.ReadAsStringAsync().Result;

                if (Utilities.ValidResponse(responseData))
                    return JsonConvert.DeserializeObject<Models.GamesData>(responseData);

                dynamic data = JsonConvert.DeserializeObject(responseData);

                throw new Exception(data.data.message.ToString());
            }
        }

        /// <summary>
        /// Web address link pointing to the database file containing the game data
        /// </summary>
        internal const string URL_GAMEDATA = "https://www.dropbox.com/s/98bp8y8ii1o7y64/gamedata.json?raw=true";

        internal static Models.ModsData GetModsData()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(URL_MODSDATA).Result;

                if (response.StatusCode != HttpStatusCode.OK) throw new Exception($"Bad response {response.StatusCode}");

                var responseData = response.Content.ReadAsStringAsync().Result;

                if (Utilities.ValidResponse(responseData))
                    return JsonConvert.DeserializeObject<Models.ModsData>(responseData);

                dynamic data = JsonConvert.DeserializeObject(responseData);

                throw new Exception(data.data.message.ToString());
            }
        }

        /// <summary>
        /// Uploads the specified local file to the appropriate location on the console
        /// </summary>
        /// <param name="ps3Address">PS3 IP address</param>
        /// <param name="localFile">Path of the local file</param>
        /// <param name="consoleFile">Path of the uploading file directory/param>
        internal static void FileToPS3(string ps3Address, string localFile, string consoleFile)
        {
            using (var PS3 = new PS3FTP(ps3Address))
            {
                if (!PS3.IsConnected)
                    throw new Exception("Failed to connect to console");

                string fileName = consoleFile.Contains("/") ? consoleFile.Substring(consoleFile.LastIndexOf('/')).Replace("/", "").Replace("//", "") : consoleFile;
                string dirPath = consoleFile.Contains("/") ? consoleFile.Substring(0, consoleFile.LastIndexOf('/')) + '/' : "dev_hdd0/";
                PS3.SetCurrentDirectory(dirPath);
                PS3.PutFile(localFile, fileName);
            }
        }

        /// <summary>
        /// Gets the game data matching the prefix
        /// </summary>
        /// <param name="gamePrefix">Prefix of the game</param>
        /// <returns>Game information</returns>
        internal static Models.GamesData.Game GetGameByPrefix(string gamePrefix)
        {
            foreach (var game in Ps3xftp.GamesData.Games)
                if (game.Prefix == gamePrefix)
                    return game;

            return new Models.GamesData.Game() { };
        }

        /// <summary>
        /// Gets the game data matching the title
        /// </summary>
        /// <param name="gameTitle">Title of the game</param>
        /// <returns>Game information</returns>
        internal static Models.GamesData.Game GetGameByTitle(string gameTitle)
        {
            foreach (var game in Ps3xftp.GamesData.Games)
                if (game.Title == gameTitle)
                    return game;

            return new Models.GamesData.Game() { };
        }

        /// <summary>
        /// Determines a valid json response
        /// </summary>
        /// <param name="data">Json data</param>
        /// <returns>True/false if valid</returns>
        internal static bool ValidResponse(string data)
        {
            string validator = @"{
			  'type': 'object',
			  'required': true,
			  'properties': {
				'status': {
					'type': 'string',
					'required': true
				},
				'data': {
				  'type': 'object',
				  'required': true,
				  'properties': {
					'type': {
						'type': 'string',
						'required': true
					},
					'message': {
						'type': 'string',
						'required': true
					}
				  }
				}
			  }
			}";

            //Hack: Just pull in the new library at some point!
#pragma warning disable 0618
            var schema = JsonSchema.Parse(validator);
            var obj = JObject.Parse(data);
            var ret = obj.IsValid(schema);
            return !obj.IsValid(schema);
#pragma warning restore 0618
        }

        internal static string GetDescription(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attr)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
        }
    }
}