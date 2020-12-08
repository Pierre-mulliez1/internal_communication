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
    public partial class Project_create : Form
    {
        Projects_class pro = new Projects_class();
        Int32 year;
        List<Projects_class> proj = new List<Projects_class>();
        string connec = "datasource=localhost;port=3306;username=root;password=jmsb;server=127.0.0.2;database=internal_communication_4;persistsecurityinfo=True";

        public Project_create()
        {
            InitializeComponent();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            //create a random number TO CHANGE TO ENUMERATE 
            Random rnd = new Random();
            int projectid = rnd.Next(1, 100000);

            if (int.TryParse(nwyr_txtbx.Text, out year))

            {
                year = int.Parse(nwyr_txtbx.Text);

            }
            else
            { MessageBox.Show("Please input a correct project year"); }

            //In case the project ID already exist 
            MySqlConnection connection = new MySqlConnection(connec);
            connection.Open();
            string query0 = "SELECT project_id FROM internal_communication_4.projects WHERE ( project_id = " + projectid + ")";
            MySqlCommand idused = new MySqlCommand(query0, connection);
            MySqlDataReader MyReader3;
            MyReader3 = idused.ExecuteReader();
            while (MyReader3.Read())
            {
                if (MyReader3.GetString(0) != null)
                {

                    Random rrnd = new Random();
                    projectid = rrnd.Next(1, 100000);


                }
            }



            connection.Close();

            //text file saved 
            Projects_class pro = new Projects_class();
            pro.ID = projectid;
            pro.Project_name = nwnm_txtbx.Text;
            pro.Year = year;
            pro.Category = nwcat_txtbx.Text;
          

            proj.Add(pro);
            projectDA.Save(proj);

            //databased saved 
            connection.Open();
            string query = "INSERT INTO internal_communication_4.projects(project_id,project_name,project_year,project_category) VALUES('" + projectid + "','" + this.nwnm_txtbx.Text + "','" + this.year + "','" + this.nwcat_txtbx.Text + "')";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader MyReader2;
            MyReader2 = command.ExecuteReader();
            while (MyReader2.Read())
            {
            }
            connection.Close();
            MessageBox.Show("project " + pro.Project_name + "  successfully created!");
            nwnm_txtbx.Text = "";
            nwyr_txtbx.Text = "";
            nwcat_txtbx.Text = "";

            this.Close();
            project_selection_form pr = new project_selection_form();
            pr.ShowDialog();



        }
    }
}
