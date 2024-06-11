using NorthNomads.GOL.Landscape.Flowers.Genetics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NorthNomads.GOL.Landscape.Flowers
{
    /// <summary>
    /// Represents the flower to plant to the tiles.
    /// </summary>
    public interface IFlower : INameable
    {
        /// <summary>
        /// Gets all the genes stored in this flower instance.
        /// </summary>
        IReadOnlyCollection<IGene> Genes { get; }

        /// <summary>
        /// Checks if the flower can be planted to the given soil type.
        /// </summary>
        /// <param name="soil">The soil type to check.</param>
        /// <returns>A value indicating whether the flower can be planted to the specified soil.</returns>
        bool CanPlant(SoilType soil);

        /// <summary>
        /// Gets the effeciency coefficient for the specified soil type.
        /// </summary>
        /// <param name="soil">The soil type to get the coefficient for.</param>
        /// <returns>A value indicating the coeffieicient of the plant efficiency.</returns>
        float GetPlantCoefficient(SoilType soil);

        /// <summary>
        /// Applies the gene to the current flower instance.
        /// </summary>
        /// <param name="gene">The gene instance to apply.</param>
        void AddGene(IGene gene);
    }
}