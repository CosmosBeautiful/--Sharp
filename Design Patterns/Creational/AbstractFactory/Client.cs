namespace AbstractFactoryNet
{
    class Client
    {
        private AbstractRod rod;
        private AbstractCap cap;
        private AbstractHousing housing;

        public Client(AbstractFactory factory)
        {
            // Абстрагирование процесса инстанцирования.
            rod = factory.CreateRod();
            cap = factory.CreateCap();
            housing = factory.CreateHousing();
        }

        public void Run()
        {
            // Абстрагирование вариантов использования.
            housing.Assemble(rod, cap);
        }
    }
}
