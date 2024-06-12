namespace GOL.Landscape.Flowers.Genetics
{
    /// <summary>
    /// Represents an interface for the antidote genes.
    /// </summary>
    /// <remarks>
    /// Antidote genes helps with pollution clearing.
    /// </remarks>
    public interface IAntidoteGene : IGene
    {
        /// <summary>
        /// Gets the effeciency of pollution removal performed by this gene instance.
        /// </summary>
        float ClearEfficiency { get; }
    }
}