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
        Dictionary<Player, int> scores;

        /// <summary>
        /// Creates an empty score card
        /// </summary>
        public ScoreCard()
        {
            this.scores = new Dictionary<Player, int>();
        }

        /// <summary>
        /// Saves a score in this score card
        /// </summary>
        /// <param name="game"></param>
        public void saveScore(MastermindGame game)
        {

        }
    }
}
