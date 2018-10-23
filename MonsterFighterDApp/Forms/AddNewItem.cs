using MaterialSkin.Controls;
using MonsterFighterDApp.Classes;
using MonsterFighterDApp.Classes.ContractServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterFighterDApp
{
    public partial class AddNewWeaponItem : MaterialForm
    {
        public AddNewWeaponItem()
        {
            InitializeComponent();
        }

        private void AddNewItem_Load(object sender, EventArgs e)
        {

        }

        private void BtnCreateWeapon_Click(object sender, EventArgs e)
        {
            try
            {
                ContractService contractService = new ContractService(LoginHandler.provider,
                                                                    LoginHandler.contractAddress,
                                                                    LoginHandler.abi,
                                                                    LoginHandler.privateKey);

                contractService.addWeapon(txtName.Text, uint.Parse(txtDamage.Text), txtWeaponType.Text, uint.Parse(txtNumberOfAttacks.Text), txtImageUrl.Text);
                MessageBox.Show("Added New Monster", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
