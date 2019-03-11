using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    class Inventory
    {
        public ItemStack[] spaces;
        public double weight;
        public double value;

        public Inventory()
        {
           spaces = new ItemStack[9];
        }

        public int AddItem(Item item, int amount)
        {

            if (ItemExists(item)) // If item exists in inventory then stack what you can
            {
                foreach (int location in GetItemStackLocations(item))
                {
                    int spaceLeft = 0;
                    spaceLeft = spaces[location].item.stackSize - spaces[location].amount;
                    if (spaceLeft > 0)
                    {
                        for (int j = 0; j < spaceLeft; j++)
                        {
                            spaces[location].amount++;
                            amount--;
                        }
                    }
                }
            }

            if (IsSpace()) // once youve stacked what you can make empty stacks
            {
                for (int i = 0; i < spaces.Length; i++) 
                {
                    if ((spaces[i] == null) && (amount > 0))
                    {
                        if (amount <= item.stackSize) 
                        {
                            spaces[i] = new ItemStack(item, amount);
                            amount = 0;
                        }
                        else
                        {
                            spaces[i] = new ItemStack(item, item.stackSize);
                            amount = amount - item.stackSize;
                        }
                    }
                }
            }

            return amount;
           
        }

        public void RemoveItem(Item item, int amount)
        {

        }

        public void DisplayInventory()
        {
            for (int i = 0; i < spaces.Length; i++)
            {
                if (spaces[i] != null)
                {
                    Console.WriteLine("Inventory slot " + i + " : " + spaces[i].item.name + " x " + spaces[i].amount);
                }
                
            }
        }

        public Boolean ItemExists(Item item)
        {
            for (int i = 0; i < spaces.Length; i++)
            {
                if (spaces[i] != null)
                {
                    if (spaces[i].item.id.Equals(item.id))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Boolean IsSpace()
        {
            for (int i = 0; i < spaces.Length; i++)
            {
                if (spaces[i] == null)
                {
                    return true;
                }
            }

            return false;
        }

        public List<int> GetItemStackLocations(Item item)
        {
            List<int> locationList = new List<int>();
            for (int i = 0; i < spaces.Length; i++)
            {
                if (spaces[i] != null)
                {
                    if (spaces[i].item.id.Equals(item.id))
                    {
                        locationList.Add(i);
                    }
                }
            }
            return locationList;
        }


    }

  
}
