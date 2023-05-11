using System;
using System.IO;

internal static class ProgramHelpers
{
    static void Main()
    {
        string unlockCodesFilePath = "unlock_codes.txt"; // Fájl elérési útvonala, amelyben a kódzár kódok vannak
        if (!File.Exists(unlockCodesFilePath))
        {
            Console.WriteLine("A kódzár kódok fájl nem található.");
            return;
        }

        // Kódzár kódok betöltése és feldolgozása
        string[] unlockCodes = File.ReadAllLines(unlockCodesFilePath);
        foreach (string code in unlockCodes)
        {
            Console.WriteLine("Unlock code: " + code);
        }
    }
}
