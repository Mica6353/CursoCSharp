using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }
        //essa é uma ação do botão somar
        private void btnSomar_Click(object sender, EventArgs e)
        {
            //declarando as variáveis da soma
            double num1, num2, resp = 0.0;

            Operacoes op = new Operacoes();

            resp = op.somaValor(num1, num2);


            //inicializando as variáveis
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            //realizando o calculo de soma
            resp = num1 + num2;

            lblResposta.Text = resp.ToString();

            flag = true;


        }
        bool flag;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            flag = false;
            txtNum1.Clear();
            txtNum2.Clear();
            lblResposta.Text = "";
            txtNum1.Focus();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;

            try
            {

                num1 = double.Parse(txtNum1.Text);
                num2 = double.Parse(txtNum2.Text);

                Operacoes op = new Operacoes();

                if (rdbSoma.Checked)
                {
                    resp = op.somaValor(num1, num2);
                }
                if (rdbSubtração.Checked)
                {
                    resp = op.SubtrairValor(num1, num2);
                }
                if (rdbMutiplicação.Checked)
                {
                    resp = op.multiplicarValor(num1, num2);
                }
                if (rdbDivisão.Checked)
                {
                    resp = op.divideValor(num1, num2);
                }
                if (num2 != 0)
                {
                    MessageBox.Show("Impossivel divisão por zero");
                }
                else
                {
                    resp = op.divideValor(num1, num2);
                }

                lblResultado.Text = resp.ToString();
            }
            catch (Exception ) { 
               MessageBox.Show("Favor inserir valores válidos")
            }

        }

        private void rdbSoma_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
