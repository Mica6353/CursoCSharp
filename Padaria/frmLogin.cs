using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Padaria
{
    public partial class frmLogin : Form
    {
//Criando variáveis para controle do menu

        const int MF_BYCOMMAND = 0X400;

        [DllImport("user32")]

        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32")]

        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32")]

        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuário_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario, senha;

            usuario = txtUsuário.Text;
            senha = txtSenha.Text;
            if (usuario.Equals("senac") && senha.Equals("senac")) 
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválida!",
                    "Mesagem do sistema", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                txtUsuário.Clear();
                txtSenha.Text = "";
                txtUsuário.Focus();

            }
        }

        private void txtUsuário_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)  
            {
                txtSenha.Focus();
            }

        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnEntrar.Focus();
            }
        }
    }
}
