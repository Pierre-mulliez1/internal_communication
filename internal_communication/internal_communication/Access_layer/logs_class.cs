using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internal_communication.Forms
{
    public class logs_class
    {
        private int id;
        private string log_in;
        private int user_id;
        private string log_out;
        private int log_current;


        public int ID
        {
            get => id;
            set => id = value;
        }

        public string Log_in
        {
            get => log_in;
            set => log_in = value;
        }
        public int User_id
        {
            get => user_id;
            set => user_id = value;
        }

        public int Log_current
        {
            get => log_current;
            set => log_current = value;
        }

        public string Log_out
        {
            get => log_out;
            set => log_out = value;
        }



        public string Show_los(int ide)
        {
            ide = ID;
            

            return ID + "," + Log_in + "," + User_id + "," + Log_current + "," + Log_out;
        }
    }
}
