using System;

namespace ClassRoom
{
    class ClassRoom
    {
        Pupil[] pupil = new Pupil[4];

        Random random = new Random();

        public ClassRoom(Pupil[] MasPupil)
        {
            int Len = MasPupil.Length;

            for (int i = 0; i < 4 ; i++)
            {
                if (i < Len)
                {
                    pupil[i] = MasPupil[i];
                }
                else
                {
                    pupil[i] = GeneratePupil();
                }
            }
        }

        public Pupil GeneratePupil()
        {
            Pupil pupil;

            switch (random.Next(1, 4))
            {
                case 1:
                    {
                        pupil = new ExcelentPupil();
                        break;
                    }
                case 2:
                    {
                        pupil = new GoodPupil();
                        break;
                    }
                default:
                    {
                        pupil = new BadPupil();
                        break;
                    }
            }
            return pupil;
        }

        public void Study()
        {
            foreach (Pupil p in pupil)
            {
                p.Study();
            }
        }
        public void Read()
        {
            foreach (Pupil p in pupil)
            {
                p.Read();
            }
        }
    }
}
