using System;

namespace State
{
    internal class OffendDogState : DogState
    {
        internal OffendDogState()
        {
            Console.WriteLine("Собака в состоянии обиды:");
            SitDown();
        }

        protected override void ChangeState(Dog dog, ActionDogType actionDogType)
        {
            switch (actionDogType)
            {
                case ActionDogType.Call:
                    {
                        dog.DogState = new SadnessDogState();
                        break;
                    }
                case ActionDogType.Scare:
                    {
                        dog.DogState = new OffendDogState();
                        break;
                    }
            }
        }

        private void SitDown()
        {
            Console.WriteLine("Собака прячется.");
        }
    }
}