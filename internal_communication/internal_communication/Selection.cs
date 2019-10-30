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
    public partial class project_selection_form : Form
    {
        Projects_class pro = new Projects_class(); 
        Int32 year;
        List<Projects_class> proj = new List<Projects_class>();


        public project_selection_form()
        {
            InitializeComponent();
        }

       //load the text file
        private void project_selection_form_Load(object sender, EventArgs e)
        {
           

                proj = projectDA.Load();
                AddProjects(proj);

        }

        public void project_list_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

       
        //add a new project (some restrictions apply)
        public void new_btn_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(nwyr_txtbx.Text, out year))
            {
                MessageBox.Show("input a correct year, only numbers allowed");
            }
            else
            {

                Projects_class pro = new Projects_class();
                pro.Project_name = nwnm_txtbx.Text;
                pro.Year = Convert.ToInt32(nwyr_txtbx.Text);
                pro.Category = nwcat_txtbx.Text;
                project_list.Items.Add(pro.Showproject());
               
                proj.Add(pro);
                
            
                nwnm_txtbx.Text = "";
                nwyr_txtbx.Text = "";
                nwcat_txtbx.Text = "";
            }

        }

       
          
        



        private void label4_Click(object sender, EventArgs e)
        {

        }

        //remove a project (confirmation page opens)
        private void button1_Click(object sender, EventArgs e)
        {
            del_confirm del = new del_confirm();
            del.ShowDialog();
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(project_list);
            selectedItems = project_list.SelectedItems;
            int selectedIndex = project_list.SelectedIndex;
            if (selectedIndex != -1)
            {
                if (del.Showconfirmation() == true)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        project_list.Items.Remove(selectedItems[i]);
                    proj.Remove(proj[selectedIndex]);
                }
                else
                { }
            }
            else
                MessageBox.Show("You must select a project");
        }

       //go to the project messagerie and features
        private void go_btn_Click(object sender, EventArgs e)
        {
            
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(project_list);
            selectedItems = project_list.SelectedItems;
            view_project view = new view_project(selectedItems);
            view.ShowDialog();

        }
       
       //search bar find button
        private void find_btn_Click(object sender, EventArgs e)
        {
            project_list.SelectedItem = null;
                foreach (string project in project_list.Items)
                {
                    Convert.ToString(project);
                    string[] projectdiv = project.Split(',');
                    if (projectdiv[0] == project_txtbx.Text)
                    {
                        project_list.SelectedItem = project;
                        project_txtbx.Text = "";
                        break;
                    }

                    else if (byyear_chckbx.Checked)
                    {
                        if (projectdiv[1] == project_txtbx.Text)
                        {
                            project_txtbx.Text = "";
                            byyear_chckbx.Checked = false;
                            project_list.SelectedItem = project;
                            break;
                    }
                    }

                }
        if  (project_list.SelectedItem == null)
            {
                MessageBox.Show("Project does not exist ");
            }
            

        }

        //add a new project to the project list from the text file
        public void AddProjects(List<Projects_class> prje)
        {
            foreach (Projects_class pro in prje)
            { 
            project_list.Items.Add(pro.Showproject());
                }
        }

        //save the file to text file
        private void save_btn_Click(object sender, EventArgs e)
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
            }

        private void project_txtbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
