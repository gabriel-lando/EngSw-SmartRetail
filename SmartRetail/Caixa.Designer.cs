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
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TabCtrl = new System.Windows.Forms.TabControl();
            this.CaixaClienteSaida = new System.Windows.Forms.TabPage();
            this.CaixaWelcomeTab = new System.Windows.Forms.TabPage();
            this.CaixaClienteEntrada = new System.Windows.Forms.TabPage();
            this.CaixaCadastroCliente = new System.Windows.Forms.TabPage();
            this.FacialRecPictureBox = new System.Windows.Forms.PictureBox();
            this.TabCtrl.SuspendLayout();
            this.CaixaClienteSaida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacialRecPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(164, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(622, 405);
            this.panel1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 211);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(150, 200);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
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
            this.TabCtrl.ItemSize = new System.Drawing.Size(5, 5);
            this.TabCtrl.Location = new System.Drawing.Point(0, 0);
            this.TabCtrl.Name = "TabCtrl";
            this.TabCtrl.Padding = new System.Drawing.Point(0, 0);
            this.TabCtrl.SelectedIndex = 0;
            this.TabCtrl.Size = new System.Drawing.Size(800, 430);
            this.TabCtrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabCtrl.TabIndex = 6;
            // 
            // CaixaClienteSaida
            // 
            this.CaixaClienteSaida.Controls.Add(this.richTextBox1);
            this.CaixaClienteSaida.Controls.Add(this.panel1);
            this.CaixaClienteSaida.Controls.Add(this.FacialRecPictureBox);
            this.CaixaClienteSaida.Location = new System.Drawing.Point(4, 9);
            this.CaixaClienteSaida.Name = "CaixaClienteSaida";
            this.CaixaClienteSaida.Padding = new System.Windows.Forms.Padding(3);
            this.CaixaClienteSaida.Size = new System.Drawing.Size(792, 417);
            this.CaixaClienteSaida.TabIndex = 0;
            this.CaixaClienteSaida.UseVisualStyleBackColor = true;
            // 
            // CaixaWelcomeTab
            // 
            this.CaixaWelcomeTab.Location = new System.Drawing.Point(4, 9);
            this.CaixaWelcomeTab.Name = "CaixaWelcomeTab";
            this.CaixaWelcomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.CaixaWelcomeTab.Size = new System.Drawing.Size(792, 417);
            this.CaixaWelcomeTab.TabIndex = 1;
            this.CaixaWelcomeTab.UseVisualStyleBackColor = true;
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
            // FacialRecPictureBox
            // 
            this.FacialRecPictureBox.BackColor = System.Drawing.Color.PaleGreen;
            this.FacialRecPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FacialRecPictureBox.Location = new System.Drawing.Point(6, 6);
            this.FacialRecPictureBox.Name = "FacialRecPictureBox";
            this.FacialRecPictureBox.Size = new System.Drawing.Size(150, 200);
            this.FacialRecPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FacialRecPictureBox.TabIndex = 0;
            this.FacialRecPictureBox.TabStop = false;
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
            this.CaixaClienteSaida.ResumeLayout(false);
            this.CaixaClienteSaida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacialRecPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabControl TabCtrl;
        private System.Windows.Forms.TabPage CaixaClienteSaida;
        private System.Windows.Forms.TabPage CaixaWelcomeTab;
        private System.Windows.Forms.TabPage CaixaClienteEntrada;
        private System.Windows.Forms.TabPage CaixaCadastroCliente;
        private System.Windows.Forms.PictureBox FacialRecPictureBox;
    }
}