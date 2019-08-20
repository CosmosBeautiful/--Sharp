using System;
using System.Windows.Forms;

namespace _12_MVP_Event
{
    class Presenter
    {
        //MVP
        private readonly Model model;
        private readonly ViewForm viewForm;

        public Presenter(ViewForm viewForm)
        {
            model = new Model();
            this.viewForm = viewForm;

            //Подписка на события
            viewForm.Start += ViewStart;
            viewForm.Stop += ViewStop;
            viewForm.Reset += ViewReset;
            viewForm.timer.Tick += TimerTick;

            viewForm.timer.Start();
            viewForm.timer.Enabled = false;

        }

        private void ViewStart(object sender, EventArgs e)
        {
            viewForm.timer.Enabled = true;
        }

        private void ViewStop(object sender, EventArgs e)
        {
            viewForm.timer.Enabled = false;
        }

        private void ViewReset(object sender, EventArgs e)
        {
            viewForm.timer.Stop();
            viewForm.tBSecond.Clear();
            model.Reset();
            viewForm.timer.Enabled = false;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            viewForm.tBSecond.Text = model.Tick();
        }
    }
}
