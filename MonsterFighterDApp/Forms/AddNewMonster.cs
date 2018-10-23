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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterFighterDApp
{
    public partial class AddNewMonster : MaterialForm
    {
        public AddNewMonster()
        {
            InitializeComponent();
        }

        private void AddNewMonster_Load(object sender, EventArgs e)
        {

        }

        private void BtnCreateMonster_Click(object sender, EventArgs e)
        {
            try
            {
                ContractService contractService = new ContractService(LoginHandler.provider,
                                                                    LoginHandler.contractAddress,
                                                                    LoginHandler.abi,
                                                                    LoginHandler.privateKey);


                contractService.addMonster(TxtName.Text,
                                           uint.Parse(TxtHealth.Text),
                                           uint.Parse(TxtDamagePerTurn.Text),
                                           uint.Parse(TxtAttackPerTurn.Text),
                                           "None");

                MessageBox.Show("Added New Monster", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
