using System;

namespace project
{
    class Player
    {

        private string name;
        private byte hp;
        
        public string Name
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

