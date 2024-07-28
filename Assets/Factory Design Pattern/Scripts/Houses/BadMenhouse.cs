using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class BadMenhouse : HeroHouses
{
    protected override Hero CreateHero()
    {
        Console.WriteLine("bb");
        return new Jocker();
    }
}

