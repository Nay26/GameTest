using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    class MapTile
    {
        public List<ItemStack> tileItemsList;
        public List<Entity> tileEntityList;
        public char tileImage;

        public MapTile()
        {
            tileItemsList = new List<ItemStack>();
            tileEntityList = new List<Entity>();
            tileImage = '-';
        }

        public void UpdateTileImage()
        {
            Boolean playerExists = false;
            foreach (var entity in tileEntityList)
            {
                if (entity.GetType() == typeof(Player))
                {
                    playerExists = true;
                }              
            }

            if (playerExists)
            {
                tileImage = '0';
            }
            else if (tileItemsList.Count > 0)
            {
                tileImage = '*';           
            }
            else
            {
                tileImage = '-';
            }

           
        }
    }
}
