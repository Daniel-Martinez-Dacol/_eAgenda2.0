using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoContato.Dominio
{
    public class Contato
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }


        public Contato()
        {

        }

        public Contato(int numero, string n, string e, string t, string m, string c) : this()
        {
            Numero = numero;
            Nome = n;
            Email = e;
            Telefone = t;
            Empresa = m;
            Cargo = c;
        }

        public override string ToString()
        {
            return $"Numero: {Numero}, Nome: {Nome}, Email: {Email}, Telefone: {Telefone}, Empresa:{Empresa}, Cargo: {Cargo} ";
        }
    }
}

