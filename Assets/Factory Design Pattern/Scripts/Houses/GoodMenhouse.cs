using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class GoodMenhouse : HeroHouses
{
    protected override Hero CreateHero()
    {
        return new Batman();
    }
}