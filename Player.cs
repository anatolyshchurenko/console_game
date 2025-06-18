using System;

namespace project
{
    class Player
    {

        private string name;
        private byte hp;
        private byte damage;
        private byte lvl;


        public string Name //проверка имени
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
                else
                    name = "Mr Chronica";
            }
        } 
        

    }
}

