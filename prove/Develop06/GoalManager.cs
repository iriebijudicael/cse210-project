using System;

// GoalManager class
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool exit = false;
        while (!exit)
        { 
            Console.Clear();
            Console.WriteLine("Goal Manager Menu");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create New Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");
            Console.Write("Select an option from the menu: ");

            switch (Console.ReadLine())
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    SaveGoals();
                    break;
                case "7":
                    LoadGoals();
                    break;
                case "8":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.Write("Enter Goal Type (Simple, Eternal, Checklist): ");
        string type = Console.ReadLine().ToLower();

        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Goal Description: ");
        string description = Console.ReadLine();

        Console.Write("Enter Goal Points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = type switch
        {
            "simple" => new SimpleGoal(name, description, points),
            "eternal" => new EternalGoal(name, description, points),
            "checklist" => CreateChecklistGoal(name, description, points),
            _ => null
        };

        if (goal != null)
        {
            _goals.Add(goal);
            Console.WriteLine($"{type} goal created successfully.");
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    private ChecklistGoal CreateChecklistGoal(string name, string description, int points)
    {
        Console.Write("Enter Target Number of Completions: ");
        int target = int.Parse(Console.ReadLine());

        Console.Write("Enter Bonus Points: ");
        int bonus = int.Parse(Console.ReadLine());

        return new ChecklistGoal(name, description, points, target, bonus);
    }

    public void RecordEvent()
    {
        Console.WriteLine("Choose a goal to record an event for:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            int points = _goals[choice].RecordEvent();
            _score += points;
            Console.WriteLine($"Event recorded! You've earned {points} points. Total Score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved to goals.txt.");
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        _goals.Clear();
        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                Goal goal = parts[0] switch
                {
                    "SimpleGoal" => new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])),
                    "EternalGoal" => new EternalGoal(parts[1], parts[2], int.Parse(parts[3])),
                    "ChecklistGoal" => new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])),
                    _ => null
                };
                if (goal != null) _goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded from goals.txt.");
    }
}