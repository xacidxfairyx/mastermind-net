using System;

namespace Softklin.Mastermind
{
    /// <summary>
    /// Represents a player in the mastermind game
    /// </summary>
    public class Player
    {
        #region Properties

        /// <summary>
        /// The player's nickname
        /// </summary>
        public string Nickname { get; private set; }

        #endregion


        /// <summary>
        /// Creates a new player
        /// </summary>
        /// <param name="nickname">The player's nickname</param>
        /// <example>Player p = new Player("mycoolnick");</example>
        internal Player(string nickname)
        {
            if (nickname == null || nickname == String.Empty)
                throw new MastermindPlayerException("Nickname cannot be null or empty");

            this.Nickname = nickname;
        }


        #region Overrides

        /// <summary>
        /// Checks if two PLayers are equal (by nicknames)
        /// </summary>
        /// <param name="obj">Other object to compare</param>
        /// <returns>True, if there is the smae player, false otherwise</returns>
        public override bool Equals(object obj)
        {
            return (obj is Player && ((Player)obj).Nickname == this.Nickname);
        }

        /// <summary>
        /// Generates an unique hash code for each player
        /// </summary>
        /// <returns>hash code generated from nickname</returns>
        public override int GetHashCode()
        {
            return this.Nickname.GetHashCode();
        }

        /// <summary>
        /// Returns the player textual representation
        /// </summary>
        /// <returns>player nickname</returns>
        public override string ToString()
        {
            return this.Nickname;
        }

        #endregion
    }
}
