using ArisenMods.Database;
using ArisenMods.Extensions;
using ArisenMods.Forms.Windows;
using System.Collections.Generic;
using System.Linq;

namespace ArisenMods.Models.Database
{
    public class PatchesData
    {
        /// <summary>
        /// Get the mods from the database.
        /// </summary>
        public List<PatchItemData> Patches { get; set; }

        /// <summary>
        /// Get all of the mods matching the specified filters.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="modId"></param>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="creator"></param>
        /// <param name="favorites"></param>
        /// <returns></returns>
        //public List<ModItemData> GetPluginItems(string categoryId, string name, string version, string creator, bool favorites = false)
        //{
        //    if (favorites)
        //    {
        //        return Mods.Where(x =>
        //            MainWindow.Settings.FavoriteMods.Exists(y => y.ModId == x.Id) &&
        //            (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
        //            x.Name.ContainsIgnoreCase(name) &&
        //            x.Versions.ToArray().AnyContainsIgnoreCase(version) &&
        //            x.Creators.ToArray().AnyContainsIgnoreCase(creator))
        //            .ToList();
        //    }
        //    else
        //    {
        //        return Mods.Where(x =>
        //            (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
        //            x.Name.ContainsIgnoreCase(name) &&
        //            x.Versions.ToArray().AnyContainsIgnoreCase(version) &&
        //            x.Creators.ToArray().AnyContainsIgnoreCase(creator))
        //            .ToList();
        //    }
        //}

        /// <summary>
        /// Get the <see cref="ModItemData" /> matching the specified <see cref="ModItemData.Id" />.
        /// </summary>
        /// <param name="id">
        /// <see cref="ModItemData.Id" />
        /// </param>
        /// <returns> Mod details for the <see cref="ModItemData.Id" /> </returns>
        //public ModItemData GetModById(Platform platform, int id)
        //{
        //    return Mods.FirstOrDefault(modItem => modItem.GetPlatform() == platform && modItem.Id.Equals(id));
        //}
    }
}