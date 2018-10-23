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
                LoginHandler.contractAddress = "0x90faea2c477f9294997a25d5d7b701a20fb1ab9e";
                LoginHandler.privateKey = txtPrivateKey.Text;
                
                ContractService contractService = new ContractService(LoginHandler.provider,
                                                                      LoginHandler.contractAddress,
                                                                      LoginHandler.abi,
                                                                      LoginHandler.privateKey);
                if (contractService.checkIfPlayerAlreadyExists())
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
