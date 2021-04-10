namespace GeekWars
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Attack1 = new System.Windows.Forms.Button();
            this.Attack2 = new System.Windows.Forms.Button();
            this.Attack3 = new System.Windows.Forms.Button();
            this.Attack4 = new System.Windows.Forms.Button();
            this.Attack5 = new System.Windows.Forms.Button();
            this.pbAttack1 = new System.Windows.Forms.ProgressBar();
            this.pbAttack2 = new System.Windows.Forms.ProgressBar();
            this.pbAttack3 = new System.Windows.Forms.ProgressBar();
            this.pbAttack4 = new System.Windows.Forms.ProgressBar();
            this.pbAttack5 = new System.Windows.Forms.ProgressBar();
            this.lblKilled = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Attack6 = new System.Windows.Forms.Button();
            this.pbAttack6 = new System.Windows.Forms.ProgressBar();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Attack1
            // 
            this.Attack1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Attack1.BackColor = System.Drawing.Color.Blue;
            this.Attack1.ForeColor = System.Drawing.SystemColors.Control;
            this.Attack1.Location = new System.Drawing.Point(218, 129);
            this.Attack1.Name = "Attack1";
            this.Attack1.Size = new System.Drawing.Size(165, 23);
            this.Attack1.TabIndex = 0;
            this.Attack1.Tag = "0.20";
            this.Attack1.Text = "0.20 Dmg";
            this.Attack1.UseVisualStyleBackColor = false;
            this.Attack1.Click += new System.EventHandler(this.Attack1_Click);
            // 
            // Attack2
            // 
            this.Attack2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Attack2.BackColor = System.Drawing.Color.Blue;
            this.Attack2.ForeColor = System.Drawing.SystemColors.Control;
            this.Attack2.Location = new System.Drawing.Point(218, 298);
            this.Attack2.Name = "Attack2";
            this.Attack2.Size = new System.Drawing.Size(165, 23);
            this.Attack2.TabIndex = 0;
            this.Attack2.Tag = "0.40";
            this.Attack2.Text = "0.40 Dmg";
            this.Attack2.UseVisualStyleBackColor = false;
            this.Attack2.Click += new System.EventHandler(this.Attack2_Click);
            // 
            // Attack3
            // 
            this.Attack3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Attack3.BackColor = System.Drawing.Color.Blue;
            this.Attack3.ForeColor = System.Drawing.SystemColors.Control;
            this.Attack3.Location = new System.Drawing.Point(218, 477);
            this.Attack3.Name = "Attack3";
            this.Attack3.Size = new System.Drawing.Size(165, 23);
            this.Attack3.TabIndex = 0;
            this.Attack3.Tag = "0.60";
            this.Attack3.Text = "0.60 Dmg";
            this.Attack3.UseVisualStyleBackColor = false;
            this.Attack3.Click += new System.EventHandler(this.Attack3_Click);
            // 
            // Attack4
            // 
            this.Attack4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Attack4.BackColor = System.Drawing.Color.Blue;
            this.Attack4.ForeColor = System.Drawing.SystemColors.Control;
            this.Attack4.Location = new System.Drawing.Point(612, 129);
            this.Attack4.Name = "Attack4";
            this.Attack4.Size = new System.Drawing.Size(165, 23);
            this.Attack4.TabIndex = 0;
            this.Attack4.Text = "0.80 Dmg";
            this.Attack4.UseVisualStyleBackColor = false;
            this.Attack4.Click += new System.EventHandler(this.Attack4_Click);
            // 
            // Attack5
            // 
            this.Attack5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Attack5.BackColor = System.Drawing.Color.Blue;
            this.Attack5.ForeColor = System.Drawing.SystemColors.Control;
            this.Attack5.Location = new System.Drawing.Point(612, 298);
            this.Attack5.Name = "Attack5";
            this.Attack5.Size = new System.Drawing.Size(165, 23);
            this.Attack5.TabIndex = 0;
            this.Attack5.Text = "1 Dmg";
            this.Attack5.UseVisualStyleBackColor = false;
            this.Attack5.Click += new System.EventHandler(this.Attack5_Click);
            // 
            // pbAttack1
            // 
            this.pbAttack1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAttack1.Location = new System.Drawing.Point(218, 100);
            this.pbAttack1.MarqueeAnimationSpeed = 1;
            this.pbAttack1.Name = "pbAttack1";
            this.pbAttack1.Size = new System.Drawing.Size(165, 23);
            this.pbAttack1.Step = 1;
            this.pbAttack1.TabIndex = 1;
            this.pbAttack1.Value = 100;
            // 
            // pbAttack2
            // 
            this.pbAttack2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAttack2.Location = new System.Drawing.Point(218, 269);
            this.pbAttack2.Name = "pbAttack2";
            this.pbAttack2.Size = new System.Drawing.Size(165, 23);
            this.pbAttack2.TabIndex = 1;
            this.pbAttack2.Value = 100;
            // 
            // pbAttack3
            // 
            this.pbAttack3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAttack3.Location = new System.Drawing.Point(218, 448);
            this.pbAttack3.Name = "pbAttack3";
            this.pbAttack3.Size = new System.Drawing.Size(165, 23);
            this.pbAttack3.TabIndex = 1;
            this.pbAttack3.Value = 100;
            // 
            // pbAttack4
            // 
            this.pbAttack4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAttack4.Location = new System.Drawing.Point(612, 100);
            this.pbAttack4.Name = "pbAttack4";
            this.pbAttack4.Size = new System.Drawing.Size(165, 23);
            this.pbAttack4.TabIndex = 1;
            this.pbAttack4.Value = 100;
            // 
            // pbAttack5
            // 
            this.pbAttack5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAttack5.Location = new System.Drawing.Point(612, 269);
            this.pbAttack5.Name = "pbAttack5";
            this.pbAttack5.Size = new System.Drawing.Size(165, 23);
            this.pbAttack5.TabIndex = 1;
            this.pbAttack5.Value = 100;
            // 
            // lblKilled
            // 
            this.lblKilled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKilled.BackColor = System.Drawing.Color.White;
            this.lblKilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilled.ForeColor = System.Drawing.Color.Red;
            this.lblKilled.Location = new System.Drawing.Point(12, 237);
            this.lblKilled.Name = "lblKilled";
            this.lblKilled.Size = new System.Drawing.Size(760, 47);
            this.lblKilled.TabIndex = 2;
            this.lblKilled.Text = "You\'ve been killed. Revive in 15 seconds";
            this.lblKilled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKilled.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(406, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 140);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 360);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 140);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(406, 360);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(200, 140);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // Attack6
            // 
            this.Attack6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Attack6.BackColor = System.Drawing.Color.Blue;
            this.Attack6.ForeColor = System.Drawing.SystemColors.Control;
            this.Attack6.Location = new System.Drawing.Point(612, 477);
            this.Attack6.Name = "Attack6";
            this.Attack6.Size = new System.Drawing.Size(165, 23);
            this.Attack6.TabIndex = 0;
            this.Attack6.Text = "2 Dmg";
            this.Attack6.UseVisualStyleBackColor = false;
            this.Attack6.Click += new System.EventHandler(this.Attack6_Click);
            // 
            // pbAttack6
            // 
            this.pbAttack6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAttack6.Location = new System.Drawing.Point(612, 448);
            this.pbAttack6.Name = "pbAttack6";
            this.pbAttack6.Size = new System.Drawing.Size(165, 23);
            this.pbAttack6.TabIndex = 1;
            this.pbAttack6.Value = 100;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(406, 181);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(200, 140);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(218, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Y-Wing";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(218, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "B-Wing";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(218, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "X-Wing";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(612, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ARC 170";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(612, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "X-Wing";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(612, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Z-95 Headhunter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.lblKilled);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbAttack6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbAttack5);
            this.Controls.Add(this.pbAttack4);
            this.Controls.Add(this.pbAttack3);
            this.Controls.Add(this.pbAttack2);
            this.Controls.Add(this.Attack6);
            this.Controls.Add(this.pbAttack1);
            this.Controls.Add(this.Attack5);
            this.Controls.Add(this.Attack4);
            this.Controls.Add(this.Attack3);
            this.Controls.Add(this.Attack2);
            this.Controls.Add(this.Attack1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "GeekWars";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Attack1;
        private System.Windows.Forms.Button Attack2;
        private System.Windows.Forms.Button Attack3;
        private System.Windows.Forms.Button Attack4;
        private System.Windows.Forms.Button Attack5;
        private System.Windows.Forms.ProgressBar pbAttack1;
        private System.Windows.Forms.ProgressBar pbAttack2;
        private System.Windows.Forms.ProgressBar pbAttack3;
        private System.Windows.Forms.ProgressBar pbAttack4;
        private System.Windows.Forms.ProgressBar pbAttack5;
        private System.Windows.Forms.Label lblKilled;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button Attack6;
        private System.Windows.Forms.ProgressBar pbAttack6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

