namespace GOL.Landscape.Generation
{
	/// <summary>
	/// Represents an utility class to provide options for the world generation process.
	/// </summary>
	public class GeneratorOptions
	{
		/// <summary>
		/// Gets the world width to generate tilemap.
		/// </summary>
		public int TargetWidth { get; set; }

		/// <summary>
		/// Gets the world height to generate tilemap.
		/// </summary>
		public int TargetHeight { get; set; }

		/// <summary>
		/// Gets the generic coefficient for the landscape completion difficulty.
		/// </summary>
		public float DifficultyMultiplier { get; set; }

		/// <summary>
		/// Gets the seed for the random number generator to generate the tile map.
		/// </summary>
		public int Seed { get; set; }

		/// <summary>
		/// Gets the scale of the noise to generate.
		/// </summary>
		public float NoiseScale { get; set; }

		/// <summary>
		/// Gets the array of obstacles to fill the map with.
		/// </summary>
		public PlaceableObstacle[] Obstacles { get; set; }
	}
}