using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DC_Comic : MonoBehaviour
{
    void Start()
    {
        HeroHouses heroHouses = new GoodMenhouse(); //Batman
        Hero batman = heroHouses.CreateYourHero();

        Console.WriteLine("\n");
        
        HeroHouses enemiesHouses = new BadMenhouse(); //Joker
        Hero joker = heroHouses.CreateYourHero();

    }

}
