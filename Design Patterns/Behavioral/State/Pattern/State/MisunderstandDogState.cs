using System;

namespace State
{
    internal class MisunderstandDogState : DogState
    {
        internal MisunderstandDogState()
        {
            Console.WriteLine("Собака в состоянии непонимании:");
            SitDown();
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

        private void SitDown()
        {
            Console.WriteLine("Собака садится.");
        }
    }
}