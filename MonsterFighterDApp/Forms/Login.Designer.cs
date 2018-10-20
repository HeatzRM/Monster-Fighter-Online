namespace MonsterFighterDApp.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtContractAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrivateKey = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPlay = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(208, 476);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(130, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Contract Address:";
            // 
            // txtContractAddress
            // 
            this.txtContractAddress.Depth = 0;
            this.txtContractAddress.Hint = "";
            this.txtContractAddress.Location = new System.Drawing.Point(348, 475);
            this.txtContractAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContractAddress.Name = "txtContractAddress";
            this.txtContractAddress.PasswordChar = '\0';
            this.txtContractAddress.SelectedText = "";
            this.txtContractAddress.SelectionLength = 0;
            this.txtContractAddress.SelectionStart = 0;
            this.txtContractAddress.Size = new System.Drawing.Size(386, 23);
            this.txtContractAddress.TabIndex = 2;
            this.txtContractAddress.UseSystemPasswordChar = false;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Depth = 0;
            this.txtPrivateKey.Hint = "";
            this.txtPrivateKey.Location = new System.Drawing.Point(348, 514);
            this.txtPrivateKey.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.PasswordChar = '*';
            this.txtPrivateKey.SelectedText = "";
            this.txtPrivateKey.SelectionLength = 0;
            this.txtPrivateKey.SelectionStart = 0;
            this.txtPrivateKey.Size = new System.Drawing.Size(386, 23);
            this.txtPrivateKey.TabIndex = 5;
            this.txtPrivateKey.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(208, 515);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(87, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Private Key:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 554);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLogo.Font = new System.Drawing.Font("OCR A Std", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(126, 126);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(665, 47);
            this.lblLogo.TabIndex = 7;
            this.lblLogo.Text = "Monster Fighter Online";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(200, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 123);
            this.label1.TabIndex = 8;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Depth = 0;
            this.BtnPlay.Location = new System.Drawing.Point(663, 543);
            this.BtnPlay.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Primary = true;
            this.BtnPlay.Size = new System.Drawing.Size(71, 35);
            this.BtnPlay.TabIndex = 9;
            this.BtnPlay.Text = "Play!";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 616);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtContractAddress);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContractAddress;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrivateKey;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton BtnPlay;
    }
}