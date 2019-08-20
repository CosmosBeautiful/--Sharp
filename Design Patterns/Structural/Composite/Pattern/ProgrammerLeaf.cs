using System;

namespace Composite
{
    class ProgrammerLeaf : Component
    {

        public ProgrammerLeaf(string name)
            : base(name)
        {
        }

        public override void Operation()
        {
            Console.WriteLine(name);
        }

        public override void Add(Component component)
        {
            throw new InvalidOperationException();
        }

        public override Component GetChild(int index)
        {
            throw new InvalidOperationException();
        }

        public override void Remove(Component component)
        {
            throw new InvalidOperationException();
        }
    }
}
