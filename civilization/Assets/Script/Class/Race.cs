using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Race
{
    public enum Type { human, orc, qiraji }
    public Type type;
    public int ap;
    public int createUnitCost;
    public int moveCost;
    public int attackCost;
    int baseAP = 1;


    public Race(Type type)
    {
        this.type = type;
        switch (this.type)
        {
            case Type.human:
                ap = 0 + baseAP;
                createUnitCost = 2;
                moveCost = 2;
                attackCost = 1;
                break;
            case Type.orc:
                ap = 1 + baseAP;
                createUnitCost = 2;
                moveCost = 2;
                attackCost = 1;
                break;
            case Type.qiraji:
                ap = 0 + baseAP;
                createUnitCost = 1;
                moveCost = 1;
                attackCost = 1;
                break;

        }
    }
}
