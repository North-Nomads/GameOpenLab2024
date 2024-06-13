using GOL.PlayerScripts;

namespace GOL.Landscape
{
	public interface INotifyPlayerEnter 
	{
        /// <summary>
        /// Handles callback when the player enters the current tile.
        /// </summary>
        /// <param name="player">Player who enters the tile.</param>
        void OnPlayerEnter(PlayerInventory player);

        /// <summary>
        /// Handles callback when the player leaves the current tile.
        /// </summary>
        /// <param name="player">Player who leaves the tile.</param>
        void OnPlayerLeave(PlayerInventory player);
    }
}