using MaterialSkin.Controls;
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
            //Insert Data into Contract
            ContractService contractService = new ContractService();

        }
    }
}
