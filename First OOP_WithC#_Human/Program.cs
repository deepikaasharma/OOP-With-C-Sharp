using System;

namespace Heroes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Human dylan = new Human("Dylan", 5, 5, 3, 100);
            Human shane = new Human("Shane");
            // Console.WriteLine(dylan.Health);
            
            Wizard dylan = new Wizard("Dylan");
            Console.WriteLine(dylan.Health);
            while (shane.Health > 50)
            {
                dylan.Attack(shane);
            }
            Console.WriteLine(shane.Health);
            dylan.Heal(shane);
            Console.WriteLine(shane.Health);
        }
    }
}