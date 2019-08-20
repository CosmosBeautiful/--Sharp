using System;

namespace _09_GC_Dispose
{
    class MyClass : IDisposable
    {

        #region IDisposable Support

        // Флаг нужен, для отслеживания была ли утилита уже вызвана?
        private bool disposedValue = false; // Для определения избыточных вызовов

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Освободить управляемое объекты
                    Console.WriteLine("Соединение с базой данных закрыто.");
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        //Переопределить метод завершения, если необходим.
         ~MyClass()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(false);

            Console.WriteLine("Выполнелся метод - Finalize");
        }

        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);

            // Метод не вызывает деструктор. Нужен если переопределен деструктор.
            GC.SuppressFinalize(this);  
        }
        #endregion

    }
}

