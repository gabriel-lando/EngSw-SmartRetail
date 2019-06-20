namespace SmartRetail
{
    partial class Totem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabCtrl = new System.Windows.Forms.TabControl();
            this.TotemWelcomeTab = new System.Windows.Forms.TabPage();
            this.TotemLogoLabel = new System.Windows.Forms.Label();
            this.CamLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.TotemWelcomeLabel = new System.Windows.Forms.Label();
            this.TotemCliente = new System.Windows.Forms.TabPage();
            this.ClienteTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ClienteCarrinhoPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClienteLabelOfertas = new System.Windows.Forms.Label();
            this.ClienteOfertaPanel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ClienteOfertaPic1 = new System.Windows.Forms.PictureBox();
            this.ClienteOfertaPanel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ClienteOfertaPic2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ClienteCarrinhoTotalValue = new System.Windows.Forms.Label();
            this.ClienteLabelCarrinho = new System.Windows.Forms.Label();
            this.ClienteCarrinhoTotalLabel = new System.Windows.Forms.Label();
            this.ClienteCarrinhoTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FacialRecPictureBox = new System.Windows.Forms.PictureBox();
            this.ClienteCarrinhoProdNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteCarrinhoProdPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteCarrinhoProdQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteCarrinhoProdTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabCtrl.SuspendLayout();
            this.TotemWelcomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CamLogoPictureBox)).BeginInit();
            this.TotemCliente.SuspendLayout();
            this.ClienteTableLayout.SuspendLayout();
            this.ClienteCarrinhoPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ClienteOfertaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteOfertaPic1)).BeginInit();
            this.ClienteOfertaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteOfertaPic2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteCarrinhoTable)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacialRecPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TabCtrl
            // 
            this.TabCtrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabCtrl.Controls.Add(this.TotemWelcomeTab);
            this.TabCtrl.Controls.Add(this.TotemCliente);
            this.TabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCtrl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabCtrl.ItemSize = new System.Drawing.Size(5, 5);
            this.TabCtrl.Location = new System.Drawing.Point(0, 0);
            this.TabCtrl.Margin = new System.Windows.Forms.Padding(0);
            this.TabCtrl.Name = "TabCtrl";
            this.TabCtrl.Padding = new System.Drawing.Point(0, 0);
            this.TabCtrl.SelectedIndex = 0;
            this.TabCtrl.Size = new System.Drawing.Size(800, 430);
            this.TabCtrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabCtrl.TabIndex = 7;
            // 
            // TotemWelcomeTab
            // 
            this.TotemWelcomeTab.Controls.Add(this.TotemLogoLabel);
            this.TotemWelcomeTab.Controls.Add(this.CamLogoPictureBox);
            this.TotemWelcomeTab.Controls.Add(this.TotemWelcomeLabel);
            this.TotemWelcomeTab.Location = new System.Drawing.Point(4, 9);
            this.TotemWelcomeTab.Name = "TotemWelcomeTab";
            this.TotemWelcomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.TotemWelcomeTab.Size = new System.Drawing.Size(792, 417);
            this.TotemWelcomeTab.TabIndex = 1;
            this.TotemWelcomeTab.UseVisualStyleBackColor = true;
            // 
            // TotemLogoLabel
            // 
            this.TotemLogoLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TotemLogoLabel.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotemLogoLabel.Location = new System.Drawing.Point(3, 340);
            this.TotemLogoLabel.Name = "TotemLogoLabel";
            this.TotemLogoLabel.Size = new System.Drawing.Size(786, 74);
            this.TotemLogoLabel.TabIndex = 2;
            this.TotemLogoLabel.Text = "Smart Retail";
            this.TotemLogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CamLogoPictureBox
            // 
            this.CamLogoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CamLogoPictureBox.BackgroundImage = global::SmartRetail.Properties.Resources.CamPicture;
            this.CamLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CamLogoPictureBox.ErrorImage = null;
            this.CamLogoPictureBox.InitialImage = null;
            this.CamLogoPictureBox.Location = new System.Drawing.Point(210, 100);
            this.CamLogoPictureBox.Name = "CamLogoPictureBox";
            this.CamLogoPictureBox.Size = new System.Drawing.Size(353, 226);
            this.CamLogoPictureBox.TabIndex = 1;
            this.CamLogoPictureBox.TabStop = false;
            // 
            // TotemWelcomeLabel
            // 
            this.TotemWelcomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TotemWelcomeLabel.Font = new System.Drawing.Font("Century Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotemWelcomeLabel.ForeColor = System.Drawing.Color.Blue;
            this.TotemWelcomeLabel.Location = new System.Drawing.Point(3, 3);
            this.TotemWelcomeLabel.Name = "TotemWelcomeLabel";
            this.TotemWelcomeLabel.Size = new System.Drawing.Size(786, 83);
            this.TotemWelcomeLabel.TabIndex = 0;
            this.TotemWelcomeLabel.Text = "Veja seu carrinho!";
            this.TotemWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotemCliente
            // 
            this.TotemCliente.Controls.Add(this.ClienteTableLayout);
            this.TotemCliente.Location = new System.Drawing.Point(4, 9);
            this.TotemCliente.Margin = new System.Windows.Forms.Padding(0);
            this.TotemCliente.Name = "TotemCliente";
            this.TotemCliente.Size = new System.Drawing.Size(792, 417);
            this.TotemCliente.TabIndex = 0;
            this.TotemCliente.UseVisualStyleBackColor = true;
            // 
            // ClienteTableLayout
            // 
            this.ClienteTableLayout.ColumnCount = 3;
            this.ClienteTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.ClienteTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClienteTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClienteTableLayout.Controls.Add(this.ClienteCarrinhoPanel, 1, 0);
            this.ClienteTableLayout.Controls.Add(this.panel3, 2, 0);
            this.ClienteTableLayout.Controls.Add(this.panel2, 0, 0);
            this.ClienteTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClienteTableLayout.Location = new System.Drawing.Point(0, 0);
            this.ClienteTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.ClienteTableLayout.Name = "ClienteTableLayout";
            this.ClienteTableLayout.RowCount = 1;
            this.ClienteTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ClienteTableLayout.Size = new System.Drawing.Size(792, 417);
            this.ClienteTableLayout.TabIndex = 5;
            // 
            // ClienteCarrinhoPanel
            // 
            this.ClienteCarrinhoPanel.Controls.Add(this.tableLayoutPanel1);
            this.ClienteCarrinhoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClienteCarrinhoPanel.Location = new System.Drawing.Point(160, 0);
            this.ClienteCarrinhoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ClienteCarrinhoPanel.Name = "ClienteCarrinhoPanel";
            this.ClienteCarrinhoPanel.Size = new System.Drawing.Size(316, 417);
            this.ClienteCarrinhoPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ClienteOfertaPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ClienteOfertaPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(316, 417);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClienteLabelOfertas);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 24);
            this.panel1.TabIndex = 0;
            // 
            // ClienteLabelOfertas
            // 
            this.ClienteLabelOfertas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClienteLabelOfertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteLabelOfertas.Location = new System.Drawing.Point(0, 0);
            this.ClienteLabelOfertas.Name = "ClienteLabelOfertas";
            this.ClienteLabelOfertas.Padding = new System.Windows.Forms.Padding(3);
            this.ClienteLabelOfertas.Size = new System.Drawing.Size(310, 24);
            this.ClienteLabelOfertas.TabIndex = 1;
            this.ClienteLabelOfertas.Text = "Ofertas:";
            this.ClienteLabelOfertas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClienteOfertaPanel1
            // 
            this.ClienteOfertaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClienteOfertaPanel1.Controls.Add(this.label1);
            this.ClienteOfertaPanel1.Controls.Add(this.ClienteOfertaPic1);
            this.ClienteOfertaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClienteOfertaPanel1.Location = new System.Drawing.Point(3, 33);
            this.ClienteOfertaPanel1.Name = "ClienteOfertaPanel1";
            this.ClienteOfertaPanel1.Size = new System.Drawing.Size(310, 187);
            this.ClienteOfertaPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Foto Oferta 1";
            // 
            // ClienteOfertaPic1
            // 
            this.ClienteOfertaPic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClienteOfertaPic1.Location = new System.Drawing.Point(14, 14);
            this.ClienteOfertaPic1.Name = "ClienteOfertaPic1";
            this.ClienteOfertaPic1.Size = new System.Drawing.Size(114, 156);
            this.ClienteOfertaPic1.TabIndex = 0;
            this.ClienteOfertaPic1.TabStop = false;
            // 
            // ClienteOfertaPanel2
            // 
            this.ClienteOfertaPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClienteOfertaPanel2.Controls.Add(this.label2);
            this.ClienteOfertaPanel2.Controls.Add(this.ClienteOfertaPic2);
            this.ClienteOfertaPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClienteOfertaPanel2.Location = new System.Drawing.Point(3, 226);
            this.ClienteOfertaPanel2.Name = "ClienteOfertaPanel2";
            this.ClienteOfertaPanel2.Size = new System.Drawing.Size(310, 188);
            this.ClienteOfertaPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Foto Oferta 2";
            // 
            // ClienteOfertaPic2
            // 
            this.ClienteOfertaPic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClienteOfertaPic2.Location = new System.Drawing.Point(14, 15);
            this.ClienteOfertaPic2.Name = "ClienteOfertaPic2";
            this.ClienteOfertaPic2.Size = new System.Drawing.Size(114, 156);
            this.ClienteOfertaPic2.TabIndex = 1;
            this.ClienteOfertaPic2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ClienteCarrinhoTotalValue);
            this.panel3.Controls.Add(this.ClienteLabelCarrinho);
            this.panel3.Controls.Add(this.ClienteCarrinhoTotalLabel);
            this.panel3.Controls.Add(this.ClienteCarrinhoTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(476, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 417);
            this.panel3.TabIndex = 4;
            // 
            // ClienteCarrinhoTotalValue
            // 
            this.ClienteCarrinhoTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClienteCarrinhoTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteCarrinhoTotalValue.Location = new System.Drawing.Point(189, 383);
            this.ClienteCarrinhoTotalValue.Name = "ClienteCarrinhoTotalValue";
            this.ClienteCarrinhoTotalValue.Size = new System.Drawing.Size(124, 31);
            this.ClienteCarrinhoTotalValue.TabIndex = 3;
            this.ClienteCarrinhoTotalValue.Text = "0,00";
            this.ClienteCarrinhoTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClienteLabelCarrinho
            // 
            this.ClienteLabelCarrinho.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClienteLabelCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteLabelCarrinho.Location = new System.Drawing.Point(0, 0);
            this.ClienteLabelCarrinho.Name = "ClienteLabelCarrinho";
            this.ClienteLabelCarrinho.Padding = new System.Windows.Forms.Padding(3);
            this.ClienteLabelCarrinho.Size = new System.Drawing.Size(316, 24);
            this.ClienteLabelCarrinho.TabIndex = 0;
            this.ClienteLabelCarrinho.Text = "Carrinho:";
            this.ClienteLabelCarrinho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClienteCarrinhoTotalLabel
            // 
            this.ClienteCarrinhoTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClienteCarrinhoTotalLabel.AutoSize = true;
            this.ClienteCarrinhoTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteCarrinhoTotalLabel.Location = new System.Drawing.Point(3, 383);
            this.ClienteCarrinhoTotalLabel.Name = "ClienteCarrinhoTotalLabel";
            this.ClienteCarrinhoTotalLabel.Size = new System.Drawing.Size(110, 31);
            this.ClienteCarrinhoTotalLabel.TabIndex = 2;
            this.ClienteCarrinhoTotalLabel.Text = "TOTAL:";
            this.ClienteCarrinhoTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClienteCarrinhoTable
            // 
            this.ClienteCarrinhoTable.AllowUserToAddRows = false;
            this.ClienteCarrinhoTable.AllowUserToDeleteRows = false;
            this.ClienteCarrinhoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClienteCarrinhoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteCarrinhoProdNome,
            this.ClienteCarrinhoProdPreco,
            this.ClienteCarrinhoProdQtde,
            this.ClienteCarrinhoProdTotal});
            this.ClienteCarrinhoTable.Location = new System.Drawing.Point(4, 27);
            this.ClienteCarrinhoTable.Name = "ClienteCarrinhoTable";
            this.ClienteCarrinhoTable.ReadOnly = true;
            this.ClienteCarrinhoTable.RowHeadersVisible = false;
            this.ClienteCarrinhoTable.Size = new System.Drawing.Size(311, 342);
            this.ClienteCarrinhoTable.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.FacialRecPictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 417);
            this.panel2.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 209);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(150, 200);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // FacialRecPictureBox
            // 
            this.FacialRecPictureBox.BackColor = System.Drawing.Color.PaleGreen;
            this.FacialRecPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FacialRecPictureBox.Location = new System.Drawing.Point(3, 3);
            this.FacialRecPictureBox.Name = "FacialRecPictureBox";
            this.FacialRecPictureBox.Size = new System.Drawing.Size(150, 200);
            this.FacialRecPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FacialRecPictureBox.TabIndex = 0;
            this.FacialRecPictureBox.TabStop = false;
            this.FacialRecPictureBox.Click += new System.EventHandler(this.FacialRecPictureBox_Click);
            // 
            // ClienteCarrinhoProdNome
            // 
            this.ClienteCarrinhoProdNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ClienteCarrinhoProdNome.DefaultCellStyle = dataGridViewCellStyle1;
            this.ClienteCarrinhoProdNome.FillWeight = 180F;
            this.ClienteCarrinhoProdNome.HeaderText = "Produto";
            this.ClienteCarrinhoProdNome.Name = "ClienteCarrinhoProdNome";
            this.ClienteCarrinhoProdNome.ReadOnly = true;
            this.ClienteCarrinhoProdNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClienteCarrinhoProdPreco
            // 
            this.ClienteCarrinhoProdPreco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ClienteCarrinhoProdPreco.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClienteCarrinhoProdPreco.FillWeight = 80F;
            this.ClienteCarrinhoProdPreco.HeaderText = "Preço";
            this.ClienteCarrinhoProdPreco.Name = "ClienteCarrinhoProdPreco";
            this.ClienteCarrinhoProdPreco.ReadOnly = true;
            this.ClienteCarrinhoProdPreco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClienteCarrinhoProdQtde
            // 
            this.ClienteCarrinhoProdQtde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ClienteCarrinhoProdQtde.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClienteCarrinhoProdQtde.FillWeight = 60F;
            this.ClienteCarrinhoProdQtde.HeaderText = "Qtde";
            this.ClienteCarrinhoProdQtde.Name = "ClienteCarrinhoProdQtde";
            this.ClienteCarrinhoProdQtde.ReadOnly = true;
            this.ClienteCarrinhoProdQtde.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClienteCarrinhoProdTotal
            // 
            this.ClienteCarrinhoProdTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ClienteCarrinhoProdTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.ClienteCarrinhoProdTotal.FillWeight = 80F;
            this.ClienteCarrinhoProdTotal.HeaderText = "Total";
            this.ClienteCarrinhoProdTotal.Name = "ClienteCarrinhoProdTotal";
            this.ClienteCarrinhoProdTotal.ReadOnly = true;
            this.ClienteCarrinhoProdTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Totem
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.TabCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, 469);
            this.MaximizeBox = false;
            this.Name = "Totem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Totem";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Totem_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Totem_DragEnter);
            this.TabCtrl.ResumeLayout(false);
            this.TotemWelcomeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CamLogoPictureBox)).EndInit();
            this.TotemCliente.ResumeLayout(false);
            this.ClienteTableLayout.ResumeLayout(false);
            this.ClienteCarrinhoPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ClienteOfertaPanel1.ResumeLayout(false);
            this.ClienteOfertaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteOfertaPic1)).EndInit();
            this.ClienteOfertaPanel2.ResumeLayout(false);
            this.ClienteOfertaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteOfertaPic2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteCarrinhoTable)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FacialRecPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabCtrl;
        private System.Windows.Forms.TabPage TotemWelcomeTab;
        private System.Windows.Forms.PictureBox FacialRecPictureBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage TotemCliente;
        private System.Windows.Forms.Label TotemWelcomeLabel;
        private System.Windows.Forms.Label TotemLogoLabel;
        private System.Windows.Forms.PictureBox CamLogoPictureBox;
        private System.Windows.Forms.Label ClienteLabelCarrinho;
        private System.Windows.Forms.Label ClienteCarrinhoTotalValue;
        private System.Windows.Forms.Label ClienteCarrinhoTotalLabel;
        private System.Windows.Forms.DataGridView ClienteCarrinhoTable;
        private System.Windows.Forms.TableLayoutPanel ClienteTableLayout;
        private System.Windows.Forms.Panel ClienteCarrinhoPanel;
        private System.Windows.Forms.Label ClienteLabelOfertas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ClienteOfertaPanel1;
        private System.Windows.Forms.Panel ClienteOfertaPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ClienteOfertaPic1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ClienteOfertaPic2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteCarrinhoProdNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteCarrinhoProdPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteCarrinhoProdQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteCarrinhoProdTotal;
    }
}