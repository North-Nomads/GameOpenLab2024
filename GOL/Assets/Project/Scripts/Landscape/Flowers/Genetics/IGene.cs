namespace GOL.Landscape.Flowers.Genetics
{
	/// <summary>
	/// Represents an interface for the flower modification genes.
	/// </summary>
	public interface IGene : INameable
	{
		/// <summary>
		/// Handles gene application process.
		/// </summary>
		/// <param name="target">Target flower to apply gene to.</param>
		void OnApply(IFlower target);

		/// <summary>
		/// Handles flower plant.
		/// </summary>
		/// <param name="target">Target flower to apply gene effect.</param>
		/// <param name="pot">Target pot to plant the flower to.</param>
		/// <param name="effeciency">Effeciency coefficient for the plant.</param>
        void OnFlowerPlant(IFlower target, IFlowerPot pot, float effeciency);

        /// <summary>
        /// Handles flower removal.
        /// </summary>
        /// <param name="target">Target flower to apply gene effect.</param>
        /// <param name="pot">Target pot to remove the flower from.</param>
        /// <param name="effeciency">Effeciency coefficient for the plant.</param>
        void OnFlowerRemove(IFlower target, IFlowerPot pot, float effeciency);
    }
}