using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land
{
    public enum Kind { forest, grassland, desert}
    public enum Status { fertile, normal, barren}
    public enum Building { castle, none}

    public Kind kind;
    public Status status = Status.normal;
    public Building building = Building.none;
    int baseEnergyReturn = 0;
    

    public Land(Kind kind)
    {
        this.kind = kind;
        switch (this.kind)
        {
            case Kind.grassland:
                baseEnergyReturn = 3;
                break;
            case Kind.forest:
                baseEnergyReturn = 2;
                break;
            case Kind.desert:
                baseEnergyReturn = 1;
                break;
        }
    }
    public int GetEnergyReturn()
    {
        int energyReturn = baseEnergyReturn;
        switch (status)
        {
            case Status.fertile:
                energyReturn += 2;
                break;
            case Status.normal:
                break;
            case Status.barren:
                energyReturn -= 2;
                if(energyReturn < 0)
                {
                    energyReturn = 0;
                }
                break;
        }
        return energyReturn;
    }
    public void Buff()
    {
        switch (status)
        {
            case Status.fertile:
                break;
            case Status.normal:
                status = Status.fertile;
                break;
            case Status.barren:
                status = Status.normal;
                break;
        }
    }
    public void Debuff()
    {
        switch (status)
        {
            case Status.fertile:
                status = Status.normal;
                break;
            case Status.normal:
                status = Status.barren;
                break;
            case Status.barren:
                break;
        }
    }
}
