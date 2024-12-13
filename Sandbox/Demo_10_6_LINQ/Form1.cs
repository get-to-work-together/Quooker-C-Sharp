namespace Demo_10_6_LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(Environment.SystemDirectory);
            
            var x = from f in di.GetFiles()
                    where f.Length > 100000
                    orderby f.Length descending
                    select new { f.Name, f.Length };

            this.dataGridView1.DataSource = x.ToList();
        }
    }
}
