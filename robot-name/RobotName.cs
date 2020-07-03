using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

public class Robot
{
    private string _name;
    private readonly RobotNamesRegistry _robotNamesRegistry;
    public string Name
    {
        get
        {
            if (string.IsNullOrWhiteSpace(_name))
            {
                _name = _robotNamesRegistry.Get();
            }
            return _name;
        }
    }

    public Robot() => _robotNamesRegistry = RobotNamesRegistry.GetInstance();

    public void Reset()
    {
        if (!string.IsNullOrWhiteSpace(_name) &&
            _robotNamesRegistry.Remove(_name))
        {            
            _name = null;
        }
    }
}

public class RobotNamesRegistry
{
    private readonly HashSet<string> RobotNames = new HashSet<string>();

    private static RobotNamesRegistry _instance;
    private static readonly object padlock = new object();

    public string Get()
    {
        lock (padlock)
        {
            string name;
            do
            {                
                name = GenerateName();
            }
            while (!RobotNames.Add(name));            

            return name;
        }
    }

    private RobotNamesRegistry() { }

    public static RobotNamesRegistry GetInstance()
    {
        lock (padlock)
        {
            if (_instance == null)
            {
                _instance = new RobotNamesRegistry();
            }
            return _instance;
        }
    }

    private string GenerateName()
    {        
        var name = new StringBuilder();

        var random = new Random();

        var threeRandomDigits = Math.Floor(random.NextDouble() * 1000).ToString().PadLeft(3, '0');

        name.Append((char)random.Next('A', 'Z' + 1))
            .Append((char)random.Next('A', 'Z' + 1))
            .Append(threeRandomDigits);
        
        return name.ToString();
    }        

    public bool Remove(string robotName)
    {
        lock (padlock)
        {
            return RobotNames.Remove(robotName);
        }        
    }
}