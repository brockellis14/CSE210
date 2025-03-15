class Scripture
{
    private string Book;
    private int Chapter;
    private int Verse;
    private List<Word> Words;  // Store words as Word objects

    public Scripture(string book, int chapter, int verse, string text)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        Words = new List<Word>();

        // Convert text into words and store them as Word objects
        foreach (string word in text.Split(' '))
        {
            Words.Add(new Word(word));
        }
    }

    public void DisplayScripture()
    {
        Console.Write($"{Book} {Chapter}:{Verse} - ");
        foreach (Word word in Words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        List<Word> visibleWords = Words.FindAll(w => !w.IsHidden);

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return Words.TrueForAll(w => w.IsHidden);
    }
}
