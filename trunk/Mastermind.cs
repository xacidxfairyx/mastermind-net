using System;

namespace Softklin.Mastermind
{
    /// <summary>
    /// Mastermind class allows you to create players and games
    /// </summary>
    /// <remarks>This class is a factory. You should create object instance using this class</remarks>
    class Mastermind
    {
        /// <summary>
        /// Creates a new player
        /// </summary>
        /// <param name="nickname"></param>
        /// <returns></returns>
        public static Player createPlayer(string nickname)
        {
            return new Player(nickname);
        }

        /// <summary>
        /// Creates a new Mastermind game
        /// </summary>
        /// <param name="p1">PLayer 1</param>
        /// <param name="p2">PLayer 2</param>
        /// <returns>New Mastermind game</returns>
        /// <remarks>The order of players have no meaning, because the first player will be choosen when the game starts</remarks>
        public static MastermindGame createGame(Player p1, Player p2)
        {
            return null;
        }
    }
}
