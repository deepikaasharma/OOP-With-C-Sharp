using System;

namespace Heroes
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            int dmg = 5 * Dexterity;
            Random rInt = new Random();
            if (rInt.Next(1,5) == 1)
            {
                dmg += 10;
            }
            return base.Attack(target, dmg);
        }

        public void Steal(Human target)
        {
            target.Health -= 5;
            health += 5;
        }
    }
}