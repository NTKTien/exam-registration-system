using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam_registration_system.Utils;
using System.Windows.Forms;

public static class SqlServerHelper
{
    public static string ConnectionString { get; set; }

    public static void SetConnection(string user, string password)
    {
        ConnectionString = $"Server=localhost;Database=QLToChucThiCC;User Id={user};Password={password};";
        GlobalInfo.ConnectionString = ConnectionString;
        GlobalInfo.CurrentUsername = user;
    }
    public static void SetConnectionWindowsAuth()
    {
        //ConnectionString = "Server=localhost\\SQLEXPRESS;Database=QLToChucThiCC;Integrated Security=true;";
        //GlobalInfo.ConnectionString = ConnectionString;
        //GlobalInfo.CurrentUsername = Environment.UserName;

        // ConnectionString = "Server=MSI\\TKTHO;Database=QLToChucThiCC;Integrated Security=true;";
        // GlobalInfo.ConnectionString = ConnectionString;
        // GlobalInfo.CurrentUsername = Environment.UserName;

        ConnectionString = "Server=localhost;Database=QLToChucThiCC;Integrated Security=true;";
        GlobalInfo.ConnectionString = ConnectionString;
        GlobalInfo.CurrentUsername = Environment.UserName;
    }
    public static DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
    {
        using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
        {
            conn.Open();
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (var da = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
    public static void ExecuteNonQuery(string sql, params SqlParameter[] parameters)
    {
        using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
        {
            conn.Open();
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                cmd.ExecuteNonQuery();
            }
        }
    }
    public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
    {
        using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
        {
            conn.Open();
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteScalar();
            }
        }
    }
    public static bool TestConnection()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            {
                conn.Open();
                return true;
            }
        }
        catch
        {
            return false;
        }
    }
}
