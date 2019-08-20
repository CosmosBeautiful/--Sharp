namespace AbstractFactoryNet
{
    abstract class AbstractFactory
    {
        public abstract AbstractRod CreateRod();
        public abstract AbstractCap CreateCap();
        public abstract AbstractHousing CreateHousing();
    }
}
