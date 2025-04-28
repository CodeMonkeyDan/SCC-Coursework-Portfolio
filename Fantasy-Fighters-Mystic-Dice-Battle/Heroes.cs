//Daniel Schiefer
//CPT-185-A80H-2024FA
//Final Project: Fantasy Fighters: Mystic Dice Battle


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Schiefer_Final_Project_Fantasy_Fighters_Mystic_Dice_Battle
{
    public class Heroes
    {
        //properties and fields
        public string heroName { get; }
        public Image heroPicture { get; }
        public int heroHealth { get; set; }
        public int heroAccessoryBoost { get; set; }


        //constructors
        public Heroes(string name, Image picture, int health, int boost)
        {
            heroName = name;
            heroPicture = picture;
            heroHealth = health;
            heroAccessoryBoost = boost;
        }
    }
}
