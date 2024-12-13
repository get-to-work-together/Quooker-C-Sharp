namespace DemoBlinker
{
    public partial class Form1 : Form
    {
        private Led Led1;
        private Led Led2;
        private Led Led3;
        private Led Led4;
        private Led Led5;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            Led1.StartBlinking();
        }
        private void btnStart2_Click(object sender, EventArgs e)
        {
            Led2.StartBlinking();
        }
        private void btnStart3_Click(object sender, EventArgs e)
        {
            Led3.StartBlinking();
        }
        private void btnStart4_Click(object sender, EventArgs e)
        {
            Led4.StartBlinking();
        }
        private void btnStart5_Click(object sender, EventArgs e)
        {
            Led5.StartBlinking();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Led1 = new Led(lblLed1);
            Led2 = new Led(lblLed2);
            Led3 = new Led(lblLed3);
            Led4 = new Led(lblLed4);
            Led5 = new Led(lblLed5);
        }
    }
}
