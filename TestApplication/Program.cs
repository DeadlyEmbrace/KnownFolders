using System;
using System.Runtime.InteropServices;
using Syroot.Windows.IO;

namespace TestApplication
{
    /// <summary>
    /// Represents the main class of the application.
    /// </summary>
    internal class Program
    {
        // ---- METHODS (PRIVATE) --------------------------------------------------------------------------------------

        private static void Main(string[] args)
        {
            // Go through each KnownFolderType enumeration member.
            foreach (KnownFolderType type in Enum.GetValues(typeof(KnownFolderType)))
            {
                KnownFolder knownFolder = new KnownFolder(type);

                // Write down the current and default path.
                Console.WriteLine(knownFolder.Type.ToString());
                try
                {
                    Console.Write("Current Path: ");
                    Console.WriteLine(knownFolder.Path);
                    Console.Write("Default Path: ");
                    Console.WriteLine(knownFolder.DefaultPath);
                }
                catch (ExternalException ex)
                {
                    // While uncommon with personal folders, other KnownFolders don't exist on every system, and trying
                    // to query those returns an error which we catch here.
                    Console.WriteLine("<Exception> " + ex.ErrorCode);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
