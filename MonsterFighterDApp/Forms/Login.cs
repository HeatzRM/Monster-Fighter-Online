using MaterialSkin;
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

namespace MonsterFighterDApp.Forms
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();

            var pos = this.PointToScreen(lblLogo.Location);
            pos = pictureBox1.PointToClient(pos);
            lblLogo.Parent = pictureBox1;
            lblLogo.Location = pos;
            lblLogo.BackColor = Color.Transparent;
        }

        private void InitializeSkinManager()
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //Use this to configure color schemes
            skinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Yellow800, Primary.Blue400, Accent.Yellow700, TextShade.WHITE);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            InitializeSkinManager();
        }

        private void pictureBox1_Click(object sender, EventArgs e){}

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                //LoginHandler.contractAddress = txtContractAddress.Text;
                LoginHandler.contractAddress = "0x1142aab02581ee377fb8f92610d7c64165f5acaa";
                LoginHandler.privateKey = txtPrivateKey.Text;
                
                ContractService contractService = new ContractService(LoginHandler.provider,
                                                                      LoginHandler.contractAddress,
                                                                      LoginHandler.abi,
                                                                      LoginHandler.privateKey);
                Console.WriteLine("test" + contractService.addMonster("mon1",100,20,2,"None"));
                //0xFB1B73E1DE8CA2E4B0C80382CF521DEC775B5E317EAC39BA154C3984DD8CB778
                /*
                var state = contractService.checkIfPlayerAlreadyExists();
                if (true)
                {
                    //check if address is owner
                    string playerAddress = contractService.getAddressOfPlayer();
                    if (contractService.getOwnerAddress() == playerAddress)
                    {
                        AdminMenu adminMenu = new AdminMenu();
                        adminMenu.Show();
                    }
                    else
                    {
                        PlayerMenu playerMenu = new PlayerMenu();
                        playerMenu.PlayerAddress = playerAddress;
                        playerMenu.Show();
                    }

                }
                else
                {
                    contractService.playerCreate(txtUsername.Text);
                }
                Hide();
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
