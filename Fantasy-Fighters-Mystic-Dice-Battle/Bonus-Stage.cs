//Daniel Schiefer
//CPT-185-A80H-2024FA
//Final Project: Fantasy Fighters: Mystic Dice Battle


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Schiefer_Final_Project_Fantasy_Fighters_Mystic_Dice_Battle
{
    public partial class bonusStageFrm : Form
    {
        //declare variable to hold the reference of startFrm
        private mainMenuFrm _mainMenuFrm;

        //constructor that takes mainMenuFrm as a parameter
        public bonusStageFrm(mainMenuFrm existingMainMenuFrm)
        {
            InitializeComponent();
            //store the reference startFrm
            _mainMenuFrm = existingMainMenuFrm;
        }


        //load chest depending on the stage
        private void bonusStageFrm_Load(object sender, EventArgs e)
        {
            bonusStageTitleLbl.Text = "Area " + (GameData.stage / 2) + " Bonus Stage";

            switch (GameData.stage)
            {
                case 3:
                    if (GameData.areaOneKey)
                    {
                        treasureBoxPicBx.BackgroundImage = Properties.Resources.OpenChest_ElfAmulet;
                        findingsLbl.Text = "You use the key you found to get an ancient Amulet! Elf's Attack is" +
                            " boosted by 2!";
                        
                        foreach (var hero in GameData.heroList)
                        {
                            if (hero.heroName == "Elf")
                            {
                                hero.heroAccessoryBoost += 2;
                            }
                        }
                    }
                    else
                    {
                        treasureBoxPicBx.BackgroundImage = Properties.Resources.LockedChest1;
                        findingsLbl.Text = "A chest!....but it is locked?";
                    }
                    break;
                case 5:
                    if (GameData.areaTwoKey)
                    {
                        treasureBoxPicBx.BackgroundImage = Properties.Resources.OpenChest_DwarfAmulet;
                        findingsLbl.Text = "You use the key you found to get an ancient Amulet! Dwarf's Attack is" +
                            " boosted by 2!";

                        foreach (var hero in GameData.heroList)
                        {
                            if (hero.heroName == "Dwarf")
                            {
                                hero.heroAccessoryBoost += 2;
                            }
                        }
                    }
                    else
                    {
                        treasureBoxPicBx.BackgroundImage = Properties.Resources.LockedChest2;
                        findingsLbl.Text = "A chest!....but it is locked?";
                    }
                    break;
                case 7:
                    if (GameData.areaThreeKey)
                    {
                        treasureBoxPicBx.BackgroundImage = Properties.Resources.OpenChest_WizardAmulet;
                        findingsLbl.Text = "You use the key you found to get an ancient Amulet! Wizard's Attack is" +
                            " boosted by 2!";

                        foreach (var hero in GameData.heroList)
                        {
                            if (hero.heroName == "Wizard")
                            {
                                hero.heroAccessoryBoost += 2;
                            }
                        }
                    }
                    else
                    {
                        treasureBoxPicBx.BackgroundImage = Properties.Resources.LockedChest3;
                        findingsLbl.Text = "A chest!....but it is locked?";
                    }
                    break;
                case 9:
                    if (GameData.areaFourKey1 && GameData.areaFourKey2)
                    {
                        treasureBoxPicBx.BackgroundImage = Properties.Resources.OpenChest_DragonPearl;
                        findingsLbl.Text = "You use the keys you found to get an ancient Amulet! Dragons healt is " +
                            "lowered by 20%!";

                        GameData.dragonAmuletFound = true;
                    }
                    else
                    {
                        treasureBoxPicBx.BackgroundImage = Properties.Resources.LockedChest4;
                        findingsLbl.Text = "A chest!....but it is locked?";
                    }
                    break;
            }
        }


        //continue to the story form
        private void continueBtn_Click(object sender, EventArgs e)
        {
            storyFrm newStoryFrm = new storyFrm(_mainMenuFrm);
            this.Close();
            newStoryFrm.Show();
        }
    }
}
