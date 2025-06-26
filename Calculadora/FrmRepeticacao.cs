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
    public partial class FrmRepeticacao : Form
    {
        public FrmRepeticacao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            cbbCategorias.Items.Add("Vestuarios");
        }

        private void cbbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbCategorias.Items.Clear();

            cbbCategorias.Items.Add("Vestuario"); 

            cbbCategorias.Items.Add("Pescados");

            cbbCategorias.Items.Add("Padaria");

            cbbCategorias.Items.Add("Medicamentos");

            cbbCategorias.Items.Add("Conmeticos");

            cbbCategorias.Items.Add("Frutas");

            cbbCategorias.Items.Add("Pets");

            cbbCategorias.Items.Add("calçados");

            cbbCategorias.Items.Add("Eletrodomesticos");


            int[] valor = new int[5];

            valor[0]= 10;
            valor[1] = 20;
            valor[2] = 30; 
            valor[3] = 50;
            valor[4] = 100;

            cbbCategorias.Items.Add(valor[0]);

            for (int i = 0; i < 5; i++)
            {
                cbbCategorias.Items.Add(valor[i]);
            }
        }

        private void FrmRepeticacao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[5];

            nomes[0] = "Funcionarios";
            nomes[1] = "caixa";
            nomes[2] = "Recepção";
            nomes[3] = "Balcão";
            nomes[4] = "Produção";

            ltbCategoria.Items.Clear();

            for (int cont = 0; cont <=5;cont++) ;
            {
                ltbCategoria.Items.Add(nomes[0]);
            }
            

        }
    }
}
