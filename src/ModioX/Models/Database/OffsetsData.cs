using System;
using System.Collections.Generic;
using System.Linq;
using ModioX.Database;
using ModioX.Extensions;

namespace ModioX.Models.Database
{
    public class OffsetsData
    {
        /// <summary>
        /// Get the date/time the database was last updated.
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Get the mods from the database.
        /// </summary>
        public List<ModsOffsets> Mods { get; set; }

        /// <summary>
        /// Gets all of the mods for the specified Console Type, Game Id and Game Type and Category
        /// </summary>
        /// <param name="consoleType"> </param>
        /// <param name="gameId"> </param>
        /// <param name="gameMode"> </param>
        /// <param name="category"> </param>
        /// <returns> </returns>
        public List<ModsOffsets> GetMods(string consoleType, string gameId, string gameMode, string category)
        {
            return Mods.Where(
                x => x.ConsoleType.EqualsIgnoreCase(consoleType)
                && x.GameId.EqualsIgnoreCase(gameId)
                && x.Memory.Any(y => y.GameMode.ContainsIgnoreCase(gameMode))
                && x.Memory.Any(y => y.Category.ContainsIgnoreCase(category))).ToList();

            //return (from mod in Mods
            //        where mod.ConsoleType.EqualsIgnoreCase(consoleType) && mod.GameId.EqualsIgnoreCase(gameId)
            //        from memory in mod.Memory
            //        where memory.GameMode.ContainsIgnoreCase(gameMode) && memory.Category.ContainsIgnoreCase(category)
            //        select mod).ToList();

            //return Mods.Where(x => x.ConsoleType.EqualsIgnoreCase(consoleType)
            //                       & x.GameId.ContainsIgnoreCase(gameId)
            //                       && x.Memory.Any(y => y.GameMode.ContainsIgnoreCase(gameMode))
            //                       && x.Memory.Any(y => y.Category.ContainsIgnoreCase(category))).ToList();
        }

        /// <summary>
        /// Gets all of the mods for the specified Console Type, Game Id and Game Type
        /// and type
        /// </summary>
        /// <param name="consoleType"> </param>
        /// <param name="gameId"> </param>
        /// <param name="gameType"> </param>
        /// <param name="name"> </param>
        /// <returns> </returns>
        public Memory GetMemoryByName(string consoleType, string gameId, string gameMode, string name)
        {
            //return Mods.Where(
            //    x => x.ConsoleType.EqualsIgnoreCase(consoleType)
            //    && x.GameId.EqualsIgnoreCase(gameId)
            //    && x.Memory.All(y => y.GameType.ContainsIgnoreCase(gameType))
            //    && x.Memory.All(y => y.Name.ContainsIgnoreCase(name))).ToList();
            //&& x.Memory.All(y => y.Category.ContainsIgnoreCase(category))).ToList();

            foreach (var memory in
            from mod in Mods
            where mod.ConsoleType.EqualsIgnoreCase(consoleType) && mod.GameId.EqualsIgnoreCase(gameId)
            from memory in mod.Memory
            where memory.Name.EqualsIgnoreCase(name) && memory.GameMode.EqualsIgnoreCase(gameMode)
            select memory)
            {
                return memory;
            }

            return null;
        }

        /// <summary>
        /// Get the <see cref="ModsOffsets" /> matching the specified <see cref="ModsOffsets.Id" />.
        /// </summary>
        /// <param name="id"> <see cref="ModsOffsets.Id" /> </param>
        /// <returns> Mod details for the <see cref="ModsOffsets.Id" /> </returns>
        public ModsOffsets GetModsById(int id)
        {
            return Mods.FirstOrDefault(offset => offset.Id.Equals(id));
        }

        /// <summary>
        /// Get all the <see cref="ModsOffsets" /> matching the specified <see cref="ModsOffsets.ConsoleType" />.
        /// </summary>
        /// <returns> </returns>
        public List<ModsOffsets> GetModsByConsoleType(string consoleType)
        {
            return Mods.Where(x => x.ConsoleType.EqualsIgnoreCase(consoleType)).ToList();
        }

        /// <summary>
        /// Get all the <see cref="ModsOffsets" /> matching the specified <see cref="ModsOffsets.ConsoleType" />.
        /// </summary>
        /// <returns> </returns>
        public List<ModsOffsets> GetModsByConsoleTypeAndGameId(string consoleType, string gameId)
        {
            return Mods.Where(x => x.ConsoleType.EqualsIgnoreCase(consoleType) && x.GameId.EqualsIgnoreCase(gameId)).ToList();
        }

        /// <summary>
        /// Get all the <see cref="ModsOffsets" /> matching the specified <see cref="ModsOffsets.ConsoleType" />.
        /// </summary>
        /// <returns> </returns>
        public ModsOffsets GetGameInfo(string gameId)
        {
            return Mods.FirstOrDefault(x => x.GameId.EqualsIgnoreCase(gameId));
        }

        /// <summary>
        /// Gets all of the mods for the specified Console Type, Game Id and Game Type
        /// and type
        /// </summary>
        /// <param name="consoleType"> </param>
        /// <param name="gameId"> </param>
        /// <param name="gameId"> </param>
        /// <param name="gameType"> </param>
        /// <returns> </returns>
        public List<Offset> GetOffsetsByModName(string consoleType, string gameId, string modName, string gameMode)
        {
            foreach (Memory memory in from ModsOffsets mod in Mods
                                   where mod.ConsoleType.EqualsIgnoreCase(consoleType) && mod.GameId.Equals(gameId)
                                   from Memory memory in mod.Memory
                                   where memory.Name.EqualsIgnoreCase(modName) && memory.GameMode.ContainsIgnoreCase(gameMode)
                                   select memory)
            {
                return memory.Offsets;
            }

            return null;
        }

        /// <summary>
        /// Get the total number of offsets.
        /// </summary>
        /// <returns> </returns>
        public int GetTotalMods()
        {
            return Mods.Count();
        }
    }
}