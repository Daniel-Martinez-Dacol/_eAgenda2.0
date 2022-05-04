namespace GestaoTarefas.WinApp
{
    partial class ListagemTarefas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrarItens = new System.Windows.Forms.Button();
            this.btnAtualizarItens = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listTarefasPendentes = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listTarefasConcluidas = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listContatos = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listCompromissos = new System.Windows.Forms.ListBox();
            this.btnExcluirContato = new System.Windows.Forms.Button();
            this.btnEditarContato = new System.Windows.Forms.Button();
            this.btnInserirContato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInserirCompromisso = new System.Windows.Forms.Button();
            this.btnExcluirCompromissos = new System.Windows.Forms.Button();
            this.btnEditarCompromissos = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(45, 67);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(72, 39);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(123, 67);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 38);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(204, 67);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 38);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCadastrarItens
            // 
            this.btnCadastrarItens.Location = new System.Drawing.Point(285, 67);
            this.btnCadastrarItens.Name = "btnCadastrarItens";
            this.btnCadastrarItens.Size = new System.Drawing.Size(113, 38);
            this.btnCadastrarItens.TabIndex = 3;
            this.btnCadastrarItens.Text = "Cadastrar Itens";
            this.btnCadastrarItens.UseVisualStyleBackColor = true;
            this.btnCadastrarItens.Click += new System.EventHandler(this.btnCadastrarItens_Click);
            // 
            // btnAtualizarItens
            // 
            this.btnAtualizarItens.Location = new System.Drawing.Point(404, 68);
            this.btnAtualizarItens.Name = "btnAtualizarItens";
            this.btnAtualizarItens.Size = new System.Drawing.Size(116, 38);
            this.btnAtualizarItens.TabIndex = 4;
            this.btnAtualizarItens.Text = "Atualizar Itens";
            this.btnAtualizarItens.UseVisualStyleBackColor = true;
            this.btnAtualizarItens.Click += new System.EventHandler(this.btnAtualizarItens_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(548, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 279);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listTarefasPendentes);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tarefas Pendentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listTarefasPendentes
            // 
            this.listTarefasPendentes.FormattingEnabled = true;
            this.listTarefasPendentes.ItemHeight = 15;
            this.listTarefasPendentes.Location = new System.Drawing.Point(6, 9);
            this.listTarefasPendentes.Name = "listTarefasPendentes";
            this.listTarefasPendentes.Size = new System.Drawing.Size(547, 229);
            this.listTarefasPendentes.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listTarefasConcluidas);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tarefas Concluídas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listTarefasConcluidas
            // 
            this.listTarefasConcluidas.FormattingEnabled = true;
            this.listTarefasConcluidas.ItemHeight = 15;
            this.listTarefasConcluidas.Location = new System.Drawing.Point(6, 5);
            this.listTarefasConcluidas.Name = "listTarefasConcluidas";
            this.listTarefasConcluidas.Size = new System.Drawing.Size(547, 244);
            this.listTarefasConcluidas.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listContatos);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(559, 251);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Contatos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listContatos
            // 
            this.listContatos.FormattingEnabled = true;
            this.listContatos.ItemHeight = 15;
            this.listContatos.Location = new System.Drawing.Point(6, 10);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(547, 229);
            this.listContatos.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listCompromissos);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(559, 251);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Compromissos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listCompromissos
            // 
            this.listCompromissos.FormattingEnabled = true;
            this.listCompromissos.ItemHeight = 15;
            this.listCompromissos.Location = new System.Drawing.Point(6, 10);
            this.listCompromissos.Name = "listCompromissos";
            this.listCompromissos.Size = new System.Drawing.Size(547, 229);
            this.listCompromissos.TabIndex = 8;
            // 
            // btnExcluirContato
            // 
            this.btnExcluirContato.Location = new System.Drawing.Point(368, 30);
            this.btnExcluirContato.Name = "btnExcluirContato";
            this.btnExcluirContato.Size = new System.Drawing.Size(136, 38);
            this.btnExcluirContato.TabIndex = 9;
            this.btnExcluirContato.Text = "Excluir";
            this.btnExcluirContato.UseVisualStyleBackColor = true;
            this.btnExcluirContato.Click += new System.EventHandler(this.btnExcluirContato_Click);
            // 
            // btnEditarContato
            // 
            this.btnEditarContato.Location = new System.Drawing.Point(188, 30);
            this.btnEditarContato.Name = "btnEditarContato";
            this.btnEditarContato.Size = new System.Drawing.Size(174, 38);
            this.btnEditarContato.TabIndex = 8;
            this.btnEditarContato.Text = "Editar";
            this.btnEditarContato.UseVisualStyleBackColor = true;
            this.btnEditarContato.Click += new System.EventHandler(this.btnEditarContato_Click);
            // 
            // btnInserirContato
            // 
            this.btnInserirContato.Location = new System.Drawing.Point(29, 30);
            this.btnInserirContato.Name = "btnInserirContato";
            this.btnInserirContato.Size = new System.Drawing.Size(150, 39);
            this.btnInserirContato.TabIndex = 7;
            this.btnInserirContato.Text = "Inserir";
            this.btnInserirContato.UseVisualStyleBackColor = true;
            this.btnInserirContato.Click += new System.EventHandler(this.btnInserirContato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(490, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "E-AGENDA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 89);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tarefas e Items";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnInserirContato);
            this.panel2.Controls.Add(this.btnExcluirContato);
            this.panel2.Controls.Add(this.btnEditarContato);
            this.panel2.Location = new System.Drawing.Point(16, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 89);
            this.panel2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contatos";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnInserirCompromisso);
            this.panel3.Controls.Add(this.btnExcluirCompromissos);
            this.panel3.Controls.Add(this.btnEditarCompromissos);
            this.panel3.Location = new System.Drawing.Point(16, 232);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 89);
            this.panel3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Compromissos";
            // 
            // btnInserirCompromisso
            // 
            this.btnInserirCompromisso.Location = new System.Drawing.Point(29, 31);
            this.btnInserirCompromisso.Name = "btnInserirCompromisso";
            this.btnInserirCompromisso.Size = new System.Drawing.Size(150, 39);
            this.btnInserirCompromisso.TabIndex = 7;
            this.btnInserirCompromisso.Text = "Inserir";
            this.btnInserirCompromisso.UseVisualStyleBackColor = true;
            this.btnInserirCompromisso.Click += new System.EventHandler(this.btnInserirCompromisso_Click);
            // 
            // btnExcluirCompromissos
            // 
            this.btnExcluirCompromissos.Location = new System.Drawing.Point(368, 30);
            this.btnExcluirCompromissos.Name = "btnExcluirCompromissos";
            this.btnExcluirCompromissos.Size = new System.Drawing.Size(136, 38);
            this.btnExcluirCompromissos.TabIndex = 9;
            this.btnExcluirCompromissos.Text = "Excluir";
            this.btnExcluirCompromissos.UseVisualStyleBackColor = true;
            this.btnExcluirCompromissos.Click += new System.EventHandler(this.btnExcluirCompromissos_Click);
            // 
            // btnEditarCompromissos
            // 
            this.btnEditarCompromissos.Location = new System.Drawing.Point(188, 30);
            this.btnEditarCompromissos.Name = "btnEditarCompromissos";
            this.btnEditarCompromissos.Size = new System.Drawing.Size(174, 38);
            this.btnEditarCompromissos.TabIndex = 8;
            this.btnEditarCompromissos.Text = "Editar";
            this.btnEditarCompromissos.UseVisualStyleBackColor = true;
            this.btnEditarCompromissos.Click += new System.EventHandler(this.btnEditarCompromissos_Click);
            // 
            // ListagemTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1134, 335);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAtualizarItens);
            this.Controls.Add(this.btnCadastrarItens);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ListagemTarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Agenda 2.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrarItens;
        private System.Windows.Forms.Button btnAtualizarItens;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listTarefasPendentes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listTarefasConcluidas;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnExcluirContato;
        private System.Windows.Forms.Button btnEditarContato;
        private System.Windows.Forms.Button btnInserirContato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listContatos;
        private System.Windows.Forms.ListBox listCompromissos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInserirCompromisso;
        private System.Windows.Forms.Button btnExcluirCompromissos;
        private System.Windows.Forms.Button btnEditarCompromissos;
    }
}