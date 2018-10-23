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
            this.BtnAddArmor = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // btnAddMonster
            // 
            this.btnAddMonster.Depth = 0;
            this.btnAddMonster.Location = new System.Drawing.Point(83, 396);
            this.btnAddMonster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddMonster.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddMonster.Name = "btnAddMonster";
            this.btnAddMonster.Primary = true;
            this.btnAddMonster.Size = new System.Drawing.Size(301, 220);
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
            this.materialLabel1.Location = new System.Drawing.Point(16, 94);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(161, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Contract Address:";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Depth = 0;
            this.LblAddress.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAddress.Location = new System.Drawing.Point(211, 94);
            this.LblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(90, 24);
            this.LblAddress.TabIndex = 2;
            this.LblAddress.Text = "{address}";
            // 
            // btnAddWeapon
            // 
            this.btnAddWeapon.Depth = 0;
            this.btnAddWeapon.Location = new System.Drawing.Point(473, 396);
            this.btnAddWeapon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddWeapon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddWeapon.Name = "btnAddWeapon";
            this.btnAddWeapon.Primary = true;
            this.btnAddWeapon.Size = new System.Drawing.Size(301, 220);
            this.btnAddWeapon.TabIndex = 3;
            this.btnAddWeapon.Text = "Add Weapon";
            this.btnAddWeapon.UseVisualStyleBackColor = true;
            this.btnAddWeapon.Click += new System.EventHandler(this.btnAddWeapon_Click);
            // 
            // BtnAddArmor
            // 
            this.BtnAddArmor.Depth = 0;
            this.BtnAddArmor.Location = new System.Drawing.Point(836, 396);
            this.BtnAddArmor.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddArmor.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddArmor.Name = "BtnAddArmor";
            this.BtnAddArmor.Primary = true;
            this.BtnAddArmor.Size = new System.Drawing.Size(301, 220);
            this.BtnAddArmor.TabIndex = 4;
            this.BtnAddArmor.Text = "Add Armor";
            this.BtnAddArmor.UseVisualStyleBackColor = true;
            this.BtnAddArmor.Click += new System.EventHandler(this.BtnAddArmor_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 752);
            this.Controls.Add(this.BtnAddArmor);
            this.Controls.Add(this.btnAddWeapon);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnAddMonster);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private MaterialSkin.Controls.MaterialRaisedButton BtnAddArmor;
    }
}