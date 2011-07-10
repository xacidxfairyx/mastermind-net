namespace Softklin.Mastermind
{
    /// <summary>
    /// Represents a Mastermind game 
    /// </summary>
    public class MastermindGame
    {
        #region Properties
        /// <summary>
        /// Gets the current players in the game
        /// </summary>
        public Player[] Players { get; private set; }

        /// <summary>
        /// Gets the current player
        /// </summary>
        public Player CurrentPlayer { get; private set; }

        /// <summary>
        /// Gets the current game status
        /// </summary>
        public GameStatus GameStatus { get; private set; }

        /// <summary>
        /// Get the actual game difficulty level
        /// </summary>
        public DifficultyLevel Level { get; private set; }
        #endregion


        #region Atributes
        private Board theBoard;
        #endregion


        /// <summary>
        /// Creates a Mastermind game with basic atributes
        /// </summary>
        /// <param name="players">The players</param>
        private MastermindGame(Player[] players)
        {
            if (players.Length != 2)
                throw new MastermindGameException("To create a game, there are needed exactly two players");

            if (players[0] == null)
                throw new MastermindGameException("Player 1 cannot be null");

            if (players[1] == null)
                throw new MastermindGameException("Player 2 cannot be null");

            if (players[0].Equals(players[1]))
                throw new MastermindGameException("Players can't be equal");

            this.Players = players;
            this.GameStatus = GameStatus.Setup;
        }

        /// <summary>
        /// Creates a new Mastermind game, with a predefined difficulty level
        /// </summary>
        /// <param name="players">The players</param>
        /// <param name="difficulty">he diffiulty level</param>
        /// <remarks>If you pretend to create a custom game, please use the other constructor</remarks>
        internal MastermindGame(Player[] players, DifficultyLevel difficulty) : this(players)
	    {
            if (difficulty == DifficultyLevel.Custom)
                throw new MastermindGameException("A custom game must have configuration options");

            this.Level = difficulty;
            this.theBoard = new Board(difficulty);
	    }

        /// <summary>
        /// Creates a new Mastermind game, with custom configuration
        /// </summary>
        /// <param name="players">The players</param>
        /// <param name="rows">The number of rows in the board</param>
        /// <param name="pegs">The number of colored pegs per row</param>
        /// <remarks>This constructor creates a game with custom configuration</remarks>
        internal MastermindGame(Player[] players, int rows, int pegs) : this(players)
        {
            this.Level = DifficultyLevel.Custom;
            this.theBoard = new Board(rows, pegs);
        }

        /// <summary>
        /// Creates the combination to be broke by human player
        /// </summary>
        /// <param name="combination">An array containing the combination</param>
        /// <remarks>Once set, the combination cannot be changed</remarks>
        public void setup(ColoredPegRow combination)
        {
            if (this.GameStatus != GameStatus.Setup)
                throw new MastermindGameException("Setup can only be done during setup game status");

            this.theBoard.setup(combination);
            this.GameStatus = GameStatus.Ready;
        }

        /*
        /// <summary>
        /// Starts the game, using Random class to schoose the first player
        /// </summary>
        /// <returns>Player who will start the game</returns>
        /// <remarks>This method uses the Random class to choose the fisrt player</remarks>
        public Player startGame()
        {
            Random r = new Random();
            int decision = r.Next() % 2;
            this.CurrentPlayer = this.Players[decision];

            return this.CurrentPlayer;
        }

        /// <summary>
        /// Starts the game, using a custom random provider
        /// </summary>
        /// <param name="randomProvider">The random source to use</param>
        /// <returns>Player who will start the game</returns>
        /// <remarks>See https://code.google.com/p/mastermind-net/wiki/IRandomProvider for details</remarks>
        public Player startGame(IRandomProvider randomProvider)
        {
            int decision = randomProvider.generateRandom() % 2;
            this.CurrentPlayer = this.Players[decision];

            return this.CurrentPlayer;
        }

        /// <summary>
        /// Starts the game, defining one of the players
        /// </summary>
        /// <param name="player">The player who wil play first</param>
        public void startGame(Player player)
        {
            if (!this.Players[0].Equals(player) && !this.Players[1].Equals(player))
                throw new MastermindGameException("The player doesn't exists in this game");

            this.CurrentPlayer = player;
        }*/

        /// <summary>
        /// Starts the game
        /// </summary>
        public void startGame()
        {
            if (this.GameStatus != GameStatus.Ready)
                throw new MastermindGameException("To start the game, setup is needed");

            this.GameStatus = GameStatus.Running;
        }

        /// <summary>
        /// Try to guess a row of the board
        /// </summary>
        /// <param name="row">Row with pegs to break the combination</param>
        /// <returns>Result stats of the move</returns>
        public MoveResult doMove(ColoredPegRow row)
        {
            if (this.GameStatus != GameStatus.Running)
                throw new MastermindGameException("The game is not running");

            return this.theBoard.doMove(row);
        }
    }


    #region Enumerators
    /// <summary>
    /// Represents the current game status
    /// </summary>
    public enum GameStatus
    {
        /// <summary>
        /// The current game didn't start yet, the pegs need to be set up
        /// </summary>
        Setup,

        /// <summary>
        /// The current game didn't start yet, the pegs are posicionated
        /// </summary>
        Ready,

        /// <summary>
        /// The game is running, no winner or loser are known
        /// </summary>
        Running,

        /// <summary>
        /// The game endend, and the score card was updated
        /// </summary>
        Ended
    }


    /// <summary>
    /// Represents the game difficulty level
    /// </summary>
    public enum DifficultyLevel
    {
        /// <summary>
        /// Easy difficulty, with 4 pegs and 8 rows
        /// </summary>
        Level1,

        /// <summary>
        /// Medium difficulty, with 5 pegs and 10 rows
        /// </summary>
        Level2,

        /// <summary>
        /// Hard difficulty, with 6 pegs and 12 rows
        /// </summary>
        Level3,

        /// <summary>
        /// Custom number of pegs and rows
        /// </summary>
        Custom
    }
    #endregion
}
