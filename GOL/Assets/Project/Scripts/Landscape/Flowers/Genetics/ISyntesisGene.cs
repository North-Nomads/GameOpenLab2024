using GOL.PlayerScripts;
using GOL.Resources;

namespace GOL.Landscape.Flowers.Genetics
{
    /// <summary>
    /// Represents an interface for the syntesis genes.
    /// </summary>
    /// <remarks>
    /// Syntesis genes are used for the resources production.
    /// </remarks>
    public interface ISyntesisGene : IGene, INotifyPlayerEnter
    {
        /// <summary>
        /// Gets the resource produced by this gene instance.
        /// </summary>
        IResource SyntesisTarget { get; }
    }
}