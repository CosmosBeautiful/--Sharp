using System;

namespace AbstractFactoryNet
{
    class BlueFactory : IAbstractFactory
    {
        dynamic _product;

        public dynamic Make(Product product)
        {
            // Получение полного квалифицированного имени продукта семейства - синия ручка.
            string name = this.GetType().Namespace + "."+ "Blue" + product.ToString();

            // Динамическое создание продукта семейства
            this._product = Activator.CreateInstance(Type.GetType(name));

            return this._product;
        }
    }
}
