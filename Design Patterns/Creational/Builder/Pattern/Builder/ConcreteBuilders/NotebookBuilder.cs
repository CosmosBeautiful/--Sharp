using System;

namespace Builder
{
    // ConcreteBuilder
    class NotebookBuilder : Builder
    {
        Notebook notebook = new Notebook();


        public Notebook GetNotebook()
        {
            Console.WriteLine("Произведена тетрадь!\n");
            return notebook;
        }

        //Методы - abstract Builder
        public override void MakeCover()
        {
            notebook.Add(new Cover());
        }

        public override void PrintMarkup()
        {
            notebook.Add(new Markup());
        }

        public override void ProdusePaper()
        {
            notebook.Add(new Paper());
        }
    }
}
