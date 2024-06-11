namespace NorthNomads.GOL.Landscape.Flowers.Genetics
{
    /// <summary>
    /// Represents an interface for the soil genes.
    /// </summary>
    /// <remarks>
    /// Soil genes adapt flowers for the different soil types to improve their efficiency on different soil types.
    /// </remarks>
    public interface ISoilGene : IGene
    {
        /// <summary>
        /// Gets the soil type that improves flower adaptivity by <see langword="100 percent"/>.
        /// </summary>
        SoilType TargetSoilType { get; }
    }
}