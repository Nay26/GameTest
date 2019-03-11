using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    class Player : Entity
    {
        public Inventory inventory;
        public int mapx, mapy;

        public Player()
        {
            inventory = new Inventory();
            mapx = 5;
            mapy = 5;
        }

        public MapTile PickUp(MapTile mapSquare)
        {
            if (mapSquare.tileItemsList.Count > 0)
            {

                


                Item pickingUpItem = mapSquare.tileItemsList[mapSquare.tileItemsList.Count - 1].item;
                int amount = mapSquare.tileItemsList[mapSquare.tileItemsList.Count - 1].amount;

                Console.WriteLine("There are " + amount + " " + pickingUpItem.name + " on the floor.");

                mapSquare.tileItemsList.RemoveAt(mapSquare.tileItemsList.Count - 1);


                int amountNotPickedUp = 0;
                amountNotPickedUp = inventory.AddItem(pickingUpItem, amount);
                Console.WriteLine("Added " + (amount-amountNotPickedUp) + " " + pickingUpItem.name + " to players inventory.");
                if (amountNotPickedUp > 0)
                {
                    Console.WriteLine("Couldn't pick up " + amountNotPickedUp + " " + pickingUpItem.name);
                    ItemStack itemStack = new ItemStack(pickingUpItem, amountNotPickedUp);
                    mapSquare.tileItemsList.Add(itemStack);
                }

                
            } else
            {
                Console.WriteLine("There is nothing here to pickup");
            }
            return mapSquare;
        }

        public void GetAction(WorldMap map)
        {
            Console.WriteLine("Enter Action: N, S, E, W to Move, I for Inventory, P to pickup");
            string playerAction = Console.ReadLine();
            Console.Clear();
            if ( playerAction.Equals("n") || playerAction.Equals("s") || playerAction.Equals("e") || playerAction.Equals("w") )
            {
                Move(playerAction, map);
            }
            else if (playerAction.Equals("i"))
            {
                inventory.DisplayInventory();

            } else if (playerAction.Equals("p"))
            {
               map.world[mapy,mapx] = PickUp(map.world[mapy,mapx]);
            }
        }

        public void Move(string move, WorldMap map)
        {
            map.world[mapy, mapx].tileEntityList.Remove(this);
            if (move.Equals("n"))
            {
                mapy -= 1;
            }
            if (move.Equals("s"))
            {
                mapy += 1;
            }
            if (move.Equals("e"))
            {
                mapx += 1;
            }
            if (move.Equals("w"))
            {
                mapx -= 1;
            }
            map.world[mapy, mapx].tileEntityList.Add(this);
        }

    }
}
