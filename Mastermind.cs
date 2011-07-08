using System;

namespace Softklin.MasterMind
{
    /// <summary>
    /// MasterMind class allows you to create players and games
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

        public static MastermindGame createGame(Player p1, Player p2)
        {
            return null;
        }
    }
}
