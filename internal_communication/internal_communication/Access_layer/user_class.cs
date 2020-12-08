using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internal_communication
{
    public class user_class
    {
        private int id;
        private string name;
        private int password;
        private string position;


        public int ID
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Password
        {
            get => password;
            set => password = value;
        }

        public string Position
        {
            get => position;
            set => position = value;
        }

      

        public string Show_pasw(int ide, string nme)
        {
            ide = ID;
            nme = Name;

            return ID + "," + Name + "," + Password + "," + Position;
        }

        public string Showemployee()
        {
            return ID + "," + Name + "," + Password + "," + Position;
        }
    }
}
