using System;
using System.Windows.Forms;

namespace _12_MVP_Event
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ViewForm());
        }
    }
}

//Создайте программу секундомер. Требуеться выводить показания секундомера в окне.
//Окно имеет кнопки запуска, остановки и сброса секундомера. 
//Для реализации секундомера используйте паттерн MVP.