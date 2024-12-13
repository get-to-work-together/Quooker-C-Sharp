using System.Diagnostics;

namespace IntroLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I've been hit!");
            Debug.WriteLine("I've been hit!!!!!");
        }
    }
}
