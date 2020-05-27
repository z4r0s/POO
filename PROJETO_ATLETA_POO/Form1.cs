using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_ATLETA_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Atleta obj = new Atleta();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Nome = txtNome.Text;
                obj.Idade = int.Parse(txtIdade.Text);
                obj.Altura = double.Parse(txtAltura.Text);
                obj.Peso = double.Parse(txtPeso.Text);
                MessageBox.Show("Dados armazenados.");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro. \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obj.ImprimirDados());
            txtIMC.Text = obj.CalcularIMC().ToString();
        }
    }
}
