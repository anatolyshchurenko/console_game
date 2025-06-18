using System;

namespace project
{
    class Enemy
    {

        private string name;
        private byte damage;
        private byte hp;
        private byte ex;

        public void setValue_Enemy(string name, byte damage, byte hp, byte ex) //назначение свойств
        {
            this.name = name; 
            this.damage = damage;
            this.hp = hp;
            this.ex = ex;
        }

        public Enemy(string name, byte damage, byte hp) //конструктор врага
        {
            setValue_Enemy(this.name, this.damage, this.hp, this.ex);
            Console.WriteLine("на горизонте " + this.name + "!");
        }

        public void Experience() //вывод опыта
        {
            Console.WriteLine("враг повержен!");
            Console.WriteLine("вы получили " + this.ex + "опыта" );
        }

    }
}

