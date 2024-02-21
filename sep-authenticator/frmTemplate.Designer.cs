namespace sep_authenticator
{
    partial class frmTemplate
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar1 = new sep_authenticator.CircularProgressBar();
            this.pnlTemplate = new System.Windows.Forms.Panel();
            this.btnMore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 50);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Example Service - email@test.com";
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
            this.circularProgressBar1.Location = new System.Drawing.Point(328, 30);
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
            // pnlTemplate
            // 
            this.pnlTemplate.Controls.Add(this.btnMore);
            this.pnlTemplate.Controls.Add(this.label2);
            this.pnlTemplate.Controls.Add(this.circularProgressBar1);
            this.pnlTemplate.Controls.Add(this.label1);
            this.pnlTemplate.Controls.Add(this.pictureBox1);
            this.pnlTemplate.Location = new System.Drawing.Point(12, 200);
            this.pnlTemplate.Name = "pnlTemplate";
            this.pnlTemplate.Size = new System.Drawing.Size(426, 140);
            this.pnlTemplate.TabIndex = 4;
            // 
            // btnMore
            // 
            this.btnMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMore.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMore.Location = new System.Drawing.Point(352, 3);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(52, 27);
            this.btnMore.TabIndex = 4;
            this.btnMore.Text = "...";
            this.btnMore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMore.UseVisualStyleBackColor = true;
            // 
            // frmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlTemplate);
            this.Name = "frmTemplate";
            this.Text = "Template";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTemplate.ResumeLayout(false);
            this.pnlTemplate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.Panel pnlTemplate;
        private System.Windows.Forms.Button btnMore;
    }
}

