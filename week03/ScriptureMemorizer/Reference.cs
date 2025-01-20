public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string referenceText)
    {
        var parts = referenceText.Split(' ');
        _book = parts[0];
        var verses = parts[1].Split(':');
        _chapter = int.Parse(verses[0]);
        _verse = int.Parse(verses[1]);
        _endVerse = _verse;
    }

    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}
