using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace carvalhioPDV2
{
    class Connection
    {
        public string connec = "SERVER=localhost; DATABASE=carvalhiopdv; UID=root; PWD=; PORT=;";

        public MySqlConnection con = null;

        public void OpenConnection()
        {
            con = new MySqlConnection(connec);
            con.Open();
        }

        public void CloseConnection()
        {
            con = new MySqlConnection(connec);
            con.Close();
            con.Dispose();            // Derruba algumas conexões abertas
            con.ClearAllPoolsAsync(); // Método de limpeza
        }
    }
}
