using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.Dominio
{
    public interface IRepositorioCompromisso
    {
        void Editar(Compromisso Compromisso);
        void Excluir(Compromisso Compromisso);
        void Inserir(Compromisso novaCompromisso);
        List<Compromisso> SelecionarTodos();
    }
}
