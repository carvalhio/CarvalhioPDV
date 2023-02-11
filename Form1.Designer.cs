
namespace carvalhioPDV2
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.frmPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuários = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentações = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFluxoDeCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLançarVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntradasSaídas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutosRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVendasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentosRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntradasSaídasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDespesasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.img01 = new System.Windows.Forms.PictureBox();
            this.frmPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            this.SuspendLayout();
            // 
            // frmPrincipal
            // 
            this.frmPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastros,
            this.MenuProdutos,
            this.MenuMovimentações,
            this.MenuRelatorios,
            this.MenuSair});
            this.frmPrincipal.Location = new System.Drawing.Point(0, 0);
            this.frmPrincipal.Name = "frmPrincipal";
            this.frmPrincipal.Size = new System.Drawing.Size(921, 24);
            this.frmPrincipal.TabIndex = 0;
            this.frmPrincipal.Text = "menuStrip1";
            // 
            // MenuCadastros
            // 
            this.MenuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFuncionarios,
            this.MenuClientes,
            this.MenuUsuários,
            this.MenuCargos,
            this.MenuFornecedores});
            this.MenuCadastros.Name = "MenuCadastros";
            this.MenuCadastros.Size = new System.Drawing.Size(71, 20);
            this.MenuCadastros.Text = "Cadastros";
            // 
            // MenuFuncionarios
            // 
            this.MenuFuncionarios.Name = "MenuFuncionarios";
            this.MenuFuncionarios.Size = new System.Drawing.Size(180, 22);
            this.MenuFuncionarios.Text = "Funcionários";
            this.MenuFuncionarios.Click += new System.EventHandler(this.MenuFuncionarios_Click);
            // 
            // MenuClientes
            // 
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(180, 22);
            this.MenuClientes.Text = "Clientes";
            // 
            // MenuUsuários
            // 
            this.MenuUsuários.Name = "MenuUsuários";
            this.MenuUsuários.Size = new System.Drawing.Size(180, 22);
            this.MenuUsuários.Text = "Usuários";
            // 
            // MenuCargos
            // 
            this.MenuCargos.Name = "MenuCargos";
            this.MenuCargos.Size = new System.Drawing.Size(180, 22);
            this.MenuCargos.Text = "Cargos";
            this.MenuCargos.Click += new System.EventHandler(this.MenuCargos_Click);
            // 
            // MenuFornecedores
            // 
            this.MenuFornecedores.Name = "MenuFornecedores";
            this.MenuFornecedores.Size = new System.Drawing.Size(180, 22);
            this.MenuFornecedores.Text = "Fornecedores";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProduto,
            this.MenuEstoque});
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(67, 20);
            this.MenuProdutos.Text = "Produtos";
            // 
            // MenuProduto
            // 
            this.MenuProduto.Name = "MenuProduto";
            this.MenuProduto.Size = new System.Drawing.Size(122, 22);
            this.MenuProduto.Text = "Produtos";
            // 
            // MenuEstoque
            // 
            this.MenuEstoque.Name = "MenuEstoque";
            this.MenuEstoque.Size = new System.Drawing.Size(122, 22);
            this.MenuEstoque.Text = "Estoque";
            // 
            // MenuMovimentações
            // 
            this.MenuMovimentações.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFluxoDeCaixa,
            this.MenuLançarVenda,
            this.MenuEntradasSaídas,
            this.MenuDespesas});
            this.MenuMovimentações.Name = "MenuMovimentações";
            this.MenuMovimentações.Size = new System.Drawing.Size(104, 20);
            this.MenuMovimentações.Text = "Movimentações";
            // 
            // MenuFluxoDeCaixa
            // 
            this.MenuFluxoDeCaixa.Name = "MenuFluxoDeCaixa";
            this.MenuFluxoDeCaixa.Size = new System.Drawing.Size(163, 22);
            this.MenuFluxoDeCaixa.Text = "Fluxo Caixa";
            // 
            // MenuLançarVenda
            // 
            this.MenuLançarVenda.Name = "MenuLançarVenda";
            this.MenuLançarVenda.Size = new System.Drawing.Size(163, 22);
            this.MenuLançarVenda.Text = "Lançar Venda";
            // 
            // MenuEntradasSaídas
            // 
            this.MenuEntradasSaídas.Name = "MenuEntradasSaídas";
            this.MenuEntradasSaídas.Size = new System.Drawing.Size(163, 22);
            this.MenuEntradasSaídas.Text = "Entradas / Saídas";
            // 
            // MenuDespesas
            // 
            this.MenuDespesas.Name = "MenuDespesas";
            this.MenuDespesas.Size = new System.Drawing.Size(163, 22);
            this.MenuDespesas.Text = "Despesas";
            // 
            // MenuRelatorios
            // 
            this.MenuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProdutosRel,
            this.MenuVendasRel,
            this.MenuMovimentosRel,
            this.MenuEntradasSaídasRel,
            this.MenuDespesasRel});
            this.MenuRelatorios.Name = "MenuRelatorios";
            this.MenuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.MenuRelatorios.Text = "Relatórios";
            // 
            // MenuProdutosRel
            // 
            this.MenuProdutosRel.Name = "MenuProdutosRel";
            this.MenuProdutosRel.Size = new System.Drawing.Size(163, 22);
            this.MenuProdutosRel.Text = "Produtos";
            // 
            // MenuVendasRel
            // 
            this.MenuVendasRel.Name = "MenuVendasRel";
            this.MenuVendasRel.Size = new System.Drawing.Size(163, 22);
            this.MenuVendasRel.Text = "Vendas";
            // 
            // MenuMovimentosRel
            // 
            this.MenuMovimentosRel.Name = "MenuMovimentosRel";
            this.MenuMovimentosRel.Size = new System.Drawing.Size(163, 22);
            this.MenuMovimentosRel.Text = "Movimentos";
            // 
            // MenuEntradasSaídasRel
            // 
            this.MenuEntradasSaídasRel.Name = "MenuEntradasSaídasRel";
            this.MenuEntradasSaídasRel.Size = new System.Drawing.Size(163, 22);
            this.MenuEntradasSaídasRel.Text = "Entradas / Saídas";
            // 
            // MenuDespesasRel
            // 
            this.MenuDespesasRel.Name = "MenuDespesasRel";
            this.MenuDespesasRel.Size = new System.Drawing.Size(163, 22);
            this.MenuDespesasRel.Text = "Despesas";
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(38, 20);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // img01
            // 
            this.img01.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.img01.Image = global::carvalhioPDV2.Properties.Resources.logo2;
            this.img01.Location = new System.Drawing.Point(181, 44);
            this.img01.Name = "img01";
            this.img01.Size = new System.Drawing.Size(552, 406);
            this.img01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img01.TabIndex = 2;
            this.img01.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(921, 479);
            this.Controls.Add(this.img01);
            this.Controls.Add(this.frmPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.frmPrincipal.ResumeLayout(false);
            this.frmPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip frmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentações;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox img01;
        private System.Windows.Forms.ToolStripMenuItem MenuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem MenuClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuários;
        private System.Windows.Forms.ToolStripMenuItem MenuCargos;
        private System.Windows.Forms.ToolStripMenuItem MenuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem MenuProduto;
        private System.Windows.Forms.ToolStripMenuItem MenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem MenuFluxoDeCaixa;
        private System.Windows.Forms.ToolStripMenuItem MenuLançarVenda;
        private System.Windows.Forms.ToolStripMenuItem MenuEntradasSaídas;
        private System.Windows.Forms.ToolStripMenuItem MenuDespesas;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutosRel;
        private System.Windows.Forms.ToolStripMenuItem MenuVendasRel;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentosRel;
        private System.Windows.Forms.ToolStripMenuItem MenuEntradasSaídasRel;
        private System.Windows.Forms.ToolStripMenuItem MenuDespesasRel;
    }
}

