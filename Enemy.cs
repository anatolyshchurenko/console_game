using System;

namespace project
{
    class Enemy
    {

        private string name;
        private byte damage;
        private byte hp;
        private byte ex;

        public void setValue(string name, byte damage, byte hp, byte ex)
        {
            this.name = name; 
            this.damage = damage;
            this.hp = hp;
            this.ex = ex;
        }

        public Enemy(string name, byte damage, byte hp)
        {
            Console.WriteLine("враг на горизонте!");
            setValue(this.name, this.damage, this.hp, this.ex);
        }

        public void Experience()
        {
            Console.WriteLine("враг повержен!");
            Console.WriteLine("вы получили " + this.ex + "опыта" );
        }

    }
}

