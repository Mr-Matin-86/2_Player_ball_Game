namespace Ball2Player
{
    partial class FRMMain
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
            this.PXBBall = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TXTX = new System.Windows.Forms.TextBox();
            this.TXTY = new System.Windows.Forms.TextBox();
            this.BTNPlayer2 = new System.Windows.Forms.Button();
            this.BTNPlayer1 = new System.Windows.Forms.Button();
            this.LBLCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PXBBall)).BeginInit();
            this.SuspendLayout();
            // 
            // PXBBall
            // 
            this.PXBBall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PXBBall.Image = global::Ball2Player.Properties.Resources._1;
            this.PXBBall.Location = new System.Drawing.Point(539, 206);
            this.PXBBall.Name = "PXBBall";
            this.PXBBall.Size = new System.Drawing.Size(293, 402);
            this.PXBBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PXBBall.TabIndex = 0;
            this.PXBBall.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXTX
            // 
            this.TXTX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXTX.Font = new System.Drawing.Font("Tahoma", 15F);
            this.TXTX.Location = new System.Drawing.Point(448, 37);
            this.TXTX.Multiline = true;
            this.TXTX.Name = "TXTX";
            this.TXTX.Size = new System.Drawing.Size(86, 40);
            this.TXTX.TabIndex = 2;
            // 
            // TXTY
            // 
            this.TXTY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXTY.Font = new System.Drawing.Font("Tahoma", 15F);
            this.TXTY.Location = new System.Drawing.Point(833, 37);
            this.TXTY.Multiline = true;
            this.TXTY.Name = "TXTY";
            this.TXTY.Size = new System.Drawing.Size(86, 40);
            this.TXTY.TabIndex = 3;
            // 
            // BTNPlayer2
            // 
            this.BTNPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNPlayer2.Location = new System.Drawing.Point(1215, 790);
            this.BTNPlayer2.Name = "BTNPlayer2";
            this.BTNPlayer2.Size = new System.Drawing.Size(122, 71);
            this.BTNPlayer2.TabIndex = 4;
            this.BTNPlayer2.Text = "بازیکن شماره 2";
            this.BTNPlayer2.UseVisualStyleBackColor = true;
            this.BTNPlayer2.Click += new System.EventHandler(this.BTNPlayer2_Click);
            // 
            // BTNPlayer1
            // 
            this.BTNPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNPlayer1.Location = new System.Drawing.Point(51, 790);
            this.BTNPlayer1.Name = "BTNPlayer1";
            this.BTNPlayer1.Size = new System.Drawing.Size(122, 71);
            this.BTNPlayer1.TabIndex = 5;
            this.BTNPlayer1.Text = "بازیکن شماره 1";
            this.BTNPlayer1.UseVisualStyleBackColor = true;
            this.BTNPlayer1.Click += new System.EventHandler(this.BTNPlayer1_Click);
            // 
            // LBLCount
            // 
            this.LBLCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBLCount.AutoSize = true;
            this.LBLCount.Font = new System.Drawing.Font("Tahoma", 20F);
            this.LBLCount.Location = new System.Drawing.Point(653, 137);
            this.LBLCount.Name = "LBLCount";
            this.LBLCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBLCount.Size = new System.Drawing.Size(30, 33);
            this.LBLCount.TabIndex = 6;
            this.LBLCount.Text = "0";
            // 
            // FRMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1392, 873);
            this.Controls.Add(this.LBLCount);
            this.Controls.Add(this.BTNPlayer1);
            this.Controls.Add(this.BTNPlayer2);
            this.Controls.Add(this.TXTY);
            this.Controls.Add(this.TXTX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PXBBall);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بازی توپ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PXBBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PXBBall;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TXTX;
        private System.Windows.Forms.TextBox TXTY;
        private System.Windows.Forms.Button BTNPlayer2;
        private System.Windows.Forms.Button BTNPlayer1;
        private System.Windows.Forms.Label LBLCount;

    }
}

