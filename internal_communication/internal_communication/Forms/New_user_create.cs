using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace internal_communication
{
    public partial class New_user_create : Form
    {
        int pass;
        int psw;
        int ident;
        string position;
        string name;
        int identification;
        int pass2;
        public New_user_create()
        {
            InitializeComponent();
        }

        public void New_user_create_Load(object sender, EventArgs e)
        {
           
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
          
            if (int.TryParse(password_txtbx.Text, out psw) || int.TryParse(ID_txtbx.Text, out ident))
                
            {
                psw = int.Parse(password_txtbx.Text);
                ident = int.Parse(ID_txtbx.Text);

                user_class user = new user_class();
                user.ID = ident;
                user.Name = name_txbx.Text;
                user.Password = psw;
                user.Position = postion_txtbx.Text;
                identification = user.ID;
                
                
                pass = user.Password;
                identification = user.ID;
                position = user.Position;
                name = user.Name;
               

            }
            else
            { MessageBox.Show("Please input a number password AND ID"); }
           
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=jmsb;server=127.0.0.2;database=internal_communication_4;persistsecurityinfo=True");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    connection1_lbl.Text = "connected";
                    connection1_lbl.ForeColor = Color.Green;

                }
                else
                {
                    connection1_lbl.Text = "Not connected";
                    connection1_lbl.ForeColor = Color.Red;
                }
              

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO internal_communication_4.user(user_id,user_password,user_position,user_name) VALUES( @user_id,  @user_password, @user_position, @user_name)";
                command.Parameters.AddWithValue("@user_id", identification);
                command.Parameters.AddWithValue("@user_password", pass);
                command.Parameters.AddWithValue("@user_position", position);
                command.Parameters.AddWithValue("@user_name", name);
                command.ExecuteNonQuery();
               
                MessageBox.Show("New user " + identification + " successfully created!");

                connection.Close();

               
                login_form lgin = new login_form();

                foreach (Form var in Application.OpenForms)
                {
                    var.Hide();
                }

                postion_txtbx.Text = "";
                name_txbx.Text = "";
                pass = 0;
                lgin.Show();
            }
            catch
            {
                MessageBox.Show("Cannot create user, ID already used ?");
                foreach (Form var in Application.OpenForms)
                {
                    var.Hide();
                }
                login_form lgin = new login_form();
                lgin.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name_txbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void password_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void postion_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(deluser_txtbx.Text, out pass2) )

            {
                user_class use = new user_class();
                use.ID = int.Parse(deluser_txtbx.Text);
                pass2 = use.ID;


            }
            else
            { MessageBox.Show("Please input a correct ID"); }
            string message = "Do you want to proceed?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {




                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=jmsb;server=127.0.0.2;database=internal_communication_4;persistsecurityinfo=True");
                connection.Open();
                string query = "DELETE FROM `internal_communication_4`.`user` WHERE (`user_id` = " + this.pass2 + ");";
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataReader MyReader2;

                MyReader2 = command.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                connection.Close();
                MessageBox.Show("user successfully deleted!");
               
                login_form lgin = new login_form();

                foreach (Form var in Application.OpenForms)
                {
                    var.Hide();
                }

                postion_txtbx.Text = "";
                name_txbx.Text = "";
                pass = 0;
                lgin.Show();
            }
            else
            {
                login_form lg = new login_form();
                foreach (Form var in Application.OpenForms)
                {
                    var.Hide();
                }
                postion_txtbx.Text = "";
                name_txbx.Text = "";
                pass = 0;
                lg.Show();
            }
        }
    }
}
