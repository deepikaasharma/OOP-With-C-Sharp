using System;

namespace Heroes
{
    class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            health = 50;
        }

        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            health += dmg;
            if (health > 50)
            {
                health = 50;
            }
            return base.Attack(target, dmg);
        }

        public void Heal(Human target)
        {
            target.Health += Intelligence * 10;
        }
    }
}