namespace MonsterFighterDApp.Forms
{
    partial class PlayerMenu
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
            MaterialSkin.Controls.MaterialRaisedButton btnPlayerProfile;
            this.BtnHuntMonsters = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnArena = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnMarketPlace = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LblAddress = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btnPlayerProfile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // btnPlayerProfile
            // 
            btnPlayerProfile.Depth = 0;
            btnPlayerProfile.Location = new System.Drawing.Point(646, 86);
            btnPlayerProfile.MouseState = MaterialSkin.MouseState.HOVER;
            btnPlayerProfile.Name = "btnPlayerProfile";
            btnPlayerProfile.Primary = true;
            btnPlayerProfile.Size = new System.Drawing.Size(179, 76);
            btnPlayerProfile.TabIndex = 5;
            btnPlayerProfile.Text = "Player Profile";
            btnPlayerProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnPlayerProfile.UseVisualStyleBackColor = true;
            btnPlayerProfile.Click += new System.EventHandler(this.BtnPlayerProfile_Click);
            // 
            // BtnHuntMonsters
            // 
            this.BtnHuntMonsters.Depth = 0;
            this.BtnHuntMonsters.Location = new System.Drawing.Point(39, 283);
            this.BtnHuntMonsters.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnHuntMonsters.Name = "BtnHuntMonsters";
            this.BtnHuntMonsters.Primary = true;
            this.BtnHuntMonsters.Size = new System.Drawing.Size(230, 162);
            this.BtnHuntMonsters.TabIndex = 0;
            this.BtnHuntMonsters.Text = "Hunt Monsters";
            this.BtnHuntMonsters.UseVisualStyleBackColor = true;
            this.BtnHuntMonsters.Click += new System.EventHandler(this.BtnHuntMonsters_Click);
            // 
            // BtnArena
            // 
            this.BtnArena.Depth = 0;
            this.BtnArena.Location = new System.Drawing.Point(595, 283);
            this.BtnArena.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnArena.Name = "BtnArena";
            this.BtnArena.Primary = true;
            this.BtnArena.Size = new System.Drawing.Size(230, 162);
            this.BtnArena.TabIndex = 1;
            this.BtnArena.Text = "Arena";
            this.BtnArena.UseVisualStyleBackColor = true;
            this.BtnArena.Click += new System.EventHandler(this.BtnArena_Click);
            // 
            // BtnMarketPlace
            // 
            this.BtnMarketPlace.Depth = 0;
            this.BtnMarketPlace.Location = new System.Drawing.Point(319, 283);
            this.BtnMarketPlace.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnMarketPlace.Name = "BtnMarketPlace";
            this.BtnMarketPlace.Primary = true;
            this.BtnMarketPlace.Size = new System.Drawing.Size(230, 162);
            this.BtnMarketPlace.TabIndex = 2;
            this.BtnMarketPlace.Text = "Marketplace";
            this.BtnMarketPlace.UseVisualStyleBackColor = true;
            this.BtnMarketPlace.Click += new System.EventHandler(this.BtnMarketPlace_Click);
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Depth = 0;
            this.LblAddress.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAddress.Location = new System.Drawing.Point(166, 86);
            this.LblAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(72, 19);
            this.LblAddress.TabIndex = 4;
            this.LblAddress.Text = "{address}";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(20, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(113, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Player Address:";
            // 
            // PlayerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 511);
            this.Controls.Add(btnPlayerProfile);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.BtnMarketPlace);
            this.Controls.Add(this.BtnArena);
            this.Controls.Add(this.BtnHuntMonsters);
            this.Name = "PlayerMenu";
            this.Text = "PlayerMenu";
            this.Load += new System.EventHandler(this.PlayerMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtnHuntMonsters;
        private MaterialSkin.Controls.MaterialRaisedButton BtnArena;
        private MaterialSkin.Controls.MaterialRaisedButton BtnMarketPlace;
        private MaterialSkin.Controls.MaterialLabel LblAddress;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}