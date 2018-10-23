using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonsterFighterDApp;
using MonsterFighterDApp.Classes;

namespace MFTest
{
    [TestClass]
    public class TurnBasedTest
    {
        [TestMethod]
        public void PlayerBattleTest()
        {
            Dictionary<Element, double> elementWeakness = new Dictionary<Element, double>();
            elementWeakness.Add(Element.Earth, 10);
            elementWeakness.Add(Element.Fire, 20);

            Dictionary<Element, double> elementalAttribute = new Dictionary<Element, double>();
            elementalAttribute.Add(Element.None, 0);
            List<Dictionary<Element, double>> elementalAttributes = new List<Dictionary<Element, double>>();
            elementalAttributes.Add(elementalAttribute);

            Weapon woodsword = new Weapon("WoodSword", WeaponType.Sword, elementalAttributes, 2, 4);
            Weapon ironsword = new Weapon("IronSword", WeaponType.Sword, elementalAttributes, 10, 2);

            Player player1 = new Player();
            player1.Name = "James Bond";
            player1.Health = 100;
            player1.head = new Head(new Armor("LeatherHelmet", 20, elementWeakness, ArmorType.Head));
            player1.torso = new Torso(new Armor("LeatherChestplate", 40, elementWeakness, ArmorType.Torso));
            player1.arms = new Arms(new Armor("LeatherArmbands", 20, elementWeakness, ArmorType.Arms));
            player1.leggings = new Leggings(new Armor("LeatherLeggings", 25, elementWeakness, ArmorType.Leggings));
            player1.footwear = new Footwear(new Armor("LeatherFootwear", 15, elementWeakness, ArmorType.Footwear));
            player1.weaponEquipped = woodsword;
            player1.calculateDamage();

            Player player2 = new Player();
            player2.Name = "John Bond";
            player2.Health = 100;
            player2.head = new Head(new Armor("LeatherHelmet", 20, elementWeakness, ArmorType.Head));
            player2.torso = new Torso(new Armor("LeatherChestplate", 40, elementWeakness, ArmorType.Torso));
            player2.arms = new Arms(new Armor("LeatherArmbands", 20, elementWeakness, ArmorType.Arms));
            player2.leggings = new Leggings(new Armor("LeatherLeggings", 25, elementWeakness, ArmorType.Leggings));
            player2.footwear = new Footwear(new Armor("LeatherFootwear", 15, elementWeakness, ArmorType.Footwear));
            player2.weaponEquipped = ironsword;
            player2.calculateDamage();

            while (!(player1.Health <= 0) && !(player2.Health <= 0))
            {
                player1.Attack(player2);
                player2.Attack(player1);
            }

            Console.Write(player1.Health);
            Console.Write(player2.Health);
        }

        [TestMethod]
        public void PlayerVsMonsterTest()
        {
            Dictionary<Element, double> elementWeakness = new Dictionary<Element, double>();
            elementWeakness.Add(Element.Earth, 10);
            elementWeakness.Add(Element.Fire, 20);

            Dictionary<Element, double> elementalAttribute = new Dictionary<Element, double>();
            elementalAttribute.Add(Element.None, 0);
            List<Dictionary<Element, double>> elementalAttributes = new List<Dictionary<Element, double>>();
            elementalAttributes.Add(elementalAttribute);

            Weapon ironsword = new Weapon("IronSword", WeaponType.Sword, elementalAttributes, 10, 2);

            Player player1 = new Player();
            player1.Name = "James Bond";
            player1.Health = 100;
            player1.head = new Head(new Armor("LeatherHelmet", 20, elementWeakness, ArmorType.Head));
            player1.torso = new Torso(new Armor("LeatherChestplate", 40, elementWeakness, ArmorType.Torso));
            player1.arms = new Arms(new Armor("LeatherArmbands", 20, elementWeakness, ArmorType.Arms));
            player1.leggings = new Leggings(new Armor("LeatherLeggings", 25, elementWeakness, ArmorType.Leggings));
            player1.footwear = new Footwear(new Armor("LeatherFootwear", 15, elementWeakness, ArmorType.Footwear));
            player1.weaponEquipped = ironsword;
            player1.calculateDamage();

            Monster slime = new Monster();
            slime.Name = "Mr. Slimy";
            slime.Health = 50;
            slime.DamagePerAttack = 2;
            slime.AttacksPerTurn = 1;

            while (!(player1.Health <= 0) && !(slime.Health <= 0))
            {
                player1.Attack(slime);
                slime.Attack(player1);
            }

            Console.Write(player1.Health);
            Console.Write(slime.Health);
        }

    }
}
