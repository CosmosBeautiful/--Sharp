using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            //IPlayable play = player as IPlayable;
            //IRecodable record = player as IRecodable;

            //play.Play();
            //play.Stop();
            //record.Record();
            //record.Stop();

            player.Play();
            (player as IPlayable).Stop();

            player.Record();
            (player as IRecodable).Stop();

            Console.ReadKey();
        }
    }
}

//Создайте 2 интерфейса IPlayable и IRecodable.В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно. 
//Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
//Написать программу, которая выполняет проигрывание и запись.

