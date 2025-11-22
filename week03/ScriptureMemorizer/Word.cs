using System;

public class Word
{
    // ATRIBUTES
    private string _text;
    private bool _isHidden;

    // CONSTRUCTORS
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // METHODS
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}