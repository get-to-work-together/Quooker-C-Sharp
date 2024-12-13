using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instances
{
    class Test
    {
        public static void Main()
        {
            Application.EnableVisualStyles();
            Form1 f = new Form1();
            f.Show();
            Application.Run(f);
        }
    }
}
