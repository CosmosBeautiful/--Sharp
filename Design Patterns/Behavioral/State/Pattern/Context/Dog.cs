namespace State
{
    public class Dog
    {
        internal DogState  DogState { get; set; }

        public Dog()
        {
            DogState = new NeutralDogState();
        }

        public void Hear(ActionDogType actionDogType)
        {
            DogState.ActionDog(this, actionDogType);
        }
    }
}
