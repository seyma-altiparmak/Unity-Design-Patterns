using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class HeroHouses : MonoBehaviour
{
    public Hero CreateYourHero()
    {
        Hero hero = CreateHero();
        Console.WriteLine("cyh");


        hero.AttackHero();
        hero.DeathHero();
        hero.RebornHero();

        return hero;
    }

    protected abstract Hero CreateHero();
}
