using System;

namespace ClassRoom
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ExcelentPupil.Stydy()");
        }
        public override void Read()
        {
            Console.WriteLine("ExcelentPupil.Read()");
        }
    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GoodPupil.Stydy()");
        }
        public override void Read()
        {
            Console.WriteLine("GoodPupil.Read()");
        }
    }

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupil.Stydy()");
        }
        public override void Read()
        {
            Console.WriteLine("BadPupil.Read()");
        }
    }
}
