using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1; 
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalNames();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        _level = GetLevelFromScore();
        string title = GetLevelTitle();

        Console.WriteLine($"\nYou have {_score} points.");
        Console.WriteLine($"Level: {_level} - {title}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        int type = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (type == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (type == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }

        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex];
            if (selectedGoal is SimpleGoal && selectedGoal.IsComplete())
            {
                Console.WriteLine("This goal is already completed!");
                return;
            }

            int previousLevel = _level;

            selectedGoal.RecordEvent();

            int pointsEarned = selectedGoal.GetPoints();
            _score += pointsEarned;

            if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                int bonus = checklistGoal.GetBonus();
                _score += bonus;
                Console.WriteLine($"Congratulations! You completed the goal and earned a bonus of {bonus} points!");
                Console.WriteLine($"You earned {pointsEarned + bonus} points total!");
            }
            else
            {
                Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");
            }

            _level = GetLevelFromScore();
            if (_level > previousLevel)
            {
                Console.WriteLine("\n╔══════════════════════════════════════╗");
                Console.WriteLine("║        *** LEVEL UP! ***             ║");
                Console.WriteLine($"║   Level {_level} - {GetLevelTitle()}");
                Console.WriteLine("╚══════════════════════════════════════╝\n");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        _level = GetLevelFromScore();

        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string goalType = parts[0];
            string goalData = parts[1];

            string[] data = goalData.Split(",");

            if (goalType == "SimpleGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                bool isComplete = bool.Parse(data[3]);

                SimpleGoal goal = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);

                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                int target = int.Parse(data[3]);
                int bonus = int.Parse(data[4]);
                int amountCompleted = int.Parse(data[5]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    // This calculates del level
    public int GetLevelFromScore()
    {
        // Level system: every 1000 points = 1 level
        // Level 1: 0-999 points
        // Level 2: 1000-1999 points
        // Level 3: 2000-2999 points, etc.
        return (_score / 1000) + 1;
    }

    public string GetLevelTitle()
    {
        // Funny level label
        if (_level == 1) return "Child of God";
        else if (_level == 2) return "Telestial Master";
        else if (_level == 3) return "Terrestrial Master";
        else if (_level == 4) return "Disciple of Christ";
        else if (_level == 5) return "Saint";
        else if (_level >= 6 && _level <= 9) return "Good and Faithful Servant";
        else return "Celestial Grand Master";  // Nivel 10+
    }
}
