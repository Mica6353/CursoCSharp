﻿using System;
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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            pgbSplash.Value = pgbSplash.Value + 1;

            lblPorcentagem.Text = pgbSplash.Value.ToString() + "%";


            if (pgbSplash.Value < 100)
            {
                pgbSplash.Value = pgbSplash.Value + 1;

                lblPorcentagem.Text = pgbSplash.Value.ToString() + "%";

                frmLogin abrir = new frmLogin();
                abrir.Show();
                this.Hide();
                tmrSplash.Enabled = false;

            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }

        private void pgbSplash_Click(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND)
        }
    }
}

