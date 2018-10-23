pragma solidity ^0.4.24;

contract MonsterFighterGame
{
    
    /*
    A monster hunting game contract where you get rewarded for hunting down monsters,
    but if you fail to hunt down the monster you won't get rewarded.
    Get stronger by buying equipment to have a better chance of hunting down monsters.
    
    Arena mode by accepting challenges from players.
    Beat them and you get rewarded.
    
    
    In game token == Shia
    */
    
    address private contractOwner = msg.sender;
    
    uint priceOfTokens = 0.001 ether;
    mapping (address => Player) public players;
    
    mapping (uint256 => Monster) monsters;
    Monster[] monsterArr;
    
    
    struct Weapon
    {
        string Name;
        uint256 Damage;
        string WeaponType;
        uint256 NumberOfAttacksOfTheWeapon;
        
        string image; //For image url display
    }

    struct Armor
    {
        string Name;
        string ArmorType;
        uint256 Defense;
        
        string image; //For image url display
    }
    
    struct Monster
    {
        string Name;
        uint256 Health;
        uint256 DamagePerAttack;
        uint256 DamagePerTurn;
        
        string image; //For image url display
    }
    
    struct Player
    {
        string Name;
        uint256 Health;
        Armor Head;
        Armor Arms;
        Armor Torso;
        Armor Leggings;
        Armor Footwear;
        Weapon WeaponEquipped;
        uint256 Shia;
        
        string image; //For image url display
        bool exists;
    }
    
    ///Monster Functions
    function addMonster (string Name, uint256 Health, uint256 DamagePerAttack, uint256 DamagePerTurn, string image) public
    {
        monsterArr.push(Monster({Name:Name, Health:Health, DamagePerAttack:DamagePerAttack, DamagePerTurn:DamagePerTurn, image:image}));
    } 
    
    function getMonsterCount() public view returns(uint256)
    {
        return monsterArr.length;
    }
    
    function getMonsterByIndex(uint256 index) public view returns(string, uint256, uint256, uint256, string)
    {
        return(monsterArr[index].Name, 
               monsterArr[index].Health,
               monsterArr[index].DamagePerAttack, 
               monsterArr[index].DamagePerTurn, 
               monsterArr[index].image);
    }
    
    
    ///Player Functions
    function checkIfPlayerAlreadyExists(address __userAddress) public view returns(bool)
    {
        return(players[__userAddress].exists);
    }
    
    //This is where the player enters if doesnt already exists
    function playerCreate(string Name) public
    {
        players[msg.sender].Name = Name;
        players[msg.sender].Health = 100;
        players[msg.sender].Head = Armor("None","None",0, "url");
        players[msg.sender].Arms = Armor("None","None",0, "url");
        players[msg.sender].Torso = Armor("None","None",0, "url");
        players[msg.sender].Leggings = Armor("None","None",0, "url");
        players[msg.sender].Footwear = Armor("None","None",0, "url");
        players[msg.sender].WeaponEquipped = Weapon("None",0,"None",1,"url");
        players[msg.sender].Shia = 10;    
        players[msg.sender].exists = true;
    }
    
    function getPlayerName(address _userAddress) public view returns(string)
    {
        return(players[_userAddress].Name);
    }
    
    function getPlayerMaxHealth(address __userAddress) public view returns(uint256)
    {
        return(players[__userAddress].Health);   
    }
    
    function getPlayerShia(address __userAddress) public view returns(uint256)
    {
        return(players[__userAddress].Shia);
    }
    
    //Get player armor
    function getHeadArmorData(address __userAddress) public view returns(string, string, uint256, string)
    {
        return(players[__userAddress].Head.Name,
               players[__userAddress].Head.ArmorType,
               players[__userAddress].Head.Defense,
               players[__userAddress].Head.image);
    }
    
    function getArmsArmorData(address __userAddress) public view returns(string, string, uint256, string)
    {
        return(players[__userAddress].Arms.Name,
               players[__userAddress].Arms.ArmorType,
               players[__userAddress].Arms.Defense,
               players[__userAddress].Arms.image);
    }
    
    function getTorsoArmorData(address __userAddress) public view returns(string, string, uint256, string)
    {
        return(players[__userAddress].Torso.Name,
               players[__userAddress].Torso.ArmorType,
               players[__userAddress].Torso.Defense,
               players[__userAddress].Torso.image);
    }
    
    function getLeggingsArmorData(address __userAddress) public view returns(string, string, uint256, string)
    {
        return(players[__userAddress].Leggings.Name,
               players[__userAddress].Leggings.ArmorType,
               players[__userAddress].Leggings.Defense,
               players[__userAddress].Leggings.image);
    }
    
    function getFootwearArmorData(address __userAddress) public view returns(string, string, uint256, string)
    {
        return(players[__userAddress].Footwear.Name,
               players[__userAddress].Footwear.ArmorType,
               players[__userAddress].Footwear.Defense,
               players[__userAddress].Footwear.image);
    }
    
    
    //Set Player Armor
    function setHeadArmor(address __userAddress, string Name, string ArmorType, uint256 Defense, string image) public
    {
         players[__userAddress].Head.Name = Name;
         players[__userAddress].Head.ArmorType = ArmorType;
         players[__userAddress].Head.Defense = Defense;
         players[__userAddress].Head.image = image;
    }
    
    function setArmsArmor(address __userAddress, string Name, string ArmorType, uint256 Defense, string image) public
    {
         players[__userAddress].Arms.Name = Name;
         players[__userAddress].Arms.ArmorType = ArmorType;
         players[__userAddress].Arms.Defense = Defense;
         players[__userAddress].Arms.image = image;
    }
    
    function setTorsoArmor(address __userAddress, string Name, string ArmorType, uint256 Defense, string image) public
    {
         players[__userAddress].Torso.Name = Name;
         players[__userAddress].Torso.ArmorType = ArmorType;
         players[__userAddress].Torso.Defense = Defense;
         players[__userAddress].Torso.image = image;
    }
    
    function setLeggingsArmor(address __userAddress, string Name, string ArmorType, uint256 Defense, string image) public
    {
         players[__userAddress].Leggings.Name = Name;
         players[__userAddress].Leggings.ArmorType = ArmorType;
         players[__userAddress].Leggings.Defense = Defense;
         players[__userAddress].Leggings.image = image;
    }
    
     function setFootwearArmor(address __userAddress, string Name, string ArmorType, uint256 Defense, string image) public
    {
         players[__userAddress].Footwear.Name = Name;
         players[__userAddress].Footwear.ArmorType = ArmorType;
         players[__userAddress].Footwear.Defense = Defense;
         players[__userAddress].Footwear.image = image;
    }
    
    
    
    
    //Initial token of the contractOwner address
    constructor (uint256 initialOwnerTokens) public 
    {
        players[msg.sender].Shia = initialOwnerTokens;
    }
 
    modifier onlyOwner {
        require(msg.sender == contractOwner, "You do not own this contract");
        _;
    }
    
    function getShiaPrice() view public returns(uint _price) {
        _price = priceOfTokens;
    }
    
    function setShiaPrice(uint _newPrice) public onlyOwner {
        priceOfTokens = _newPrice;
    }
    
    function buyShia(uint _numTokens) public payable 
    {
        require(msg.value >= _numTokens * priceOfTokens);
        contractOwner.transfer(msg.value);
        players[msg.sender].Shia += _numTokens;
    }
    
    function sellShia(uint __numTokens) public payable 
    {
        require(__numTokens > 0, "Input some amount to sell");
        require(players[msg.sender].Shia > 0, "You have no Shia left to sell");
        uint256 moneyToTransfer = __numTokens * priceOfTokens;
        msg.sender.transfer(moneyToTransfer);

    }
    
    modifier inlimits() {
        require(msg.value >= priceOfTokens);
        //require(msg.value % priceOfTokens == 0);
        _;
    }
    
    //For Transfering of Shia to Another Player
    function transfer(address to, uint256 value) public 
    {
        if ((players[msg.sender].Shia >= value) && (players[to].Shia + value >= players[to].Shia)) 
        {
            players[msg.sender].Shia -= value; // Subtract the value from the sender
            players[to].Shia += value; // Add the same value to the recipient
        }
    }

    function getOwnerAddress() public view returns(address owner)
    {
        owner = contractOwner;
    }
    
    function getContractBalance() onlyOwner public view returns(uint balance)
    {
        balance = address(this).balance;
    }
    
     function payoutToken(uint amount) public payable {
        msg.sender.transfer(amount * priceOfTokens);
        players[msg.sender].Shia -= amount;
    }
    
  
}
