namespace NorthNomads.GOL
{
    /// <summary>
    /// Represents an interface for all the objects that can be named.
    /// </summary>
    public interface INameable
    {
        /// <summary>
        /// Gets the name of the current instance.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the localized description of the current instance.
        /// </summary>
        string Description { get; }
    }
}