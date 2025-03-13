using System;

class Scripture
{
    public string Book { get; }
    public int Chapter { get; }
    public int Verse { get; }
    public string Text { get; }

    public Scripture(string book, int chapter, int verse, string text)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        Text = text;
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"{Book} {Chapter}:{Verse} - {Text}");
    }
}
