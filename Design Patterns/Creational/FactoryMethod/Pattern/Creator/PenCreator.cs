namespace FactoryMethod
{
    class PenCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new PenProduct();
        }
    }
}
