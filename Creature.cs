using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    public class Creature
    {
        private string name = string.Empty;
        private int health;
        private int health_limit = 100;
        private int damage;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }
        public int Health
        {
            get { return health; }
            set
            {
                if (value > health_limit)
                    health = health_limit;
                else
                if (value <= 0)
                    health = 0;
                else
                    health = value;
            }
        }
        public int Damage
        {
            get { return damage; }
            set
            {
                if (value <= 0)
                    damage = 0;
                else
                    damage = value;
            }
        }
    }
}
