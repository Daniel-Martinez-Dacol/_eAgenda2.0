using GestaoTarefas.Dominio;
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
    public partial class CadastroCompromissos : Form
    {
        private Compromisso compromisso;
        public CadastroCompromissos()
        {
            InitializeComponent();
        }
        public Compromisso Compromisso
        {
            get { return compromisso; }
            set 
            {
                compromisso = value;
                txtNumero.Text = compromisso.Numero.ToString();
                txtAssunto.Text = compromisso.Assunto;
                txtLocal.Text = compromisso.Local;
                txtData.Text = compromisso.Data.ToShortDateString();
                txtHoraInicio.Text = compromisso.HoraInicio.ToString();
                txtHoraFinal.Text = compromisso.HoraTermino.ToString();

            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            compromisso.Assunto = txtAssunto.Text;
            txtLocal.Text = txtLocal.Text;
            compromisso.Data = Convert.ToDateTime(txtData.Text);
            compromisso.HoraInicio = Convert.ToInt32(txtHoraInicio.Text);
            compromisso.HoraTermino = Convert.ToInt32(txtHoraTermino.Text);
        }
    }
}
