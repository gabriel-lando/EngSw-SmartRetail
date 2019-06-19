namespace SmartRetail
{
    partial class Prateleira
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
            this.TabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TotemWelcomeLabel = new System.Windows.Forms.Label();
            this.CamLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.FacialRecPictureBoxPrateleira = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrateleiraComboBox = new System.Windows.Forms.ComboBox();
            this.ProdutoComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QtdeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DetailsTextBox = new System.Windows.Forms.RichTextBox();
            this.TabCtrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CamLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacialRecPictureBoxPrateleira)).BeginInit();
            this.SuspendLayout();
            // 
            // TabCtrl
            // 
            this.TabCtrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabCtrl.Controls.Add(this.tabPage1);
            this.TabCtrl.Controls.Add(this.tabPage2);
            this.TabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCtrl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabCtrl.ItemSize = new System.Drawing.Size(0, 1);
            this.TabCtrl.Location = new System.Drawing.Point(0, 0);
            this.TabCtrl.Name = "TabCtrl";
            this.TabCtrl.Padding = new System.Drawing.Point(0, 0);
            this.TabCtrl.SelectedIndex = 0;
            this.TabCtrl.Size = new System.Drawing.Size(596, 224);
            this.TabCtrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabCtrl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.CamLogoPictureBox);
            this.tabPage1.Controls.Add(this.TotemWelcomeLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 9);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(588, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.DetailsTextBox);
            this.tabPage2.Controls.Add(this.AddBtn);
            this.tabPage2.Controls.Add(this.CancelarBtn);
            this.tabPage2.Controls.Add(this.QtdeComboBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ProdutoComboBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.PrateleiraComboBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.FacialRecPictureBoxPrateleira);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(588, 215);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // TotemWelcomeLabel
            // 
            this.TotemWelcomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TotemWelcomeLabel.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotemWelcomeLabel.ForeColor = System.Drawing.Color.Blue;
            this.TotemWelcomeLabel.Location = new System.Drawing.Point(3, 3);
            this.TotemWelcomeLabel.Name = "TotemWelcomeLabel";
            this.TotemWelcomeLabel.Size = new System.Drawing.Size(582, 60);
            this.TotemWelcomeLabel.TabIndex = 1;
            this.TotemWelcomeLabel.Text = "Prateleira!";
            this.TotemWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CamLogoPictureBox
            // 
            this.CamLogoPictureBox.BackgroundImage = global::SmartRetail.Properties.Resources.CamPicture;
            this.CamLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CamLogoPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CamLogoPictureBox.ErrorImage = null;
            this.CamLogoPictureBox.InitialImage = null;
            this.CamLogoPictureBox.Location = new System.Drawing.Point(3, 72);
            this.CamLogoPictureBox.Name = "CamLogoPictureBox";
            this.CamLogoPictureBox.Size = new System.Drawing.Size(582, 136);
            this.CamLogoPictureBox.TabIndex = 2;
            this.CamLogoPictureBox.TabStop = false;
            // 
            // FacialRecPictureBoxPrateleira
            // 
            this.FacialRecPictureBoxPrateleira.BackColor = System.Drawing.Color.PaleGreen;
            this.FacialRecPictureBoxPrateleira.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FacialRecPictureBoxPrateleira.Location = new System.Drawing.Point(6, 7);
            this.FacialRecPictureBoxPrateleira.Name = "FacialRecPictureBoxPrateleira";
            this.FacialRecPictureBoxPrateleira.Size = new System.Drawing.Size(150, 200);
            this.FacialRecPictureBoxPrateleira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FacialRecPictureBoxPrateleira.TabIndex = 2;
            this.FacialRecPictureBoxPrateleira.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prateleira:";
            // 
            // PrateleiraComboBox
            // 
            this.PrateleiraComboBox.Enabled = false;
            this.PrateleiraComboBox.FormattingEnabled = true;
            this.PrateleiraComboBox.Location = new System.Drawing.Point(165, 23);
            this.PrateleiraComboBox.Name = "PrateleiraComboBox";
            this.PrateleiraComboBox.Size = new System.Drawing.Size(179, 21);
            this.PrateleiraComboBox.TabIndex = 4;
            this.PrateleiraComboBox.Text = "(Selecione)";
            this.PrateleiraComboBox.SelectedIndexChanged += new System.EventHandler(this.PrateleiraComboBox_SelectedIndexChanged);
            // 
            // ProdutoComboBox
            // 
            this.ProdutoComboBox.Enabled = false;
            this.ProdutoComboBox.FormattingEnabled = true;
            this.ProdutoComboBox.Location = new System.Drawing.Point(165, 77);
            this.ProdutoComboBox.Name = "ProdutoComboBox";
            this.ProdutoComboBox.Size = new System.Drawing.Size(179, 21);
            this.ProdutoComboBox.TabIndex = 6;
            this.ProdutoComboBox.SelectedIndexChanged += new System.EventHandler(this.ProdutoComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produto:";
            // 
            // QtdeComboBox
            // 
            this.QtdeComboBox.Enabled = false;
            this.QtdeComboBox.FormattingEnabled = true;
            this.QtdeComboBox.Location = new System.Drawing.Point(165, 131);
            this.QtdeComboBox.Name = "QtdeComboBox";
            this.QtdeComboBox.Size = new System.Drawing.Size(179, 21);
            this.QtdeComboBox.TabIndex = 8;
            this.QtdeComboBox.SelectedIndexChanged += new System.EventHandler(this.QtdeComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade:";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(165, 184);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 9;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(269, 184);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Adicionar";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DetailsTextBox
            // 
            this.DetailsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.DetailsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailsTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.DetailsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsTextBox.Location = new System.Drawing.Point(366, 3);
            this.DetailsTextBox.Name = "DetailsTextBox";
            this.DetailsTextBox.ReadOnly = true;
            this.DetailsTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.DetailsTextBox.Size = new System.Drawing.Size(219, 209);
            this.DetailsTextBox.TabIndex = 12;
            this.DetailsTextBox.Text = "";
            // 
            // Prateleira
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 224);
            this.Controls.Add(this.TabCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Prateleira";
            this.Text = "Prateleira";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Prateleira_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Prateleira_DragEnter);
            this.TabCtrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CamLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacialRecPictureBoxPrateleira)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabCtrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label TotemWelcomeLabel;
        private System.Windows.Forms.PictureBox CamLogoPictureBox;
        private System.Windows.Forms.PictureBox FacialRecPictureBoxPrateleira;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.ComboBox QtdeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ProdutoComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PrateleiraComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DetailsTextBox;
    }
}