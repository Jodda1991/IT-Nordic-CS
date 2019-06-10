using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Storage.SqlServer.ADO.Tests.Properties;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Reminder.Storage.SqlServer.ADO.Tests1
{

    public class SqlReminderStorageInit
    {
        private readonly string _connectionString;
       public SqlReminderStorageInit(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public void InitializeDatabase()
        {
            RunSqlScript(Resources.L31_ClassWork_Reminder_schema);
            RunSqlScript(Resources.SPs);
            RunSqlScript(Resources.Data);
        }
        private void RunSqlScript(string script)
        {
            using (SqlConnection sqlConnection = GetOpenedSqlConnection())
            {
                var cmd = sqlConnection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                var sqlInstructions = SplitSqlInstructions(script);
                foreach(string sqlInstruction in sqlInstructions)
                {
                    if (string.IsNullOrWhiteSpace(sqlInstruction))
                        continue;

                    cmd.CommandText = sqlInstruction;
                    cmd.ExecuteNonQuery();
                }               
            }
        }

        private string[] SplitSqlInstructions(string script)
        {
            return Regex.Split(script, @"\bGO\b");
        }
        private SqlConnection GetOpenedSqlConnection()
        {
            var sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();
            return sqlConnection;

        }
    }
}
