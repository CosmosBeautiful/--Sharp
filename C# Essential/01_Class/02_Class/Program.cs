using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice A = new Invoice(00119, "Nikita", "Provider PC 74");
            A.Purchase("PC", 2);
            A.CalculationCost(true);
            Console.WriteLine("Клиент: {0}, Поставщик: {1}, Товар: {2}, Количество: {3} Цена: {4}, На сумму: {5} Включая НДС: {6}" , A.Account, A.Customer, A.Article, A.Quantity, A.Cost, A.Sum, A.Tax);

            Console.ReadKey();
        }
    }
}

//Создать класс Invoice.
//В теле класса создать три поля int account, string customer, string provider, которые должны быть проинициализированы один раз(при создании экземпляра данного класса) без возможности их дальнейшего изменения.
//В теле класса создать два закрытых поля string article, int quantity
//Создать метод расчета стоимости заказа с НДС и без НДС.
//Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.
