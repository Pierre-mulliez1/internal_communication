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
        public int Year
        {
            get => year; 
            set => year = value; 
        }
        public string Category
        {
            get => category; 
            set  => category = value; 
        }
        public string Showproject()
        {
        return Project_name + "," + Year + "," + Category;
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
