namespace SmartRetail
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
            this.FacialRecPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CaixaClienteSaida = new System.Windows.Forms.TabPage();
            this.CaixaWelcomeTab = new System.Windows.Forms.TabPage();
            this.CaixaClienteEntrada = new System.Windows.Forms.TabPage();
            this.CaixaCadastroCliente = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.FacialRecPictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.CaixaClienteSaida.SuspendLayout();
            this.SuspendLayout();
            // 
            // FacialRecPictureBox
            // 
            this.FacialRecPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FacialRecPictureBox.BackColor = System.Drawing.Color.PaleGreen;
            this.FacialRecPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FacialRecPictureBox.Location = new System.Drawing.Point(8, 219);
            this.FacialRecPictureBox.Name = "FacialRecPictureBox";
            this.FacialRecPictureBox.Size = new System.Drawing.Size(150, 200);
            this.FacialRecPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FacialRecPictureBox.TabIndex = 0;
            this.FacialRecPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(164, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(629, 413);
            this.panel1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(150, 200);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.CaixaWelcomeTab);
            this.tabControl1.Controls.Add(this.CaixaClienteEntrada);
            this.tabControl1.Controls.Add(this.CaixaCadastroCliente);
            this.tabControl1.Controls.Add(this.CaixaClienteSaida);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(5, 5);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 440);
            this.tabControl1.TabIndex = 6;
            // 
            // CaixaClienteSaida
            // 
            this.CaixaClienteSaida.Controls.Add(this.richTextBox1);
            this.CaixaClienteSaida.Controls.Add(this.panel1);
            this.CaixaClienteSaida.Controls.Add(this.FacialRecPictureBox);
            this.CaixaClienteSaida.Location = new System.Drawing.Point(4, 9);
            this.CaixaClienteSaida.Name = "CaixaClienteSaida";
            this.CaixaClienteSaida.Padding = new System.Windows.Forms.Padding(3);
            this.CaixaClienteSaida.Size = new System.Drawing.Size(801, 427);
            this.CaixaClienteSaida.TabIndex = 0;
            this.CaixaClienteSaida.UseVisualStyleBackColor = true;
            // 
            // CaixaWelcomeTab
            // 
            this.CaixaWelcomeTab.Location = new System.Drawing.Point(4, 9);
            this.CaixaWelcomeTab.Name = "CaixaWelcomeTab";
            this.CaixaWelcomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.CaixaWelcomeTab.Size = new System.Drawing.Size(801, 427);
            this.CaixaWelcomeTab.TabIndex = 1;
            this.CaixaWelcomeTab.UseVisualStyleBackColor = true;
            // 
            // CaixaClienteEntrada
            // 
            this.CaixaClienteEntrada.Location = new System.Drawing.Point(4, 9);
            this.CaixaClienteEntrada.Name = "CaixaClienteEntrada";
            this.CaixaClienteEntrada.Size = new System.Drawing.Size(801, 427);
            this.CaixaClienteEntrada.TabIndex = 2;
            this.CaixaClienteEntrada.Text = "tabPage1";
            this.CaixaClienteEntrada.UseVisualStyleBackColor = true;
            // 
            // CaixaCadastroCliente
            // 
            this.CaixaCadastroCliente.Location = new System.Drawing.Point(4, 9);
            this.CaixaCadastroCliente.Name = "CaixaCadastroCliente";
            this.CaixaCadastroCliente.Size = new System.Drawing.Size(801, 427);
            this.CaixaCadastroCliente.TabIndex = 3;
            this.CaixaCadastroCliente.Text = "tabPage1";
            this.CaixaCadastroCliente.UseVisualStyleBackColor = true;
            // 
            // Caixa
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 440);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Caixa";
            this.Text = "Caixa";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Caixa_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Caixa_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.FacialRecPictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.CaixaClienteSaida.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FacialRecPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CaixaClienteSaida;
        private System.Windows.Forms.TabPage CaixaWelcomeTab;
        private System.Windows.Forms.TabPage CaixaClienteEntrada;
        private System.Windows.Forms.TabPage CaixaCadastroCliente;
    }
}