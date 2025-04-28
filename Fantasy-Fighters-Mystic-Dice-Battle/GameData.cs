//Daniel Schiefer
//CPT-185-A80H-2024FA
//Final Project: Fantasy Fighters: Mystic Dice Battle


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Schiefer_Final_Project_Fantasy_Fighters_Mystic_Dice_Battle
{
    public static class GameData
    {
        public static string userName {  get; set; }
        public static int userScore { get; set; }
        public static int stage { get; set; }
        public static int enemiesDefeated { get; set; }

        //prevents heroList from being recreated between stages
        public static List<Heroes> heroList = new List<Heroes>();

        //random number generator for multiple uses in game
        public static Random randomNumber = new Random();

        //generate keys to unlock sercret chests (attack bonuses)
        public static bool areaOneKey = false;
        public static bool areaTwoKey = false;
        public static bool areaThreeKey = false;
        public static bool areaFourKey1 = false;
        public static bool areaFourKey2 = false;

        //dragon amulet reduces dragons overall health
        public static bool dragonAmuletFound = false;
    }
}
