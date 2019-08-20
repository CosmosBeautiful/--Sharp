using System;

namespace Memento
{
    class Monitor
    {
        public int Brightness { get; set; }
        public int Contrast { get; set; }

        public Monitor(int brightness, int contrast)
        {
            this.Brightness = brightness;
            this.Contrast = contrast;
        }

        public void SetSettings(MonitorMemento monitorMemento)
        {
            this.Brightness = monitorMemento.Brightness;
            this.Contrast = monitorMemento.Contrast;
        }

        public MonitorMemento SaveSettings()
        {
            return new MonitorMemento(Brightness, Contrast);
        }

        public void ReadSettings()
        {
            Console.WriteLine($"Яркость: {Brightness}, Контрастность: {Contrast}.");
        }

    }
}
