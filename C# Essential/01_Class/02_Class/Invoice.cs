namespace Class
{
    class Invoice
    {
        public const double PERCENT_TAX = 0.18;

        public readonly int account;
        public readonly string customer;
        public readonly string provider;

        private string article;
        private int quantity;
        private float cost;
        private decimal sum;
        private bool tax;

        public int Account { get { return account; } }
        public string Customer { get { return customer; } }
        public string Provider { get { return provider; } }

        public string Article { get { return article; } }
        public int Quantity { get { return quantity; } }
        public float Cost { get { return cost; } }
        public decimal Sum { get { return sum; } }
        public bool Tax { get { return tax; } }

        public Invoice(int account, string customer, string provider) 
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public bool Purchase(string article, int quantity)
        {
            bool flag = true;
            
            switch (article)
            {
                case "PC":
                    {
                        this.cost = 35009.45f;
                        break;
                    }
                case "Laptop":
                    {
                        this.cost = 37000;
                        break;
                    }
                case "Server":
                    {
                        this.cost = 82000;
                        break;
                    }
                default:
                    {
                        flag = false;
                        break;
                    }
            }
            if (flag)
            {
                this.article = article;
                this.quantity = quantity;
            }

            return flag;
        }

        public bool CalculationCost(bool tax)
        {
            bool flag = false;
            this.tax = tax;
            if (this.tax)
            {
                this.sum = (decimal)(this.cost * this.quantity) * (decimal)PERCENT_TAX;
            }
            else
            {
                this.sum = (decimal)(this.cost * this.quantity);
            }

            return flag;
        }

        public bool CalculationCost(string article, int quantity, bool tax)
        {
            bool flag = false;
            if (Purchase(article, quantity))
            {
                flag = CalculationCost(tax);
            }
            return flag;
        }



    }
}
