using System;

namespace State
{
    internal class AttentionDogState : DogState
    {
        internal AttentionDogState()
        {
            Console.WriteLine("Собака в состоянии внимания:");
            Listen();
        }

        protected override void ChangeState(Dog dog, ActionDogType actionDogType)
        {
            switch (actionDogType)
            {
                case ActionDogType.Call:
                    {
                        dog.DogState = new JoyDogState();
                        break;
                    }
                case ActionDogType.Scare:
                    {
                        dog.DogState = new SadnessDogState();
                        break;
                    }
            }
        }

        private void Listen()
        {
            Console.WriteLine("Собака слушает.");
        }
    }
}
