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
    public class Enemies
    {
        //properties and fields
        public string enemyName { get; }
        public Image enemyPicture { get; }
        public int enemyHealth { get; set; }
        public string enemyStrength { get; }
        public string enemyWeakness { get; }


        //constructors
        public Enemies(string name, Image picture, string strength, string weakness)
        {
            enemyName = name;
            enemyPicture = picture;
            enemyHealth = 0;
            enemyStrength = strength;
            enemyWeakness = weakness;
        }
    }
}
