using System;

namespace Lab5
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Cat
    {
        // Автозгенерований параметр тільки для зчитування Name типу string.
        public string Name { get; }

        public Gender Gender { get; }

        private double _energy;

        public static readonly double MaxEnergy = 20;

        public static readonly double MinEnergy = 0;

        public static readonly double SleepEnergyGain = 10;

        public static readonly double JumpEnergyDrain = 0.5;


        public double Energy
        {
            get { return _energy; }
            private set
            {
                if (value < MinEnergy)
                {
                    throw new ArgumentException("Not enough energy to jump");
                }
                else if (value > MaxEnergy)
                {
                    _energy = MaxEnergy;
                }
                else
                {
                    _energy = value;
                }
            }
        }

  
        public Cat(string name, Gender gender)
        {
            Name = name;
            Gender = gender;
            Energy = MaxEnergy;
        }

       
        public void Jump()
        {
            Energy -= JumpEnergyDrain;
        }

    
        public void Sleep()
        {
            Energy += SleepEnergyGain;
        }
    }

    class Program
    {
        static void Main()
        {
            // Створення екземплярів класу Cat
            Cat cat1 = new Cat("Барсік", Gender.Male);
            Cat cat2 = new Cat("Стьопа", Gender.Female);

            // Виведення назви, площі та периметра усіх фігур
            Console.WriteLine($"{cat1.Name} ({cat1.Gender}): Energy = {cat1.Energy}");
            Console.WriteLine($"{cat2.Name} ({cat2.Gender}): Energy = {cat2.Energy}");

            // Виклик методів Jump та Sleep для перевірки
            cat1.Jump();
            cat2.Sleep();

            Console.WriteLine($"{cat1.Name} ({cat1.Gender}): Energy after jump = {cat1.Energy}");
            Console.WriteLine($"{cat2.Name} ({cat2.Gender}): Energy after sleep = {cat2.Energy}");

            Console.ReadLine();
        }
    }
}
