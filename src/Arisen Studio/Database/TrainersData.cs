using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArisenStudio.Database
{
    public class TrainersData
    {
        /// <summary>
        /// Get the mods from the database.
        /// </summary>
        public List<TrainerGameItem> Library { get; set; }

        /// <summary>
        /// Get all of the mods matching the specified filters.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="name"></param>
        /// <param name="region"></param>
        /// <param name="version"></param>
        /// <param name="creator"></param>
        /// <returns></returns>
        //public List<TrainersGameData> GetGameSaveItems(Platform platform, string categoryId, string name, string region, string version)
        //{
        //    return categoryId switch
        //    {
        //        "fvrt" => Library.Where(x =>
        //        //consoleProfile.FavoriteIds.Any(y => y == x.Id) &&
        //        x.Name.ContainsIgnoreCase(name) &&
        //        x.Region.ContainsIgnoreCase(region) &&
        //        x.Version.ContainsIgnoreCase(version))
        //        .ToList(),
        //        _ => Library.Where(x =>
        //            x.GetPlatform() == platform &&
        //            (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
        //            x.Name.ContainsIgnoreCase(name) &&
        //            x.Region.ContainsIgnoreCase(region) &&
        //            x.Version.ContainsIgnoreCase(version))
        //        .ToList()
        //    };
        //}

        /// <summary>
        /// Get all of the mods matching the specified filters.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="name"></param>
        /// <param name="region"></param>
        /// <param name="version"></param>
        /// <param name="creator"></param>
        /// <returns></returns>
        //public List<TrainersGameData> GetGameSaveItems(Platform platform, string categoryId, string name, string region, string version)
        //{
        //    return categoryId switch
        //    {
        //        "fvrt" => Library.Where(x =>
        //        //consoleProfile.FavoriteIds.Any(y => y == x.Id) &&
        //        x.Name.ContainsIgnoreCase(name) &&
        //        x.Region.ContainsIgnoreCase(region) &&
        //        x.Version.ContainsIgnoreCase(version))
        //        .ToList(),
        //        _ => Library.Where(x =>
        //            x.GetPlatform() == platform &&
        //            (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
        //            x.Name.ContainsIgnoreCase(name) &&
        //            x.Region.ContainsIgnoreCase(region) &&
        //            x.Version.ContainsIgnoreCase(version))
        //        .ToList()
        //    };
        //}

        /// <summary>
        /// Get all the <see cref="ModItemData" /> matching the specified <see cref="Category.Id" />.
        /// </summary>
        /// <returns> </returns>
        public List<TrainerGameItem> GetItemsByTitleId(string titleId)
        {
            return Library.Where(x => x.TitleId.EqualsIgnoreCase(titleId)).ToList();
        }

        /// <summary>
        /// Get the <see cref="ModItemData" /> matching the specified <see cref="ModItemData.Id" />.
        /// </summary>
        /// <param name="id"> <see cref="ModItemData.Id" /> </param>
        /// <returns> Mod details for the <see cref="ModItemData.Id" /> </returns>
        public TrainerItem GetTrainerByUrl(string url)
        {
            foreach (TrainerItem trainer in from item in Library
                                            from trainer in item.Trainers
                                            where trainer.Url == url
                                            select trainer)
            {
                return trainer;
            }

            return null;
        }
    }

    public class TrainerItem
    {
        public DateTime LastUpdated { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Url { get; set; }

        public string[] InstallPaths { get; set; }

        public new TrainerType GetType()
        {
            if (Type.EqualsIgnoreCase("aurora"))
            {
                return TrainerType.Aurora;
            }
            else
            {
                return TrainerType.Xbdm;
            }
        }
    }
}

