namespace Softklin.Mastermind
{
    /// <summary>
    /// Represents a board in the Mastermind game
    /// </summary>
    class Board
    {
        #region Properties
        /// <summary>
        /// Gets the number of pegs per row
        /// </summary>
        internal int NumberPegs { get; private set; }

        /// <summary>
        /// Gets the number of rows in the board
        /// </summary>
        internal int NumberRows { get; private set; }

        /// <summary>
        /// Gets the current peg row
        /// </summary>
        private ColoredPegRow CurrentRow
        {
            get { return this.rows[this.curRow]; }
            set { this.rows[this.curRow] = value; }
        }
        #endregion

        private ColoredPegRow combination;
        private ColoredPegRow[] rows;
        private int curRow;


        /// <summary>
        /// Creates a new board with 0 rows
        /// </summary>
        private Board()
        {
            this.curRow = 0;
        }

        /// <summary>
        /// Creates a new board, according to the difficulty level
        /// </summary>
        /// <param name="level">Difficulty level</param>
        /// <remarks>Don't use this constructor to create a custom game</remarks>
        internal Board(DifficultyLevel level) : this()
        {
            if (level == DifficultyLevel.Custom)
                throw new MastermindBoardException("The difficulty level cannot be cutom");

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

            this.rows = new ColoredPegRow[this.NumberRows];
        }

        /// <summary>
        /// Creates a new board using custom settings
        /// </summary>
        /// <param name="rows">Number of rows of board</param>
        /// <param name="pegs">Number of pegs per row</param>
        internal Board(int rows, int pegs) : this()
        {
            if (rows <= 0 || pegs <= 0)
                throw new MastermindBoardException("Rows and pegs must be positive non-zero values");

            this.NumberPegs = pegs;
            this.NumberRows = rows;

            this.rows = new ColoredPegRow[this.NumberRows];
        }

        /// <summary>
        /// Setup the board
        /// </summary>
        /// <param name="combination">Secret combination to be guessed by player</param>
        internal void setup(ColoredPegRow combination)
        {
            if (combination == null)
                throw new MastermindBoardException("The combination cannot be null");

            if (combination.NumberPegs != this.NumberPegs)
                throw new MastermindBoardException("The combination doesn't match the size of pegs per row");

            this.combination = combination;
        }

        /// <summary>
        /// Extracts the row and compares it to the combination
        /// </summary>
        /// <param name="row">The guess by player to compare to combination</param>
        /// <returns>MoveResult struct, which carries some stats based on the guess. Also flags when no more moves are allowed.</returns>
        internal MoveResult doMove(ColoredPegRow row)
        {
            if (row == null)
                throw new MastermindBoardException("Row cannot be null");

            if (row.NumberPegs != this.NumberPegs)
                throw new MastermindBoardException("The row is invalid for this move");

            if (this.curRow >= this.NumberRows)
                throw new MastermindBoardException("There are no more possible moves");

            MoveResult mr = new MoveResult();
            this.CurrentRow = row;
            mr.TotalRightColor = this.CurrentRow.EqualColors(this.combination);
            mr.TotalRightColorAndPosition = this.CurrentRow.EqualColorsAndPositions(this.combination);
            mr.TotalMoves = this.curRow + 1;
            this.curRow++;

            if (this.curRow >= this.NumberRows)
                mr.NoMoreMoves = true;

            return mr;
        }
    }


    #region Enumerators
    /// <summary>
    /// Avaliable colors for pegs
    /// </summary>
    public enum PegColor
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
        /// Light brown/gold peg
        /// </summary>
        LightBrown,

        /// <summary>
        /// Purple peg
        /// </summary>
        Purple
    }
    #endregion
}
