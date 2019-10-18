using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map
{
    int x_max;
    int y_max;
    int totalLand;
    Land[,] map;

    public Map(int x_max, int y_max)
    {
        this.x_max = x_max;
        this.y_max = y_max;
        totalLand = x_max * y_max;
        map = new Land[x_max, y_max];
        
        for(int x = 0; x < x_max; x++)
        {
            for(int y = 0; y< y_max; y++)
            {
                int type = Random.Range(0, 3);
                if(type == 0)
                {
                    map[x, y] = new Land(Land.Kind.desert);
                }
                else if (type == 1)
                {
                    map[x, y] = new Land(Land.Kind.forest);
                }
                else
                {
                    map[x, y] = new Land(Land.Kind.grassland);
                }
            }
        }
    }

}
