namespace Bytejam_Project
{
    partial class TexasHoldEm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TexasHoldEm));
            this.playerCard2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnFold = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dealerCard1 = new System.Windows.Forms.PictureBox();
            this.dealerCard4 = new System.Windows.Forms.PictureBox();
            this.dealerCard3 = new System.Windows.Forms.PictureBox();
            this.dealerCard2 = new System.Windows.Forms.PictureBox();
            this.dealerCard5 = new System.Windows.Forms.PictureBox();
            this.playerCard1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // playerCard2
            // 
            this.playerCard2.Image = global::Bytejam_Project.Properties.Resources.Back;
            this.playerCard2.Location = new System.Drawing.Point(807, 311);
            this.playerCard2.Name = "playerCard2";
            this.playerCard2.Size = new System.Drawing.Size(74, 99);
            this.playerCard2.TabIndex = 12;
            this.playerCard2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(366, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(602, 599);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(203, 73);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Return to Main Menu";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.BackColor = System.Drawing.Color.Red;
            this.btnDeal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeal.Location = new System.Drawing.Point(21, 585);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(203, 73);
            this.btnDeal.TabIndex = 2;
            this.btnDeal.Text = "Deal ($200)";
            this.btnDeal.UseVisualStyleBackColor = false;
            this.btnDeal.Click += new System.EventHandler(this.BtnDeal_Click);
            // 
            // btnCall
            // 
            this.btnCall.BackColor = System.Drawing.Color.Red;
            this.btnCall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCall.Location = new System.Drawing.Point(299, 599);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(203, 73);
            this.btnCall.TabIndex = 3;
            this.btnCall.Text = "Call ($100)";
            this.btnCall.UseVisualStyleBackColor = false;
            // 
            // btnFold
            // 
            this.btnFold.BackColor = System.Drawing.Color.Red;
            this.btnFold.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFold.Location = new System.Drawing.Point(878, 599);
            this.btnFold.Name = "btnFold";
            this.btnFold.Size = new System.Drawing.Size(203, 73);
            this.btnFold.TabIndex = 5;
            this.btnFold.Text = "Fold";
            this.btnFold.UseVisualStyleBackColor = false;
            this.btnFold.Click += new System.EventHandler(this.BtnFold_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(807, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 275);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // dealerCard1
            // 
            this.dealerCard1.Image = global::Bytejam_Project.Properties.Resources.Back;
            this.dealerCard1.Location = new System.Drawing.Point(70, 311);
            this.dealerCard1.Name = "dealerCard1";
            this.dealerCard1.Size = new System.Drawing.Size(74, 99);
            this.dealerCard1.TabIndex = 7;
            this.dealerCard1.TabStop = false;
            // 
            // dealerCard4
            // 
            this.dealerCard4.Image = global::Bytejam_Project.Properties.Resources.Back;
            this.dealerCard4.Location = new System.Drawing.Point(310, 311);
            this.dealerCard4.Name = "dealerCard4";
            this.dealerCard4.Size = new System.Drawing.Size(74, 99);
            this.dealerCard4.TabIndex = 8;
            this.dealerCard4.TabStop = false;
            // 
            // dealerCard3
            // 
            this.dealerCard3.Image = global::Bytejam_Project.Properties.Resources.Back;
            this.dealerCard3.Location = new System.Drawing.Point(230, 311);
            this.dealerCard3.Name = "dealerCard3";
            this.dealerCard3.Size = new System.Drawing.Size(74, 99);
            this.dealerCard3.TabIndex = 9;
            this.dealerCard3.TabStop = false;
            // 
            // dealerCard2
            // 
            this.dealerCard2.Image = global::Bytejam_Project.Properties.Resources.Back;
            this.dealerCard2.Location = new System.Drawing.Point(150, 311);
            this.dealerCard2.Name = "dealerCard2";
            this.dealerCard2.Size = new System.Drawing.Size(74, 99);
            this.dealerCard2.TabIndex = 10;
            this.dealerCard2.TabStop = false;
            // 
            // dealerCard5
            // 
            this.dealerCard5.Image = global::Bytejam_Project.Properties.Resources.Back;
            this.dealerCard5.Location = new System.Drawing.Point(390, 311);
            this.dealerCard5.Name = "dealerCard5";
            this.dealerCard5.Size = new System.Drawing.Size(74, 99);
            this.dealerCard5.TabIndex = 11;
            this.dealerCard5.TabStop = false;
            // 
            // playerCard1
            // 
            this.playerCard1.Image = global::Bytejam_Project.Properties.Resources.Back;
            this.playerCard1.Location = new System.Drawing.Point(704, 311);
            this.playerCard1.Name = "playerCard1";
            this.playerCard1.Size = new System.Drawing.Size(74, 99);
            this.playerCard1.TabIndex = 13;
            this.playerCard1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(178, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dealer\'s Hand";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(717, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Player\'s Hand";
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPlayerName.Location = new System.Drawing.Point(48, 127);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(0, 20);
            this.labelPlayerName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(681, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Card\'s Value x10";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(764, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "$200 ";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(760, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "$400";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(760, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "$300";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(760, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "$500 ";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(760, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "$700 ";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(756, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "$600";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(753, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "$1000";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(764, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "$900";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(764, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "$800";
            // 
            // TexasHoldEm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1114, 685);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerCard1);
            this.Controls.Add(this.playerCard2);
            this.Controls.Add(this.dealerCard5);
            this.Controls.Add(this.dealerCard2);
            this.Controls.Add(this.dealerCard3);
            this.Controls.Add(this.dealerCard4);
            this.Controls.Add(this.dealerCard1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnFold);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TexasHoldEm";
            this.Text = "TexasHoldEm";
            this.Load += new System.EventHandler(this.TexasHoldEm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Button btnFold;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox dealerCard1;
        private System.Windows.Forms.PictureBox dealerCard4;
        private System.Windows.Forms.PictureBox dealerCard3;
        private System.Windows.Forms.PictureBox dealerCard2;
        private System.Windows.Forms.PictureBox dealerCard5;
        private System.Windows.Forms.PictureBox playerCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox playerCard2;
    }
}