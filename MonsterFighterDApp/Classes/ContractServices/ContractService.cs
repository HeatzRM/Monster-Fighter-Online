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
    class ContractService
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

        public string AddFact(string fact)
        {
            var addFactFunction = contract.GetFunction("add");
            var txHash = addFactFunction.SendTransactionAsync(account.Address, Gas, new HexBigInteger(0), fact)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            return txHash;
        }
    }
}
