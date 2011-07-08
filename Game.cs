using System;
using System.Collections.Generic;

namespace Softklin.MasterMind
{
    /// <summary>
    /// Represents a MasterMind game 
    /// </summary>
    class MastermindGame
    {
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
        public GameState GameStatus { get; private set; }


        /// <summary>
        /// Creates a new MasterMind game
        /// </summary>
        /// <param name="players">The players</param>
        internal MastermindGame (Player[] players)
	    {
            if (players.Length != 2)
                throw new MastermindGameException("You need to provide exactly two players");

            if (players[0] == null)
                throw new MastermindGameException("Player 1 cannot be null");

            if (players[1] == null)
                throw new MastermindGameException("Player 2 cannot be null");

            if (players[0].Equals(players[1]))
                throw new MastermindGameException("Players can't be equal");

            this.Players = players;
	    }

        /// <summary>
        /// Starts the game, using Random class to schoose the first player
        /// </summary>
        /// <returns>Player who will start the game</returns>
        public Player startGame()
        {
            return null;
        }

        /// <summary>
        /// Starts the game, using a custom random provider
        /// </summary>
        /// <param name="randomProvider">The random source to use</param>
        /// <returns>Player who will start the game</returns>
        public Player startGame(IRandomProvider randomProvider)
        {
            return null;
        }

        /// <summary>
        /// Starts the game, defining one of the players
        /// </summary>
        /// <param name="player">The player who wil play first</param>
        public void startGame(Player player)
        {
            if (!this.Players[0].Equals(player) && !this.Players[1].Equals(player))
                throw new MastermindGameException("The player doesn't exists in this game");


        }
    }


    enum GameState
    {
        /// <summary>
        /// The current game didn't started yet
        /// </summary>
        Ready,
        /// <summary>
        /// The game is running, no winner or losers are known
        /// </summary>
        Running,
        /// <summary>
        /// The game endend, and the score card was updated
        /// </summary>
        Ended
    }


    [Serializable]
    public class MastermindGameException : Exception
    {
        public MastermindGameException() { }
        public MastermindGameException(string message) : base(message) { }
        public MastermindGameException(string message, Exception inner) : base(message, inner) { }
        protected MastermindGameException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
