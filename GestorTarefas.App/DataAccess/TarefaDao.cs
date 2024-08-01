using GestorTarefas.App.Interfaces;
using GestorTarefas.App.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace GestorTarefas.App.DataAccess
{
    public class TarefaDao : ITarefaDao
    {
        public void AdicionarTarefa(Tarefa tarefa)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                string sql = "INSERT INTO TAREFAS (Nome, Descricao) VALUES (@Nome, @Descricao)";
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Nome", tarefa.Nome);
                    cmd.Parameters.AddWithValue("@Descricao", tarefa.Descricao);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        List<Tarefa> ITarefaDao.ObterTarefas()
        {
            throw new NotImplementedException();
        }

        void ITarefaDao.AtualizarTarefa(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }

        public void DeletarTarefa(int id)
        {
            throw new NotImplementedException();
        }

        Tarefa ITarefaDao.ObterTarefaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
