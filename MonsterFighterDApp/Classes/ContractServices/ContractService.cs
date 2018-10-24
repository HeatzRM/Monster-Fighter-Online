using Nethereum.Contracts;
using Nethereum.Hex.HexTypes;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFighterDApp.Classes.ContractServices
{
    public class ContractService
    {
        private readonly Web3 web3;
        private readonly Contract contract;
        private readonly Account account;

        private static readonly HexBigInteger Gas = new HexBigInteger(4600000);

        public ContractService(string provider, string contractAddress, string abi, string privateKey)
        {
            account = new Account(privateKey);
            web3 = new Web3(account, provider);
            contract = web3.Eth.GetContract(abi, contractAddress);
        }

        public string getOwnerAddress()
        {
            var getOwnerAddressFunction = contract.GetFunction("getOwnerAddress");
            var task = getOwnerAddressFunction.CallAsync<string>();
            var monster = task.Result;
            return monster;
        }

        #region Monster Functions

        public string addMonster(string name, uint health, uint damagePerAttack, uint attacksPerTurn, string imageUrl)
        {
            var addMonsterFunction = contract.GetFunction("addMonster");
            var txHash = addMonsterFunction.SendTransactionAsync(account.Address, Gas, new HexBigInteger(0), name, health, damagePerAttack, attacksPerTurn, imageUrl)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            return txHash;
        }

        public int getMonsterCount()
        {
            var getTotalMonsterCountFunction = contract.GetFunction("getMonsterCount");
            var monsterCount = getTotalMonsterCountFunction.CallAsync<int>();
            return monsterCount.Result;
        }

        public string getMonsterByIndex(string name, uint health, uint damagePerAttack, uint attacksPerTurn)
        {
            var getTotalMonsterFunction = contract.GetFunction("getMonsterByIndex");
            var task = getTotalMonsterFunction.CallAsync<string>(name, health, damagePerAttack, attacksPerTurn);
            var monster = task.Result;
            return monster;
        }

        #endregion

        public string buyShia(uint amount)
        {
            var buyShiaFunction = contract.GetFunction("buyShia");
            var txHash = buyShiaFunction.SendTransactionAsync(account.Address, Gas, new HexBigInteger(0), amount)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            return txHash;
        }

        public string payoutToken(uint amount)
        {
            var payoutTokenFunction = contract.GetFunction("payoutToken");
            var txHash = payoutTokenFunction.SendTransactionAsync(account.Address, Gas, new HexBigInteger(0), amount)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            return txHash;
        }

        #region Player Functions

        public string playerCreate(string name)
        {
            var addPlayerFunction = contract.GetFunction("playerCreate");
            var txHash = addPlayerFunction.SendTransactionAsync(account.Address, Gas, new HexBigInteger(0), name)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            return txHash;
        }

        public string getPlayerName(string address)
        {
            var getNameFunction = contract.GetFunction("getPlayerName");
            var task = getNameFunction.CallAsync<string>(address);
            var name = task.Result;
            return name;
        }

        public string getAddressOfPlayer()
        {
            var getAddressFunction = contract.GetFunction("getAddressOfPlayer");
            var task = getAddressFunction.CallAsync<string>();
            var name = task.Result;
            return name;
        }

        public string checkIfPlayerAlreadyExists()
        {
            /*
            var getFunction = contract.GetFunction("checkIfPlayerAlreadyExists");
            var task = getFunction.CallAsync<bool>();
            var status = task.Result;
            return status; */

            var getFactFunction = contract.GetFunction("checkIfPlayerAlreadyExists");
            var task = getFactFunction.CallAsync<string>();
            var fact = task.Result;
            return fact;
        }
        #endregion

        public string sellShia(uint amount)
        {
            var addFactFunction = contract.GetFunction("sellShia");
            var txHash = addFactFunction.SendTransactionAsync(account.Address, Gas, new HexBigInteger(0), amount)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            return txHash;
        }

        #region Set Armor Data Functions

        public string setHeadArmor(string address, string name, string armorType, uint defense, string image)
        {
            var addHeadArmorFunction = contract.GetFunction("setHeadArmor");
            var txHash = addHeadArmorFunction.SendTransactionAsync(account.Address, Gas, new HexBigInteger(0), address, name, armorType, defense, image)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            return txHash;
        }

        public string setArmsArmor(string address, string name, string armorType, uint defense, string image)
        {
            var addArmsArmorFunction = contract.GetFunction("setArmsArmor");
            var txHash = addArmsArmorFunction.SendTransactionAsync(account.Address, Gas, new HexBigInteger(0), address, name, armorType, defense, image)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            return txHash;
        }

        public string setTorsoArmor(string address, string name, string armorType, uint defense, string image)
        {
            var addTorsoArmorFunction = contract.GetFunction("setTorsoArmor");
            var txHash = addTorsoArmorFunction.SendTransactionAsync(account.Address, Gas, new HexBigInteger(0), address, name, armorType, defense, image)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            return txHash;
        }

        public string setLeggingsArmor(string address, string name, string armorType, uint defense, string image)
        {
            var addLeggingsArmorFunction = contract.GetFunction("setLeggingsArmor");
            var txHash = addLeggingsArmorFunction.SendTransactionAsync(account.Address, Gas, new HexBigInteger(0), address, name, armorType, defense, image)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            return txHash;
        }

        public string setFootwearArmor(string address, string name, string armorType, uint defense, string image)
        {
            var addFootwearArmorFunction = contract.GetFunction("setFootwearArmor");
            var txHash = addFootwearArmorFunction.SendTransactionAsync(account.Address, Gas, new HexBigInteger(0), address, name, armorType, defense, image)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            return txHash;
        }
        #endregion

        #region Get Armor Data Functions
        public string getHeadArmorData(string address)
        {
            var getArmorFunction = contract.GetFunction("getHeadArmorData");
            var task = getArmorFunction.CallAsync<string>(address);
            var armorData = task.Result;
            return armorData;
        }

        public string getArmsArmorData(string address)
        {
            var getArmorFunction = contract.GetFunction("getArmsArmorData");
            var task = getArmorFunction.CallAsync<string>(address);
            var armorData = task.Result;
            return armorData;
        }

        public string getTorsoArmorData(string address)
        {
            var getArmorFunction = contract.GetFunction("getTorsoArmorData");
            var task = getArmorFunction.CallAsync<string>(address);
            var armorData = task.Result;
            return armorData;
        }

        public string getLeggingsArmorData(string address)
        {
            var getArmorFunction = contract.GetFunction("getLeggingsArmorData");
            var task = getArmorFunction.CallAsync<string>(address);
            var armorData = task.Result;
            return armorData;
        }

        public string getFootwearArmorData(string address)
        {
            var getArmorFunction = contract.GetFunction("getFootwearArmorData");
            var task = getArmorFunction.CallAsync<string>(address);
            var armorData = task.Result;
            return armorData;
        }
        #endregion


        #region Add Weapon Function
        public string addWeapon(string name, uint damage, string weaponType, uint numberOfAttacksOfTheWeapon, string imageUrl)
        {
            var addMonsterFunction = contract.GetFunction("addMonster");
            var txHash = addMonsterFunction.SendTransactionAsync(account.Address, Gas, new HexBigInteger(0), name, damage, weaponType, numberOfAttacksOfTheWeapon, imageUrl)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            return txHash;
        }
        #endregion



    }
}
