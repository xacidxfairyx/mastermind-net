namespace Softklin.Mastermind
{
    /// <summary>
    /// Defines rules to create a Random Provider
    /// </summary>
    /// <remarks>See https://code.google.com/p/mastermind-net/wiki/IRandomProvider for details</remarks>
    public interface IRandomProvider
    {
        /// <summary>
        /// Generates a random number
        /// </summary>
        /// <returns>Integer random number</returns>
        int generateRandom();
    }
}
