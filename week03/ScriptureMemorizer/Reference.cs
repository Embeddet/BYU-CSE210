using System.Text.RegularExpressions;

class Reference
{
    public string Book { get; }
    public int Chapter { get; }
    public int StartVerse { get; }
    public int? EndVerse { get; } // Nullable for single verses

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse.HasValue ? $"{Book} {Chapter}:{StartVerse}-{EndVerse}" : $"{Book} {Chapter}:{StartVerse}";
    }

    public static Reference Parse(string referenceText)
    {
        System.Text.RegularExpressions.Match match = Regex.Match(referenceText, @"(\w+)\s(\d+):(\d+)(?:-(\d+))?");
        if (match.Success)
        {
            string book = match.Groups[1].Value;
            int chapter = int.Parse(match.Groups[2].Value);
            int startVerse = int.Parse(match.Groups[3].Value);
            int? endVerse = match.Groups[4].Success ? int.Parse(match.Groups[4].Value) : (int?)null;
            return new Reference(book, chapter, startVerse, endVerse);
        }
        throw new FormatException("Invalid scripture reference format.");
    }
}
