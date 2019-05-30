namespace SmartRetail
{
    partial class App
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
            this.TabCtrl = new System.Windows.Forms.TabControl();
            this.LoginPageTab = new System.Windows.Forms.TabPage();
            this.ErrorLoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.MessageLoginPage = new System.Windows.Forms.RichTextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.LimparBtn = new System.Windows.Forms.Button();
            this.PwdTextBox = new System.Windows.Forms.TextBox();
            this.FornecedorTab = new System.Windows.Forms.TabPage();
            this.FornecedorCtrl = new System.Windows.Forms.TabControl();
            this.FornecedorCtrlHome = new System.Windows.Forms.TabPage();
            this.FornecedorCtrlCadastrar = new System.Windows.Forms.TabPage();
            this.GerenteTab = new System.Windows.Forms.TabPage();
            this.GerenteCtrl = new System.Windows.Forms.TabControl();
            this.GerenteCtrlHome = new System.Windows.Forms.TabPage();
            this.GerenteCtrlGerProd = new System.Windows.Forms.TabPage();
            this.GerenteCtrlConsDados = new System.Windows.Forms.TabPage();
            this.GerCtrlCons_Label1 = new System.Windows.Forms.Label();
            this.GerCtrlCons_ComboBox = new System.Windows.Forms.ComboBox();
            this.GerenteCtrlGerOfertas = new System.Windows.Forms.TabPage();
            this.GerenteCtrlCadastrar = new System.Windows.Forms.TabPage();
            this.GerCtrlCad_ErrorTextBox = new System.Windows.Forms.TextBox();
            this.GerCtrlCad_CadastrarBtn = new System.Windows.Forms.Button();
            this.GerCtrlCad_ClearBtn = new System.Windows.Forms.Button();
            this.GerCtrlCad_ProdTable = new System.Windows.Forms.DataGridView();
            this.GerCadProd_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GerCadProd_Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GerCadProd_Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GerCtrlCad_Label8 = new System.Windows.Forms.Label();
            this.GerCtrlCad_SenhaRep = new System.Windows.Forms.TextBox();
            this.GerCtrlCad_Label7 = new System.Windows.Forms.Label();
            this.GerCtrlCad_Senha = new System.Windows.Forms.TextBox();
            this.GerCtrlCad_Label6 = new System.Windows.Forms.Label();
            this.GerCtrlCad_Telefone = new System.Windows.Forms.TextBox();
            this.GerCtrlCad_Label5 = new System.Windows.Forms.Label();
            this.GerCtrlCad_Email = new System.Windows.Forms.TextBox();
            this.GerCtrlCad_Label4 = new System.Windows.Forms.Label();
            this.GerCtrlCad_Cadastro = new System.Windows.Forms.TextBox();
            this.GerCtrlCad_Label3 = new System.Windows.Forms.Label();
            this.GerCtrlCad_Nome = new System.Windows.Forms.TextBox();
            this.GerCtrlCad_Label2 = new System.Windows.Forms.Label();
            this.GerCtrlCad_Label1 = new System.Windows.Forms.Label();
            this.GerCtrlCad_ComboBox = new System.Windows.Forms.ComboBox();
            this.GerenteCtrlRemover = new System.Windows.Forms.TabPage();
            this.GerCtrlRem_ErrorTextBox = new System.Windows.Forms.TextBox();
            this.GerCtrlRem_RemoverBtn = new System.Windows.Forms.Button();
            this.GerCtrlRem_ClearBtn = new System.Windows.Forms.Button();
            this.GerCtrlRem_Label3 = new System.Windows.Forms.Label();
            this.GerCtrlRem_EmailRep = new System.Windows.Forms.TextBox();
            this.GerCtrlRem_Label2 = new System.Windows.Forms.Label();
            this.GerCtrlRem_Email = new System.Windows.Forms.TextBox();
            this.GerCtrlRem_Label1 = new System.Windows.Forms.Label();
            this.GerCtrlRem_ComboBox = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LogoffForBtn = new System.Windows.Forms.PictureBox();
            this.LogoffGerBtn = new System.Windows.Forms.PictureBox();
            this.TabCtrl.SuspendLayout();
            this.LoginPageTab.SuspendLayout();
            this.FornecedorTab.SuspendLayout();
            this.FornecedorCtrl.SuspendLayout();
            this.FornecedorCtrlHome.SuspendLayout();
            this.GerenteTab.SuspendLayout();
            this.GerenteCtrl.SuspendLayout();
            this.GerenteCtrlHome.SuspendLayout();
            this.GerenteCtrlConsDados.SuspendLayout();
            this.GerenteCtrlCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GerCtrlCad_ProdTable)).BeginInit();
            this.GerenteCtrlRemover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoffForBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoffGerBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // TabCtrl
            // 
            this.TabCtrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabCtrl.Controls.Add(this.LoginPageTab);
            this.TabCtrl.Controls.Add(this.FornecedorTab);
            this.TabCtrl.Controls.Add(this.GerenteTab);
            this.TabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCtrl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabCtrl.ItemSize = new System.Drawing.Size(0, 1);
            this.TabCtrl.Location = new System.Drawing.Point(0, 0);
            this.TabCtrl.Margin = new System.Windows.Forms.Padding(0);
            this.TabCtrl.Name = "TabCtrl";
            this.TabCtrl.Padding = new System.Drawing.Point(0, 0);
            this.TabCtrl.SelectedIndex = 0;
            this.TabCtrl.Size = new System.Drawing.Size(284, 511);
            this.TabCtrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabCtrl.TabIndex = 0;
            this.TabCtrl.TabStop = false;
            // 
            // LoginPageTab
            // 
            this.LoginPageTab.Controls.Add(this.ErrorLoginTextBox);
            this.LoginPageTab.Controls.Add(this.LoginText);
            this.LoginPageTab.Controls.Add(this.MessageLoginPage);
            this.LoginPageTab.Controls.Add(this.LoginBtn);
            this.LoginPageTab.Controls.Add(this.EmailTextBox);
            this.LoginPageTab.Controls.Add(this.LimparBtn);
            this.LoginPageTab.Controls.Add(this.PwdTextBox);
            this.LoginPageTab.Location = new System.Drawing.Point(4, 5);
            this.LoginPageTab.Margin = new System.Windows.Forms.Padding(0);
            this.LoginPageTab.Name = "LoginPageTab";
            this.LoginPageTab.Size = new System.Drawing.Size(276, 502);
            this.LoginPageTab.TabIndex = 2;
            this.LoginPageTab.Text = "LoginPageTab";
            this.LoginPageTab.UseVisualStyleBackColor = true;
            // 
            // ErrorLoginTextBox
            // 
            this.ErrorLoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLoginTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ErrorLoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorLoginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ErrorLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLoginTextBox.ForeColor = System.Drawing.Color.Red;
            this.ErrorLoginTextBox.Location = new System.Drawing.Point(8, 370);
            this.ErrorLoginTextBox.Name = "ErrorLoginTextBox";
            this.ErrorLoginTextBox.ReadOnly = true;
            this.ErrorLoginTextBox.Size = new System.Drawing.Size(260, 15);
            this.ErrorLoginTextBox.TabIndex = 5;
            this.ErrorLoginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ErrorLoginTextBox.Visible = false;
            // 
            // LoginText
            // 
            this.LoginText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginText.BackColor = System.Drawing.Color.Black;
            this.LoginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginText.Enabled = false;
            this.LoginText.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginText.ForeColor = System.Drawing.Color.White;
            this.LoginText.Location = new System.Drawing.Point(3, 3);
            this.LoginText.MaxLength = 10;
            this.LoginText.Name = "LoginText";
            this.LoginText.ReadOnly = true;
            this.LoginText.Size = new System.Drawing.Size(270, 68);
            this.LoginText.TabIndex = 0;
            this.LoginText.Text = "LOGIN";
            this.LoginText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginText.WordWrap = false;
            // 
            // MessageLoginPage
            // 
            this.MessageLoginPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageLoginPage.BackColor = System.Drawing.SystemColors.Control;
            this.MessageLoginPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageLoginPage.DetectUrls = false;
            this.MessageLoginPage.Enabled = false;
            this.MessageLoginPage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLoginPage.Location = new System.Drawing.Point(8, 112);
            this.MessageLoginPage.Name = "MessageLoginPage";
            this.MessageLoginPage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MessageLoginPage.Size = new System.Drawing.Size(260, 105);
            this.MessageLoginPage.TabIndex = 0;
            this.MessageLoginPage.Text = "Para acessar o sistema, é preciso fazer login com suas credenciais de Gerente ou " +
    "Fornecedor.";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(185, 447);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(83, 30);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(8, 270);
            this.EmailTextBox.MaxLength = 50;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(260, 24);
            this.EmailTextBox.TabIndex = 1;
            this.EmailTextBox.Text = "Email";
            this.EmailTextBox.WordWrap = false;
            this.EmailTextBox.Click += new System.EventHandler(this.EmailTextBox_Click);
            // 
            // LimparBtn
            // 
            this.LimparBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LimparBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimparBtn.Location = new System.Drawing.Point(8, 447);
            this.LimparBtn.Name = "LimparBtn";
            this.LimparBtn.Size = new System.Drawing.Size(83, 30);
            this.LimparBtn.TabIndex = 3;
            this.LimparBtn.Text = "Limpar";
            this.LimparBtn.UseVisualStyleBackColor = true;
            this.LimparBtn.Click += new System.EventHandler(this.LimparBtn_Click);
            // 
            // PwdTextBox
            // 
            this.PwdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PwdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwdTextBox.Location = new System.Drawing.Point(8, 313);
            this.PwdTextBox.MaxLength = 32;
            this.PwdTextBox.Name = "PwdTextBox";
            this.PwdTextBox.Size = new System.Drawing.Size(260, 24);
            this.PwdTextBox.TabIndex = 2;
            this.PwdTextBox.Text = "Password";
            this.PwdTextBox.UseSystemPasswordChar = true;
            this.PwdTextBox.WordWrap = false;
            this.PwdTextBox.Click += new System.EventHandler(this.PwdTextBox_Click);
            // 
            // FornecedorTab
            // 
            this.FornecedorTab.Controls.Add(this.FornecedorCtrl);
            this.FornecedorTab.Location = new System.Drawing.Point(4, 5);
            this.FornecedorTab.Margin = new System.Windows.Forms.Padding(0);
            this.FornecedorTab.Name = "FornecedorTab";
            this.FornecedorTab.Size = new System.Drawing.Size(276, 502);
            this.FornecedorTab.TabIndex = 0;
            this.FornecedorTab.Text = "FornecedorTab";
            this.FornecedorTab.UseVisualStyleBackColor = true;
            // 
            // FornecedorCtrl
            // 
            this.FornecedorCtrl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.FornecedorCtrl.Controls.Add(this.FornecedorCtrlHome);
            this.FornecedorCtrl.Controls.Add(this.FornecedorCtrlCadastrar);
            this.FornecedorCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FornecedorCtrl.Location = new System.Drawing.Point(0, 0);
            this.FornecedorCtrl.Multiline = true;
            this.FornecedorCtrl.Name = "FornecedorCtrl";
            this.FornecedorCtrl.SelectedIndex = 0;
            this.FornecedorCtrl.Size = new System.Drawing.Size(276, 502);
            this.FornecedorCtrl.TabIndex = 0;
            // 
            // FornecedorCtrlHome
            // 
            this.FornecedorCtrlHome.BackColor = System.Drawing.SystemColors.Control;
            this.FornecedorCtrlHome.Controls.Add(this.LogoffForBtn);
            this.FornecedorCtrlHome.Location = new System.Drawing.Point(23, 4);
            this.FornecedorCtrlHome.Name = "FornecedorCtrlHome";
            this.FornecedorCtrlHome.Padding = new System.Windows.Forms.Padding(3);
            this.FornecedorCtrlHome.Size = new System.Drawing.Size(249, 494);
            this.FornecedorCtrlHome.TabIndex = 0;
            this.FornecedorCtrlHome.Text = "Home";
            // 
            // FornecedorCtrlCadastrar
            // 
            this.FornecedorCtrlCadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.FornecedorCtrlCadastrar.Location = new System.Drawing.Point(23, 4);
            this.FornecedorCtrlCadastrar.Name = "FornecedorCtrlCadastrar";
            this.FornecedorCtrlCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.FornecedorCtrlCadastrar.Size = new System.Drawing.Size(249, 494);
            this.FornecedorCtrlCadastrar.TabIndex = 1;
            this.FornecedorCtrlCadastrar.Text = "Cadastrar";
            // 
            // GerenteTab
            // 
            this.GerenteTab.Controls.Add(this.GerenteCtrl);
            this.GerenteTab.Location = new System.Drawing.Point(4, 5);
            this.GerenteTab.Margin = new System.Windows.Forms.Padding(0);
            this.GerenteTab.Name = "GerenteTab";
            this.GerenteTab.Size = new System.Drawing.Size(276, 502);
            this.GerenteTab.TabIndex = 1;
            this.GerenteTab.Text = "GerenteTab";
            this.GerenteTab.UseVisualStyleBackColor = true;
            // 
            // GerenteCtrl
            // 
            this.GerenteCtrl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.GerenteCtrl.Controls.Add(this.GerenteCtrlHome);
            this.GerenteCtrl.Controls.Add(this.GerenteCtrlGerProd);
            this.GerenteCtrl.Controls.Add(this.GerenteCtrlConsDados);
            this.GerenteCtrl.Controls.Add(this.GerenteCtrlGerOfertas);
            this.GerenteCtrl.Controls.Add(this.GerenteCtrlCadastrar);
            this.GerenteCtrl.Controls.Add(this.GerenteCtrlRemover);
            this.GerenteCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GerenteCtrl.Location = new System.Drawing.Point(0, 0);
            this.GerenteCtrl.Multiline = true;
            this.GerenteCtrl.Name = "GerenteCtrl";
            this.GerenteCtrl.SelectedIndex = 0;
            this.GerenteCtrl.Size = new System.Drawing.Size(276, 502);
            this.GerenteCtrl.TabIndex = 0;
            // 
            // GerenteCtrlHome
            // 
            this.GerenteCtrlHome.BackColor = System.Drawing.SystemColors.Control;
            this.GerenteCtrlHome.Controls.Add(this.LogoffGerBtn);
            this.GerenteCtrlHome.Location = new System.Drawing.Point(23, 4);
            this.GerenteCtrlHome.Name = "GerenteCtrlHome";
            this.GerenteCtrlHome.Padding = new System.Windows.Forms.Padding(3);
            this.GerenteCtrlHome.Size = new System.Drawing.Size(249, 494);
            this.GerenteCtrlHome.TabIndex = 0;
            this.GerenteCtrlHome.Text = "Home";
            // 
            // GerenteCtrlGerProd
            // 
            this.GerenteCtrlGerProd.BackColor = System.Drawing.SystemColors.Control;
            this.GerenteCtrlGerProd.Location = new System.Drawing.Point(23, 4);
            this.GerenteCtrlGerProd.Name = "GerenteCtrlGerProd";
            this.GerenteCtrlGerProd.Size = new System.Drawing.Size(249, 494);
            this.GerenteCtrlGerProd.TabIndex = 3;
            this.GerenteCtrlGerProd.Text = "Produtos";
            // 
            // GerenteCtrlConsDados
            // 
            this.GerenteCtrlConsDados.BackColor = System.Drawing.SystemColors.Control;
            this.GerenteCtrlConsDados.Controls.Add(this.GerCtrlCons_Label1);
            this.GerenteCtrlConsDados.Controls.Add(this.GerCtrlCons_ComboBox);
            this.GerenteCtrlConsDados.Location = new System.Drawing.Point(23, 4);
            this.GerenteCtrlConsDados.Name = "GerenteCtrlConsDados";
            this.GerenteCtrlConsDados.Padding = new System.Windows.Forms.Padding(3);
            this.GerenteCtrlConsDados.Size = new System.Drawing.Size(249, 494);
            this.GerenteCtrlConsDados.TabIndex = 4;
            this.GerenteCtrlConsDados.Text = "Consultar";
            // 
            // GerCtrlCons_Label1
            // 
            this.GerCtrlCons_Label1.AutoSize = true;
            this.GerCtrlCons_Label1.Location = new System.Drawing.Point(6, 15);
            this.GerCtrlCons_Label1.Name = "GerCtrlCons_Label1";
            this.GerCtrlCons_Label1.Size = new System.Drawing.Size(57, 13);
            this.GerCtrlCons_Label1.TabIndex = 1;
            this.GerCtrlCons_Label1.Text = "Selecione:";
            // 
            // GerCtrlCons_ComboBox
            // 
            this.GerCtrlCons_ComboBox.FormattingEnabled = true;
            this.GerCtrlCons_ComboBox.Items.AddRange(new object[] {
            "Vendas",
            "Estoque",
            "Fornecimento",
            "Clientes",
            "Gastos"});
            this.GerCtrlCons_ComboBox.Location = new System.Drawing.Point(6, 31);
            this.GerCtrlCons_ComboBox.Name = "GerCtrlCons_ComboBox";
            this.GerCtrlCons_ComboBox.Size = new System.Drawing.Size(237, 21);
            this.GerCtrlCons_ComboBox.TabIndex = 0;
            // 
            // GerenteCtrlGerOfertas
            // 
            this.GerenteCtrlGerOfertas.BackColor = System.Drawing.SystemColors.Control;
            this.GerenteCtrlGerOfertas.Location = new System.Drawing.Point(23, 4);
            this.GerenteCtrlGerOfertas.Name = "GerenteCtrlGerOfertas";
            this.GerenteCtrlGerOfertas.Size = new System.Drawing.Size(249, 494);
            this.GerenteCtrlGerOfertas.TabIndex = 5;
            this.GerenteCtrlGerOfertas.Text = "Ofertas";
            // 
            // GerenteCtrlCadastrar
            // 
            this.GerenteCtrlCadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_ErrorTextBox);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_CadastrarBtn);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_ClearBtn);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_ProdTable);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_Label8);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_SenhaRep);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_Label7);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_Senha);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_Label6);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_Telefone);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_Label5);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_Email);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_Label4);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_Cadastro);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_Label3);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_Nome);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_Label2);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_Label1);
            this.GerenteCtrlCadastrar.Controls.Add(this.GerCtrlCad_ComboBox);
            this.GerenteCtrlCadastrar.Location = new System.Drawing.Point(23, 4);
            this.GerenteCtrlCadastrar.Name = "GerenteCtrlCadastrar";
            this.GerenteCtrlCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.GerenteCtrlCadastrar.Size = new System.Drawing.Size(249, 494);
            this.GerenteCtrlCadastrar.TabIndex = 1;
            this.GerenteCtrlCadastrar.Text = "Cadastrar";
            // 
            // GerCtrlCad_ErrorTextBox
            // 
            this.GerCtrlCad_ErrorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GerCtrlCad_ErrorTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.GerCtrlCad_ErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GerCtrlCad_ErrorTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GerCtrlCad_ErrorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GerCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
            this.GerCtrlCad_ErrorTextBox.Location = new System.Drawing.Point(6, 444);
            this.GerCtrlCad_ErrorTextBox.Name = "GerCtrlCad_ErrorTextBox";
            this.GerCtrlCad_ErrorTextBox.ReadOnly = true;
            this.GerCtrlCad_ErrorTextBox.Size = new System.Drawing.Size(237, 13);
            this.GerCtrlCad_ErrorTextBox.TabIndex = 18;
            this.GerCtrlCad_ErrorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GerCtrlCad_ErrorTextBox.Visible = false;
            // 
            // GerCtrlCad_CadastrarBtn
            // 
            this.GerCtrlCad_CadastrarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GerCtrlCad_CadastrarBtn.Location = new System.Drawing.Point(168, 465);
            this.GerCtrlCad_CadastrarBtn.Name = "GerCtrlCad_CadastrarBtn";
            this.GerCtrlCad_CadastrarBtn.Size = new System.Drawing.Size(75, 23);
            this.GerCtrlCad_CadastrarBtn.TabIndex = 17;
            this.GerCtrlCad_CadastrarBtn.Text = "Cadastrar";
            this.GerCtrlCad_CadastrarBtn.UseVisualStyleBackColor = true;
            this.GerCtrlCad_CadastrarBtn.Click += new System.EventHandler(this.GerCtrlCad_CadastrarBtn_Click);
            // 
            // GerCtrlCad_ClearBtn
            // 
            this.GerCtrlCad_ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GerCtrlCad_ClearBtn.Location = new System.Drawing.Point(6, 465);
            this.GerCtrlCad_ClearBtn.Name = "GerCtrlCad_ClearBtn";
            this.GerCtrlCad_ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.GerCtrlCad_ClearBtn.TabIndex = 16;
            this.GerCtrlCad_ClearBtn.Text = "Limpar";
            this.GerCtrlCad_ClearBtn.UseVisualStyleBackColor = true;
            this.GerCtrlCad_ClearBtn.Click += new System.EventHandler(this.GerCtrlCad_ClearBtn_Click);
            // 
            // GerCtrlCad_ProdTable
            // 
            this.GerCtrlCad_ProdTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GerCtrlCad_ProdTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GerCadProd_Nome,
            this.GerCadProd_Preco,
            this.GerCadProd_Qtd});
            this.GerCtrlCad_ProdTable.Location = new System.Drawing.Point(6, 306);
            this.GerCtrlCad_ProdTable.Name = "GerCtrlCad_ProdTable";
            this.GerCtrlCad_ProdTable.Size = new System.Drawing.Size(237, 122);
            this.GerCtrlCad_ProdTable.TabIndex = 15;
            this.GerCtrlCad_ProdTable.Visible = false;
            // 
            // GerCadProd_Nome
            // 
            this.GerCadProd_Nome.HeaderText = "Nome";
            this.GerCadProd_Nome.MaxInputLength = 50;
            this.GerCadProd_Nome.Name = "GerCadProd_Nome";
            this.GerCadProd_Nome.Width = 98;
            // 
            // GerCadProd_Preco
            // 
            this.GerCadProd_Preco.HeaderText = "Preço";
            this.GerCadProd_Preco.MaxInputLength = 10;
            this.GerCadProd_Preco.Name = "GerCadProd_Preco";
            this.GerCadProd_Preco.Width = 48;
            // 
            // GerCadProd_Qtd
            // 
            this.GerCadProd_Qtd.HeaderText = "Qtde";
            this.GerCadProd_Qtd.MaxInputLength = 8;
            this.GerCadProd_Qtd.Name = "GerCadProd_Qtd";
            this.GerCadProd_Qtd.Width = 48;
            // 
            // GerCtrlCad_Label8
            // 
            this.GerCtrlCad_Label8.AutoSize = true;
            this.GerCtrlCad_Label8.Location = new System.Drawing.Point(6, 290);
            this.GerCtrlCad_Label8.Name = "GerCtrlCad_Label8";
            this.GerCtrlCad_Label8.Size = new System.Drawing.Size(52, 13);
            this.GerCtrlCad_Label8.TabIndex = 14;
            this.GerCtrlCad_Label8.Text = "Produtos:";
            // 
            // GerCtrlCad_SenhaRep
            // 
            this.GerCtrlCad_SenhaRep.Location = new System.Drawing.Point(6, 267);
            this.GerCtrlCad_SenhaRep.MaxLength = 32;
            this.GerCtrlCad_SenhaRep.Name = "GerCtrlCad_SenhaRep";
            this.GerCtrlCad_SenhaRep.Size = new System.Drawing.Size(237, 20);
            this.GerCtrlCad_SenhaRep.TabIndex = 13;
            this.GerCtrlCad_SenhaRep.UseSystemPasswordChar = true;
            // 
            // GerCtrlCad_Label7
            // 
            this.GerCtrlCad_Label7.AutoSize = true;
            this.GerCtrlCad_Label7.Location = new System.Drawing.Point(6, 251);
            this.GerCtrlCad_Label7.Name = "GerCtrlCad_Label7";
            this.GerCtrlCad_Label7.Size = new System.Drawing.Size(78, 13);
            this.GerCtrlCad_Label7.TabIndex = 12;
            this.GerCtrlCad_Label7.Text = "Repetir Senha:";
            // 
            // GerCtrlCad_Senha
            // 
            this.GerCtrlCad_Senha.Location = new System.Drawing.Point(6, 228);
            this.GerCtrlCad_Senha.MaxLength = 32;
            this.GerCtrlCad_Senha.Name = "GerCtrlCad_Senha";
            this.GerCtrlCad_Senha.Size = new System.Drawing.Size(237, 20);
            this.GerCtrlCad_Senha.TabIndex = 11;
            this.GerCtrlCad_Senha.UseSystemPasswordChar = true;
            // 
            // GerCtrlCad_Label6
            // 
            this.GerCtrlCad_Label6.AutoSize = true;
            this.GerCtrlCad_Label6.Location = new System.Drawing.Point(6, 212);
            this.GerCtrlCad_Label6.Name = "GerCtrlCad_Label6";
            this.GerCtrlCad_Label6.Size = new System.Drawing.Size(41, 13);
            this.GerCtrlCad_Label6.TabIndex = 10;
            this.GerCtrlCad_Label6.Text = "Senha:";
            // 
            // GerCtrlCad_Telefone
            // 
            this.GerCtrlCad_Telefone.Location = new System.Drawing.Point(6, 189);
            this.GerCtrlCad_Telefone.Name = "GerCtrlCad_Telefone";
            this.GerCtrlCad_Telefone.Size = new System.Drawing.Size(237, 20);
            this.GerCtrlCad_Telefone.TabIndex = 9;
            // 
            // GerCtrlCad_Label5
            // 
            this.GerCtrlCad_Label5.AutoSize = true;
            this.GerCtrlCad_Label5.Location = new System.Drawing.Point(6, 173);
            this.GerCtrlCad_Label5.Name = "GerCtrlCad_Label5";
            this.GerCtrlCad_Label5.Size = new System.Drawing.Size(52, 13);
            this.GerCtrlCad_Label5.TabIndex = 8;
            this.GerCtrlCad_Label5.Text = "Telefone:";
            // 
            // GerCtrlCad_Email
            // 
            this.GerCtrlCad_Email.Location = new System.Drawing.Point(6, 150);
            this.GerCtrlCad_Email.MaxLength = 50;
            this.GerCtrlCad_Email.Name = "GerCtrlCad_Email";
            this.GerCtrlCad_Email.Size = new System.Drawing.Size(237, 20);
            this.GerCtrlCad_Email.TabIndex = 7;
            // 
            // GerCtrlCad_Label4
            // 
            this.GerCtrlCad_Label4.AutoSize = true;
            this.GerCtrlCad_Label4.Location = new System.Drawing.Point(6, 134);
            this.GerCtrlCad_Label4.Name = "GerCtrlCad_Label4";
            this.GerCtrlCad_Label4.Size = new System.Drawing.Size(35, 13);
            this.GerCtrlCad_Label4.TabIndex = 6;
            this.GerCtrlCad_Label4.Text = "Email:";
            // 
            // GerCtrlCad_Cadastro
            // 
            this.GerCtrlCad_Cadastro.Location = new System.Drawing.Point(6, 111);
            this.GerCtrlCad_Cadastro.MaxLength = 14;
            this.GerCtrlCad_Cadastro.Name = "GerCtrlCad_Cadastro";
            this.GerCtrlCad_Cadastro.Size = new System.Drawing.Size(237, 20);
            this.GerCtrlCad_Cadastro.TabIndex = 5;
            // 
            // GerCtrlCad_Label3
            // 
            this.GerCtrlCad_Label3.AutoSize = true;
            this.GerCtrlCad_Label3.Location = new System.Drawing.Point(6, 95);
            this.GerCtrlCad_Label3.Name = "GerCtrlCad_Label3";
            this.GerCtrlCad_Label3.Size = new System.Drawing.Size(62, 13);
            this.GerCtrlCad_Label3.TabIndex = 4;
            this.GerCtrlCad_Label3.Text = "CPF/CNPJ:";
            // 
            // GerCtrlCad_Nome
            // 
            this.GerCtrlCad_Nome.Location = new System.Drawing.Point(6, 72);
            this.GerCtrlCad_Nome.MaxLength = 50;
            this.GerCtrlCad_Nome.Name = "GerCtrlCad_Nome";
            this.GerCtrlCad_Nome.Size = new System.Drawing.Size(237, 20);
            this.GerCtrlCad_Nome.TabIndex = 3;
            // 
            // GerCtrlCad_Label2
            // 
            this.GerCtrlCad_Label2.AutoSize = true;
            this.GerCtrlCad_Label2.Location = new System.Drawing.Point(6, 56);
            this.GerCtrlCad_Label2.Name = "GerCtrlCad_Label2";
            this.GerCtrlCad_Label2.Size = new System.Drawing.Size(38, 13);
            this.GerCtrlCad_Label2.TabIndex = 2;
            this.GerCtrlCad_Label2.Text = "Nome:";
            // 
            // GerCtrlCad_Label1
            // 
            this.GerCtrlCad_Label1.AutoSize = true;
            this.GerCtrlCad_Label1.Location = new System.Drawing.Point(6, 16);
            this.GerCtrlCad_Label1.Name = "GerCtrlCad_Label1";
            this.GerCtrlCad_Label1.Size = new System.Drawing.Size(85, 13);
            this.GerCtrlCad_Label1.TabIndex = 1;
            this.GerCtrlCad_Label1.Text = "Tipo de Usuário:";
            // 
            // GerCtrlCad_ComboBox
            // 
            this.GerCtrlCad_ComboBox.FormattingEnabled = true;
            this.GerCtrlCad_ComboBox.Items.AddRange(new object[] {
            "(Selecionar)",
            "Fornecedor",
            "Gerente"});
            this.GerCtrlCad_ComboBox.Location = new System.Drawing.Point(6, 32);
            this.GerCtrlCad_ComboBox.Name = "GerCtrlCad_ComboBox";
            this.GerCtrlCad_ComboBox.Size = new System.Drawing.Size(237, 21);
            this.GerCtrlCad_ComboBox.TabIndex = 0;
            this.GerCtrlCad_ComboBox.SelectedIndexChanged += new System.EventHandler(this.GerCtrlCad_ComboBox_SelectedIndexChanged);
            // 
            // GerenteCtrlRemover
            // 
            this.GerenteCtrlRemover.BackColor = System.Drawing.SystemColors.Control;
            this.GerenteCtrlRemover.Controls.Add(this.GerCtrlRem_ErrorTextBox);
            this.GerenteCtrlRemover.Controls.Add(this.GerCtrlRem_RemoverBtn);
            this.GerenteCtrlRemover.Controls.Add(this.GerCtrlRem_ClearBtn);
            this.GerenteCtrlRemover.Controls.Add(this.GerCtrlRem_Label3);
            this.GerenteCtrlRemover.Controls.Add(this.GerCtrlRem_EmailRep);
            this.GerenteCtrlRemover.Controls.Add(this.GerCtrlRem_Label2);
            this.GerenteCtrlRemover.Controls.Add(this.GerCtrlRem_Email);
            this.GerenteCtrlRemover.Controls.Add(this.GerCtrlRem_Label1);
            this.GerenteCtrlRemover.Controls.Add(this.GerCtrlRem_ComboBox);
            this.GerenteCtrlRemover.Location = new System.Drawing.Point(23, 4);
            this.GerenteCtrlRemover.Name = "GerenteCtrlRemover";
            this.GerenteCtrlRemover.Padding = new System.Windows.Forms.Padding(3);
            this.GerenteCtrlRemover.Size = new System.Drawing.Size(249, 494);
            this.GerenteCtrlRemover.TabIndex = 2;
            this.GerenteCtrlRemover.Text = "Remover";
            // 
            // GerCtrlRem_ErrorTextBox
            // 
            this.GerCtrlRem_ErrorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GerCtrlRem_ErrorTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.GerCtrlRem_ErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GerCtrlRem_ErrorTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GerCtrlRem_ErrorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GerCtrlRem_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
            this.GerCtrlRem_ErrorTextBox.Location = new System.Drawing.Point(9, 431);
            this.GerCtrlRem_ErrorTextBox.Name = "GerCtrlRem_ErrorTextBox";
            this.GerCtrlRem_ErrorTextBox.ReadOnly = true;
            this.GerCtrlRem_ErrorTextBox.Size = new System.Drawing.Size(231, 15);
            this.GerCtrlRem_ErrorTextBox.TabIndex = 21;
            this.GerCtrlRem_ErrorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GerCtrlRem_ErrorTextBox.Visible = false;
            // 
            // GerCtrlRem_RemoverBtn
            // 
            this.GerCtrlRem_RemoverBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GerCtrlRem_RemoverBtn.Location = new System.Drawing.Point(168, 465);
            this.GerCtrlRem_RemoverBtn.Name = "GerCtrlRem_RemoverBtn";
            this.GerCtrlRem_RemoverBtn.Size = new System.Drawing.Size(75, 23);
            this.GerCtrlRem_RemoverBtn.TabIndex = 20;
            this.GerCtrlRem_RemoverBtn.Text = "Remover";
            this.GerCtrlRem_RemoverBtn.UseVisualStyleBackColor = true;
            this.GerCtrlRem_RemoverBtn.Click += new System.EventHandler(this.GerCtrlRem_RemoverBtn_Click);
            // 
            // GerCtrlRem_ClearBtn
            // 
            this.GerCtrlRem_ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GerCtrlRem_ClearBtn.Location = new System.Drawing.Point(6, 465);
            this.GerCtrlRem_ClearBtn.Name = "GerCtrlRem_ClearBtn";
            this.GerCtrlRem_ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.GerCtrlRem_ClearBtn.TabIndex = 19;
            this.GerCtrlRem_ClearBtn.Text = "Limpar";
            this.GerCtrlRem_ClearBtn.UseVisualStyleBackColor = true;
            this.GerCtrlRem_ClearBtn.Click += new System.EventHandler(this.GerCtrlRem_ClearBtn_Click);
            // 
            // GerCtrlRem_Label3
            // 
            this.GerCtrlRem_Label3.AutoSize = true;
            this.GerCtrlRem_Label3.Location = new System.Drawing.Point(6, 95);
            this.GerCtrlRem_Label3.Name = "GerCtrlRem_Label3";
            this.GerCtrlRem_Label3.Size = new System.Drawing.Size(81, 13);
            this.GerCtrlRem_Label3.TabIndex = 17;
            this.GerCtrlRem_Label3.Text = "Confirmar email:";
            // 
            // GerCtrlRem_EmailRep
            // 
            this.GerCtrlRem_EmailRep.Location = new System.Drawing.Point(6, 111);
            this.GerCtrlRem_EmailRep.MaxLength = 50;
            this.GerCtrlRem_EmailRep.Name = "GerCtrlRem_EmailRep";
            this.GerCtrlRem_EmailRep.Size = new System.Drawing.Size(237, 20);
            this.GerCtrlRem_EmailRep.TabIndex = 16;
            // 
            // GerCtrlRem_Label2
            // 
            this.GerCtrlRem_Label2.AutoSize = true;
            this.GerCtrlRem_Label2.Location = new System.Drawing.Point(6, 56);
            this.GerCtrlRem_Label2.Name = "GerCtrlRem_Label2";
            this.GerCtrlRem_Label2.Size = new System.Drawing.Size(35, 13);
            this.GerCtrlRem_Label2.TabIndex = 15;
            this.GerCtrlRem_Label2.Text = "Email:";
            // 
            // GerCtrlRem_Email
            // 
            this.GerCtrlRem_Email.Location = new System.Drawing.Point(6, 72);
            this.GerCtrlRem_Email.MaxLength = 50;
            this.GerCtrlRem_Email.Name = "GerCtrlRem_Email";
            this.GerCtrlRem_Email.Size = new System.Drawing.Size(237, 20);
            this.GerCtrlRem_Email.TabIndex = 14;
            // 
            // GerCtrlRem_Label1
            // 
            this.GerCtrlRem_Label1.AutoSize = true;
            this.GerCtrlRem_Label1.Location = new System.Drawing.Point(6, 16);
            this.GerCtrlRem_Label1.Name = "GerCtrlRem_Label1";
            this.GerCtrlRem_Label1.Size = new System.Drawing.Size(85, 13);
            this.GerCtrlRem_Label1.TabIndex = 10;
            this.GerCtrlRem_Label1.Text = "Tipo de Usuário:";
            // 
            // GerCtrlRem_ComboBox
            // 
            this.GerCtrlRem_ComboBox.FormattingEnabled = true;
            this.GerCtrlRem_ComboBox.Items.AddRange(new object[] {
            "Cliente",
            "Fornecedor",
            "Gerente"});
            this.GerCtrlRem_ComboBox.Location = new System.Drawing.Point(6, 32);
            this.GerCtrlRem_ComboBox.Name = "GerCtrlRem_ComboBox";
            this.GerCtrlRem_ComboBox.Size = new System.Drawing.Size(237, 21);
            this.GerCtrlRem_ComboBox.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LogoffForBtn
            // 
            this.LogoffForBtn.Image = global::SmartRetail.Properties.Resources.Logoff;
            this.LogoffForBtn.Location = new System.Drawing.Point(217, 6);
            this.LogoffForBtn.Name = "LogoffForBtn";
            this.LogoffForBtn.Size = new System.Drawing.Size(26, 26);
            this.LogoffForBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoffForBtn.TabIndex = 1;
            this.LogoffForBtn.TabStop = false;
            this.LogoffForBtn.Click += new System.EventHandler(this.LogoffForBtn_Click);
            // 
            // LogoffGerBtn
            // 
            this.LogoffGerBtn.Image = global::SmartRetail.Properties.Resources.Logoff;
            this.LogoffGerBtn.Location = new System.Drawing.Point(217, 6);
            this.LogoffGerBtn.Name = "LogoffGerBtn";
            this.LogoffGerBtn.Size = new System.Drawing.Size(26, 26);
            this.LogoffGerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoffGerBtn.TabIndex = 0;
            this.LogoffGerBtn.TabStop = false;
            this.LogoffGerBtn.Click += new System.EventHandler(this.LogoffGerBtn_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 511);
            this.Controls.Add(this.TabCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "App";
            this.Text = "App";
            this.TabCtrl.ResumeLayout(false);
            this.LoginPageTab.ResumeLayout(false);
            this.LoginPageTab.PerformLayout();
            this.FornecedorTab.ResumeLayout(false);
            this.FornecedorCtrl.ResumeLayout(false);
            this.FornecedorCtrlHome.ResumeLayout(false);
            this.GerenteTab.ResumeLayout(false);
            this.GerenteCtrl.ResumeLayout(false);
            this.GerenteCtrlHome.ResumeLayout(false);
            this.GerenteCtrlConsDados.ResumeLayout(false);
            this.GerenteCtrlConsDados.PerformLayout();
            this.GerenteCtrlCadastrar.ResumeLayout(false);
            this.GerenteCtrlCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GerCtrlCad_ProdTable)).EndInit();
            this.GerenteCtrlRemover.ResumeLayout(false);
            this.GerenteCtrlRemover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoffForBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoffGerBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabCtrl;
        private System.Windows.Forms.TabPage LoginPageTab;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.RichTextBox MessageLoginPage;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button LimparBtn;
        private System.Windows.Forms.TextBox PwdTextBox;
        private System.Windows.Forms.TabPage GerenteTab;
        private System.Windows.Forms.TabPage FornecedorTab;
        private System.Windows.Forms.TextBox ErrorLoginTextBox;
        private System.Windows.Forms.TabControl GerenteCtrl;
        private System.Windows.Forms.TabPage GerenteCtrlHome;
        private System.Windows.Forms.TabPage GerenteCtrlCadastrar;
        private System.Windows.Forms.ComboBox GerCtrlCad_ComboBox;
        private System.Windows.Forms.TabPage GerenteCtrlRemover;
        private System.Windows.Forms.Label GerCtrlCad_Label1;
        private System.Windows.Forms.TextBox GerCtrlCad_SenhaRep;
        private System.Windows.Forms.Label GerCtrlCad_Label7;
        private System.Windows.Forms.TextBox GerCtrlCad_Senha;
        private System.Windows.Forms.Label GerCtrlCad_Label6;
        private System.Windows.Forms.TextBox GerCtrlCad_Telefone;
        private System.Windows.Forms.Label GerCtrlCad_Label5;
        private System.Windows.Forms.TextBox GerCtrlCad_Email;
        private System.Windows.Forms.Label GerCtrlCad_Label4;
        private System.Windows.Forms.TextBox GerCtrlCad_Cadastro;
        private System.Windows.Forms.Label GerCtrlCad_Label3;
        private System.Windows.Forms.TextBox GerCtrlCad_Nome;
        private System.Windows.Forms.Label GerCtrlCad_Label2;
        private System.Windows.Forms.DataGridView GerCtrlCad_ProdTable;
        private System.Windows.Forms.Label GerCtrlCad_Label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn GerCadProd_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn GerCadProd_Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn GerCadProd_Qtd;
        private System.Windows.Forms.Button GerCtrlCad_CadastrarBtn;
        private System.Windows.Forms.Button GerCtrlCad_ClearBtn;
        private System.Windows.Forms.TextBox GerCtrlCad_ErrorTextBox;
        private System.Windows.Forms.TextBox GerCtrlRem_ErrorTextBox;
        private System.Windows.Forms.Button GerCtrlRem_RemoverBtn;
        private System.Windows.Forms.Button GerCtrlRem_ClearBtn;
        private System.Windows.Forms.Label GerCtrlRem_Label3;
        private System.Windows.Forms.TextBox GerCtrlRem_EmailRep;
        private System.Windows.Forms.Label GerCtrlRem_Label2;
        private System.Windows.Forms.TextBox GerCtrlRem_Email;
        private System.Windows.Forms.Label GerCtrlRem_Label1;
        private System.Windows.Forms.ComboBox GerCtrlRem_ComboBox;
        private System.Windows.Forms.PictureBox LogoffGerBtn;
        private System.Windows.Forms.TabControl FornecedorCtrl;
        private System.Windows.Forms.TabPage FornecedorCtrlHome;
        private System.Windows.Forms.PictureBox LogoffForBtn;
        private System.Windows.Forms.TabPage FornecedorCtrlCadastrar;
        private System.Windows.Forms.TabPage GerenteCtrlGerProd;
        private System.Windows.Forms.TabPage GerenteCtrlConsDados;
        private System.Windows.Forms.ComboBox GerCtrlCons_ComboBox;
        private System.Windows.Forms.TabPage GerenteCtrlGerOfertas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label GerCtrlCons_Label1;
    }
}

