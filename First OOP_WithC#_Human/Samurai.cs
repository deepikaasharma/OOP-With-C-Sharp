using System;

namespace Heroes
{
    class Samurai : Human
    {
        public Samurai(string name) : base(name, 3, 3, 3, 200){}

        public override int Attack(Human target)
        {
            int remainingHealth = base.Attack(target);
            if (remainingHealth < 50)
            {
                target.Health = 0;
                Console.WriteLine($"{target.Name} was executed!");
            }
            return remainingHealth;
        }

        public void Meditate()
        {
            health = 200;
        }
    }
}