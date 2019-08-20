namespace Proxy
{
    abstract class Subject
    {
        public abstract void Create();
        public abstract void Read();
        public abstract void Update();
        public abstract bool Delete();
    }
}
