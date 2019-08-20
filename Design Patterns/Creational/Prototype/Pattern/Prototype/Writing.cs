
namespace Prototype
{
    abstract class Writing
    {
        public string Color { get; private set; }

        public Writing(string color)
        {
            this.Color = color;
        }

        public abstract Writing Clone();
    }
}
