using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace carvalhioPDV2.cadastro
{
    public partial class FrmCargo : Form
    {

        Connection con = new Connection();
        string sql;
        MySqlCommand cmd;
        string id;
        string cargoAntigo;

        public FrmCargo()
        {
            InitializeComponent();
        }

        // CARREGAR ABA 'CARGOS'
        private void FrmCargo_Load(object sender, EventArgs e)
        {
            printDatas();
        }

        // FORMATAR DADOS
        private void FormatList()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Cargo";
            grid.Columns[2].HeaderText = "Data";
            // grid.Columns[0].Width = 50; // largura da coluna

            grid.Columns[0].Visible = false; // oculta o id[0] na exibição
        }

        // LISTR DADOS
        private void printDatas()
        {
            con.OpenConnection();
            sql = "SELECT * FROM cargos ORDER BY cargo asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.CloseConnection();
            FormatList();
        }


        // EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Excluir cargo '" +txtCargo.Text+ "'?","Excluir cargo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                con.OpenConnection();
                sql = "DELETE FROM cargos WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.CloseConnection();
                printDatas();

                MessageBox.Show("Cargo '" +txtCargo.Text+ "' excluído com sucesso!", "Cadastro de cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnNovo.Enabled = true;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;

            }
        }

        // SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Por favor, preencher o campo 'Cargo'", "Cadastro de cargos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCargo.Text = "";
                txtCargo.Focus();
                return;
            }

            if (txtCargo.Text != cargoAntigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("SELECT * FROM cargos WHERE cargo = @cargo", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@cargo", txtCargo.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("O cargo "+ txtCargo.Text +" já existe!", "Cadastro de cargos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCargo.Text = "";
                    txtCargo.Focus();
                    return;
                }
            }


            con.OpenConnection();
            sql = "INSERT INTO cargos(cargo, data) VALUES(@cargo, curDate())";
            cmd = new MySqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@cargo", txtCargo.Text);

            cmd.ExecuteNonQuery();
            con.CloseConnection();

            MessageBox.Show("Cargo cadastrado com sucesso!", "Cadastro de cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            txtCargo.Text = "";
            printDatas();

        }


        // CANCELAR
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            //unableFields();
            //cleanFields();
        }

        // BOTAO NOVO
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCargo.Text = "";
            txtCargo.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;

                id = grid.CurrentRow.Cells[0].Value.ToString();
                txtCargo.Text = grid.CurrentRow.Cells[1].Value.ToString();
                cargoAntigo = grid.CurrentRow.Cells[2].Value.ToString();

            }
        }
    }    
}