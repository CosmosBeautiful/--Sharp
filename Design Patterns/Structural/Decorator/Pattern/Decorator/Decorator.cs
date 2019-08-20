namespace Decorator
{
    abstract class Decorator : PizzaComponent
    {
        public PizzaComponent Component { protected get; set; }

        public override void MakePizza()
        {
            if (Component != null)
                Component.MakePizza();
        }
    }
}
