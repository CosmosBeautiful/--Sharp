namespace State
{
    internal abstract class DogState
    {
        internal virtual void ActionDog(Dog dog, ActionDogType actionDogType)
        {
            ChangeState(dog, actionDogType);
        }

        protected abstract void ChangeState(Dog dog, ActionDogType actionDogType);
    }
}
