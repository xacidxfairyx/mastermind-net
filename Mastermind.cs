using System;

namespace Softklin.Mastermind
{
    /// <summary>
    /// Mastermind class allows you to create players and games
    /// </summary>
    /// <remarks>This class is a factory. You should create objects instances using this class</remarks>
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
        /// <param name="level">The difficulty level of game</param>
        /// <returns>New Mastermind game</returns>
        /// <remarks>The difficulty level cannot be "Custom" with this constructor.</remarks>
        public static MastermindGame createGame(Player p1, Player p2, DifficultyLevel level)
        {
            return new MastermindGame(new Player[] { p1, p2 }, level);
        }

        /// <summary>
        /// Creates a new Mastermind game, with custom configuration
        /// </summary>
        /// <param name="p1">Player 1</param>
        /// <param name="p2">PLayer 2</param>
        /// <param name="rows">The number of rows in the board</param>
        /// <param name="pegs">The number of colored pegs per row</param>
        /// <returns>New Mastermind game, with custom configuration</returns>
        public static MastermindGame createCustomGame(Player p1, Player p2, int rows, int pegs)
        {
            return new MastermindGame(new Player[] { p1, p2 }, rows, pegs);
        }
    }
}
