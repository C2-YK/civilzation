using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int totalUnit = 1;
    public int totalEnergy = 1;
    public Race race;

    public Player(Race race)
    {
        this.race = race;
    }
}
