using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internal_communication.Forms
{
    public class Message_class
    {
        private int message_id;
        private int user_id;
        private int project_id;
        private string user_name;
        private int subject_id;
        private string message_content;
        private DateTime message_posting;

        public int Message_id
        {
            get => message_id;
            set => message_id = value;
        }

        public int Project_id
        {
            get => project_id;
            set => project_id = value;
        }

        public string User_name
        {
            get => user_name;
            set => user_name = value;
        }

        public int Subject_id
        {
            get => subject_id;
            set => subject_id = value;
        }

        public int User_id
        {
            get => user_id;
            set => user_id = value;
        }

        public string Message_content
        {
            get => message_content;
            set => message_content = value;
        }

        public DateTime Message_posting
        {
            get => message_posting;
            set => message_posting = value;
        }

       
        public string Showmessage()
        {
            
            return User_name + ": " + Message_content;
        }
    }
}
