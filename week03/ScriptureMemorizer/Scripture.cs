using System;
using System.Collections.Generic;

public class Scripture
{
    // ATRIBUTES
    private Reference _reference;
    private List<Word> _words;
    private static List<Reference> _referencesList = new List<Reference>();
    private static List<string> _textsList = new List<string>();

    // CONSTRUCTORS
    static Scripture()
    {
        // Add Scriptures to lists
        _referencesList.Add(new Reference("1 Nephi", 3, 5, 7));
        _textsList.Add("5 And now, behold thy brothers murmur, saying it is a hard thing which I have required of them; but behold I have not required it of them, but it is a commandment of the Lord. \n 6 Therefore go, my son, and thou shalt be favored of the Lord, because thou hast not murmured. \n 7 And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        
        _referencesList.Add(new Reference("John", 3, 16));
        _textsList.Add("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    // Construct by option number
    public Scripture(int option)
    {
        int index = option - 1;

        _reference = _referencesList[index];
        string text = _textsList[index];

        _words = new List<Word>();
        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    // METHODS

    // Create Random
    public Scripture()
    {
        Random randomObj = new Random();
        int index = randomObj.Next(0, _referencesList.Count);
        
        _reference = _referencesList[index];
        string text = _textsList[index];
        
        // Parse words
        _words = new List<Word>();
        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // Get hidden words
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }
        
        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);
        
        // Create random
        Random random = new Random();
        
        // Hidde words
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
         string result = _reference.GetDisplayText() + " ";
         foreach (Word word in _words)
         {
             result += word.GetDisplayText() + " ";
         }

         return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

}