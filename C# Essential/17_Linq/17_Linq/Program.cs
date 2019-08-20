using System;

namespace _17_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            dynamic query = controller.QueryUserCars();

            foreach (var user in query)
            {
                Console.WriteLine("Клиент: {0} Машина: {1}, {2}, {3}, {4}", user.Name, user.Mark, user.Model, user.Year, user.Color);
            }

            Console.ReadKey();

        }
    }
}

//Представьте, что вы пишите приложение для Автостанции и вам необходимо создать простую
//коллекцию автомобилей со следующими данными: Марка автомобиля, модель, год выпуска, цвет.
//А также вторую коллекцию с моделью автомобиля, именем покупателя и его номером телефона.
//Используя простейший LINQ запрос, выведите на экран информацию о покупателе одного из
//автомобилей и полную характеристику приобретенной ними модели.
