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

namespace carvalhioPDV2.cadastro
{
    public partial class FrmCargo : Form
    {

        Connection con = new Connection();
        string sql;
        MySqlCommand cmd;
        private string foto;
        string cpfAntigo;
        string id;
        string changedImage = "no";


        public FrmCargo()
        {
            InitializeComponent();
        }

        // CARREGAR ABA 'CARGOS'
        private void FrmCargo_Load(object sender, EventArgs e)
        {

        }

        // FORMATAR DADOS
        private void FormatList()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Cargo";
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
            var msg = MessageBox.Show("Tem certeza?", "Excluir cargo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                con.OpenConnection();
                sql = "DELETE FROM cargos WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.CloseConnection();
                printDatas();

                MessageBox.Show("Cargo excluído com sucesso!", "Cadastro de cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Por favor, preencher o campo 'Cargo'", "Cadastro Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCargo.Text = "";
                txtCargo.Focus();
                return;
            }
           

            con.OpenConnection();
            sql = "INSERT INTO cargos(cargo, data) VALUES(@cargo, curDate(), @foto)";
            cmd = new MySqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@cargo", txtCargo.Text);

            cmd.ExecuteNonQuery();
            con.CloseConnection();

            MessageBox.Show("Cargo cadastrado com sucesso!", "Cadastro de cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
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
    }    
}