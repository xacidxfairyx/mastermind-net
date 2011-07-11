using System;
using System.Collections.Generic;

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

        /// <summary>
        /// Checks how many equal colors, withous repetitions, are in common with both rows
        /// </summary>
        /// <param name="row">The other row to compare</param>
        /// <returns>Number of similar colors, without repetitions</returns>
        internal int EqualColors(ColoredPegRow row)
        {
            if (this.NumberPegs != row.NumberPegs)
                throw new MastermindColoredPegRowException("To compare objects, the number of pegs must be equal");

            List<PegColor> foundColors = new List<PegColor>();

            for (int i = 0; i < this.NumberPegs; i++)
            {
                if (!foundColors.Contains(this.Pegs[i]))
                {
                    bool newColor = false;
                    PegColor current = this.Pegs[i];

                    foreach (PegColor color in row.Pegs)
                        if (current == color)
                        {
                            newColor = true;
                            break;
                        }

                    if (newColor)
                        foundColors.Add(current);
                }
            }

            return foundColors.Count;
        }

        /// <summary>
        /// Checks how many pegs are in right positions (same color and same position)
        /// </summary>
        /// <param name="row">The other row to compare</param>
        /// <returns>Number of right pegs</returns>
        internal int EqualColorsAndPositions(ColoredPegRow row)
        {
            if (this.NumberPegs != row.NumberPegs)
                throw new MastermindColoredPegRowException("To compare objects, the number of pegs must be equal");

            int total = 0;

            for (int i = 0; i < this.NumberPegs; i++)
                if (this.Pegs[i] == row.Pegs[i])
                    total++;

            return total;
        }

        /// <summary>
        /// Checks if two ColoredPegRow are equal
        /// </summary>
        /// <param name="obj">The other object to compare</param>
        /// <returns>True, if the rows are equal (peg colors and positions); false otherwise</returns>
        /// <remarks>This method always returns false if the other object is not a ColoredPegRow</remarks>
        public override bool Equals(object obj)
        {
            if (!(obj is ColoredPegRow))
                return false;

            ColoredPegRow other = (ColoredPegRow)obj;

            if (other.NumberPegs != this.NumberPegs)
                return false;

            for (int i = 0; i < this.NumberPegs; i++)
                if (this.Pegs[i] != other.Pegs[i])
                    return false;

            return true;
        }

        /// <summary>
        /// Gets the hash code for this row
        /// </summary>
        /// <returns>Unique hash code for this row</returns>
        /// <remarks>The hash code is based on the peg colors and it positions</remarks>
        public override int GetHashCode()
        {
            const int ODD_PRIME_NUMBER = 31;
            int code = 0;

            for (int i = 0; i < this.NumberPegs; i++)
                code += (int) (this.Pegs[i]) * (ODD_PRIME_NUMBER ^ i);

            return code;
        }
    }
}
