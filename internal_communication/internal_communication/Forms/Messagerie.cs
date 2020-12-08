using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using internal_communication.Forms;
using MySql.Data.MySqlClient;

namespace internal_communication
{
    public partial class Messagerie : Form
    {
        string Connec = "datasource=localhost;port=3306;username=root;password=jmsb;server=127.0.0.2;database=internal_communication_4;persistsecurityinfo=True";
        DataTable table2 = new DataTable();
        int row = 0;
        int user_id_messages;
        int project_id;
        public Messagerie()
        {
            InitializeComponent();
        }

        private void Messagerie_Load(object sender, EventArgs e)
        {
                try
            {
                

                subjnme_lbl.Text = project_selection_form.subject;
                subj_id_lbl.Text = project_selection_form.subject_ID;

                MySqlConnection connection = new MySqlConnection(Connec);
                connection.Open();
                string query3 = @"SELECT message_content, user_name
                                FROM internal_communication_4.messages AS m1 JOIN internal_communication_4.subjects AS s1 
                                ON m1.subjects_subject_id = s1.subject_id
                                JOIN user AS u1
                                ON m1.user_user_id = u1.user_id
                                WHERE (subject_selection = 1)";
                MySqlDataAdapter adapte = new MySqlDataAdapter(query3, connection);
                adapte.Fill(table2);
                while (row < table2.Rows.Count)
                {
                    Message_class mes = new Message_class();
                    mes.User_name = (string)table2.Rows[row]["message_content"];
                    mes.Message_content = (string)table2.Rows[row]["user_name"];
                    message_lstbx.Items.Add(mes.Showmessage());
                    row += 1;
                }
                subjnme_lbl.Text = (string)table2.Rows[0]["subject_name"];
                subj_id_lbl.Text = table2.Rows[0]["subject_id"].ToString();
                connection.Close();
                row = 0;
                
            }
            catch
            { }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            project_selection_form slect = new project_selection_form();
            slect.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            project_selection_form slect = new project_selection_form();
            foreach (Form var in Application.OpenForms)
            {
                var.Close();
            }
            slect.ShowDialog();
        }

        private void message_lstbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(Connec);
                connection.Open();

                string query = @"SELECT user_id FROM  internal_communication_4.users 
                               WHERE user_name = " + login_form.user_name + " ";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader MyReader2;
                MyReader2 = command.ExecuteReader();
                while (MyReader2.Read())
                {
                    user_id_messages = Convert.ToInt32(MyReader2.GetString(0));
                }

                connection.Close();


                MySqlConnection connection3 = new MySqlConnection(Connec);
                connection3.Open();

                string query3 = @"SELECT Project_project_id FROM  internal_communication_4.subjects 
                               WHERE subject_id = " + subj_id_lbl.Text + " ";
                MySqlCommand command3 = new MySqlCommand(query3, connection3);
                MySqlDataReader MyReader4;
                MyReader4 = command3.ExecuteReader();
                while (MyReader4.Read())
                {
                    project_id = Convert.ToInt32(MyReader4.GetString(0));
                }

                connection3.Close();
            }

            catch
            {
                MessageBox.Show("error in data integrity");
            }

            try
            {
                Message_class mes = new Message_class();
                mes.Message_content = input_txtbx.Text;
                mes.Subject_id = Convert.ToInt32(subj_id_lbl.Text);
                mes.User_id = user_id_messages;
                mes.Project_id = project_id;
                mes.Message_posting = DateTime.Now;

                MySqlConnection connection2 = new MySqlConnection(Connec);
                connection2.Open();

                MySqlCommand command2 = connection2.CreateCommand();
                command2.CommandText = @"INSERT INTO internal_communication_4.messages
                                                (user_user_id,subjects_subject_id,subjects_Project_project_id,message_content, message_posting) 
                                     VALUES( @user_user_id,  @subjects_subject_id, @subjects_Project_project_id, @message_content, @message_posting)";
                command2.Parameters.AddWithValue("@user_user_id", mes.User_id);
                command2.Parameters.AddWithValue("@subjects_subject_id", mes.Subject_id);
                command2.Parameters.AddWithValue("@subjects_Project_project_id", mes.Project_id);
                command2.Parameters.AddWithValue("@message_content", mes.Message_content);
                command2.Parameters.AddWithValue("@message_posting", mes.Message_posting);
                command2.ExecuteNonQuery();

                connection2.Close();

                message_lstbx.Items.Add(mes.Showmessage());
            }

            catch
            {
                MessageBox.Show("could not add message");
            }
        }

        private void input_txtbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
