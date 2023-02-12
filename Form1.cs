using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carvalhioPDV2
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuFuncionarios_Click(object sender, EventArgs e)
        {
            cadastro.FrmFuncionario frm = new cadastro.FrmFuncionario();
            frm.ShowDialog();
        }

        private void MenuCargos_Click(object sender, EventArgs e)
        {
            cadastro.FrmCargo frm = new cadastro.FrmCargo();
            frm.ShowDialog();
        }
    }
}
