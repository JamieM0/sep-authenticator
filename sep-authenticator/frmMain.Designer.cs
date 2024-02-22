namespace sep_authenticator
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.pnlTemplate = new System.Windows.Forms.Panel();
            this.btnMore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addAuthenticatorTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTokenFromSetupKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAddToken = new System.Windows.Forms.Panel();
            this.txtSetupKey = new System.Windows.Forms.TextBox();
            this.btnAddToken = new System.Windows.Forms.Button();
            this.btnAddTokenClose = new System.Windows.Forms.Button();
            this.lbAddTokenTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlTokenHolder = new System.Windows.Forms.Panel();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar1 = new sep_authenticator.CircularProgressBar();
            this.circularProgressBar2 = new sep_authenticator.CircularProgressBar();
            this.pnlTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlAddToken.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlTokenHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTemplate
            // 
            this.pnlTemplate.Controls.Add(this.btnMore);
            this.pnlTemplate.Controls.Add(this.label2);
            this.pnlTemplate.Controls.Add(this.circularProgressBar1);
            this.pnlTemplate.Controls.Add(this.label1);
            this.pnlTemplate.Controls.Add(this.pictureBox1);
            this.pnlTemplate.Location = new System.Drawing.Point(14, 298);
            this.pnlTemplate.Name = "pnlTemplate";
            this.pnlTemplate.Size = new System.Drawing.Size(494, 120);
            this.pnlTemplate.TabIndex = 5;
            this.pnlTemplate.Visible = false;
            // 
            // btnMore
            // 
            this.btnMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMore.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMore.Location = new System.Drawing.Point(439, 50);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(52, 27);
            this.btnMore.TabIndex = 4;
            this.btnMore.Text = "...";
            this.btnMore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMore.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Example Service - email@test.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "012345";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sep_authenticator.Properties.Resources.icon_256x256;
            this.pictureBox1.Location = new System.Drawing.Point(5, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAuthenticatorTokenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1003, 29);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addAuthenticatorTokenToolStripMenuItem
            // 
            this.addAuthenticatorTokenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTokenFromSetupKeyToolStripMenuItem,
            this.addCustomTokenToolStripMenuItem});
            this.addAuthenticatorTokenToolStripMenuItem.Name = "addAuthenticatorTokenToolStripMenuItem";
            this.addAuthenticatorTokenToolStripMenuItem.Size = new System.Drawing.Size(192, 25);
            this.addAuthenticatorTokenToolStripMenuItem.Text = "Add Authenticator Token";
            // 
            // addTokenFromSetupKeyToolStripMenuItem
            // 
            this.addTokenFromSetupKeyToolStripMenuItem.Name = "addTokenFromSetupKeyToolStripMenuItem";
            this.addTokenFromSetupKeyToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.addTokenFromSetupKeyToolStripMenuItem.Text = "Add Token from Setup Key";
            this.addTokenFromSetupKeyToolStripMenuItem.Click += new System.EventHandler(this.addTokenFromSetupKeyToolStripMenuItem_Click);
            // 
            // addCustomTokenToolStripMenuItem
            // 
            this.addCustomTokenToolStripMenuItem.Name = "addCustomTokenToolStripMenuItem";
            this.addCustomTokenToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.addCustomTokenToolStripMenuItem.Text = "Add Custom Token";
            this.addCustomTokenToolStripMenuItem.Click += new System.EventHandler(this.addCustomTokenToolStripMenuItem_Click);
            // 
            // pnlAddToken
            // 
            this.pnlAddToken.Controls.Add(this.txtSetupKey);
            this.pnlAddToken.Controls.Add(this.btnAddToken);
            this.pnlAddToken.Controls.Add(this.btnAddTokenClose);
            this.pnlAddToken.Controls.Add(this.lbAddTokenTitle);
            this.pnlAddToken.Location = new System.Drawing.Point(174, 101);
            this.pnlAddToken.Name = "pnlAddToken";
            this.pnlAddToken.Size = new System.Drawing.Size(451, 173);
            this.pnlAddToken.TabIndex = 7;
            this.pnlAddToken.Visible = false;
            // 
            // txtSetupKey
            // 
            this.txtSetupKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetupKey.Location = new System.Drawing.Point(12, 42);
            this.txtSetupKey.Multiline = true;
            this.txtSetupKey.Name = "txtSetupKey";
            this.txtSetupKey.Size = new System.Drawing.Size(296, 117);
            this.txtSetupKey.TabIndex = 3;
            // 
            // btnAddToken
            // 
            this.btnAddToken.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToken.Location = new System.Drawing.Point(330, 129);
            this.btnAddToken.Name = "btnAddToken";
            this.btnAddToken.Size = new System.Drawing.Size(108, 30);
            this.btnAddToken.TabIndex = 2;
            this.btnAddToken.Text = "Add Token";
            this.btnAddToken.UseVisualStyleBackColor = true;
            this.btnAddToken.Click += new System.EventHandler(this.btnAddToken_Click);
            // 
            // btnAddTokenClose
            // 
            this.btnAddTokenClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTokenClose.Location = new System.Drawing.Point(330, 9);
            this.btnAddTokenClose.Name = "btnAddTokenClose";
            this.btnAddTokenClose.Size = new System.Drawing.Size(108, 30);
            this.btnAddTokenClose.TabIndex = 1;
            this.btnAddTokenClose.Text = "Close";
            this.btnAddTokenClose.UseVisualStyleBackColor = true;
            this.btnAddTokenClose.Click += new System.EventHandler(this.btnAddTokenClose_Click);
            // 
            // lbAddTokenTitle
            // 
            this.lbAddTokenTitle.AutoSize = true;
            this.lbAddTokenTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddTokenTitle.Location = new System.Drawing.Point(7, 9);
            this.lbAddTokenTitle.Name = "lbAddTokenTitle";
            this.lbAddTokenTitle.Size = new System.Drawing.Size(259, 30);
            this.lbAddTokenTitle.TabIndex = 0;
            this.lbAddTokenTitle.Text = "Add Token from Setup Key";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.circularProgressBar2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(502, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 140);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(400, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Example Service - email@test.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 70);
            this.label4.TabIndex = 1;
            this.label4.Text = "012345";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sep_authenticator.Properties.Resources.icon_256x256;
            this.pictureBox2.Location = new System.Drawing.Point(5, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnlTokenHolder
            // 
            this.pnlTokenHolder.AllowDrop = true;
            this.pnlTokenHolder.Controls.Add(this.panel1);
            this.pnlTokenHolder.Location = new System.Drawing.Point(12, 32);
            this.pnlTokenHolder.Name = "pnlTokenHolder";
            this.pnlTokenHolder.Size = new System.Drawing.Size(979, 416);
            this.pnlTokenHolder.TabIndex = 9;
            this.pnlTokenHolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlTokenHolder_DragDrop);
            this.pnlTokenHolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlTokenHolder_DragEnter);
            // 
            // tmrTick
            // 
            this.tmrTick.Interval = 1000;
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.circularProgressBar1.BarColor1 = System.Drawing.Color.LimeGreen;
            this.circularProgressBar1.BarColor2 = System.Drawing.Color.DeepSkyBlue;
            this.circularProgressBar1.BarWidth = 14F;
            this.circularProgressBar1.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.DimGray;
            this.circularProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.circularProgressBar1.LineColor = System.Drawing.Color.DimGray;
            this.circularProgressBar1.LineWidth = 1;
            this.circularProgressBar1.Location = new System.Drawing.Point(0, 20);
            this.circularProgressBar1.Maximum = ((long)(30));
            this.circularProgressBar1.MinimumSize = new System.Drawing.Size(100, 100);
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.ProgressShape = sep_authenticator.CircularProgressBar._ProgressShape.Flat;
            this.circularProgressBar1.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar1.TabIndex = 3;
            this.circularProgressBar1.Text = "30";
            this.circularProgressBar1.TextMode = sep_authenticator.CircularProgressBar._TextMode.Value;
            this.circularProgressBar1.Value = ((long)(30));
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.BackColor = System.Drawing.SystemColors.Control;
            this.circularProgressBar2.BarColor1 = System.Drawing.Color.LimeGreen;
            this.circularProgressBar2.BarColor2 = System.Drawing.Color.DeepSkyBlue;
            this.circularProgressBar2.BarWidth = 14F;
            this.circularProgressBar2.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar2.ForeColor = System.Drawing.Color.DimGray;
            this.circularProgressBar2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.circularProgressBar2.LineColor = System.Drawing.Color.DimGray;
            this.circularProgressBar2.LineWidth = 1;
            this.circularProgressBar2.Location = new System.Drawing.Point(0, 37);
            this.circularProgressBar2.Maximum = ((long)(30));
            this.circularProgressBar2.MinimumSize = new System.Drawing.Size(100, 100);
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.ProgressShape = sep_authenticator.CircularProgressBar._ProgressShape.Flat;
            this.circularProgressBar2.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar2.TabIndex = 3;
            this.circularProgressBar2.Text = "30";
            this.circularProgressBar2.TextMode = sep_authenticator.CircularProgressBar._TextMode.Value;
            this.circularProgressBar2.Value = ((long)(30));
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.pnlAddToken);
            this.Controls.Add(this.pnlTemplate);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlTokenHolder);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "SEP Authenticator";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.pnlTemplate.ResumeLayout(false);
            this.pnlTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlAddToken.ResumeLayout(false);
            this.pnlAddToken.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlTokenHolder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTemplate;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addAuthenticatorTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTokenFromSetupKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomTokenToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAddToken;
        private System.Windows.Forms.Button btnAddToken;
        private System.Windows.Forms.Button btnAddTokenClose;
        private System.Windows.Forms.Label lbAddTokenTitle;
        private System.Windows.Forms.TextBox txtSetupKey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar circularProgressBar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlTokenHolder;
        private System.Windows.Forms.Timer tmrTick;
    }
}