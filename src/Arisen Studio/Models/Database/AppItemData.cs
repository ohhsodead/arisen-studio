using System.Collections.Generic;
using System.Linq;
using System;
using ArisenStudio.Extensions;

namespace ArisenStudio.Models.Database
{
    public partial class AppItemData
    {        
        public string Platform { get; set; }
        
        public int Id { get; set; }
        
        public string CategoryId { get; set; }
        
        public string Name { get; set; }
        
        public string CreatedBy { get; set; } = "Unknown";
        
        public string SubmittedBy { get; set; }
        
        public string Version { get; set; }
        
        public string PlayableVersion { get; set; }
        
        public string ContentId { get; set; }
        
        public string TitleId { get; set; }
        
        public string Description { get; set; }
        
        public List<AppItemFile> DownloadFiles { get; set; }

        public IEnumerable<string> Creators => CreatedBy.Split(['/', '&']).Select(x => x.Trim());
        
        public List<string> Versions => Version.Split('/').ToList();
        
        public List<string> FirmwareVersions => PlayableVersion.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

        public Platform GetPlatform()
        {
            return ArisenStudio.Platform.PS4;
        }

        public string GetVersion(AppItemFile appFile)
        {
            return appFile.Version.IsNullOrEmpty() ? string.Empty : appFile.Version;
        }

        /// <summary>
        /// Get the category data.
        /// </summary>
        /// <param name="categoriesData"> </param>
        /// <returns> </returns>
        public Category GetCategory(CategoriesData categoriesData)
        {
            return categoriesData.Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(CategoryId)) ?? new Category() { Title = "<Can't Find Name>" };
        }

        /// <summary>
        /// Get the category type.
        /// </summary>
        /// <param name="categoriesData"> </param>
        /// <returns> </returns>
        public CategoryType GetCategoryType(CategoriesData categoriesData)
        {
            return categoriesData.Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(CategoryId))?.CategoryType ?? CategoryType.Game;
        }

        /// <summary>
        /// Get the category name.
        /// </summary>
        /// <param name="categoriesData"> </param>
        /// <returns> </returns>
        public string GetCategoryName(CategoriesData categoriesData)
        {
            return categoriesData.Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(CategoryId))?.Title ?? "<Can't Find Name>";
        }
    }
}