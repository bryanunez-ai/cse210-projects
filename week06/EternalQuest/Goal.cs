using System;

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual void RecordEvent()
    {
        string record = "";
        record = "1";
    }

    public virtual bool IsComplete()
    {
        bool complete = false;
        return complete;
    }

    public virtual string GetDetailsString()
    {
        string details = "";
        return details;
    }

    public virtual string GetStringRepresentation()
    {
        string representation = "";
        return representation;
    }
}