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

namespace internal_communication.Forms
{
    public partial class subject_create : Form
    {
        string Connec = "datasource=localhost;port=3306;username=root;password=jmsb;server=127.0.0.2;database=internal_communication_4;persistsecurityinfo=True";
        public subject_create()
        {
            InitializeComponent();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            //generate random id
            Random rnd = new Random();
            int subjid = rnd.Next(1, 100000);


            //initialize subject class
            Subject_class sub = new Subject_class();
            sub.Subject_id = subjid;
            sub.Subject = subject_txtbx.Text;
            sub.Project_id = Convert.ToInt32(project_id_lbl.Text);



            try
            {
                /* string[] projectdiv = project.Split(',');
                 Subject_class sub = new Subject_class();
                 sub.Subject = subject_txtbx.Text;
                 sub.Project_id = projectdiv[0];
                 subject_listbx.Items.Add(sub.Showsubject(projectdiv[0]));

                 subj.Add(sub);

                 MessageBox.Show(projectdiv[0]);
                 subject_txtbx.Text = "";
                 */
                MySqlConnection connection = new MySqlConnection(Connec);
                connection.Open();
                string query2 = "INSERT INTO internal_communication_4.subjects(subject_id, subject_name, Project_project_id) VALUES( @subject_id, @subject_name, (SELECT project_id FROM internal_communication_4.projects WHERE (project_id = '" + sub.Project_id + "' )))";
                MySqlCommand comm = connection.CreateCommand();
                comm.CommandText = query2;
                comm.Parameters.AddWithValue("@subject_id", sub.Subject_id);
                comm.Parameters.AddWithValue("@subject_name", sub.Subject);
                comm.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string query4 = "SELECT subject_id, subject_name, Project_project_id FROM internal_communication_4.subjects AS s1 JOIN internal_communication_4.projects AS p1 ON s1.Project_project_id = p1.project_id WHERE (project_selection = 1 AND subject_id = " + sub.Subject_id + ")";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query4, connection);
                adapter.Fill(table);
                while (row < table.Rows.Count)
                {
                    Subject_class su = new Subject_class();
                    su.Subject = (string)table.Rows[row]["subject_name"];
                    su.Subject_id = Convert.ToInt32(table.Rows[row]["subject_id"]);
                    subject_listbx.Items.Add(su.Showsubject());
                    row += 1;
                }
                connection.Close();



            }
            catch
            {
                MessageBox.Show("Please input a correct subject ");
            }

            subject_txtbx.Text = "";
        }
    }
}
