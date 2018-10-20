using MaterialSkin.Controls;
using MonsterFighterDApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterFighterDApp.Forms
{
    public partial class PlayerMenu : MaterialForm
    {
        public PlayerMenu()
        {
            InitializeComponent();
        }

        private void BtnPlayerProfile_Click(object sender, EventArgs e)
        {
            PlayerForm playerForm = new PlayerForm();
            playerForm.Show();
        }

        private void BtnHuntMonsters_Click(object sender, EventArgs e)
        {
            HuntingGroundsForm huntingGroundsForm = new HuntingGroundsForm();
            huntingGroundsForm.Show();
        }

        private void BtnMarketPlace_Click(object sender, EventArgs e)
        {
            Market market = new Market();
            market.Show();
        }

        private void BtnArena_Click(object sender, EventArgs e)
        {
            Arena arena = new Arena();
            arena.Show();
        }

        private void PlayerMenu_Load(object sender, EventArgs e)
        {
            LblAddress.Text = LoginHandler.contractAddress;
        }
    }
}
