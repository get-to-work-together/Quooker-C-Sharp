namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private Processor processor = new Processor();

        public CalculatorForm()
        {
            InitializeComponent();
            this.Load += CalculatorForm_Load; // Subscribe to the Load event
        }

        private void CalculatorForm_Load(object? sender, EventArgs e)
        {
            display.Text = processor.getDisplay();
        }
    }
}
