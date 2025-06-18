using System;

namespace project
{
    class Items
    {

        private string name;
        private byte damage_received;
        private string info;


        public void setValue_Item(string name, byte damage_received, string info) //назначение свойств
        {
            this.name = name;
            this.damage_received = damage_received;
            this.info = info;
        }

        public Items(string name, byte damage, byte hp) //конструктор предмета
        {
            setValue_Item(this.name, this.damage_received, this.info);
            Console.WriteLine("у вас новое оружие!");
            Console.WriteLine("вы получили:" + this.name);
        }
    }
}

