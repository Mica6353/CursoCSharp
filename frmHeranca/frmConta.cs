﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmHeranca
{
    public partial class frmConta : Form
    {
        public frmConta()
        {
            InitializeComponent();
        }

        private void frmConta_Load(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                private void radioButton2_CheckedChanged(object sender, EventArgs e)
                {
                    double valor, porc, reso;

                    valor = Convert.ToDouble(txtValor.Text);
                    porc = Convert.ToDouble(txtPorcentagem.Text);

                    poupanca cp = new poupanca();

                    resp = cp.calculoRendimento(porc, valor);

                    ltbExtrato.Items.Add("valor a receber" + resp);
                }
            }
        }

        Conta conta = new Conta();

        private void btnConta_Click(object sender, EventArgs e)
        {
           
            conta.Valor = 1500.00;
            MessageBox.Show("Valor da sua conta:" + conta.Valor);
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            conta.Valor = Convert.ToDouble(txtValor.text);

            double[] saldo = new double[10];

            for (int i =0; i < saldo.Length; i++)
            {
                saldo[i] = conta.depositar(saldo[i]0);

            }
            for int i = 0; i < saldo.Length; i++0) ;
            {
                extrato.items.Add("R$" + saldo[i]);
            }


           

            
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            Poupanca poupanca = new poupanca();
            poupanca.
        }

        
    }
    }

