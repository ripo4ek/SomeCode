using System;

namespace RepitableCode_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    abstract class AliveEntity //как в данном случае лучше задать проверку на состояние живой мертвый без создания доп функционала?
    {
        public int Health;

        public abstract void TakeDamage(int damage);

        public void IsAlive() 
        {
            if (Health <= 0)
            {
                Console.WriteLine("Я умер");
            }
        }

    }
    class Wombat : AliveEntity
    {
        public int Armor;

        public override void TakeDamage(int damage)
        {
            Health -= damage - Armor;
            IsAlive();
        }
    }

    class Human : AliveEntity
    {
        public int Agility;

        public override void TakeDamage(int damage)
        {
            Health -= damage / Agility;
            IsAlive();
        }
    }
}
