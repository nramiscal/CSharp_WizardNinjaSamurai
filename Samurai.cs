using System;

namespace WizardNinjaSamurai
{
    class Samurai : Human
    {
        // Samurai should have a default health of 200
        public Samurai(string name) : base(name, 3, 3, 3, 200){}

        // Provide an override Attack method to Samurai, which calls the base Attack and reduces the target to 0 if it has less than 50 remaining health points.

        public override int Attack(Human target)
        {
            int dealt = base.Attack(target);
            if (target.Health < 50)
            {
                target.Health = 0;
                Console.WriteLine($"{target.Name} IS FINISHED BY THE DEATH BLOW!");
                return 0;
            }
            return dealt;
            
        }

        // Samurai should have a method called Meditate, which when invoked, heals the Samurai back to full health

        public void Meditate()
        {
            Health = 200;
        }

    }
}