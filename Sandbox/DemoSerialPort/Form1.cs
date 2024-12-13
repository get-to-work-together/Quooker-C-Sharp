using System.IO.Ports;

namespace DemoSerialPort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadComPorts();
        }

        private void LoadComPorts()
        {
            try
            {
                // Get all available COM ports
                string[] ports = SerialPort.GetPortNames();

                // Populate the ComboBox or ListBox
                comboBoxPorts.Items.Clear();
                comboBoxPorts.Items.AddRange(ports);

                if (ports.Length > 0)
                {
                    comboBoxPorts.SelectedIndex = 0; // Select the first COM port
                }
                else
                {
                    MessageBox.Show("No COM ports found on this system.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading COM ports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenComPort()
        {
            try
            {
                string selectedPort = comboBoxPorts.SelectedItem.ToString();
                SerialPort serialPort = new SerialPort(selectedPort, 9600); // Default baud rate
                serialPort.Open();

                MessageBox.Show($"COM port {selectedPort} opened successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the port when done
                serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening COM port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadComPorts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenComPort();
        }

        private void comboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
