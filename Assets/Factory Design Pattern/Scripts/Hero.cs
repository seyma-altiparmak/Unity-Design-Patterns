using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public string Name {  get; set; }
    public List<string> Powers { get; } = new List<string>();

    public void CreateHero()
    {
        Console.WriteLine($"Created Hero : {Name}");
        Console.WriteLine("Hero powers:");
        foreach (var p in Powers)
        {
            Console.WriteLine($" , {p}");
        }
    }

    public void AttackHero()
    {
        Console.WriteLine($"{Name} Hero Attacked.");
    }

    public void DeathHero()
    {
        Console.WriteLine($"{Name} Hero dead.");
    }

    public void RebornHero()
    {
        Console.WriteLine($"{Name} Hero Reborned.");
    }
}
