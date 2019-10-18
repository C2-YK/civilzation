using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit
{
    public Race race;

    public int energy = 1;
    public Player player;
    public int[] position;
    bool alive = true;

    public Unit(Player player, int[] position)
    {
        this.player = player;
        race = player.race;
        this.position = position;
    }

    public bool HaveEnergyToCreateUnit()
    {
        if(energy - race.createUnitCost < 1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public Unit CreateUnit(int[] position)
    {
        energy -= race.createUnitCost;
        return new Unit(player, position);
    }

    public void Attack(Unit target)
    {
        if(energy - race.attackCost < 1) { return; }
        energy -= race.attackCost;
        target.energy -= race.ap;
        if(target.energy < 1)
        {
            target.alive = false;
        }
    }


    public enum Direction { r, l, u, d, ru, lu, rd, ld}
    public void Move(Direction direction)
    {
        if(energy - race.moveCost < 1) { return; }
        int[] here = position; // for future might include flexable map size
        switch (direction)
        {
            case Direction.r:
                here[0] += 1;
                break;
            case Direction.l:
                here[0] -= 1;
                break;
            case Direction.u:
                here[1] += 1;
                break;
            case Direction.d:
                here[1] -= 1;
                break;
            case Direction.ru:
                here[0] += 1;
                here[1] += 1;
                break;
            case Direction.lu:
                here[0] -= 1;
                here[1] += 1;
                break;
            case Direction.rd:
                here[0] += 1;
                here[1] -= 1;
                break;
            case Direction.ld:
                here[0] -= 1;
                here[1] -= 1;
                break;
        }
        position = here;
        energy -= race.moveCost;
    }

    public void UseAbility()
    {

    }
}
