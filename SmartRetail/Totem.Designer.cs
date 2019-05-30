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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Totem));
            this.TabCtrl = new System.Windows.Forms.TabControl();
            this.TotemWelcomeTab = new System.Windows.Forms.TabPage();
            this.FacialRecPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TotemCliente = new System.Windows.Forms.TabPage();
            this.TotemWelcomeLabel = new System.Windows.Forms.Label();
            this.CamLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.TotemLogoLabel = new System.Windows.Forms.Label();
            this.TabCtrl.SuspendLayout();
            this.TotemWelcomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacialRecPictureBox)).BeginInit();
            this.TotemCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CamLogoPictureBox)).BeginInit();
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
            this.TabCtrl.Name = "TabCtrl";
            this.TabCtrl.Padding = new System.Drawing.Point(0, 0);
            this.TabCtrl.SelectedIndex = 0;
            this.TabCtrl.Size = new System.Drawing.Size(800, 430);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(162, 6);
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
            // CamLogoPictureBox
            // 
            this.CamLogoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CamLogoPictureBox.BackgroundImage")));
            this.CamLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CamLogoPictureBox.ErrorImage = null;
            this.CamLogoPictureBox.InitialImage = null;
            this.CamLogoPictureBox.Location = new System.Drawing.Point(213, 98);
            this.CamLogoPictureBox.Name = "CamLogoPictureBox";
            this.CamLogoPictureBox.Size = new System.Drawing.Size(353, 226);
            this.CamLogoPictureBox.TabIndex = 1;
            this.CamLogoPictureBox.TabStop = false;
            // 
            // TotemLogoLabel
            // 
            this.TotemLogoLabel.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotemLogoLabel.Location = new System.Drawing.Point(6, 338);
            this.TotemLogoLabel.Name = "TotemLogoLabel";
            this.TotemLogoLabel.Size = new System.Drawing.Size(780, 74);
            this.TotemLogoLabel.TabIndex = 2;
            this.TotemLogoLabel.Text = "Smart Retail";
            this.TotemLogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Totem
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.TabCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Totem";
            this.Text = "Totem";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Totem_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Totem_DragEnter);
            this.TabCtrl.ResumeLayout(false);
            this.TotemWelcomeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FacialRecPictureBox)).EndInit();
            this.TotemCliente.ResumeLayout(false);
            this.TotemCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CamLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabCtrl;
        private System.Windows.Forms.TabPage TotemWelcomeTab;
        private System.Windows.Forms.PictureBox FacialRecPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage TotemCliente;
        private System.Windows.Forms.Label TotemWelcomeLabel;
        private System.Windows.Forms.Label TotemLogoLabel;
        private System.Windows.Forms.PictureBox CamLogoPictureBox;
    }
}