using System;

namespace AbstractFactoryNet
{
    class GreenFactory : IAbstractFactory
    {
        dynamic _product;

        public dynamic Make(Product product)
        {
            // Получение полного квалифицированного имени продукта семейства - зеленая ручка.
            string name = this.GetType().Namespace + "." + "Green" + product.ToString();

            // Динамическое создание продукта семейства
            this._product = Activator.CreateInstance(Type.GetType(name));

            return this._product;
        }
    }
}
