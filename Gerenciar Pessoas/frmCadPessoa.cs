using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciar_Pessoas
{
    public partial class frmCadPessoa : Form
    {
        public frmCadPessoa()
        {
            InitializeComponent();
            limparCampos();
        }

        private void btnTestepessoa_Click(object sender, EventArgs e)
        {
            Pessoa ps = new Pessoa();

            ps.Nome = txtNome.Text;
            ps.Email = txtemail.Text;
            ps.TelCel = mskTelefone.Text;

            ltbItensCadastrados.Items.Add(ps.Nome + ps.Email + ps.TelCel);

            limparCampos();
        }

        public void limparCampos()
        {
            txtNome.Clear();
            txtemail.Clear();
            mskTelefone.Clear();
            txtNome.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            ltbItensCadastrados.Items.Clear();
        }

        private void btnTestarClasse_Click(object sender, EventArgs e)
        {
            Pessoa ps = new Pessoa(txtNome.Text, txtemail.Text, mskTelefone.Text);

            ltbItensCadastrados.Items.Add(ps.Nome + ps.Email + ps.TelCel);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmBuscaPessoas abrit = new frmBuscaPessoas();
            abrit.ShowDialog();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
             
        }
    }
}
