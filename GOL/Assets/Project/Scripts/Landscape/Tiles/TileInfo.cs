using GOL.Landscape.Flowers;
using GOL.Landscape.Flowers.Genetics;
using GOL.PlayerScripts;
using System.Collections.Generic;
using UnityEngine;

namespace GOL.Landscape.Tiles
{
    /// <summary>
    /// Represents a description for the tile object.
    /// </summary>
    public class TileInfo : ITile
    {
        private int _potsCount;

        public TileInfo(SoilType soilType, TileState tileState, int lockLevel, int pollutionLevel, SlotsProbability[] slotsProbability)
        {
            SoilType = soilType;
            TileState = tileState;
            LockLevel = lockLevel;
            PollutionLevel = pollutionLevel;
            if (TileState != TileState.Common)
            {
                _potsCount = 0;
                LockLevel = PollutionLevel = 0;
            }
            else
            {
                _potsCount = GetFreeSlotsQuantity(slotsProbability);
            }
            Pots = InstantiateFlowerPots();

            int GetFreeSlotsQuantity(SlotsProbability[] slotsProbability)
            {
                var random = Random.Range(0f, 1f);
                foreach (SlotsProbability probability in slotsProbability)
                {
                    if (random < probability.Probability)
                        return probability.SlotsAmount;
                }
                return slotsProbability[^1].SlotsAmount;
            }

            IFlowerPot[] InstantiateFlowerPots()
            {
                var pots = new IFlowerPot[_potsCount];
                for (int i = 0; i < _potsCount; i++)
                    pots[i] = new FlowerPotInfo();
                return pots;
            }
        }

        public bool IsStable => PollutionLevel <= 0;

        public bool IsLocked => LockLevel > 0;

        public TileState TileState { get; }

        public SoilType SoilType { get; }

        public int LockLevel { get; set; }

        public int PollutionLevel { get; set; }

        public IReadOnlyList<IFlowerPot> Pots { get; }

        public void OnPlayerEnter(PlayerInventory player)
        {
            foreach (var pot in Pots)
            {
                pot.OnPlayerEnter(player);
            }
        }

        public void OnPlayerLeave(PlayerInventory player)
        {
            foreach (var pot in Pots)
            {
                pot.OnPlayerLeave(player);
            }
        }

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
    }
}