using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoContato.Dominio
{
    public interface IRepositorioContato
    {
        void Editar(Contato Contato);
        void Excluir(Contato Contato);
        void Inserir(Contato novaContato);
        List<Contato> SelecionarTodos();

    }
}
