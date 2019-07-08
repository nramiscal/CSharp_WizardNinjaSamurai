using System;

namespace WizardNinjaSamurai
{
    class Ninja : Human
    {
        // Ninja should have a default dexterity of 175
        public Ninja(string name) : base(name, 3, 3, 175, 100){}

        // Provide an override Attack method to Ninja, which reduces the target by 5 * Dexerity and a 20% chance of dealing an additional 10 points of damage.
        public override int Attack(Human target)
        {
            int dmg = Dexterity * 5;
            Random random = new Random();
            int chance = random.Next(0,101);
            if (chance <= 20)
            {
                dmg += 10;
            }

            int dealt = base.Attack(target, dmg);
            return dealt;
            
        }

        // Ninja should have a method called Steal, reduces a target Human's health by 5 and adds this amount to its own health.

        public void Steal(Human target)
        {
            base.Attack(target, 5);
            Health += 5;
        }
    }
}