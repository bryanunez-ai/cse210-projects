using System;

public class Menu
{
    public List<string> _options;

    public void DisplayMenu()
    {
        _options = new List<string>();
        _options.Add("1. Write");
        _options.Add("2. Display");
        _options.Add("3. Load");
        _options.Add("4. Save");
        _options.Add("5. Quit");

        Console.WriteLine("Please select an option:");
        foreach (string option in _options)
        {
            Console.WriteLine(option);
        }
    }

}