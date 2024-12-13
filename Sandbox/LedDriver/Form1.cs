namespace LedDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void handleColorChange(object sender, EventArgs e)
        {
            lblLed.BackColor = Color.FromArgb(trbRed.Value, trbGreen.Value, trbBlue.Value);
        }

        private void trbGreen_Scroll(object sender, EventArgs e)
        {

        }
    }
}
