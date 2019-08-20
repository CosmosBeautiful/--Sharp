using System;

namespace Birdge
{
    class CubeAbstraction : ShapeAbstraction
    {
        public CubeAbstraction(MaterialImplementor material)
            : base(material)
        {
        }

        public override void ReadyShape()
        {
            Console.Write("Выбрана фигура - куб, ");
            base.ReadyShape();

        }
    }
}
