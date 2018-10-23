using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFighterDApp.Classes
{
    public static class LoginHandler
    {
        public static string provider = "https://ropsten.infura.io/v3/8e26462ec63442fcb7ed5e708f90b643";
        //public static string abi = "[{\"constant\": false,\"inputs\": [ { \"name\": \"newFact\", \"type\": \"string\" } ], \"name\": \"add\", \"outputs\": [], \"payable\": false, \"stateMutability\": \"nonpayable\", \"type\": \"function\"},{ \"inputs\": [], \"payable\": false, \"stateMutability\": \"nonpayable\", \"type\": \"constructor\" }, { \"constant\": true, \"inputs\": [ { \"name\": \"index\", \"type\": \"uint256\" } ], \"name\": \"getFact\", \"outputs\": [ { \"name\": \"\", \"type\": \"string\" } ], \"payable\": false, \"stateMutability\": \"view\", \"type\": \"function\" } ]";

        //used file io instead because its too long to literal the string here
        //path in debug folder
        public static string abi = System.IO.File.ReadAllText(@"contract_abi.txt");

        public static  string contractAddress { set; get; }
        public static string privateKey { set; get; }
    }
}
