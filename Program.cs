using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASE_Programming_Language
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable visual styles for the application
            Application.EnableVisualStyles();

            // Set the default text rendering for the application
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of the RandomNumberGenerator for generating random numbers
            IRandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();

            // Run the application with the main form and the random number generator
            Application.Run(new Form1(randomNumberGenerator));
        }
    }
}
