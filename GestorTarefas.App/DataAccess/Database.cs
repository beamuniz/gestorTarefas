using System;
using System.Data.SQLite;

namespace GestorTarefas.App.DataAccess
{
    public class Database
    {
        private const string connectionString = @"D:\Studies\GestorTarefas.App\GestorTarefas.App\Database";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public static void CriarTabelaTarefas()
        {
            SQLiteConnection connection = null;

            try
            {
                connection = GetConnection();
                connection.Open();

                string sql = @"
                CREATE TABLE IF NOT EXISTS TAREFAS (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nome TEXT NOT NULL,
                Descricao TEXT,
                DataCriacao DATETIME DEFAULT CURRENT_TIMESTAMP
                )";

                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }
    }
}
