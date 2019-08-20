using System.Collections;

namespace Observer
{
    abstract class AbstractSubject
    {
        private ArrayList observers = new ArrayList();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
            Notify();
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }
    }
}
