using GestorTarefas.App.Models;
using System.Collections.Generic;

namespace GestorTarefas.App.Interfaces
{
    public interface ITarefaDao
    {
        void AdicionarTarefa(Tarefa tarefa);
        List<Tarefa> ObterTarefas();
        Tarefa ObterTarefaPorId(int id);
        void AtualizarTarefa(Tarefa tarefa);
        void DeletarTarefa(int id);
    }
}
