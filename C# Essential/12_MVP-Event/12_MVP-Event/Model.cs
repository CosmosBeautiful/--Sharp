namespace _12_MVP_Event
{
    class Model
    {
        private int sec;

        public string Tick()
        {
            sec++;
            return sec >= 60 ? (sec/60) + " мин " + (sec % 60) + " сек" : sec + " сек";
        }

        public void Reset()
        {
            sec = 0;
        }
    }
}
