using System;

namespace State
{
    internal class JoyDogState : DogState
    {
        internal JoyDogState()
        {
            Console.WriteLine("Собака в состоянии радости:");
            Run();
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
                        dog.DogState = new MisunderstandDogState();
                        break;
                    }
            }
        }

        private void Run()
        {
            Console.WriteLine("Собака прибегает.");
        }
    }
}
