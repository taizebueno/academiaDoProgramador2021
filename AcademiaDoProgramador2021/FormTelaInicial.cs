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
    public partial class FormTelaInicial : Form
    {
        public FormTelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Equipamentos VisualizarEquipamentos = new Equipamentos();
            VisualizarEquipamentos.ShowDialog();
        }

        private void btnEquipamentos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equipamentos Equipamentos = new Equipamentos();
            Equipamentos.ShowDialog();
        }

        private void btnChamados_Clic(object sender, EventArgs e)
        {
            this.Hide();
            FormChamados FormChamados = new FormChamados();
            FormChamados.ShowDialog();
        }
    }
}
