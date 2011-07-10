namespace Softklin.Mastermind
{
    /// <summary>
    /// Represents an row of colored pegs
    /// </summary>
    public class ColoredPegRow
    {
        #region Properties
        /// <summary>
        /// The pegs in this row, ordered
        /// </summary>
        public PegColor[] Pegs { get; private set; }

        /// <summary>
        /// Number of pegs in this row
        /// </summary>
        public int NumberPegs { get; private set; }
        #endregion


        /// <summary>
        /// Creates a new row of colored pegs
        /// </summary>
        /// <param name="colors">Colors for the pegs</param>
        /// <remarks>The order of colors is important, as it will be the same order of pegs in this row</remarks>
        internal ColoredPegRow(params PegColor[] colors)
        {
            if (colors == null)
                throw new MastermindColoredPegRowException("Peg colors cannot be null");

            this.Pegs = colors;
            this.NumberPegs = colors.Length;
        }


    }
}
