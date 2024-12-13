namespace Blinker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void blink(int n = 10)
        {
            for (int i = 0; i < n; i++)
            {
                lblLed.Visible = true;
                Thread.Sleep(500);
                lblLed.Visible = false;
                Thread.Sleep(500);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblLed.Visible)
            {
                lblLed.Visible = false;
            }
            else
            {
                lblLed.Visible = true;
            }
        }

    }
}
