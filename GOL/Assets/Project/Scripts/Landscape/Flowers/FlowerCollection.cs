using System;
using System.Collections.ObjectModel;

namespace GOL.Landscape.Flowers
{
	/// <summary>
	/// Represents a generialized collection of <see cref="IFlower"/> objects.
	/// </summary>
	[Serializable]
	public class FlowerCollection : Collection<IFlower>
	{
    }
}