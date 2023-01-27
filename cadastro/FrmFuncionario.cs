using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carvalhioPDV2.cadastro
{
   
    public partial class FrmFuncionario : Form
    {
        Connection con = new Connection();
        string sql;
        MySqlCommand cmd;
        private string foto;

        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            // Tratamento de dados
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Por favor, preencher o campo Nome", "Cadastro Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtCpf.Text == "   ,   ,   -" || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Por favor, preencher o campo CPF", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return;
            }

            if (txtTel.Text == "  -     -" || txtTel.Text.Length < 15)
            {
                MessageBox.Show("Número de telefone inválido!", "Telefone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTel.Focus();
                return;
            }

            con.OpenConnection();
            sql = "INSERT INTO funcionarios(nome, cpf, telefone, cargo, endereco, data, foto) VALUES(@nome, @cpf, @telefone, @cargo, @endereco, curDate(), @foto)";

            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTel.Text);
            cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@foto", Img());  // img() é o método criado para tratar imagem para o bando de dados

            cmd.ExecuteNonQuery();
            con.CloseConnection();

            cleanPicture();
            MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro de Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            cleanFields();
            printDatas();
            unableFields();             
        }

        private object Img()
        {
            byte[] imagem_byte = null; // variavel usada para enviar o comprimento da imagem
           
            if (foto == "")
            {
                return null;
            }

            // FileStream aqui é usado p/ enviar a imgem p/ o bd mais três parâmetros: local(foto), tipo da imagem(FileMode) e o Tipo de acesso(FileAccess)
            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs); // Usado para trabalhar com o FileStream

            imagem_byte = br.ReadBytes((int)fs.Length); // Pegando o comprimento de FileStream jogando dentro de ma tipo IMAGEM byte

            return imagem_byte;
        }
        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg; *.png) | *.jpg;*.png";  // exibe arquivos do tipo jpg e png
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();  // pega o caminho da imagem selecionada 
                img.ImageLocation = foto;            // atribui o caminho da imagem ao componente no formulário para assim exibi-la
            }
        }
        private void cleanPicture()
        {
            img.Image = Properties.Resources.profile_icon_9;
            foto = "img/profile_icon_9.png";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }

        private void enableFields()
        {
            btnSalvar.Enabled = true;
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtEndereco.Enabled = true;
            btnFoto.Enabled = true;
            txtTel.Enabled = true;
            cbCargo.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void unableFields()
        {
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtTel.Enabled = false;
            cbCargo.Enabled = false;
            txtCpf.Enabled = false;
        }

        private void cleanFields()
        {
            txtNome.Text = "";
            txtTel.Text = "";
            txtCpf.Text = "";
            txtEndereco.Text = "";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            enableFields();
            txtNome.Focus();
        }

        private void printDatas()
        {
            con.OpenConnection();
            sql = "SELECT * FROM funcionarios ORDER BY nome asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.CloseConnection();
            FormatList();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            cleanPicture();
            printDatas();
        }

        private void FormatList()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Funcionário";
            grid.Columns[2].HeaderText = "CPF";
            grid.Columns[3].HeaderText = "Telefone";
            grid.Columns[4].HeaderText = "Cargo";
            grid.Columns[5].HeaderText = "Endereço";
            grid.Columns[6].HeaderText = "Data";
            grid.Columns[7].HeaderText = "Foto";

            grid.Columns[0].Width = 50;
            grid.Columns[6].Width = 50;
            grid.Columns[0].Visible = false;
           // grid.Columns[7].Visible = false;
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                enableFields();
                txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txtCpf.Text = grid.CurrentRow.Cells[2].Value.ToString();
                txtTel.Text = grid.CurrentRow.Cells[3].Value.ToString();
                cbCargo.Text = grid.CurrentRow.Cells[4].Value.ToString();
                txtEndereco.Text = grid.CurrentRow.Cells[5].Value.ToString();
            }
            else
            {
                return;
            }
        }
    }
}

    

     
   