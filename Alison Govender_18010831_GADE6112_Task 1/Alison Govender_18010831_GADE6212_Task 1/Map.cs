using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
     class Map
    {
        string[,] map;
        char player;
        int[] Enemies;
        int WIDTH;
        int HEIGHT;
        Random Roll = new Random();

        public Map(int minWidth,int maxWidth,int minHeight,int maxHeight,int enemies)
        {
           
            Create();
            UpdateVision();
        }

        public void UpdateVision()
        {

        }

        public void Create()
        {

        }

    }
}
