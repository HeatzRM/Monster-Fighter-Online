using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFighterDApp.Classes
{
    public static class LoginHandler
    {
        public static string provider = "https://ropsten.infura.io/v3/026d2246b9c24d41b14adcea27138e09";
        public static string abi = "[{\"constant\": false,\"inputs\": [ { \"name\": \"newFact\", \"type\": \"string\" } ], \"name\": \"add\", \"outputs\": [], \"payable\": false, \"stateMutability\": \"nonpayable\", \"type\": \"function\"},{ \"inputs\": [], \"payable\": false, \"stateMutability\": \"nonpayable\", \"type\": \"constructor\" }, { \"constant\": true, \"inputs\": [ { \"name\": \"index\", \"type\": \"uint256\" } ], \"name\": \"getFact\", \"outputs\": [ { \"name\": \"\", \"type\": \"string\" } ], \"payable\": false, \"stateMutability\": \"view\", \"type\": \"function\" } ]";
        public static  string contractAddress { set; get; }
        public static string privateKey { set; get; }
    }
}
