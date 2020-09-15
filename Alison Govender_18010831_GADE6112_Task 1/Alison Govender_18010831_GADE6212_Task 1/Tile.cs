using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    public abstract class Tile
    {
        protected int X;
        protected int Y;

        public enum TILETYPE
        {
            HERO,
            ENEMY,
            GOLD,
            WEAPEN,
            OBSTACLE,
        }

        public Tile(int X,int Y,TILETYPE tileType)
        {
            this.X=X;
            this.Y=Y;

            tileType = TILETYPE.HERO;
            tileType = TILETYPE.ENEMY;
            tileType = TILETYPE.GOLD;
            tileType = TILETYPE.WEAPEN;
            tileType = TILETYPE.OBSTACLE;

        }

       

    }
}
