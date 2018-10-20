using MaterialSkin.Controls;
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
    public partial class AdminMenu : MaterialForm
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btnAddMonster_Click(object sender, EventArgs e)
        {
            AddNewMonster addNewMonster = new AddNewMonster();
            addNewMonster.Show();
        }

        private void btnAddWeapon_Click(object sender, EventArgs e)
        {
            AddNewItem addNewWeapon = new AddNewItem();
            addNewWeapon.Show();
        }
    }
}
