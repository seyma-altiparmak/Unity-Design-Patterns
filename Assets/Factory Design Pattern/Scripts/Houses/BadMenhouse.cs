using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class BadMenhouse : HeroHouses
{
    protected override Hero CreateHero()
    {
        return new Jocker();
    }
}

