using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.Common;
using System.Windows.Forms;

namespace Kurs_RPK
{
    class Query
    {
        
        OleDbConnection     connection;
        OleDbCommand        command;
        OleDbDataAdapter    dataAdapter;
        DataTable           bufferTable;

        public Query (string Conn)
        {
            connection = new OleDbConnection(ConnectionStr.ConnStr);
            
        }
        
        public DataTable UpdateEmployee()
        {
            bufferTable = new DataTable();
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM [Задолженности]", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable UpdateSubF(string SubF)
        {
            bufferTable = new DataTable();
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM [Кафедры] WHERE [SubFaculty] = '{SubF}'", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public bool exists(string ID, string StudName,  string Group, string Type, string Semester, string Class, string TeachersName)
        {
            bufferTable = new DataTable();
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM [Задолженности] WHERE [ID] = '{ID}' AND [StudName] = '{StudName}' AND [Group] = '{Group}'" +
                $" AND [Type] = '{Type}' AND [Semester] = '{Semester}' AND [Class] = '{Class}' AND [TeachersName] = '{TeachersName}'", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            if (bufferTable.Rows.Count == 0) return true;
            else return false;
        }
        public void addStud(string ID, string StudName, string Group)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO [Студенты]([ID],[StudName],[Group]) VALUES(@ID,@StudName,@Group)",connection);
            command.Parameters.AddWithValue("ID", Group+ "-" + ID);
            command.Parameters.AddWithValue("StudName", StudName);
            command.Parameters.AddWithValue("Group", Group);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public int newUser(string ID, string StudName, string Group)
        {
            bufferTable = new DataTable();
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM [Студенты] WHERE ID = '{ID}'", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            if (bufferTable.Rows.Count == 0)
            {
                return 1;
            }
            else if (bufferTable.Rows[0][1].ToString() == StudName && bufferTable.Rows[0][2].ToString() == Group)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
        public void Add(string ID, string StudName, string Group, string Type, string Semester, string Class, string TeachersName)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO [Задолженности]([ID],[StudName],[Group],[Type],[Semester],[Class],[TeachersName]) VALUES(@ID,@StudName,@Group,@Type,@Semester,@Class,@TeachersName)",connection);
            command.Parameters.AddWithValue("ID", Group + "-" + ID);
            command.Parameters.AddWithValue("StudName", StudName);
            command.Parameters.AddWithValue("Group", Group);
            command.Parameters.AddWithValue("Type", Type);
            command.Parameters.AddWithValue("Semester", Semester);
            command.Parameters.AddWithValue("Class", Class);
            command.Parameters.AddWithValue("TeachersName", TeachersName);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(string ID, string StudName, string Group, string Type, string Semester, string Class, string TeachersName)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM [Задолженности] WHERE [ID] = '{ID}' AND [StudName] = '{StudName}' AND [Group] = '{Group}' AND [Type] = '{Type}' AND [Semester] = '{Semester}' AND [Class] = '{Class}' AND [TeachersName] = '{TeachersName}'", connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public DataTable byStudName (string stud)
        {
            bufferTable = new DataTable();
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM [Задолженности] WHERE [StudName] = '{stud}'", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public DataTable byClass()
        {
            bufferTable = new DataTable();
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM [Задолженности] WHERE [Class] = '{Program.f2.QueryCB.Text}'", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable byGroup()
        {
            bufferTable = new DataTable();
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM [Задолженности] WHERE [Group] = '{Program.f2.QueryCB.Text}'", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
    }
}
