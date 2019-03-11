using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    class Program
    {


        static void Main(string[] args)
        {
            StartGame();
        }

        public static void StartGame()
        {
            
            WorldMap map = new WorldMap();          
            Player player = new Player();
            map.world[5, 5].tileEntityList.Add(player);
            map.Draw();
            do
            {
                player.GetAction(map);           
                map.Draw();

            } while (true);

           
        }
    }
}
