class Word
{
    private string Text;
    public bool IsHidden;

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public void Show()
    {
        IsHidden = false;
    }

    public override string ToString()
    {
        return IsHidden ? "_____" : Text;
    }
}
