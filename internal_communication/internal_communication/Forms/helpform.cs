using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace internal_communication
{
    public partial class helpform : Form
    {
        public helpform()
        {
            InitializeComponent();
        }

        private void helpform_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?rlz=1C1CHBF_enCA789CA789&ei=eWPDXevrDOqh_Qa5_6LACA&q=help&oq=help&gs_l=psy-ab.3..0i67l9j0.4140.8741..9059...0.1..0.122.466.0j4......0....1..gws-wiz.....0..0i71j0i131.cUMQNMSjN-Y&ved=0ahUKEwirjOGk6tblAhXqUN8KHbm_CIgQ4dUDCAs&uact=5");
        }
    }
}
