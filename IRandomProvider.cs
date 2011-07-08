using System;

namespace Softklin.Mastermind
{
    /// <summary>
    /// Defines rules to create a Random Provider
    /// </summary>
    interface IRandomProvider
    {
        /// <summary>
        /// Generates a random number
        /// </summary>
        /// <returns>Integer random number</returns>
        int generateRandom();
    }
}
