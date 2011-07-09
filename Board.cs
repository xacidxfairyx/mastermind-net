using System;

namespace Softklin.Mastermind
{
    /// <summary>
    /// Represents a board in the Mastermind game
    /// </summary>
    class Board
    {
        #region Properties
        /// <summary>
        /// Get the number of pegs per row
        /// </summary>
        public int NumberPegs { get; private set; }

        /// <summary>
        /// Get the number of rows in the board
        /// </summary>
        public int NumberRows { get; private set; }
        #endregion

        // TODO Game representation still needed!

        /// <summary>
        /// Creates a new board, according to the difficulty level
        /// </summary>
        /// <param name="level">Difficulty level</param>
        /// <remarks>Don't use this constructor to create a custom game</remarks>
        internal Board(DifficultyLevel level)
	    {
            switch (level)
            {
                case DifficultyLevel.Level1:
                    this.NumberPegs = 4;
                    this.NumberRows = 8;
                    break;

                case DifficultyLevel.Level2:
                    this.NumberPegs = 5;
                    this.NumberRows = 10;
                    break;

                case DifficultyLevel.Level3:
                    this.NumberPegs = 6;
                    this.NumberRows = 12;
                    break;

                default:
                    break;
            }
	    }

        /// <summary>
        /// Creates a new board using custom settings
        /// </summary>
        /// <param name="rows">Number of rows of board</param>
        /// <param name="pegs">Number of pegs per row</param>
        internal Board(int rows, int pegs)
        {
            if (rows <= 0 || pegs <= 0)
                throw new MastermindBoardException("Rows and pegs must be positive non-zero values");

            this.NumberPegs = pegs;
            this.NumberRows = rows;
        }
    }


    #region Enumerators
    /// <summary>
    /// Colors avaliable for pegs
    /// </summary>
    enum PegColor
    {
        /// <summary>
        /// Red peg
        /// </summary>
        Red,

        /// <summary>
        /// Green peg
        /// </summary>
        Green,

        /// <summary>
        /// Blue peg
        /// </summary>
        Blue,

        /// <summary>
        /// Yellow peg
        /// </summary>
        Yellow,

        /// <summary>
        /// Pink peg
        /// </summary>
        Pink,

        /// <summary>
        /// Cyan peg
        /// </summary>
        Cyan,

        /// <summary>
        /// Light brown peg
        /// </summary>
        LightBrown,

        /// <summary>
        /// Purple peg
        /// </summary>
        Purple
    }
    #endregion


    /// <summary>
    /// Exceptions related with the Board Class
    /// </summary>
    [Serializable]
    public class MastermindBoardException : Exception
    {
        public MastermindBoardException() { }
        public MastermindBoardException(string message) : base(message) { }
        public MastermindBoardException(string message, Exception inner) : base(message, inner) { }
        protected MastermindBoardException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
