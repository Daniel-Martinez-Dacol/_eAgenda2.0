using GestaoContato.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestaoTarefas.WinApp
{
    public partial class CadastroContato : Form
    {
        private Contato contato;

        public CadastroContato()
        {
            InitializeComponent();
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {

        }
        
        public Contato Contato
        {
            get { return contato; }
            set
            {
                contato = value;
                txtNumero.Text = contato.Numero.ToString();
                txtNome.Text = contato.Nome;
                txtEmail.Text = contato.Email;
                txtTelefone.Text = contato.Telefone;
                txtEmpresa.Text = contato.Empresa;
                txtCargo.Text = contato.Cargo;
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            contato.Nome = txtNumero.Text;
            contato.Email = txtEmail.Text;
            contato.Telefone = txtTelefone.Text;
            contato.Empresa = txtEmpresa.Text;
            contato.Cargo = txtCargo.Text;
        }
    }
}
