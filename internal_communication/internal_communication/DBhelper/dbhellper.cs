using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace internal_communication.DBhelper
{
    public class dbhellper
    {
       public  MySqlCommand cmd;
        public void connexionopen(string open_close, string query)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=jmsb;server=127.0.0.2;database=internal_communication_4;persistsecurityinfo=True");
            if (open_close == "open")
                {
                connection.Open();
                cmd = new MySqlCommand(query, connection);
            }
            else if (open_close == "close")
            {
                connection.Close();
            }
            
            

        }
    }
}
