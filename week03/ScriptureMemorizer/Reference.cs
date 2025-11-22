using System;

public class Reference
{
    // ATRIBUTES
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // CONSTRUCTORS
    // Single scripture reference
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Range scripture reference
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // METHODS
    public string GetDisplayText()
    {
        // If is a range reference, add the end verse
        if (_endVerse > 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else // If is a single reference, do not add the end verse
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }




}