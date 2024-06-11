using NorthNomads.GOL.Landscape.Flowers;
using System;
using System.Collections.Generic;

namespace NorthNomads.GOL.Landscape.Tiles
{
    /// <summary>
    /// Represents a description for the tile object.
    /// </summary>
    public class TileInfo : ITile
    {
        public TileInfo(SoilType soilType, int lockLevel, int pollutionLevel)
        {
            SoilType = soilType;
            LockLevel = lockLevel;
            PollutionLevel = pollutionLevel;
        }

        public bool IsStable => PollutionLevel <= 0;

        public bool IsLocked => LockLevel > 0;

        public SoilType SoilType { get; }

        public int LockLevel { get; }

        public int PollutionLevel { get; }

        public IReadOnlyCollection<IFlower> Flowers { get; } = Array.Empty<IFlower>();

        public void Plant(IFlower flower)
        {
            throw new NotSupportedException("Flowers planting is not supported for the tile descriptions.");
        }

        public void Remove(IFlower flower)
        {
            throw new NotSupportedException("Flowers removal is not supported for the tile descriptions.");
        }
    }
}