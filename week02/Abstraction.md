# Abstraction
Abstraction is a fundamental programming concept. It involves hiding complex implementation details while exposing only the essential functionality.

It allows us to group complex lines of code into classes and modules. This makes our code more organized and easier to read and maintain, by allowing us to keep the 'main' logic of our code in one place, and splitting other logics in different files.

One of the benefits is that we can keep related functionality within classes. We can modify the internal code of the classes without affecting other parts of our code. Which makes it easier to debug, test and understand.

I applied abstraction by creating separate classes for different responsibilities. For example, I created the Menu class that stores the menu options and the behavior of displaying them:

```C#
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
```

This allows me to add more options to the journal if needed and to add more behaviors to the menu. The rest of the code remains the same. This shows how abstraction improves our code by establishing clear organization and responsibilities for each class. For example, if I want to add a new menu option or change the display format, I only modify the Menu class without touching the main program logic.