using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRetailerManagement.Source.Utilities
{
    public class QueryGRDB
    {
        private SqlConnection _conn;
        public SqlConnection Conn { get => _conn; set => _conn = value; }

        public QueryGRDB()
        {
            var connString = @"Data Source=DESKTOP-53ZIE;Initial Catalog=GameRetailerDB;User ID=sa;Password=123456;";
            Conn = new SqlConnection(connString);
        }

        //Methods
        public int ExecuteNonQuery(string query)
        {
            Conn.Open();
            var data = (new SqlCommand(query, Conn)).ExecuteNonQuery();
            Conn.Close();

            return data;
        }

        public int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            Conn.Open();
            SqlCommand command = new SqlCommand(query, Conn);

            // Add the parameters to the command
            command.Parameters.AddRange(parameters);

            var data = command.ExecuteNonQuery();
            Conn.Close();

            return data;
        }


        public object ExecuteScalar(string query)
        {
            Conn.Open();
            var data = new SqlCommand(query, Conn).ExecuteScalar();
            Conn.Close();

            return data;
        }

        public DataSet ExcuteDataSet(string query, string tableName)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, Conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, tableName);

            return dataSet;
        }

        public SqlDataReader ExcuteReader(string query)
        {
            Conn.Open();
            return new SqlCommand(query, Conn).ExecuteReader(CommandBehavior.CloseConnection);
        }

        public Dictionary<string, List<object>> ExcuteList(string query)
        {
            var list = new Dictionary<string, List<object>>();
            var data = ExcuteReader(query);

            var columnNames = new List<string>();

            for (int i = 0; i < data.FieldCount; i++)
            {
                columnNames.Add(data.GetName(i));
                list[data.GetName(i)] = new List<object>();
            }

            while (data.Read())
                for (int i = 0; i < data.FieldCount; i++)
                    list[columnNames[i]].Add(data[i]);


            return list;
        }
    }
}
