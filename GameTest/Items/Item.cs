using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    class Item
    {
        public string id;
        public string name;
        public double weight;
        public double value;
        public int stackSize;
        public CraftingRecipe recipe;

        public Item(string id, string name, double weight, double value, int stackSize, CraftingRecipe recipe)
        {
            this.id = id;
            this.name = name;
            this.weight = weight;
            this.value = value;
            this.stackSize = stackSize;
            this.recipe = recipe;
        }
       
    }
}
