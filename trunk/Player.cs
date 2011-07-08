using System;

namespace Softklin.MasterMind
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

        public override bool Equals(object obj)
        {
            return (obj is Player && ((Player)obj).Nickname == this.Nickname);
        }

        public override int GetHashCode()
        {
            return this.Nickname.GetHashCode();
        }

        public override string ToString()
        {
            return this.Nickname;
        }

        #endregion
    }


    [Serializable]
    public class MastermindPlayerException : Exception
    {
        public MastermindPlayerException() { }
        public MastermindPlayerException(string message) : base(message) { }
        public MastermindPlayerException(string message, Exception inner) : base(message, inner) { }
        protected MastermindPlayerException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
