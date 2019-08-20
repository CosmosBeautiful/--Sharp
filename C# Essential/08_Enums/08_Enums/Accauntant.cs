namespace Enums
{
    enum Post
    {
        Developer = 175,
        Manager = 170,
        Secretary = 165,
        Accountant = 150
    }

    static class Accauntant
    {
        public static bool AskForBonus(Post worker, int hours)
        {
            bool flag = false;

            if ((int)worker < hours)
            {
                flag = true;
            }

            return flag;
        }
    }
}
