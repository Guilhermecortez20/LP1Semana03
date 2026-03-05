using System;
using System.Collections.Generic;

enum HackTool
{
    BruteForce,
    Phishing,
    Backdoor,
    ZeroDay,
    AIOverride,
    QuantumExploit
}

enum SystemType
{
    CorporateServer,
    BankDatabase,
    SmartCityCore,
    MilitaryAI
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter system type:");
        string systemInput = Console.ReadLine();
        SystemType system = Enum.Parse<SystemType>(systemInput);

        Console.WriteLine("Enter hacking tools separated by comma:");
        string toolsInput = Console.ReadLine();

        string[] toolsArray = toolsInput.Split(",");
        List<HackTool> tools = new List<HackTool>();

        foreach (string t in toolsArray)
        {
            tools.Add(Enum.Parse<HackTool>(t.Trim()));
        }

        bool hacked = false;

        if(system == SystemType.CorporateServer)
        {
            hacked =
            (tools.Contains(HackTool.Phishing) || tools.Contains(HackTool.Backdoor)) &&
            (tools.Contains(HackTool.BruteForce) || tools.Contains(HackTool.ZeroDay));
        }

        if(system == SystemType.BankDatabase)
        {
            hacked =
            (tools.Contains(HackTool.ZeroDay) && tools.Contains(HackTool.Backdoor)) ||
            (tools.Contains(HackTool.QuantumExploit) && tools.Contains(HackTool.AIOverride));
        }

        if(system == SystemType.SmartCityCore)
        {
            hacked =
            (tools.Contains(HackTool.AIOverride) && tools.Contains(HackTool.Backdoor)) ||
            (tools.Contains(HackTool.ZeroDay) && tools.Contains(HackTool.BruteForce)) ||
            (tools.Contains(HackTool.QuantumExploit) && tools.Contains(HackTool.Phishing));
        }

        if(system == SystemType.MilitaryAI)
        {
            hacked =
            (tools.Contains(HackTool.ZeroDay) && tools.Contains(HackTool.AIOverride)) &&
            (tools.Contains(HackTool.Backdoor) || tools.Contains(HackTool.BruteForce)) &&
            (tools.Contains(HackTool.Phishing) || tools.Contains(HackTool.QuantumExploit));
        }

        if(hacked)
            Console.WriteLine("System Hacked");
        else
            Console.WriteLine("System Secure");
    }
}