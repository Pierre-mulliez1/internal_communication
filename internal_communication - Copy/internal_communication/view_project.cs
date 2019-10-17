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
    public partial class view_project : Form
    {
        public view_project(ListBox.SelectedObjectCollection SelectedItem)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void input_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void subj_btn_Click(object sender, EventArgs e)
        {
          
        }

        private void project_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
