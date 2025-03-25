using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Load a scripture from a file (optional feature)
        Scripture scripture = null;
        scripture = LoadScriptureFromFile("scripture.txt");
        
        if (scripture == null) // Fallback in case file loading fails
        {
            scripture = new Scripture(new Reference("Proverbs", 3, 5, 6), 
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
                "In all thy ways acknowledge him, and he shall direct thy paths.");
        }

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(2); // Hides 2 words at a time
        }

        Console.Clear();
        Console.WriteLine("All words are hidden. Well done!\n");
        Console.WriteLine(scripture.GetDisplayText());
    }

    static Scripture LoadScriptureFromFile(string filename)
    {
        try
        {
            string[] lines = File.ReadAllLines(filename);
            if (lines.Length < 2) return null;

            Reference reference = Reference.Parse(lines[0]); // Parse the reference from the first line
            string text = string.Join(" ", lines.Skip(1));   // Join remaining lines as scripture text

            return new Scripture(reference, text);
        }
        catch (Exception)
        {
            return null; // Return null if file reading fails
        }
    }
}



