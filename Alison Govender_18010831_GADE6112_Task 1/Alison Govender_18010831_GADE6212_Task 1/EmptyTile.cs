﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    public class EmptyTile:Tile
    {
        public EmptyTile() : base(0, 0, TILETYPE.OBSTACLE)
        {
           
        }
    }
}
