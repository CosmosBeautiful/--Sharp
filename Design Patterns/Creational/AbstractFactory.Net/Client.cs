using System;

namespace AbstractFactoryNet
{
    //Перечесления
    enum Product
    {
        Rod,
        Cap,
        Housing
    }

    enum Factory
    {
        GreenFactory,
        BlueFactory
    }

    //Клиент
    class Client
    {
        dynamic _factory;
        dynamic _productRod;
        dynamic _productCap;
        dynamic _productHousing;

        public Client(Factory factory)
        {
            // Получение полного квалифицированного имени фабрики в строковом представлении.
            string name = this.GetType().Namespace + "." + factory.ToString();

            // Динамическое создание соответствующей фабрики. 
            this._factory = Activator.CreateInstance(Type.GetType(name));

            // Порождение продуктов.
            this._productRod = this._factory.Make(Product.Rod);
            this._productCap = this._factory.Make(Product.Cap);
            this._productHousing = this._factory.Make(Product.Housing);
        }

        public void Run()
        {
            // Абстрагирование вариантов использования.
            //Intellisense с такой реализацией не работает (dynamic) 
            _productHousing.Assemble(_productRod, _productCap);
        }
    }
}
