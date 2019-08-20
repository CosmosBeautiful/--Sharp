namespace AbstractFactoryNet
{
    class BlueFactory : AbstractFactory
    {
        public override AbstractCap CreateCap()
        {
            return new BlueCap();
        }

        public override AbstractRod CreateRod()
        {
            return new BlueRod();
        }

        public override AbstractHousing CreateHousing()
        {
            return new BlueHousing();
        }
    }
}
