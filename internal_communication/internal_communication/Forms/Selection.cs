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
    public partial class project_selection_form : Form
    {
        public static string subject;
        public static string subject_ID;
        string projIDii;
        string[] projIDiii;
        int proID;
        List<Projects_class> proj = new List<Projects_class>();
        public static ListBox.SelectedObjectCollection /*(project_list)*/ selectedItems ;
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        string subjnme;
        string subjD;
        string[] subjIDiii;
        int row = 0;
        public static ListBox.SelectedObjectCollection selectedItems1;
        public static ListBox.SelectedObjectCollection selectedItems2;
        string connec = "datasource=localhost;port=3306;username=root;password=jmsb;server=127.0.0.2;database=internal_communication_4;persistsecurityinfo=True";

        public project_selection_form()
        {
            InitializeComponent();
        }

       //load the text file
        private void project_selection_form_Load(object sender, EventArgs e)
        {

                proj = projectDA.Load();
            MySqlConnection connection = new MySqlConnection(connec);
            connection.Open();
            string query1 = @"SELECT 
                                    *
                                 FROM internal_communication_4.projects AS p1";


            MySqlDataAdapter adapt = new MySqlDataAdapter(query1, connection);
            adapt.Fill(table);

            while (row < table.Rows.Count)
            {
                Projects_class su = new Projects_class();
                su.Project_name = (string)table.Rows[row]["project_name"];
                su.Category = (string)table.Rows[row]["project_category"];
                su.Year = Convert.ToInt32(table.Rows[row]["project_year"]);
                su.ID = Convert.ToInt32(table.Rows[row]["project_id"]);
                project_list.Items.Add(su.Showproject());
                row += 1;
            }
            connection.Close();


            user_lbl.Text = login_form.user_name;
            position_lbl.Text = login_form.user_position;

            //load subjects !!!!!!!!!!!!!!!!!!!!!!
        

           /*MySqlConnection connection = new MySqlConnection(connec);
            connection.Open();
            string query6 = "SELECT user_name, user_position FROM internal_communication_4.user AS u1 JOIN internal_communication_4.logs AS l1 ON u1.user_id = l1.user_user_id WHERE (log_current = 1)";
            MySqlCommand command = new MySqlCommand(query6, connection);
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                user_lbl.Text = reader.GetString(0);
                position_lbl.Text = reader.GetString(1);
            }
            connection.Close();
            */
            try
            {
                MySqlConnection connection1 = new MySqlConnection(connec);
                //set projects as non active
                Projects_class pro = new Projects_class();
                pro.Proj_active = 2;
                connection1.Open();
                string query7 = "UPDATE internal_communication_4.projects SET project_selection = @project_selection ";
                MySqlCommand comm = connection1.CreateCommand();
                comm.CommandText = query7;
                comm.Parameters.AddWithValue("@project_selection", pro.Proj_active);
                comm.ExecuteNonQuery();
                connection1.Close();
            }
            catch
            { }
        }

        public void project_list_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

       
       
        private void label4_Click(object sender, EventArgs e)
        {

        }

        //remove a project (confirmation page opens)
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

       //go to the project messagerie and features
        private void go_btn_Click(object sender, EventArgs e)
        {
        }
       
     
        /* TEXT FILES 
         * 
        //add a new project to the project list from the text file
        public void AddProjects(List<Projects_class> prje)
        {
            foreach (Projects_class pro in prje)
            { 
            project_list.Items.Add(pro.Showproject());
                }
        }
        */

        //save the file to text file
       /* private void save_btn_Click(object sender, EventArgs e)
        {
                try
               {
                    projectDA.Save(proj);
                    MessageBox.Show("Project succesfully saved!");
            }
               catch
               {
                   MessageBox.Show("There are no new project to save!");
                }
            } */

        private void project_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void nwnm_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void interrogation_btn_Click(object sender, EventArgs e)
        {
            helpform helpp = new helpform();
            helpp.ShowDialog();
        }

       


            //add a new project (some restrictions apply)
            private void new_btn_Click_1(object sender, EventArgs e)
        {
           
            }


       

        //search bar find button
        private void find_btn_Click_1(object sender, EventArgs e)
        {

       
            project_list.SelectedItem = null;
            foreach (string project in project_list.Items)
            {
                Convert.ToString(project);
                string[] projectdiv = project.Split(',');
                if (projectdiv[1] == project_txtbx.Text)
                {
                    project_list.SelectedItem = project;
                    project_txtbx.Text = "";
                    break;
                }

                else if (byyear_chckbx.Checked)
                {
                    if (projectdiv[2] == project_txtbx.Text)
                    {
                        project_txtbx.Text = "";
                        byyear_chckbx.Checked = false;
                        project_list.SelectedItem = project;
                        break;
                    }
                }

            }
            if (project_list.SelectedItem == null)
            {
                MessageBox.Show("Project does not exist ");
            }

        }

           
        private void logoff_btn_Click(object sender, EventArgs e)
        {
            DateTime dateing = DateTime.Now;
            logs_class classe = new logs_class();
            classe.Log_out = dateing.ToString();
            classe.Log_current = 2;

            MySqlConnection connection = new MySqlConnection(connec);
            connection.Open();
            string query3 = "UPDATE internal_communication_4.logs SET log_current = @log_current, log_out = @log_out Where (log_current = 1)";
            MySqlCommand comm = connection.CreateCommand();
            comm.CommandText = query3;
            comm.Parameters.AddWithValue("@log_current", classe.Log_current);
            comm.Parameters.AddWithValue("@log_out", classe.Log_out);
            comm.ExecuteNonQuery();
            connection.Close();
           
            this.Hide();
            login_form gin = new login_form();
            gin.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void user_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            //reset the current project to inactive in the database and clear the subject list 
            Projects_class pro2 = new Projects_class();
            pro2.Proj_active = 2;
            MySqlConnection connection1 = new MySqlConnection(connec);
            connection1.Open();
            string query8 = @"UPDATE internal_communication_4.projects 
                                SET project_selection = @project_selection 
                                WHERE (project_id = " + proID + ")";
            MySqlCommand comm1 = connection1.CreateCommand();
            comm1.CommandText = query8;
            comm1.Parameters.AddWithValue("@project_selection", pro2.Proj_active);
            comm1.ExecuteNonQuery();
            connection1.Close();

            subject_listbx.Items.Clear();

            //reset the subject active
            try
            {
                MySqlConnection connection2 = new MySqlConnection(connec);
                Subject_class sub = new Subject_class();
                sub.Subject_select = 2;
                connection2.Open();
                string query10 = "UPDATE internal_communication_4.subjects SET subject_selection = @subject_selection";
                MySqlCommand comm = connection2.CreateCommand();
                comm.CommandText = query10;
                comm.Parameters.AddWithValue("@subject_selection", sub.Subject_select);
                comm.ExecuteNonQuery();
                connection2.Close();



            }
            catch
            {
                MessageBox.Show("error, please repeat the process");
            }


            Projects_class pro = new Projects_class();
            pro.Proj_active = 1;
            selectedItems = new ListBox.SelectedObjectCollection(project_list);
            selectedItems = project_list.SelectedItems;
            int selectedIndex = project_list.SelectedIndex;
            if (selectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    projIDii = selectedItems[i].ToString();
                projIDiii = projIDii.Split(',');
                proID = Convert.ToInt32(projIDiii[0]);
                MySqlConnection connection = new MySqlConnection(connec);
                connection.Open();
                string query7 = @"UPDATE internal_communication_4.projects 
                                   SET project_selection = @project_selection 
                                   WHERE (project_id = " + proID + ")";
                MySqlCommand comm = connection.CreateCommand();
                comm.CommandText = query7;
                comm.Parameters.AddWithValue("@project_selection", pro.Proj_active);
                comm.ExecuteNonQuery();
                connection.Close();

            }

            //selectedItems = new ListBox.SelectedObjectCollection(project_list);
            string project = Convert.ToString(selectedItems);
            if (selectedItems != null)
            {
                string[] projectdiv = project.Split(',');
                // subj = SubjectDA.Loadsub(projectdiv[0]);
                //   AddSubject(subj);


                try
                {


                    //fill listbox while loading 
                    MySqlConnection connection = new MySqlConnection(connec);
                    connection.Open();
                    string query1 = @"SELECT 
                                    subject_id, 
                                    subject_name, 
                                    Project_project_id 
                                 FROM internal_communication_4.subjects AS s1 
                                    JOIN internal_communication_4.projects AS p1 
                                    ON s1.Project_project_id = p1.project_id 
                                 WHERE (project_selection = 1)";

                    table.Clear();
                    row = 0;
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

                    selectedItems = null;
                    row = 0;


                }
                catch
                { 
                    MessageBox.Show("error, please repeat the process"); 
                }
              
            }
            else
            {
                MessageBox.Show("Please select a project");
            }


        
    }

        private void Messagerie_btn_Click(object sender, EventArgs e)
        {
            this.Close();

            Subject_class subj = new Subject_class();
            subj.Subject_select = 1;
            selectedItems1 = new ListBox.SelectedObjectCollection(subject_listbx);
            selectedItems1 = subject_listbx.SelectedItems;
            int selectedIndex = subject_listbx.SelectedIndex;
            if (selectedIndex != -1)
            {
                for (int i = selectedItems1.Count - 1; i >= 0; i--)
                    subjD = selectedItems1[i].ToString();
                subjIDiii = subjD.Split(',');
                subjnme = subjIDiii[0];
                string subb = subjIDiii[1];
                Subject_class sub = new Subject_class();
                sub.Subject_id = Convert.ToInt32(subjnme);
                //select statement according to the name of project selected 
                sub.Project_id = proID;
                MySqlConnection connection = new MySqlConnection(connec);
                connection.Open();
                string query8 = "UPDATE internal_communication_4.subjects SET subject_selection = @subject_selection Where (`subject_id` LIKE " + sub.Subject_id + " AND Project_project_id = " + sub.Project_id + ")";
                MySqlCommand comma = connection.CreateCommand();
                comma.CommandText = query8;
                comma.Parameters.AddWithValue("@subject_selection", subj.Subject_select);
                comma.ExecuteNonQuery();
                connection.Close();

                subject = subb;
                subject_ID = subjnme;

            }

            selectedItems1 = new ListBox.SelectedObjectCollection(subject_listbx);
            if (selectedItems1 != null)
            {
                Messagerie msg = new Messagerie();
                msg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a project");
            }

        }

        private void del_subj_btn_Click(object sender, EventArgs e)
        {
            selectedItems1 = new ListBox.SelectedObjectCollection(subject_listbx);
            selectedItems1 = subject_listbx.SelectedItems;
            int selectedIndex = subject_listbx.SelectedIndex;
            if (selectedIndex != -1)
            {
                for (int i = selectedItems1.Count - 1; i >= 0; i--)
                    subjD = selectedItems1[i].ToString();
                subjIDiii = subjD.Split(',');
                subjnme = subjIDiii[0];
                Subject_class sub = new Subject_class();
                sub.Subject_id = Convert.ToInt32(subjnme);
                sub.Project_id = proID;

                MySqlConnection connection = new MySqlConnection(connec);
                //delete subject associated 
                connection.Open();
                string query7 = @"DELETE 
                                    FROM `internal_communication_4`.`subjects` 
                                    WHERE(Project_project_id = " + sub.Project_id + "" +
                                    "     AND subject_id = " + sub.Subject_id + "); ";
                MySqlCommand comma = new MySqlCommand(query7, connection);
                comma.ExecuteNonQuery();
                connection.Close();
                for (int i = selectedItems1.Count - 1; i >= 0; i--)
                    subject_listbx.Items.Remove(selectedItems1[i]);
                MessageBox.Show("subject succesfully deleted ");
            }
            }

        private void subject_listbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            del_confirm del = new del_confirm();
            del.ShowDialog();
            selectedItems2 = new ListBox.SelectedObjectCollection(project_list);
            selectedItems2 = project_list.SelectedItems;
            int selectedIndex = project_list.SelectedIndex;
            if (selectedIndex != -1)
            {
                if (del.Showconfirmation() == true)
                {

                    for (int i = selectedItems2.Count - 1; i >= 0; i--)
                        projIDii = selectedItems2[i].ToString();
                    projIDiii = projIDii.Split(',');
                    proID = Convert.ToInt32(projIDiii[0]);
                    //proj.Remove(proj[selectedIndex]);
                    MySqlConnection connection = new MySqlConnection(connec);
                    connection.Open();
                    string query = "DELETE FROM `internal_communication_4`.`projects` WHERE(`project_id` = " + this.proID + "); ";
                    MySqlCommand idused = new MySqlCommand(query, connection);
                    MySqlDataReader MyReader3;
                    MyReader3 = idused.ExecuteReader();
                    while (MyReader3.Read())
                    {
                    }
                    connection.Close();

                    //delete subject associated 
                    connection.Open();
                    string query7 = "DELETE FROM `internal_communication_4`.`subjects` WHERE(`Project_project_id` = " + this.proID + "); ";
                    MySqlCommand comma = new MySqlCommand(query7, connection);
                    MySqlDataReader MyReader6;
                    MyReader6 = comma.ExecuteReader();
                    while (MyReader6.Read())
                    {
                    }
                    connection.Close();
                    for (int i = selectedItems2.Count - 1; i >= 0; i--)
                        project_list.Items.Remove(selectedItems2[i]);
                    projectDA.Save(proj);
                }
                else
                { }
            }
            else
                MessageBox.Show("You must select a project");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Project_create crea = new Project_create();
            crea.ShowDialog();
        }

        private void subj_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            subject_create sub_crea = new subject_create();
            sub_crea.Show();
        }


    }
    }

