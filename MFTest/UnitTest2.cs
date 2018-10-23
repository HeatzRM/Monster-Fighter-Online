using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonsterFighterDApp.Classes;
using MonsterFighterDApp.Classes.ContractServices;

namespace MFTest
{
    [TestClass]
    public class ContractConnectionTest
    {
        [TestMethod]
        public void PlayerCreateSuccess()
        {
           
                LoginHandler.contractAddress = "0x90faea2c477f9294997a25d5d7b701a20fb1ab9e";
                LoginHandler.privateKey = "0xfb1b73e1de8ca2e4b0c80382cf521dec775b5e317eac39ba154c3984dd8cb778";

                ContractService contractService  = new ContractService(LoginHandler.provider,
                                                                      LoginHandler.contractAddress,
                                                                      LoginHandler.abi,
                                                                      LoginHandler.privateKey);
                contractService.playerCreate("Masamune");
                string name = contractService.getPlayerName(contractService.getAddressOfPlayer());
                Assert.AreEqual(name, "Masamune");
           
        }

        [TestMethod]
        public void TestMethod1()
        {


        }
    }
}
