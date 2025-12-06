# What is Inheritance and Why is it Important?

## What is Inheritance?

Inheritance is when you create a new class that gets to use all the stuff from another class. Basically, you have a parent class (also called a base class) and a child class (also called a derived class). The child class automatically gets all the methods and variables from the parent class, so you don't have to write them again. This is really useful because if multiple classes need similar things, you can put those things in one parent class and then have other classes inherit from it.

## Why is Inheritance Important?

The biggest benefit I've learned about inheritance is that it helps you avoid writing the same code over and over again. If I have three different activities that all need to display a starting message and an ending message, I don't want to write that code three times. Instead, I can write it once in a parent class and all three activities can just use it automatically. This makes the code cleaner and if I need to fix a bug, I only have to fix it in one place instead of in every single class.

## How I Used Inheritance in My Program

In my Mindfulness program, I created a base class called `Activity` that has all the common things that every activity needs, like displaying messages, showing spinners, and keeping track of time. Then I made three specific activities: `BreathingActivity`, `ReflectingActivity`, and `ListingActivity`. All three of these inherit from the `Activity` class, which means they automatically have access to all those common methods without me having to rewrite them.

Here's some code from my program that shows this:

```csharp
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        // ... more code
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
    }
}

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly.";
    }

    public void Run()
    {
        DisplayStartingMessage();  // I can use this because I inherited it!

        // My specific breathing code here

        DisplayEndingMessage();  // This too!
    }
}
```

The `BreathingActivity` class uses `: Activity` to inherit from the Activity class. This means it can use `DisplayStartingMessage()` and `DisplayEndingMessage()` without having to write those methods again. The same thing works for my other two activities. This saved me a lot of time and made my code way easier to manage.
