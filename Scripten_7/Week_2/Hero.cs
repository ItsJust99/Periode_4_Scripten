using System;
using System.Collections.Generic;
using System.Text;

namespace Week_2
{
    class Hero
    {
        /*
         * CREATE A HERO CLASS
              *  - The hero has the following attributes:
              *     - Name : every hero needs a name
              *     - Hit points : when there are no hit points left the hero is incapacitated
              *     - Attack bonus 
              *  - The hero can do the following:
              *     - Attack : the hero does 1D12 damage + the attack bonus
              *     - Defend : when the hero defends it takes only half damage
         */
        private string name;
        private int hitPoint;
        private float attackBonus;
        private bool alive;

        public string Name
        {
                    
            get { return this.name; }
            set { this.name = value; }
            
        }

        public int hitpoint
        {
            get { return this.hitPoint; }
        }
    }
}
