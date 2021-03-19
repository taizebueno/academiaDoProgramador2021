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
    public partial class FormChamados : Form
    {
        public FormChamados()
        {
            InitializeComponent();
        }

        private void button1_CClick(object sender, EventArgs e)
        {
            
        }

        private void Cadastro_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTelaInicial_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTelaInicial FormTelaInicial = new FormTelaInicial();
            FormTelaInicial.ShowDialog();
        }

        private void btnChamados_Click(object sender, EventArgs e)
        {

        }

        private void btnEquipamentos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equipamentos Equipamentos = new Equipamentos();
            Equipamentos.ShowDialog();
        }
    }
}
