using System;

namespace Indexer
{
    class Article
    {
        private double price;

        public string Name { get; private set; }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                    price = value;
                else
                    Console.WriteLine("Цена не может быть отрицательной");
            }
        }

        public Article(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

        public string Info()
        {
            return string.Format("Товар: {0} Цена: {1} руб.", Name, Price);
        }
    }
}
