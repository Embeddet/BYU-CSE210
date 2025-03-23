using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What new thing did I learn today?",
        "How did I practice self-care today?"
    };

    public void WriteNewEntry()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        _entries.Add(new Entry(prompt, response));
        Console.WriteLine("Entry added successfully!");
    }

    public void DisplayJournal()
    {
        Console.WriteLine("\nJournal Entries:");
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

    public void SaveJournal()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Date,Prompt,Response");
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{EncodeCsvField(entry.Date)}," +
                                    $"{EncodeCsvField(entry.Prompt)}," +
                                    $"{EncodeCsvField(entry.Response)}");
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }

    public void LoadJournal()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        try
        {
            List<Entry> newEntries = new List<Entry>();
            using (StreamReader reader = new StreamReader(filename))
            {
                reader.ReadLine(); // Skip header
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = ParseCsvLine(line);
                    if (parts.Length == 3)
                    {
                        newEntries.Add(new Entry(
                            DecodeCsvField(parts[1]),
                            DecodeCsvField(parts[2]),
                            DecodeCsvField(parts[0]))
                        );
                    }
                }
            }
            _entries = newEntries;
            Console.WriteLine("Journal loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }

    private string EncodeCsvField(string field)
    {
        if (field.Contains("\"") || field.Contains(","))
        {
            return "\"" + field.Replace("\"", "\"\"") + "\"";
        }
        return field;
    }

    private string DecodeCsvField(string field)
    {
        if (field.StartsWith("\"") && field.EndsWith("\""))
        {
            field = field[1..^1];
            field = field.Replace("\"\"", "\"");
        }
        return field;
    }

    private string[] ParseCsvLine(string line)
    {
        List<string> fields = new List<string>();
        bool inQuotes = false;
        StringBuilder field = new StringBuilder();

        foreach (char c in line)
        {
            if (c == '"')
            {
                inQuotes = !inQuotes;
            }
            else if (c == ',' && !inQuotes)
            {
                fields.Add(field.ToString());
                field.Clear();
            }
            else
            {
                field.Append(c);
            }
        }
        fields.Add(field.ToString());
        return fields.ToArray();
    }
}