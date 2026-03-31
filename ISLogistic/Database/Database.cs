using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ISLogistic
{
    public static class Database
    {
        private static string connectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\ISLogistic.accdb;";

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }

        public static DataTable ExecuteQuery(string query, params OleDbParameter[] parameters)
        {
            DataTable table = new DataTable();

            try
            {
                using (OleDbConnection conn = GetConnection())
                {
                    conn.Open();

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message);
            }

            return table;
        }

        public static int ExecuteNonQuery(string query, params OleDbParameter[] parameters)
        {
            try
            {
                using (OleDbConnection conn = GetConnection())
                {
                    conn.Open();

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении команды:\n" + ex.Message);
                return 0;
            }
        }

        public static object ExecuteScalar(string query, params OleDbParameter[] parameters)
        {
            try
            {
                using (OleDbConnection conn = GetConnection())
                {
                    conn.Open();

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении значения:\n" + ex.Message);
                return null;
            }
        }
    }
}