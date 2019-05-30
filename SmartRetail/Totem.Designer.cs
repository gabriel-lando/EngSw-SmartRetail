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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TotemWelcomeTab = new System.Windows.Forms.TabPage();
            this.FacialRecPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TotemCliente = new System.Windows.Forms.TabPage();
            this.TotemWelcomeLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TotemWelcomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacialRecPictureBox)).BeginInit();
            this.TotemCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.TotemWelcomeTab);
            this.tabControl1.Controls.Add(this.TotemCliente);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(5, 5);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 430);
            this.tabControl1.TabIndex = 7;
            // 
            // TotemWelcomeTab
            // 
            this.TotemWelcomeTab.Controls.Add(this.TotemWelcomeLabel);
            this.TotemWelcomeTab.Location = new System.Drawing.Point(4, 9);
            this.TotemWelcomeTab.Name = "TotemWelcomeTab";
            this.TotemWelcomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.TotemWelcomeTab.Size = new System.Drawing.Size(792, 417);
            this.TotemWelcomeTab.TabIndex = 1;
            this.TotemWelcomeTab.UseVisualStyleBackColor = true;
            // 
            // FacialRecPictureBox
            // 
            this.FacialRecPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FacialRecPictureBox.BackColor = System.Drawing.Color.PaleGreen;
            this.FacialRecPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FacialRecPictureBox.Location = new System.Drawing.Point(8, 209);
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
            this.panel1.Location = new System.Drawing.Point(155, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(629, 403);
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
            // TotemCliente
            // 
            this.TotemCliente.Controls.Add(this.richTextBox1);
            this.TotemCliente.Controls.Add(this.panel1);
            this.TotemCliente.Controls.Add(this.FacialRecPictureBox);
            this.TotemCliente.Location = new System.Drawing.Point(4, 9);
            this.TotemCliente.Name = "TotemCliente";
            this.TotemCliente.Padding = new System.Windows.Forms.Padding(3);
            this.TotemCliente.Size = new System.Drawing.Size(792, 417);
            this.TotemCliente.TabIndex = 0;
            this.TotemCliente.UseVisualStyleBackColor = true;
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
            this.TotemWelcomeLabel.Text = "Bem Vindo!";
            this.TotemWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Totem
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Totem";
            this.Text = "Totem";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Totem_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Totem_DragEnter);
            this.tabControl1.ResumeLayout(false);
            this.TotemWelcomeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FacialRecPictureBox)).EndInit();
            this.TotemCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TotemWelcomeTab;
        private System.Windows.Forms.PictureBox FacialRecPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage TotemCliente;
        private System.Windows.Forms.Label TotemWelcomeLabel;
    }
}