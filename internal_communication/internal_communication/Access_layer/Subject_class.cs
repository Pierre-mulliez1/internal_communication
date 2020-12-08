using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internal_communication
{
    public class Subject_class
    {
        private string subject;
        private int project_id;
        private int subject_id;
        private int subject_select;

        public int Subject_select
        {
            get => subject_select;
            set => subject_select = value;

        }
        public int Project_id
        {
            get
            {
                return project_id;
            }
            set
            {
                project_id = value;
            }
        }

        public string Subject
        {
            get => subject;
            set => subject = value;
        }

        public int Subject_id
        {
            get => subject_id;
            set => subject_id = value;
        }
        public string Showsubject()
        {
          
            return Subject_id + "," + Subject;
        }
       
    }
}
