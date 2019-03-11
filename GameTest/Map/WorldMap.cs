using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{

    class WorldMap
    {
        public MapTile[,] world;

        public WorldMap()
        {
            Item rock = new Item("NR001", "Rock", 0.1, 0.01, 99, null);
            ItemStack itemStack = new ItemStack(rock, 65);
            world = new MapTile[25, 25];
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    world[i, j] = new MapTile();
                    world[i, j].tileItemsList.Add(itemStack);
                }
            }


        }

        public void Draw()
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    world[i, j].UpdateTileImage();
                    Console.Write(world[i, j].tileImage);
                }
                Console.WriteLine();
            }
        }

    }
}
