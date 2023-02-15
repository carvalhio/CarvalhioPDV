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
    public partial class FrmClientes : Form
    {
        Connection con = new Connection();
        string sql;
        MySqlCommand cmd;
       // private string foto;
        //string cpfAntigo;
        //string id;
        string changedImage = "no";
        //string radButton = "";
        //string unblock, blocked;
        //bool emailAdress = false;
        //int codCliente, idAnterior;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
           // changedImage = "no";
            printDatas();
            //btnAtualizar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = true;
 
        }

        private void SearchByName()
        {
            con.OpenConnection();
            sql = "SELECT * FROM clientes WHERE nome LIKE @nome ORDER by nome asc";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtBuscarNome + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.CloseConnection();

            FormatList();
        }

        private void FormatList()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Código";
            grid.Columns[2].HeaderText = "Nome";
            grid.Columns[3].HeaderText = "CPF";
            grid.Columns[4].HeaderText = "Valor devido";
            grid.Columns[5].HeaderText = "Tel.";
            grid.Columns[6].HeaderText = "Email";
            grid.Columns[7].HeaderText = "Status";
            grid.Columns[8].HeaderText = "Situação";
            grid.Columns[9].HeaderText = "Endereçp";
            grid.Columns[10].HeaderText = "Funcionario";
            grid.Columns[11].HeaderText = "Foto";
            grid.Columns[12].HeaderText = "Data";

            grid.Columns[0].Width = 50;
            grid.Columns[6].Width = 50;
            grid.Columns[0].Visible = false;
            // grid.Columns[7].Visible = false;
        }

        private void printDatas()
        {
            con.OpenConnection();
            sql = "SELECT * FROM clientes ORDER BY nome asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.CloseConnection();
            FormatList();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cadastro.FrmNovoCliente frm = new FrmNovoCliente();
            frm.ShowDialog();
        }
    }
}
