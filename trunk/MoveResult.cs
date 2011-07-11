namespace Softklin.Mastermind
{
    /// <summary>
    /// Represents the result of a move
    /// </summary>
    public struct MoveResult
    {
        /// <summary>
        /// Get the total of pegs in both right position and color.
        /// </summary>
        /// <remarks>The peg associated with this is normally black</remarks>
        public int TotalRightColorAndPosition { get; internal set; }

        /// <summary>
        /// Get the total of pegs in with right colors but wrong positions
        /// </summary>
        /// <remarks>The peg associated with this is blank</remarks>
        public int TotalRightColor { get; internal set; }

        /// <summary>
        /// Get the total number of tries made so far (also the current move number)
        /// </summary>
        public int TotalMoves { get; internal set; }

        /// <summary>
        /// Indicates whenever the board doesn't allow more moves
        /// </summary>
        public bool NoMoreMoves { get; internal set; }
    }
}