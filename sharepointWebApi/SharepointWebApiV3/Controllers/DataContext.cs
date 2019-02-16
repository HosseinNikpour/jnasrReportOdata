using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;

namespace sharepointWebApi.Controllers
{
    public static class Extensions
    {
        public static List<T> ToList<T>(this DataTable table) where T : new()
        {
            IList<PropertyInfo> properties = typeof(T).GetProperties().ToList();
            List<T> result = new List<T>();

            foreach (var row in table.Rows)
            {
                var item = CreateItemFromRow<T>((DataRow)row, properties);
                result.Add(item);
            }

            return result;
        }

        private static T CreateItemFromRow<T>(DataRow row, IList<PropertyInfo> properties) where T : new()
        {
            T item = new T();
            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(System.DayOfWeek))
                {
                    DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), row[property.Name].ToString());
                    property.SetValue(item, day, null);
                }
                else
                {
                    try
                    {
                        if (row[property.Name] == DBNull.Value)
                            property.SetValue(item, null, null);
                        else
                            property.SetValue(item, row[property.Name], null);
                    }
                    catch (Exception ex)
                    {

                    }

                }
            }
            return item;
        }
    }
    public class DataContext
    {
        //public DataTable getData(int level)
        //{
        //    object[] parameterValues = new object[4];
        //    parameterValues[0] = System.DBNull.Value;
        //    parameterValues[1] = System.DBNull.Value;
        //    parameterValues[2] = 1;
        //    parameterValues[3] = level;
        //    return ReaderSp("GetWBSTotalQuery", parameterValues);
        //}
        string Cs = "Data Source=172.29.0.161;Initial Catalog=wss_content;user id=sa;password=P@ssw0rd";
        public DataTable ReaderSp(string SPName, params object[] ParameterValues)
        {


            // DataSet dataset = new DataSet();

            //SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection Cn = new SqlConnection(Cs);
        
            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = SPName;
            Cmd.Connection = Cn;
            Cmd.CommandTimeout = 120;
            GetStoredProcidureParameters(SPName, ref Cmd);
            for (int i = 0; i < ParameterValues.Length; i++)
            {
                Cmd.Parameters[i].Value = ParameterValues[i];
            }
            try
            {
                Cn.Open();
            }
            catch (Exception)
            {
            }
            SqlDataReader reader = Cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            reader.Close();

            //adapter.SelectCommand = Cmd;
            //adapter.Fill(dataset);
            Cn.Close();
            return table;
        }

        private int GetStoredProcidureParameters(string storedProsedureName, ref SqlCommand comm)
        {
            int count;
            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlParameter parameter = null;
            try
            {
                command.Connection = new SqlConnection(Cs);
                command.CommandText = "    SELECT    SCHEMA_NAME(o.schema_id) AS schema_name, o.name AS object_name, o.type_desc, p.parameter_id, p.name AS parameter_name, TYPE_NAME(p.user_type_id) \r\n                                AS parameter_type, p.max_length, p.precision, p.scale, p.is_output\r\n                                FROM    sys.objects AS o INNER JOIN\r\n                                sys.parameters AS p ON o.object_id = p.object_id\r\n                                WHERE (o.name LIKE '" + storedProsedureName + "')\r\n                                ORDER BY  schema_name, object_name, p.parameter_id";
                if (command.Connection.State == ConnectionState.Closed)
                {
                    command.Connection.Open();
                }
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    parameter = new SqlParameter
                    {
                        ParameterName = row["parameter_name"].ToString(),
                        Size = int.Parse(row["max_length"].ToString())
                    };
                    comm.Parameters.Add(parameter);
                }
                count = comm.Parameters.Count;
            }
            catch (Exception)
            {
                throw;
            }
            return count;
        }
    }
}