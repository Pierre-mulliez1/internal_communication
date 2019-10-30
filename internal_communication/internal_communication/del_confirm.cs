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
    public partial class del_confirm : Form
    {
        bool confirmation;
        public del_confirm()
        {
            InitializeComponent();
        }
        public bool Showconfirmation()
        {  
           
            if (del_txtbx.Text != "YES")
            {
               
                confirmation = false;
            }
            else
            {
                confirmation = true;
            }
           
            return confirmation;
            
           
        }

        public void confirm_btn_Click(object sender, EventArgs e)
        {
            if (Showconfirmation() == false)
            {
                MessageBox.Show("please type YES");
            }
            else
            {
                this.Close();
            }

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
