namespace Mediator
{
    abstract class Mediator
    {
        public abstract void Send(string order, Colleague colleague);
    }
}
