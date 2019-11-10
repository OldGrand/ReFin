using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flamingo
{
    class DataBaseAccessor
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataReader reader;
        string dataBaseName;
        string tableName;

        public DataBaseAccessor(string dataBaseName, string tableName)
        {
            connection = new OleDbConnection($@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBases\{dataBaseName}.mdb;");
            this.dataBaseName = dataBaseName;
            this.tableName = tableName;
        }

        public bool VerifyUserData(string email, string password)
        {
            command = new OleDbCommand($"SELECT * FROM {tableName} WHERE [Email] = '{email}'", connection);
            connection.Open();
            reader = command.ExecuteReader();

            if (reader.Read() && reader.GetValue(1).ToString().Equals(password))
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }

        public bool RegisterUser(string email, string password)
        {
            command = new OleDbCommand($"SELECT * FROM {tableName} WHERE [Email] = '{email}'", connection);
            connection.Open();
            reader = command.ExecuteReader();

            if (!reader.Read())
            {
                command = new OleDbCommand($"INSERT INTO Users VALUES ('{email}', '{password}', ' ', 0, ' ')", connection);
                command.ExecuteReader();
                connection.Close();
                return true;
            }
            return false;
        }
    }
}
