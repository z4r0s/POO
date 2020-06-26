using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMVCA37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                //Instanciando o DTO do cliente para armazenar os dados da tela
                tblClienteDTO cliente = new tblClienteDTO();
                cliente.Cpf_cliente = txt_cpfA37.Text.Trim();
                cliente.Nome_cliente = txt_nomeA37.Text.Trim();
                cliente.Nome_mae = txt_nomemaeA37.Text.Trim();
                Double CPF = double.Parse(txt_cpfA37.Text);
                // Instanciando a BLL para pesquisa do email e senha do cliente no banco
                tblClienteBLL bllCliente = new tblClienteBLL();
                if (bllCliente.Autenticar(cliente.Cpf_cliente, cliente.Nome_cliente, cliente.Nome_mae))
                {
                    MessageBox.Show("✔️ Beneficiário Localizado no Banco de dados.\n🕗 Processo em Análise", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("❌ Beneficiário Não Localizado no Banco de dados.\n❌ Benefício Negado", "Falhou!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
