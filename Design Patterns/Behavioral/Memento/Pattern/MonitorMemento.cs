namespace Memento
{
    class MonitorMemento
    {
        public int Brightness { get; set; }
        public int Contrast { get; set; }

        public MonitorMemento(int brightness, int contrast)
        {
            this.Brightness = brightness;
            this.Contrast = contrast;
        }
    }
}
