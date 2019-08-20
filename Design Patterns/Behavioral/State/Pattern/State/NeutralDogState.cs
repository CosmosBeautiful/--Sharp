using System;

namespace State
{
    internal class NeutralDogState : DogState
    {
        internal NeutralDogState()
        {
            Console.WriteLine("Собака в нейтральном состоянии:");
            Sleep();
        }

        protected override void ChangeState(Dog dog, ActionDogType actionDogType)
        {
            switch (actionDogType)
            {
                case ActionDogType.Call:
                    {
                        dog.DogState = new AttentionDogState();
                        break;
                    }
                case ActionDogType.Scare:
                    {
                        dog.DogState = new AttentionDogState();
                        break;
                    }
            }
        }

        private void Sleep()
        {
            Console.WriteLine("Собака спит.");
        }
    }
}
