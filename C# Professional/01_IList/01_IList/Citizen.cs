using System;

namespace _01_IList
{
    public class Citizen
    {
        public string FirstName;
        public string LastName;
        public string Passport;

        public Citizen(string FirstName, string LastName, string Passport)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Passport = Passport;
        }

        public override string ToString()
        {
            return String.Format("Имя: {0} {1}, Паспорт: {2}",FirstName, LastName, Passport);
        }
    }
}
