using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    public class Enemy : Character
    {
        Random R = new Random();

        public Enemy(int x,int y,char symbol) : base(0, 0, 'G')
        {

        }



        public override string ToString()
        {
            return base.ToString();
        }


    }




}


