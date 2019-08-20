namespace Flyweight
{
    class UnsharedConcreteFlyweight : Flyweight
    {
        public int instanceState;

        public override void Operation(int extrinsicState)
        {
            instanceState = extrinsicState;
        }
    }
}
