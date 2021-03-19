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
    public partial class FormControleDeChamados : Form
    {
        public FormControleDeChamados()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormExcluirEquipamento FormExcluirEquipamento = new FormExcluirEquipamento();
            FormExcluirEquipamento.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEditarEquipamento FormEditarEquipamento = new FormEditarEquipamento();
            FormEditarEquipamento.ShowDialog();
        }
    }
}
