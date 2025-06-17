using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            Player igrok = new Player();
            Console.WriteLine("made by. Mr Chronica");
            Console.WriteLine("добро пожаловать в console_game.exe");
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