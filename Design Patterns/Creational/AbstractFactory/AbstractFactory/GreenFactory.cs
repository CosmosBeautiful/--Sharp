namespace AbstractFactoryNet
{
    class GreenFactory : AbstractFactory
    {
        public override AbstractCap CreateCap()
        {
            return new GreenCap();
        }

        public override AbstractRod CreateRod()
        {
            return new GreenRod();
        }

        public override AbstractHousing CreateHousing()
        {
            return new GreenHousing();
        }
    }
}
