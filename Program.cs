using System;

namespace project
{
    class Program
    {
        static void Main()
        {

            bool start = false;
            Player igrok = new Player();
            Replies.Intro(); //от автора

            if (start == false) //стартовое условие создания персонажа
            {
                    Console.WriteLine("введите пожалуйста ваше имя:");

                string input = Console.ReadLine() ?? "кажется возникла ошибка...";
                igrok.Name = input;

                if (igrok.Name == "кажется возникла ошибка...")
                {
                    Console.WriteLine("Попробуйте ввести имя ещё раз:");
                    igrok.Name = Console.ReadLine() ?? "Mr Chronica";
                }

                Console.WriteLine("Приятно познакомиться" + igrok.Name);
            }

            

        }
    }
}