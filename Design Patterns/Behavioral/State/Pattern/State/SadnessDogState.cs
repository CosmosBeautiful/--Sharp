using System;

namespace State
{
    internal class SadnessDogState : DogState
    {
        internal SadnessDogState()
        {
            Console.WriteLine("Собака в состоянии грусти:");
            RunAway();
        }

        protected override void ChangeState(Dog dog, ActionDogType actionDogType)
        {
            switch (actionDogType)
            {
                case ActionDogType.Call:
                    {
                        dog.DogState = new NeutralDogState();
                        break;
                    }
                case ActionDogType.Scare:
                    {
                        dog.DogState = new OffendDogState();
                        break;
                    }
            }
        }

        private void RunAway()
        {
            Console.WriteLine("Собака убегает.");
        }
    }
}
