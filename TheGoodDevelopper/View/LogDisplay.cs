using System;

namespace TheGoodDevelopper.View
{
    /// <summary>
    /// Controls the Displaying of the LogFile.
    /// </summary>
    internal class LogDisplay
    {
        /// <summary>
        /// Write message to console.
        /// </summary>
        /// <param name="log"></param>
        internal void DisplayLog(string log)
        {
            Console.WriteLine(log);
        }

        /// <summary>
        /// Write count to conosle.
        /// </summary>
        /// <param name="count"></param>
        internal void DisplayLineCount(int count)
        {
            Console.WriteLine($"lines in logfile: {count}");
        }

        /// <summary>
        /// Wait for any user input.
        /// </summary>
        internal void WaitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}
