namespace MonsterFighterDApp.Forms
{
    partial class AdminMenu
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
            this.btnAddMonster = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LblAddress = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddWeapon = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // btnAddMonster
            // 
            this.btnAddMonster.Depth = 0;
            this.btnAddMonster.Location = new System.Drawing.Point(62, 322);
            this.btnAddMonster.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddMonster.Name = "btnAddMonster";
            this.btnAddMonster.Primary = true;
            this.btnAddMonster.Size = new System.Drawing.Size(226, 179);
            this.btnAddMonster.TabIndex = 0;
            this.btnAddMonster.Text = "Add Monster";
            this.btnAddMonster.UseVisualStyleBackColor = true;
            this.btnAddMonster.Click += new System.EventHandler(this.btnAddMonster_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 76);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(130, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Contract Address:";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Depth = 0;
            this.LblAddress.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAddress.Location = new System.Drawing.Point(158, 76);
            this.LblAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(72, 19);
            this.LblAddress.TabIndex = 2;
            this.LblAddress.Text = "{address}";
            // 
            // btnAddWeapon
            // 
            this.btnAddWeapon.Depth = 0;
            this.btnAddWeapon.Location = new System.Drawing.Point(355, 322);
            this.btnAddWeapon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddWeapon.Name = "btnAddWeapon";
            this.btnAddWeapon.Primary = true;
            this.btnAddWeapon.Size = new System.Drawing.Size(226, 179);
            this.btnAddWeapon.TabIndex = 3;
            this.btnAddWeapon.Text = "Add Weapon";
            this.btnAddWeapon.UseVisualStyleBackColor = true;
            this.btnAddWeapon.Click += new System.EventHandler(this.btnAddWeapon_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 611);
            this.Controls.Add(this.btnAddWeapon);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnAddMonster);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnAddMonster;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel LblAddress;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddWeapon;
    }
}