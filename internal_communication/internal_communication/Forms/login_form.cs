using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using internal_communication.DBhelper;
using internal_communication.Forms;
using MySql.Data.MySqlClient;


namespace internal_communication
{
    
    public partial class login_form : Form
    {
        int pass;
        int psw;
        string nme;
        int log_now;
        DateTime login;
        string loginn;
        bool okay = false;
        public static string user_position;
        public static string user_name;
        // optional : public static string user_access;


        public login_form()
        {
            InitializeComponent();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=jmsb;server=127.0.0.2;database=internal_communication_4;persistsecurityinfo=True");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    connection_lbl.Text = "connected";
                    connection_lbl.ForeColor = Color.Green;

                }
                else
                {
                    connection_lbl.Text = "Not connected";
                    connection_lbl.ForeColor = Color.Red;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nxt_btn_Click(object sender, EventArgs e)
        {
            


            if (int.TryParse(password_txtbx.Text, out psw))

            {  psw = int.Parse(password_txtbx.Text);
               
                user_class clss = new user_class();
                clss.Name = User_txtbx.Text;
                clss.Password = psw;
               
                nme = clss.Name;
                pass = clss.Password;

            }
            else
            { MessageBox.Show("Please input a correct Password(number)"); }

            try
            {
               
                log_now = 1;
                login = DateTime.Now;
                loginn = login.ToString();
               

                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=jmsb;server=127.0.0.2;database=internal_communication_4;persistsecurityinfo=True");

                string query1 = "SELECT user_name, user_password, user_position FROM internal_communication_4.user WHERE (user_name LIKE '" + this.nme + "' AND user_password = '" + this.pass + "');";
                connection.Open();
               // dbhellper db = new dbhellper();
               // db.connexionopen("open", query1); 
                MySqlCommand command = new MySqlCommand(query1, connection);
                MySqlDataReader MyReader2;
                MyReader2 = command.ExecuteReader();
                while (MyReader2.Read())
                {
                    if (MyReader2.GetString(0) != null)
                        {
                        okay = true;
                    }
                }
                if (okay == true)
                {
                    user_name = nme;
                    user_position = MyReader2["user_position"].ToString();
                    project_selection_form frm = new project_selection_form();
                    frm.Show();
                    this.Hide();
                    connection.Close();


                    Random rnd = new Random();
                    int logid = rnd.Next(1, 100000);

                    logs_class log = new logs_class();
                    log.ID = logid;
                    log.Log_current = log_now;
                    log.Log_in = loginn;

                    connection.Open();
                  
                //how to insert foreign key values 
                    
                    string query3 = "INSERT INTO internal_communication_4.logs(log_id,log_in,user_user_id,log_current) VALUES( @log_id, @log_in, (SELECT user_id FROM internal_communication_4.user WHERE (user_name LIKE '" + this.nme + "' AND user_password = '" + this.pass + "')), @log_current)";
                    MySqlCommand comm = connection.CreateCommand();
                    comm.CommandText = query3;
                    comm.Parameters.AddWithValue("@log_id", log.ID);
                    comm.Parameters.AddWithValue("@log_in", log.Log_in);
                    comm.Parameters.AddWithValue("@log_current", log.Log_current);
                    comm.ExecuteNonQuery();
                    connection.Close();


                    
                }

                else
                {
                    MessageBox.Show("Wrong password or/and username");
                }
                
                
                
               
            }
            catch
           { MessageBox.Show("source code error"); }
            
        }
           


        

        private void password_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("please input your username (your name !) ) and password");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usercreation_psw pw = new usercreation_psw();
            pw.Show();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
