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
        Projects_class pro;
        del_confirm del;
        Int32 year;


        public project_selection_form()
        {
            InitializeComponent();
        }

       
        private void project_selection_form_Load(object sender, EventArgs e)
        {

        }

        public void project_list_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        public void new_btn_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(nwyr_txtbx.Text, out year))
            {
                MessageBox.Show("input a correct year, only numbers allowed");
            }
            else
            {
                pro = new Projects_class();
                pro.Project_name = nwnm_txtbx.Text;
                pro.Year = Convert.ToInt32(nwyr_txtbx.Text);
                pro.Category = nwcat_txtbx.Text;
                project_list.Items.Add(pro.Showproject());

                nwnm_txtbx.Text = "";
                nwyr_txtbx.Text = "";
                nwcat_txtbx.Text = "";
            }

        }

      
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            del_confirm del = new del_confirm();
            del.ShowDialog();
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(project_list);
            selectedItems = project_list.SelectedItems;
            if (project_list.SelectedIndex != -1)
            {
                if (del.Showconfirmation() == true)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        project_list.Items.Remove(selectedItems[i]);
                }
                else
                { }
            }
            else
                MessageBox.Show("You must select a project");
        }

        private void go_btn_Click(object sender, EventArgs e)
        {
            
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(project_list);
            selectedItems = project_list.SelectedItems;
            view_project view = new view_project(selectedItems);
            view.ShowDialog();

        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            foreach (string project in project_list.Items)
            {
               
                if (Convert.ToString(pro.Project_name) == project_txtbx.Text)
                {
                    project_list.SelectedItem = pro.Showproject();
                    project_txtbx.Text = "";
                    break;
                }
                else if (byyear_chckbx.Checked)
                {
                    if (pro.Year == Convert.ToInt32(project_txtbx.Text))
                    {
                        project_list.SelectedItem = pro.Showproject();
                        project_txtbx.Text = "";
                        byyear_chckbx.Checked = false;
                        break;
                    }
                }
                else
                {
                    continue;
                }
             
            }
            if  (project_list.SelectedItem == null)
            {
                MessageBox.Show("No project corresponding to the searched name");
            }
        }
    }
}
