using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    class CraftingRecipe
    {
        public string recipeID;
        public string[] itemIDs;
        public double[] amount;
        public string skill;
        public int skillLevel;

        public CraftingRecipe(string recipeID, string[] id, double[] amnt, string skill, int skillLevel )
        {
            this.recipeID = recipeID;
            itemIDs = id;
            amount = amnt;
            this.skill = skill;
            this.skillLevel = skillLevel;
        }
    }
}
