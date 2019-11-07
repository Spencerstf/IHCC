
namespace Bytejam_Project
{
    partial class Blackjack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blackjack));
            this.btnHit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.playerCard1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playerCard2 = new System.Windows.Forms.PictureBox();
            this.playerCard3 = new System.Windows.Forms.PictureBox();
            this.playerCard4 = new System.Windows.Forms.PictureBox();
            this.playerCard5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dealerCard5 = new System.Windows.Forms.PictureBox();
            this.dealerCard4 = new System.Windows.Forms.PictureBox();
            this.dealerCard3 = new System.Windows.Forms.PictureBox();
            this.dealerCard2 = new System.Windows.Forms.PictureBox();
            this.dealerCard1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.Label();
            this.dealerScore = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbllPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.btnPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Red;
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHit.Location = new System.Drawing.Point(532, 481);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(195, 79);
            this.btnHit.TabIndex = 3;
            this.btnHit.Text = "Hit Me";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(16, 481);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(189, 79);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Return to Main Menu";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.BackColor = System.Drawing.Color.Red;
            this.btnDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeal.Location = new System.Drawing.Point(267, 481);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(203, 79);
            this.btnDeal.TabIndex = 5;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = false;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // playerCard1
            // 
            this.playerCard1.Image = global::Bytejam_Project.Properties.Resources.AClub;
            this.playerCard1.Location = new System.Drawing.Point(601, 305);
            this.playerCard1.Name = "playerCard1";
            this.playerCard1.Size = new System.Drawing.Size(73, 98);
            this.playerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard1.TabIndex = 8;
            this.playerCard1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(242, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // playerCard2
            // 
            this.playerCard2.Image = global::Bytejam_Project.Properties.Resources.AClub;
            this.playerCard2.Location = new System.Drawing.Point(680, 305);
            this.playerCard2.Name = "playerCard2";
            this.playerCard2.Size = new System.Drawing.Size(73, 98);
            this.playerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard2.TabIndex = 9;
            this.playerCard2.TabStop = false;
            // 
            // playerCard3
            // 
            this.playerCard3.Image = global::Bytejam_Project.Properties.Resources.AClub;
            this.playerCard3.Location = new System.Drawing.Point(759, 305);
            this.playerCard3.Name = "playerCard3";
            this.playerCard3.Size = new System.Drawing.Size(73, 98);
            this.playerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard3.TabIndex = 10;
            this.playerCard3.TabStop = false;
            // 
            // playerCard4
            // 
            this.playerCard4.BackColor = System.Drawing.Color.Firebrick;
            this.playerCard4.Image = global::Bytejam_Project.Properties.Resources.AClub;
            this.playerCard4.Location = new System.Drawing.Point(838, 305);
            this.playerCard4.Name = "playerCard4";
            this.playerCard4.Size = new System.Drawing.Size(73, 98);
            this.playerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard4.TabIndex = 11;
            this.playerCard4.TabStop = false;
            // 
            // playerCard5
            // 
            this.playerCard5.Image = global::Bytejam_Project.Properties.Resources.AClub;
            this.playerCard5.Location = new System.Drawing.Point(917, 305);
            this.playerCard5.Name = "playerCard5";
            this.playerCard5.Size = new System.Drawing.Size(73, 98);
            this.playerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard5.TabIndex = 12;
            this.playerCard5.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(601, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 42);
            this.label2.TabIndex = 13;
            this.label2.Text = "Your Hand";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(16, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 42);
            this.label3.TabIndex = 19;
            this.label3.Text = "Dealer\'s Hand";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealerCard5
            // 
            this.dealerCard5.Image = global::Bytejam_Project.Properties.Resources.AClub;
            this.dealerCard5.Location = new System.Drawing.Point(332, 305);
            this.dealerCard5.Name = "dealerCard5";
            this.dealerCard5.Size = new System.Drawing.Size(73, 98);
            this.dealerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard5.TabIndex = 18;
            this.dealerCard5.TabStop = false;
            // 
            // dealerCard4
            // 
            this.dealerCard4.BackColor = System.Drawing.Color.Firebrick;
            this.dealerCard4.Image = global::Bytejam_Project.Properties.Resources.AClub;
            this.dealerCard4.Location = new System.Drawing.Point(253, 305);
            this.dealerCard4.Name = "dealerCard4";
            this.dealerCard4.Size = new System.Drawing.Size(73, 98);
            this.dealerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard4.TabIndex = 17;
            this.dealerCard4.TabStop = false;
            // 
            // dealerCard3
            // 
            this.dealerCard3.Image = global::Bytejam_Project.Properties.Resources.AClub;
            this.dealerCard3.Location = new System.Drawing.Point(174, 305);
            this.dealerCard3.Name = "dealerCard3";
            this.dealerCard3.Size = new System.Drawing.Size(73, 98);
            this.dealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard3.TabIndex = 16;
            this.dealerCard3.TabStop = false;
            // 
            // dealerCard2
            // 
            this.dealerCard2.Image = global::Bytejam_Project.Properties.Resources.AClub;
            this.dealerCard2.Location = new System.Drawing.Point(95, 305);
            this.dealerCard2.Name = "dealerCard2";
            this.dealerCard2.Size = new System.Drawing.Size(73, 98);
            this.dealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard2.TabIndex = 15;
            this.dealerCard2.TabStop = false;
            // 
            // dealerCard1
            // 
            this.dealerCard1.Image = global::Bytejam_Project.Properties.Resources.AClub;
            this.dealerCard1.Location = new System.Drawing.Point(16, 305);
            this.dealerCard1.Name = "dealerCard1";
            this.dealerCard1.Size = new System.Drawing.Size(73, 98);
            this.dealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard1.TabIndex = 14;
            this.dealerCard1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(697, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Your card\'s value=";
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.BackColor = System.Drawing.Color.Transparent;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerScore.Location = new System.Drawing.Point(860, 167);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(19, 20);
            this.playerScore.TabIndex = 21;
            this.playerScore.Text = "0";
            // 
            // dealerScore
            // 
            this.dealerScore.AutoSize = true;
            this.dealerScore.BackColor = System.Drawing.Color.Transparent;
            this.dealerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dealerScore.Location = new System.Drawing.Point(175, 167);
            this.dealerScore.Name = "dealerScore";
            this.dealerScore.Size = new System.Drawing.Size(19, 20);
            this.dealerScore.TabIndex = 23;
            this.dealerScore.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(12, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Dealer\'s card value=";
            // 
            // lbllPlayerName
            // 
            this.lbllPlayerName.AutoSize = true;
            this.lbllPlayerName.Location = new System.Drawing.Point(58, 37);
            this.lbllPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllPlayerName.Name = "lbllPlayerName";
            this.lbllPlayerName.Size = new System.Drawing.Size(94, 13);
            this.lbllPlayerName.TabIndex = 24;
            this.lbllPlayerName.Text = "Name Placeholder";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(13, 9);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(94, 13);
            this.lblPlayerScore.TabIndex = 25;
            this.lblPlayerScore.Text = "Score Placeholder";
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.Red;
            this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPass.Location = new System.Drawing.Point(789, 481);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(195, 79);
            this.btnPass.TabIndex = 26;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = false;
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(136)))), ((int)(((byte)(40)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(997, 569);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lbllPlayerName);
            this.Controls.Add(this.dealerScore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dealerCard5);
            this.Controls.Add(this.dealerCard4);
            this.Controls.Add(this.dealerCard3);
            this.Controls.Add(this.dealerCard2);
            this.Controls.Add(this.dealerCard1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerCard5);
            this.Controls.Add(this.playerCard4);
            this.Controls.Add(this.playerCard3);
            this.Controls.Add(this.playerCard2);
            this.Controls.Add(this.playerCard1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHit);
            this.Name = "Blackjack";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Blackjack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox playerCard1;
        private System.Windows.Forms.PictureBox playerCard2;
        private System.Windows.Forms.PictureBox playerCard3;
        private System.Windows.Forms.PictureBox playerCard4;
        private System.Windows.Forms.PictureBox playerCard5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox dealerCard5;
        private System.Windows.Forms.PictureBox dealerCard4;
        private System.Windows.Forms.PictureBox dealerCard3;
        private System.Windows.Forms.PictureBox dealerCard2;
        private System.Windows.Forms.PictureBox dealerCard1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label dealerScore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbllPlayerName;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Button btnPass;
    }
}