using GOL.Landscape.Flowers;
using GOL.Landscape.Flowers.Genetics;
using System;
using System.Collections.Generic;

namespace GOL.Landscape.Tiles
{
    /// <summary>
    /// Represents a description for the tile object.
    /// </summary>
    public class TileInfo : ITile
    {
        const int PotsCount = 4;

        public TileInfo(SoilType soilType, int lockLevel, int pollutionLevel)
        {
            SoilType = soilType;
            LockLevel = lockLevel;
            PollutionLevel = pollutionLevel;
            var pots = new IFlowerPot[PotsCount];
            for (int i = 0; i < PotsCount; i++)
            {
                pots[i] = new FlowerPotInfo();
            }
            Pots = pots;
        }

        public bool IsStable => PollutionLevel <= 0;

        public bool IsLocked => LockLevel > 0;

        public SoilType SoilType { get; }

        public int LockLevel { get; set; }

        public int PollutionLevel { get; set; }

        public IReadOnlyList<IFlowerPot> Pots { get; }

        public void Plant(IFlower flower, IFlowerPot pot)
        {
            if (!flower.CanPlant(SoilType))
                ThrowHelper.ThrowArgumentOutOfRangeException("Can't plant the specified flower.");
            pot.Plant(flower);
            float plantCoefficient = flower.GetPlantCoefficient(SoilType);
            foreach (var gene in flower.Genes)
            {
                switch (gene)
                {
                    case IAntidoteGene antidote:
                        PollutionLevel -= (int)(antidote.ClearEfficiency * plantCoefficient);
                        break;
                        // TODO
                }
            }
        }

        public void RemoveFrom(IFlowerPot pot)
        {
            var flower = pot.Slot as IFlower;
            pot.Remove();
            if (flower != null)
            {
                float plantCoefficient = flower.GetPlantCoefficient(SoilType);
                foreach (var gene in flower.Genes)
                {
                    switch (gene)
                    {
                        case IAntidoteGene antidote:
                            PollutionLevel += (int)(antidote.ClearEfficiency * plantCoefficient);
                            break;
                            // TODO
                    }
                }
            }
        }

        public void Tick()
        {
            foreach (var pot in Pots)
            {
                pot.Tick();
            }
        }
    }
}