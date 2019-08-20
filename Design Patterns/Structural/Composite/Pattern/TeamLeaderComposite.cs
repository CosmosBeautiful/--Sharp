using System;
using System.Collections;

namespace Composite
{
    class TeamLeaderComposite : Component
    {
        ArrayList nodes = new ArrayList();

        public TeamLeaderComposite(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            nodes.Add(component);
        }

        public override Component GetChild(int index)
        {
            return nodes[index] as Component;
        }

        public override void Operation()
        {
            Console.WriteLine(name);

            foreach (Component item in nodes)
                item.Operation();
        }

        public override void Remove(Component component)
        {
            nodes.Remove(component);
        }
    }
}
