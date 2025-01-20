public class Word
{
    private string _text;      // The word itself
    private bool _isHidden;    // The state (whether it's hidden)

    // Constructor to initialize a word
    public Word(string text)
    {
        _text = text;
        _isHidden = false;  // Words are visible by default
    }

    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to get the word's display text (either the word or underscores)
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);  // Replace the word with underscores
        }
        return _text;  // Otherwise, show the word itself
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }
}
