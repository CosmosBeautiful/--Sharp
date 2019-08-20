namespace COR
{
    abstract class Handler
    {
        public Handler Successor { get; set; }

        public Handler SetNext(Handler nextHandler)
        {
            this.Successor = nextHandler;
            return nextHandler;
        }

        public virtual void Request(string name, string text)
        {
            if (this.Successor != null)
            {
                this.Successor.Request(name, text);
            }

            //null;
        }



    }
}
