using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    public abstract class Character:Tile
    {
        protected int HP;
        protected int maxHP;
        protected int Damage;
        protected int[] Tiles;
      
        public enum MOVEMENT
        {
            NO_MOVEMNET,
            UP,
            DOWN,
            LEFT,
            RIGHT,
        }

        public Character(int x,int y,char symbol) : base(0, 0, TILETYPE.HERO)
        {
            
        }


        public virtual void Attack()
        {

        }

        public void isDead()
        {

        }
       

        public virtual void CheckRange()
        {

        }

        public void Move()
        {

        }

        public void ReturnMove()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
