namespace AbstractFactoryNet
{
    interface IAbstractFactory
    {
        dynamic Make(Product product);
    }
}
