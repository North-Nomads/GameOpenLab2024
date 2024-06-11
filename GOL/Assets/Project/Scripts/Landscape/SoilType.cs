using UnityEngine;

namespace NorthNomads.GOL.Landscape
{
	/// <summary>
	/// Represents the information about the <see cref="ITile"/> soil.
	/// </summary>
	public class SoilType : ScriptableObject
	{
		[SerializeField] private string type;

		/// <summary>
		/// Gets the current soil type name.
		/// </summary>
		public string Type => type;
	}
}