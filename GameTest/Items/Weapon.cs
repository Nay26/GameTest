using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    class Weapon : Item
    {
        //public WeaponClass weaponClass;
        public Boolean twoHanded;

        public Weapon(string id, string name, double weight, double value, int stackSize, CraftingRecipe recipe)
        {
            this.id = id;
            this.name = name;
            this.weight = weight;
            this.value = value;
            this.stackSize = stackSize;
            this.recipe = recipe;
            this.twoHanded = false;
        }

    }
}
