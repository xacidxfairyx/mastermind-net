namespace Softklin.Mastermind
{
    /// <summary>
    /// Mastermind class allows you to create players and games
    /// </summary>
    /// <remarks>This class is a factory. You should create objects instances using this class</remarks>
    public class Mastermind
    {
        /// <summary>
        /// Creates multiple pegs, given some colors
        /// </summary>
        /// <param name="colors">Colors to add</param>
        /// <returns>The colored pegs</returns>
        /// <remarks>
        /// The order of colors is kept when creating the pegs
        /// It is allowed to create rows with the same color in different positions
        /// </remarks>
        public static ColoredPegRow createPegRow(PegColor[] colors)
        {
            return new ColoredPegRow(colors);
        }

        /// <summary>
        /// Create a combination with multiple pegs, given some colors
        /// </summary>
        /// <param name="colors">Colors to add</param>
        /// <returns>Combination with colored pegs</returns>
        /// <remarks>This function is an alias to <see cref="createPegRow"/></remarks>
        public static ColoredPegRow createCombination(PegColor[] colors)
        {
            return createPegRow(colors);
        }

        /// <summary>
        /// Creates a new Mastermind game
        /// </summary>
        /// <param name="humanNickname">The human player</param>
        /// <param name="computerNickname">The computer player</param>
        /// <param name="level">The difficulty level of game</param>
        /// <returns>New Mastermind game</returns>
        /// <remarks>
        /// The difficulty level cannot be "Custom" with this constructor
        /// The players can't have se same nickname
        /// </remarks>
        public static MastermindGame createGame(string humanNickname, string computerNickname, DifficultyLevel level)
        {
            Player human = new Player(humanNickname);
            Player computer = new Player(computerNickname);
            return new MastermindGame(new Player[] { human, computer }, level);
        }

        /// <summary>
        /// Creates a new Mastermind game, with custom configuration
        /// </summary>
        /// <param name="humanNickname">The human player</param>
        /// <param name="computerNickname">The computer player</param>
        /// <param name="rows">The number of rows in the board</param>
        /// <param name="pegs">The number of colored pegs per row</param>
        /// <returns>
        /// New Mastermind game, with custom configuration
        /// The players can't have se same nickname
        /// </returns>
        public static MastermindGame createCustomGame(string humanNickname, string computerNickname, int rows, int pegs)
        {
            Player human = new Player(humanNickname);
            Player computer = new Player(computerNickname);
            return new MastermindGame(new Player[] { human, computer }, rows, pegs);
        }
    }
}
