using ArisenStudio.Extensions;
using System;
using System.Collections.Generic;

namespace ArisenStudio.Models.Database
{
    public class TrainerGameItemData
    {
        public string TitleId { get; set; }

        public string Description { get; set; }

        public List<TrainerItem> Trainers { get; set; }

        public Platform GetPlatform()
        {
            return Platform.XBOX360;
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
            return Type.ContainsIgnoreCase("aurora") ? TrainerType.Aurora : TrainerType.Xbdm;
        }
    }

    public enum TrainerType
    {
        Aurora,
        Xbdm,
    }
}