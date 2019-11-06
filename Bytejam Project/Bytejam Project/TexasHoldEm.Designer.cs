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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnFold = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnExit.Location = new System.Drawing.Point(12, 22);
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
            this.btnDeal.Location = new System.Drawing.Point(12, 599);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(203, 73);
            this.btnDeal.TabIndex = 2;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = false;
            // 
            // btnCall
            // 
            this.btnCall.BackColor = System.Drawing.Color.Red;
            this.btnCall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCall.Location = new System.Drawing.Point(313, 599);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(203, 73);
            this.btnCall.TabIndex = 3;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = false;
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.Red;
            this.btnPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPass.Location = new System.Drawing.Point(604, 599);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(203, 73);
            this.btnPass.TabIndex = 4;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = false;
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
            // 
            // TexasHoldEm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 725);
            this.Controls.Add(this.btnFold);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TexasHoldEm";
            this.Text = "TexasHoldEm";
            this.Load += new System.EventHandler(this.TexasHoldEm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnFold;
    }
}