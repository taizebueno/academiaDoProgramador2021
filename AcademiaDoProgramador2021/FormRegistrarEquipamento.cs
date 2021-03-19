using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaDoProgramador2021
{
    public partial class FormRegistrarEquipamento : Form
    {
        private Models.EquipamentoModel equipamento;

        public FormRegistrarEquipamento()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                equipamento = new Models.EquipamentoModel();
                equipamento.nome = txtNome.Text;
                equipamento.numero_serie = Convert.ToInt32(txtNumeroSerie.Text);
                equipamento.preco = Convert.ToDouble(txtPreco.Text);
                equipamento.data_fabricacao = txtDataFabricacao.Text;
       
                equipamento.Inserir();

                txtNome.Clear();
                txtNumeroSerie.Clear();
                txtPreco.Clear();
                txtDataFabricacao.Clear();
                MessageBox.Show("Sucesso ao cadastrar o equipamento", "Equipamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação de inserir o equipamento: " + erro , "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
