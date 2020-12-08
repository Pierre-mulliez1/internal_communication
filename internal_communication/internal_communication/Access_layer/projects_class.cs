using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internal_communication
{
    public class Projects_class
    {
        private string project_name;
        private int year;
        private string category;
        private int id;
        private int proj_active;

        public string Project_name
        {
            get
            {
                return project_name;
            }
            set
            {
                project_name = value;
            }
        }

        public int ID
        {
            get => id;
            set => id = value;
        }

        public int Year
        {
            get => year;
            set => year = value;
        }
        public string Category
        {
            get => category;
            set => category = value;
        }

        public int Proj_active
        {
            get => proj_active;
            set => proj_active = value;
        }

        public string Showproject()
        {
        return ID + "," + Project_name + "," + Year + "," + Category;
        }
      
        public Projects_class() { }
        public Projects_class(string nm, int yr, string cat)
        {
            Project_name = nm;
            Year = yr;
            Category = cat;
        }

        
    }
}
