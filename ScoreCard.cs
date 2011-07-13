using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Softklin.Mastermind
{
    /// <summary>
    /// Represents a score card to store scores from games
    /// </summary>
    public class ScoreCard
    {
        Dictionary<int, Dictionary<string, int>> scores;

        /// <summary>
        /// Creates an empty score card
        /// </summary>
        public ScoreCard()
        {
            this.scores = new Dictionary<int, Dictionary<string, int>>();
        }

        /// <summary>
        /// Gets the accumulated score for a player
        /// </summary>
        /// <param name="player">The player nickname</param>
        /// <returns>Player's accumulated score</returns>
        public int this[string player] {
            get
            {
                bool found = false;
                int playerScore = 0;

                foreach (Dictionary<string, int> result in this.scores.Values)
                {
                    if (result.ContainsKey(player))
                    {
                        found = true;
                        playerScore += result[player];
                    }
                }

                if (!found)
                    throw new MastermindScoreCardException("Player not found");

                return playerScore;
            }
        }

        /// <summary>
        /// Gets the result of a single game
        /// </summary>
        /// <param name="gameID">The unique game ID</param>
        /// <returns>Dictionary containing the players and their results</returns>
        public Dictionary<string, int> this[int gameID]
        {
            get
            {
                if (!this.scores.ContainsKey(gameID))
                    throw new MastermindScoreCardException("The game ID doesn't exists in the score card");

                return this.scores[gameID];
            }

        }

        /// <summary>
        /// Saves a score in this score card
        /// </summary>
        /// <param name="game"></param>
        public void saveScore(MastermindGame game)
        {
            if (game == null)
                throw new MastermindScoreCardException("Game cannot be null");

            if (game.Status != GameStatus.Ended)
                throw new MastermindScoreCardException("The game didn't finish yet");

            if (this.scores.ContainsKey(game.GameID))
                throw new MastermindScoreCardException("The game was already saved");

            this.scores.Add(game.GameID, new Dictionary<string,int>());

            foreach (Player p in game.Players)
                this.scores[game.GameID].Add(p.Nickname, (game.Winner.Equals(p.Nickname)) ? 1 : 0);
        }
    }
}
