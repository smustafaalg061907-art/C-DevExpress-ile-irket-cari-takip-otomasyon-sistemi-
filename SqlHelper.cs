using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace StokProjesi.Models
{
    public static class SqlHelper
    {
        // Bağlantı dizesi - LocalDB veya yerel SQL Express için yapılandırılmıştır.
        private static string ServerName = "."; // Veya "(localdb)\\MSSQLLocalDB"
        private static string DatabaseName = "STOK_OTOMASYON";
        
        public static string ConnectionString => $"Server={ServerName};Database={DatabaseName};Trusted_Connection=True;TrustServerCertificate=True;";
        private static string MasterConnectionString => $"Server={ServerName};Database=master;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            {
                using (var cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetDataTable(string query, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            {
                using (var cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            {
                using (var cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static void CheckDatabase()
        {
            try
            {
                // Önce veritabanı var mı kontrol et
                using (var conn = new SqlConnection(MasterConnectionString))
                {
                    conn.Open();
                    string checkDbQuery = $"SELECT database_id FROM sys.databases WHERE name = '{DatabaseName}'";
                    var result = new SqlCommand(checkDbQuery, conn).ExecuteScalar();

                    if (result == null)
                    {
                        // Veritabanı yok, oluştur
                        new SqlCommand($"CREATE DATABASE {DatabaseName}", conn).ExecuteNonQuery();
                        
                        // Script dosyasını oku ve çalıştır
                        string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DatabaseScript.sql");
                        if (!File.Exists(scriptPath))
                        {
                            // Eğer bin klasöründe yoksa proje kök dizinine bak (Geliştirme aşaması için)
                            scriptPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "DatabaseScript.sql");
                        }

                        if (File.Exists(scriptPath))
                        {
                            string script = File.ReadAllText(scriptPath);
                            ExecuteScript(script);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı kontrolü sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void ExecuteScript(string script)
        {
            // SQL script'ini GO komutlarına göre parçala
            string[] commands = script.Split(new[] { "GO", "go", "Go", "gO" }, StringSplitOptions.RemoveEmptyEntries);
            
            using (var conn = GetConnection())
            {
                conn.Open();
                foreach (var command in commands)
                {
                    if (string.IsNullOrWhiteSpace(command)) continue;
                    
                    // USE komutlarını atla veya temizle (zaten bağlıyız)
                    if (command.Trim().StartsWith("USE", StringComparison.OrdinalIgnoreCase)) continue;
                    if (command.Trim().StartsWith("CREATE DATABASE", StringComparison.OrdinalIgnoreCase)) continue;

                    using (var cmd = new SqlCommand(command, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
