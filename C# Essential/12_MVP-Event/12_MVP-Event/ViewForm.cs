using System;
using System.Windows.Forms;

namespace _12_MVP_Event
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
            new Presenter(this);
        }
        
        
        private event EventHandler start;
        private event EventHandler stop;
        private event EventHandler reset;

        public event EventHandler Start
        {
            add { start += value; }
            remove { start -= value; }
        }

        public event EventHandler Stop
        {
            add { stop += value; }
            remove { stop -= value; }
        }

        public event EventHandler Reset
        {
            add { reset += value; }
            remove { reset -= value; }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            start.Invoke(sender, e);
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            stop.Invoke(sender, e);
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            reset.Invoke(sender, e);
        }
    }
}
