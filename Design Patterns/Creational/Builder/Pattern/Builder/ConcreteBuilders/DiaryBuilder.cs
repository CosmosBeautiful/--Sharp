using System;

namespace Builder
{
    // ConcreteBuilder
    class DiaryBuilder : Builder
    {
        Diary diary = new Diary();

        public Diary GetNotebook()
        {
            Console.WriteLine("Произведен ежедневник!\n");
            return diary;
        }

        //Методы - abstract Builder
        public override void MakeCover()
        {
            diary.Add(new Cover());
        }

        public override void PrintMarkup()
        {
            diary.Add(new Markup());
        }

        public override void ProdusePaper()
        {
            diary.Add(new Paper());
        }

    }
}
