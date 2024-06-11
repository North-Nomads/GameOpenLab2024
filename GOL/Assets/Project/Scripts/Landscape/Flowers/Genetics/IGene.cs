namespace NorthNomads.GOL.Landscape.Flowers.Genetics
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
	}
}