using System;

namespace WizardNinjaSamurai
{
    class Wizard : Human
    {
        // Wizard should have a default health of 50 and Intelligence of 25
        public Wizard(string name) : base(name, 3, 25, 3, 50) {}

        // Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence and heals the Wizard by the amount of damage dealt
        public override int Attack(Human target)
        {
            int dealt = base.Attack(target, Intelligence * 5);
            Health -= dealt;
            return dealt;
        }

        // Wizard should have a method called Heal, which when invoked, heals a target Human by 10 * Intelligence

        public void Heal(Human target)
        {
            target.Health += Intelligence * 10;
        }

    }
}