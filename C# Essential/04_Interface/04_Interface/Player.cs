using System;

namespace Interface
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Проигрывание музыки");
        }

        public void Record()
        {
            Console.WriteLine("Начало записи");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Музыка приостановленна");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Музыка остановлена");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Запись приостановлена");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Запись остановлена");
        }
    }
}
