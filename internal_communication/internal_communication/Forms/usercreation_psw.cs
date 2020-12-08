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
    public partial class usercreation_psw : Form
    {   string pass = "infinie";
        int i = 0;
        public usercreation_psw()
        {
            InitializeComponent();
        }

        private void nxt_btn_Click(object sender, EventArgs e)
        {
        
            {
                if (psw_txtbx.Text == pass)
                {
                    New_user_create nw = new New_user_create();
                    nw.Show();
                }
                else
                {
                    MessageBox.Show("Wrong password");
                    i++;
                    if (i == 3)
                    {
                        MessageBox.Show("No more tries left");
                        this.Close();
                    }
                }
            }
     
        }

        private void bck_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usercreation_psw_Load(object sender, EventArgs e)
        {
           
        }
    }
}
