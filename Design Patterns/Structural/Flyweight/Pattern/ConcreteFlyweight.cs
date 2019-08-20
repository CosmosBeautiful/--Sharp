namespace Flyweight
{
    class ConcreteFlyweight : Flyweight
    {
        public int objectState;

        public override void Operation(int extrinsicState)
        {
            objectState = extrinsicState;
        }
    }
}
