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
    //to do : backup the subject on the text file
    public partial class view_project : Form
    {
        List<Subject_class> subj = new List<Subject_class>();
        string project = Convert.ToString(project_selection_form.selectedItems);
       // int proje = project_selection_form.proID;
       string Connec = "datasource=localhost;port=3306;username=root;password=jmsb;server=127.0.0.2;database=internal_communication_4;persistsecurityinfo=True";
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        string subjnme;
        string subjD;
        string[] subjIDiii;
        int row = 0;
        public static ListBox.SelectedObjectCollection selectedItems;



        public view_project(ListBox.SelectedObjectCollection SelectedItem)
        {
            InitializeComponent();
        }

        //load the text file
        private void view_project_Load(object sender, EventArgs e)
        {
            string[] projectdiv = project.Split(',');
            // subj = SubjectDA.Loadsub(projectdiv[0]);
            //   AddSubject(subj);


            try
            {
                //fill listbox while loading 
                MySqlConnection connection = new MySqlConnection(Connec);
                connection.Open();
                string query1 = @"SELECT 
                                    subject_id, 
                                    subject_name, 
                                    Project_project_id 
                                 FROM internal_communication_4.subjects AS s1 
                                    JOIN internal_communication_4.projects AS p1 
                                    ON s1.Project_project_id = p1.project_id 
                                 WHERE (project_selection = 1)";
                /*MySqlDataAdapter adapter = new MySqlDataAdapter(query1, connection);
                adapter.Fill(table);
                subject_listbx.DataSource = table;
                subject_listbx.DisplayMember = "subject_name";
                */
               
                MySqlDataAdapter adapt = new MySqlDataAdapter(query1, connection);
                adapt.Fill(table);

                while (row < table.Rows.Count)
                {
                    Subject_class su = new Subject_class();
                    su.Subject_id = Convert.ToInt32(table.Rows[row]["subject_id"]);
                    su.Subject = (string)table.Rows[row]["subject_name"];
                    subject_listbx.Items.Add(su.Showsubject());
                    row += 1;
                }
                connection.Close();


                connection.Open();
                string query3 = "SELECT project_name, project_id FROM internal_communication_4.projects WHERE (project_selection = 1)";
                MySqlDataAdapter adapte = new MySqlDataAdapter(query3, connection);
                adapte.Fill(table2);
                project_lbl.Text = (string)table2.Rows[0]["project_name"];
                project_id_lbl.Text = table2.Rows[0]["project_id"].ToString();
                connection.Close();
            }
            catch
            {}
            try
            {
                MySqlConnection connection2 = new MySqlConnection(Connec);
                Subject_class sub = new Subject_class();
                sub.Subject_select = 2;
                connection2.Open();
                string query7 = "UPDATE internal_communication_4.subjects SET subjects_selection = @subject_selection";
                MySqlCommand comm = connection2.CreateCommand();
                comm.CommandText = query7;
                comm.Parameters.AddWithValue("@subject_selection", sub.Subject_select);
                comm.ExecuteNonQuery();
                connection2.Close();
            }
            catch { }

        }

        /*add subject to the list acording to the previously selected project
        public void AddSubject(List<Subject_class> subjs)
        {
            string[] projectdiv = project.Split(',');

            foreach (Subject_class sub in subjs)
            {
                if (projectdiv[0] != null)
                {
                    subject_listbx.Items.Add(sub.Showsubject(sub.Showsubject(projectdiv[0])));
                }
            }
        }
        */

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
            Projects_class pro = new Projects_class();
            this.Close();
        }

        private void subject_listbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SubjectDA.Savesub(subj);
                MessageBox.Show("subject and conversation succesfully saved!");
            }
            catch
            {
                MessageBox.Show("There are no new subject and converation to save!");
            }
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            helpform helpp = new helpform();
            helpp.ShowDialog();
        }

       

        private void subject_listbx_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void subj_btn_Click_1(object sender, EventArgs e)
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


   

        
        private void Messagerie_btn_Click_1(object sender, EventArgs e)
        {

           
            this.Close();

            Subject_class subj = new Subject_class();
            subj.Subject_select = 1;
            selectedItems = new ListBox.SelectedObjectCollection(subject_listbx);
            selectedItems = subject_listbx.SelectedItems;
            int selectedIndex = subject_listbx.SelectedIndex;
            if (selectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    subjD = selectedItems[i].ToString();
                subjIDiii = subjD.Split(',');
                subjnme = subjIDiii[0];
                Subject_class sub = new Subject_class();
                sub.Subject_id = Convert.ToInt32(subjnme);
                sub.Project_id = Convert.ToInt32(project_id_lbl.Text);
                MySqlConnection connection = new MySqlConnection(Connec);
                connection.Open();
                string query8 = "UPDATE internal_communication_4.subjects SET subject_selection = @subject_selection Where (`subject_id` LIKE " + sub.Subject_id + " AND Project_project_id = " + sub.Project_id + ")";
                MySqlCommand comma = connection.CreateCommand();
                comma.CommandText = query8;
                comma.Parameters.AddWithValue("@subject_selection", subj.Subject_select);
                comma.ExecuteNonQuery();
                connection.Close();

            }

            selectedItems = new ListBox.SelectedObjectCollection(subject_listbx);
            if (selectedItems != null)
            {
                Messagerie msg = new Messagerie();
                msg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a project");
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void file_btn_Click(object sender, EventArgs e)
        {

        }

        private void del_subj_btn_Click(object sender, EventArgs e)
        {
            selectedItems = new ListBox.SelectedObjectCollection(subject_listbx);
            selectedItems = subject_listbx.SelectedItems;
            int selectedIndex = subject_listbx.SelectedIndex;
            if (selectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    subjD = selectedItems[i].ToString();
                subjIDiii = subjD.Split(',');
                subjnme = subjIDiii[0];
                Subject_class sub = new Subject_class();
                sub.Subject_id = Convert.ToInt32(subjnme);
                sub.Project_id = Convert.ToInt32(project_id_lbl.Text); 

                MySqlConnection connection = new MySqlConnection(Connec);
                //delete subject associated 
                connection.Open();
                string query7 = "DELETE FROM `internal_communication_4`.`subjects` WHERE(Project_project_id = " + sub.Project_id + " AND subject_id = " + sub.Subject_id + "); ";
                MySqlCommand comma = new MySqlCommand(query7, connection);
                comma.ExecuteNonQuery();
                /*MySqlDataReader MyReader6;
                MyReader6 = comma.ExecuteReader();
                while (MyReader6.Read())
                {
                }*/
                connection.Close();
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    subject_listbx.Items.Remove(selectedItems[i]);
                MessageBox.Show("subject succesfully deleted ");
            }
            else { }
        }
    }
}
