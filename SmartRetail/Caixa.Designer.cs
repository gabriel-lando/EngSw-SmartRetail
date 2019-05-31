﻿namespace SmartRetail
{
    partial class Caixa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabCtrl = new System.Windows.Forms.TabControl();
            this.CaixaWelcomeTab = new System.Windows.Forms.TabPage();
            this.CaixaLogoLabel = new System.Windows.Forms.Label();
            this.CamLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.CaixaWelcomeLabel = new System.Windows.Forms.Label();
            this.CaixaClienteEntrada = new System.Windows.Forms.TabPage();
            this.CaixaCadastroCliente = new System.Windows.Forms.TabPage();
            this.CaixaClienteSaida = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FacialRecPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ClienteCarrinhoTotalValue = new System.Windows.Forms.Label();
            this.ClienteLabelCarrinho = new System.Windows.Forms.Label();
            this.ClienteCarrinhoTotalLabel = new System.Windows.Forms.Label();
            this.ClienteCarrinhoTable = new System.Windows.Forms.DataGridView();
            this.ClienteCarrinhoProdNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteCarrinhoProdPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteCarrinhoProdQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabCtrl.SuspendLayout();
            this.CaixaWelcomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CamLogoPictureBox)).BeginInit();
            this.CaixaClienteSaida.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacialRecPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteCarrinhoTable)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabCtrl
            // 
            this.TabCtrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabCtrl.Controls.Add(this.CaixaWelcomeTab);
            this.TabCtrl.Controls.Add(this.CaixaClienteEntrada);
            this.TabCtrl.Controls.Add(this.CaixaCadastroCliente);
            this.TabCtrl.Controls.Add(this.CaixaClienteSaida);
            this.TabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCtrl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabCtrl.ItemSize = new System.Drawing.Size(0, 1);
            this.TabCtrl.Location = new System.Drawing.Point(0, 0);
            this.TabCtrl.Margin = new System.Windows.Forms.Padding(0);
            this.TabCtrl.Name = "TabCtrl";
            this.TabCtrl.Padding = new System.Drawing.Point(0, 0);
            this.TabCtrl.SelectedIndex = 0;
            this.TabCtrl.Size = new System.Drawing.Size(800, 430);
            this.TabCtrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabCtrl.TabIndex = 6;
            // 
            // CaixaWelcomeTab
            // 
            this.CaixaWelcomeTab.Controls.Add(this.CaixaLogoLabel);
            this.CaixaWelcomeTab.Controls.Add(this.CamLogoPictureBox);
            this.CaixaWelcomeTab.Controls.Add(this.CaixaWelcomeLabel);
            this.CaixaWelcomeTab.Location = new System.Drawing.Point(4, 9);
            this.CaixaWelcomeTab.Name = "CaixaWelcomeTab";
            this.CaixaWelcomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.CaixaWelcomeTab.Size = new System.Drawing.Size(792, 417);
            this.CaixaWelcomeTab.TabIndex = 1;
            this.CaixaWelcomeTab.UseVisualStyleBackColor = true;
            // 
            // CaixaLogoLabel
            // 
            this.CaixaLogoLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CaixaLogoLabel.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaixaLogoLabel.Location = new System.Drawing.Point(3, 340);
            this.CaixaLogoLabel.Name = "CaixaLogoLabel";
            this.CaixaLogoLabel.Size = new System.Drawing.Size(786, 74);
            this.CaixaLogoLabel.TabIndex = 3;
            this.CaixaLogoLabel.Text = "Smart Retail";
            this.CaixaLogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.CamLogoPictureBox.TabIndex = 2;
            this.CamLogoPictureBox.TabStop = false;
            // 
            // CaixaWelcomeLabel
            // 
            this.CaixaWelcomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaixaWelcomeLabel.Font = new System.Drawing.Font("Century Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaixaWelcomeLabel.ForeColor = System.Drawing.Color.Blue;
            this.CaixaWelcomeLabel.Location = new System.Drawing.Point(3, 3);
            this.CaixaWelcomeLabel.Name = "CaixaWelcomeLabel";
            this.CaixaWelcomeLabel.Size = new System.Drawing.Size(786, 83);
            this.CaixaWelcomeLabel.TabIndex = 1;
            this.CaixaWelcomeLabel.Text = "Bem Vindo!";
            this.CaixaWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CaixaClienteEntrada
            // 
            this.CaixaClienteEntrada.Location = new System.Drawing.Point(4, 9);
            this.CaixaClienteEntrada.Name = "CaixaClienteEntrada";
            this.CaixaClienteEntrada.Size = new System.Drawing.Size(792, 417);
            this.CaixaClienteEntrada.TabIndex = 2;
            this.CaixaClienteEntrada.Text = "tabPage1";
            this.CaixaClienteEntrada.UseVisualStyleBackColor = true;
            // 
            // CaixaCadastroCliente
            // 
            this.CaixaCadastroCliente.Location = new System.Drawing.Point(4, 9);
            this.CaixaCadastroCliente.Name = "CaixaCadastroCliente";
            this.CaixaCadastroCliente.Size = new System.Drawing.Size(792, 417);
            this.CaixaCadastroCliente.TabIndex = 3;
            this.CaixaCadastroCliente.Text = "tabPage1";
            this.CaixaCadastroCliente.UseVisualStyleBackColor = true;
            // 
            // CaixaClienteSaida
            // 
            this.CaixaClienteSaida.Controls.Add(this.tableLayoutPanel1);
            this.CaixaClienteSaida.Location = new System.Drawing.Point(4, 5);
            this.CaixaClienteSaida.Margin = new System.Windows.Forms.Padding(0);
            this.CaixaClienteSaida.Name = "CaixaClienteSaida";
            this.CaixaClienteSaida.Size = new System.Drawing.Size(792, 421);
            this.CaixaClienteSaida.TabIndex = 0;
            this.CaixaClienteSaida.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 421);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.FacialRecPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 421);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 213);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(150, 200);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // FacialRecPictureBox
            // 
            this.FacialRecPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FacialRecPictureBox.BackColor = System.Drawing.Color.PaleGreen;
            this.FacialRecPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FacialRecPictureBox.Location = new System.Drawing.Point(0, 3);
            this.FacialRecPictureBox.Name = "FacialRecPictureBox";
            this.FacialRecPictureBox.Size = new System.Drawing.Size(150, 200);
            this.FacialRecPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FacialRecPictureBox.TabIndex = 0;
            this.FacialRecPictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 421);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ClienteCarrinhoTotalValue);
            this.panel4.Controls.Add(this.ClienteLabelCarrinho);
            this.panel4.Controls.Add(this.ClienteCarrinhoTotalLabel);
            this.panel4.Controls.Add(this.ClienteCarrinhoTable);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(321, 421);
            this.panel4.TabIndex = 5;
            // 
            // ClienteCarrinhoTotalValue
            // 
            this.ClienteCarrinhoTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClienteCarrinhoTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteCarrinhoTotalValue.Location = new System.Drawing.Point(194, 387);
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
            this.ClienteLabelCarrinho.Size = new System.Drawing.Size(321, 24);
            this.ClienteLabelCarrinho.TabIndex = 0;
            this.ClienteLabelCarrinho.Text = "Carrinho:";
            this.ClienteLabelCarrinho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClienteCarrinhoTotalLabel
            // 
            this.ClienteCarrinhoTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClienteCarrinhoTotalLabel.AutoSize = true;
            this.ClienteCarrinhoTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteCarrinhoTotalLabel.Location = new System.Drawing.Point(3, 387);
            this.ClienteCarrinhoTotalLabel.Name = "ClienteCarrinhoTotalLabel";
            this.ClienteCarrinhoTotalLabel.Size = new System.Drawing.Size(110, 31);
            this.ClienteCarrinhoTotalLabel.TabIndex = 2;
            this.ClienteCarrinhoTotalLabel.Text = "TOTAL:";
            this.ClienteCarrinhoTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClienteCarrinhoTable
            // 
            this.ClienteCarrinhoTable.AllowUserToDeleteRows = false;
            this.ClienteCarrinhoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClienteCarrinhoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteCarrinhoProdNome,
            this.ClienteCarrinhoProdPreco,
            this.ClienteCarrinhoProdQtde});
            this.ClienteCarrinhoTable.Location = new System.Drawing.Point(4, 27);
            this.ClienteCarrinhoTable.Name = "ClienteCarrinhoTable";
            this.ClienteCarrinhoTable.Size = new System.Drawing.Size(311, 342);
            this.ClienteCarrinhoTable.TabIndex = 1;
            // 
            // ClienteCarrinhoProdNome
            // 
            this.ClienteCarrinhoProdNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ClienteCarrinhoProdNome.DefaultCellStyle = dataGridViewCellStyle13;
            this.ClienteCarrinhoProdNome.FillWeight = 180F;
            this.ClienteCarrinhoProdNome.HeaderText = "Produto";
            this.ClienteCarrinhoProdNome.Name = "ClienteCarrinhoProdNome";
            this.ClienteCarrinhoProdNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClienteCarrinhoProdPreco
            // 
            this.ClienteCarrinhoProdPreco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ClienteCarrinhoProdPreco.DefaultCellStyle = dataGridViewCellStyle14;
            this.ClienteCarrinhoProdPreco.FillWeight = 80F;
            this.ClienteCarrinhoProdPreco.HeaderText = "Preço";
            this.ClienteCarrinhoProdPreco.Name = "ClienteCarrinhoProdPreco";
            this.ClienteCarrinhoProdPreco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClienteCarrinhoProdQtde
            // 
            this.ClienteCarrinhoProdQtde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ClienteCarrinhoProdQtde.DefaultCellStyle = dataGridViewCellStyle15;
            this.ClienteCarrinhoProdQtde.FillWeight = 40F;
            this.ClienteCarrinhoProdQtde.HeaderText = "Qtde";
            this.ClienteCarrinhoProdQtde.Name = "ClienteCarrinhoProdQtde";
            this.ClienteCarrinhoProdQtde.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.richTextBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(471, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 421);
            this.panel3.TabIndex = 2;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(35, 174);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(253, 195);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "Obrigado pela\n  preferência\n \nVolte Sempre";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(3, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compra finalizada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Caixa
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.TabCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Caixa";
            this.Text = "Caixa";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Caixa_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Caixa_DragEnter);
            this.TabCtrl.ResumeLayout(false);
            this.CaixaWelcomeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CamLogoPictureBox)).EndInit();
            this.CaixaClienteSaida.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FacialRecPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteCarrinhoTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabCtrl;
        private System.Windows.Forms.TabPage CaixaClienteSaida;
        private System.Windows.Forms.TabPage CaixaWelcomeTab;
        private System.Windows.Forms.TabPage CaixaClienteEntrada;
        private System.Windows.Forms.TabPage CaixaCadastroCliente;
        private System.Windows.Forms.Label CaixaWelcomeLabel;
        private System.Windows.Forms.PictureBox CamLogoPictureBox;
        private System.Windows.Forms.Label CaixaLogoLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox FacialRecPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ClienteCarrinhoTotalValue;
        private System.Windows.Forms.Label ClienteLabelCarrinho;
        private System.Windows.Forms.Label ClienteCarrinhoTotalLabel;
        private System.Windows.Forms.DataGridView ClienteCarrinhoTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteCarrinhoProdNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteCarrinhoProdPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteCarrinhoProdQtde;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}