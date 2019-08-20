namespace Birdge
{
    abstract class ShapeAbstraction
    {
        protected MaterialImplementor material = null;

        public ShapeAbstraction(MaterialImplementor material)
        {
            this.material = material;
        }

        public virtual void ReadyShape()
        {
            material.Pour();
        }

    }
}
