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
using System.IO;
using System.Web;

namespace D_Schiefer_Final_Project_Fantasy_Fighters_Mystic_Dice_Battle
{
    public partial class battleFrm : Form
    {
        //declare variable to hold the reference of mainMenuFrm
        private mainMenuFrm _mainMenuFrm;

        //create hero and enemy lists, declare variables and initialize randoms
        public List<Enemies> enemyList = new List<Enemies>();
        private static Heroes elf;
        private static Heroes dwarf;
        private static Heroes wizard;
        public Enemies[] stageEnemies = null;
        private int[] die = new int[4];
        private int heroTotalRoll = 0;
        private int enemyTotalRoll = 0;
        private Heroes activeHero;
        private Enemies activeEnemy;

        //constructor that takes mainMenuFrm as a parameter
        public battleFrm(mainMenuFrm existingMainMenuFrm)
        {
            InitializeComponent();
            //store the reference mainMenuFrm
            _mainMenuFrm = existingMainMenuFrm;

            addHereosToGame();

            stageBuilder();
        }

        //keep track of the number of turns that are taken (for use in dragon score)
        private int turns = 0;

        //complete a round of play, one user turn and one computer turn
        private void rollBtn_Click(object sender, EventArgs e)
        {
            if (findActiveFighters())
            {
                //players turn
                turns++;
                rollDice();
                adjustAttackForHealth();
                addAttackBonuses();
                minAttack1();
                deductDamage();
                checkForDead();

                //prevents method from continuing if all heroes or enemies are dead
                if (!this.Visible)
                {
                    return;
                }

                //computers turn
                turns++;
                computerPicksFighters();
                rollDice();
                adjustAttackForHealth();
                addAttackBonuses();
                minAttack1();
                deductDamage();
                checkForDead();
            }
            else
            {
                MessageBox.Show("Please select a hero and an enemy before rolling.",
                    "No Fighters Assigned");
            }
        }


        //random roll of the dice
        private void rollDice()
        {
            //create a list of dice picture boxes
            List<PictureBox> dicePictureBoxes = new List<PictureBox> { heroDie1PicBx, heroDie2PicBx,
                enemyDie1PicBx, enemyDie2PicBx };

            //roll dice and set the image for each picture box
            for (int i = 0; i < 4; i++)
            {
                int roll = GameData.randomNumber.Next(1, 7);
                die[i] = roll;
                dicePictureBoxes[i].BackgroundImage = getDiceImage(roll);
            }
            heroTotalRoll = die[0] + die[1];
            enemyTotalRoll = die[2] + die[3];
        }


        //helper method to retrieve die pictures
        private Image getDiceImage(int roll)
        {
            switch (roll)
            {
                case 1: return Properties.Resources.Die1;
                case 2: return Properties.Resources.Die2;
                case 3: return Properties.Resources.Die3;
                case 4: return Properties.Resources.Die4;
                case 5: return Properties.Resources.Die5;
                case 6: return Properties.Resources.Die6;
                default: return null;
            }
        }


        //verify that fighters were selected and return the active fighter for each round
        private bool findActiveFighters()
        {
            //checks if hero was selected
            if (hero1RBtn.Checked)
            {
                activeHero = elf;
            }
            else if (hero2RBtn.Checked)
            {
                activeHero = dwarf;
            }
            else if (hero3RBtn.Checked)
            {
                activeHero = wizard;
            }
            else
            {
                return false;
            }

            //checks if enemy was selected
            //stages 1-8 have 3 enemies each
            if (GameData.stage <= 8)
            {
                if (enemy1RBtn.Checked)
                {
                    activeEnemy = stageEnemies[0];
                }
                else if (enemy2RBtn.Checked)
                {
                    activeEnemy = stageEnemies[1];
                }
                else if (enemy3RBtn.Checked)
                {
                    activeEnemy = stageEnemies[2];
                }
                else
                {
                    return false;
                }
            }
            //final stage only has 1 enemy
            else
            {
                if (enemy2RBtn.Checked)
                {
                    activeEnemy = stageEnemies[0];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }


        //method to adjust attack so its base cannot exceed the units health
        private void adjustAttackForHealth()
        {
            if (activeHero.heroHealth < heroTotalRoll)
            {
                heroTotalRoll = activeHero.heroHealth;
            }
            if (activeEnemy.enemyHealth < enemyTotalRoll)
            {
                enemyTotalRoll = activeEnemy.enemyHealth;
            }
        }

        //method to add attack bonuses
        private void addAttackBonuses()
        {
            if (GameData.stage <= 8)
            {
                if (activeEnemy.enemyStrength == activeHero.heroName)
                {
                    heroTotalRoll--;
                    enemyTotalRoll++;
                }
                else if (activeEnemy.enemyWeakness == activeHero.heroName)
                {
                    heroTotalRoll++;
                    enemyTotalRoll--;
                }
            }
            else
            {
                heroTotalRoll = heroTotalRoll - 2;
                enemyTotalRoll = enemyTotalRoll + 2;
            }
            heroTotalRoll += activeHero.heroAccessoryBoost;
        }


        //method so each attack at least generates 1 hit
        private void minAttack1()
        {
            if (heroTotalRoll < 1)
            {
                heroTotalRoll = 1;
            }
            if (enemyTotalRoll < 1)
            {
                enemyTotalRoll = 1;
            }
        }


        //subtract damage from fighters every round, prevent from dropping below 0
        private void deductDamage()
        {
            activeHero.heroHealth -= enemyTotalRoll;
            if (activeHero.heroHealth < 0)
            {
                activeHero.heroHealth = 0;
            }
            activeEnemy.enemyHealth -= heroTotalRoll;
            if (activeEnemy.enemyHealth < 0)
            {
                activeEnemy.enemyHealth = 0;
            }

            //tell player how much damage has been given and recieved
            MessageBox.Show("The " + activeHero.heroName + " has taken " + enemyTotalRoll + " damage," +
                "\nthe " + activeEnemy.enemyName + " has taken " + heroTotalRoll + " damage.",
                "Damage Inflicted");
            //reload health information to form
            healthLoader();
        }


        //check to see if a fighter died, display message and disable radio button
        private void checkForDead()
        {
            //checks if the active hero health has dropped to 0
            if (activeHero.heroHealth == 0)
            {
                MessageBox.Show("The " + activeHero.heroName + " has fallen in battle.", "Hero Killed");

                //diable radio button of fallen hero
                if (elf.heroHealth == 0)
                {
                    hero1RBtn.Checked = false;
                    hero1RBtn.Enabled = false;
                }
                if (dwarf.heroHealth == 0)
                {
                    hero2RBtn.Checked = false;
                    hero2RBtn.Enabled = false;
                }
                if (wizard.heroHealth == 0)
                {
                    hero3RBtn.Checked = false;
                    hero3RBtn.Enabled = false;
                }

                //verifies if any heroes are left standing, ends game if all fallen
                if (elf.heroHealth == 0 && dwarf.heroHealth == 0 && wizard.heroHealth == 0)
                {
                    MessageBox.Show("All heroes have fallen in battle, better luck next time.", "Game Over");
                    GameData.stage = 11;
                    GameData.userScore += GameData.enemiesDefeated * 100;
                    UpdateHighScores();
                    storyFrm newStoryFrm = new storyFrm(_mainMenuFrm);
                    this.Close();
                    newStoryFrm.Show();
                    return;
                }
            }

            //checks if active enemy health has dropped to 0
            if (activeEnemy.enemyHealth == 0)
            {
                MessageBox.Show("The " + activeEnemy.enemyName + " has been slain.", "Enemy Killed");
                GameData.enemiesDefeated++;

                //stages 1-8 have 3 enemies each
                if (GameData.stage <= 8)
                {
                    //disable radio button of slain enemy
                    if (stageEnemies[0].enemyHealth == 0)
                    {
                        enemy1RBtn.Checked = false;
                        enemy1RBtn.Enabled = false;
                    }
                    if (stageEnemies[1].enemyHealth == 0)
                    {
                        enemy2RBtn.Checked = false;
                        enemy2RBtn.Enabled = false;
                    }
                    if (stageEnemies[2].enemyHealth == 0)
                    {
                        enemy3RBtn.Checked = false;
                        enemy3RBtn.Enabled = false;
                    }

                    //verifies if any enemies are left standing, moves to next stage if all fallen
                    if (stageEnemies[0].enemyHealth == 0 && stageEnemies[1].enemyHealth == 0 &&
                        stageEnemies[2].enemyHealth == 0)
                    {
                        MessageBox.Show("All enemies defeated.", "Stage Complete");
                        GameData.stage++;
                        if (GameData.stage % 2 == 0)
                        {
                            storyFrm newStoryFrm = new storyFrm(_mainMenuFrm);
                            this.Close();
                            newStoryFrm.Show();
                            return;
                        }
                        else
                        {
                            bonusStageFrm newBonusStageFrm = new bonusStageFrm(_mainMenuFrm);
                            this.Close();
                            newBonusStageFrm.Show();
                            return;
                        }
                    }
                }
                //final stage only has 1 enemy
                else
                {
                    GameData.stage++;
                    int dragonScore = 0;
                    if (turns < 10)
                    {
                        dragonScore = 1000;
                    }
                    else if (turns < 14)
                    {
                        dragonScore = 800;
                    }
                    else
                    {
                        dragonScore = 600;
                    }
                    GameData.userScore += (GameData.enemiesDefeated * 100) + ((elf.heroHealth +
                        dwarf.heroHealth + wizard.heroHealth) * 150) + dragonScore;
                    UpdateHighScores();
                    storyFrm newStoryFrm = new storyFrm(_mainMenuFrm);
                    this.Close();
                    newStoryFrm.Show();
                    return;
                }
            }
        }


        //computer randomly picks an enemy to attack a hero
        private void computerPicksFighters()
        {
            //create lists of the heroes and enemies that are left alive
            List<Heroes> aliveHeroes = GameData.heroList.Where(hero => hero.heroHealth > 0).ToList();
            List<Enemies> aliveEnemies = enemyList.Where(enemy => enemy.enemyHealth > 0).ToList();

            //randomly pick one hero and one enemy
            activeHero = aliveHeroes[GameData.randomNumber.Next(aliveHeroes.Count)];
            activeEnemy = aliveEnemies[GameData.randomNumber.Next(aliveEnemies.Count)];

            //update UI with random picks
            if (activeHero == elf)
            {
                hero1RBtn.Checked = true;
            }
            else if (activeHero == dwarf)
            {
                hero2RBtn.Checked = true;
            }
            else
            {
                hero3RBtn.Checked = true;
            }

            //stages 1-8 have 3 enemies
            if (GameData.stage <= 8)
            {
                if (activeEnemy == stageEnemies[0])
                {
                    enemy1RBtn.Checked = true;
                }
                else if (activeEnemy == stageEnemies[1])
                {
                    enemy2RBtn.Checked = true;
                }
                else
                {
                    enemy3RBtn.Checked = true;
                }
            }
            //final stage only has 1 enemy
            else
            {
                enemy2RBtn.Checked = true;
            }

            //notify player who the computer selected
            MessageBox.Show("The computer has chosen the " + activeEnemy.enemyName +
                " to attack the " + activeHero.heroName, "Prepare To Be Attacked");
        }


        //method to add heroes to the game
        private void addHereosToGame()
        {
            //heroes only get added once at the beginning
            if (GameData.stage == 1)
            {
                //create heroes and add them to the hero list
                elf = new Heroes("Elf", Properties.Resources.Elf, 100, 0);
                dwarf = new Heroes("Dwarf", Properties.Resources.Dwarf, 100, 0);
                wizard = new Heroes("Wizard", Properties.Resources.Wizard, 100, 0);
                GameData.heroList.Add(elf);
                GameData.heroList.Add(dwarf);
                GameData.heroList.Add(wizard);
            }

            //load hero fields into stage
            hero1PicBx.BackgroundImage = elf.heroPicture;
            hero1NameLbl.Text = elf.heroName;
            hero1ABLbl.Text += elf.heroAccessoryBoost;

            hero2PicBx.BackgroundImage = dwarf.heroPicture;
            hero2NameLbl.Text = dwarf.heroName;
            hero2ABLbl.Text += dwarf.heroAccessoryBoost;

            hero3PicBx.BackgroundImage = wizard.heroPicture;
            hero3NameLbl.Text = wizard.heroName;
            hero3ABLbl.Text += wizard.heroAccessoryBoost;
        }


        //loads and updated the health of each unit
        private void healthLoader()
        {
            //hero health
            hero1HPLbl.Text = "HP: " + elf.heroHealth;
            hero2HPLbl.Text = "HP: " + dwarf.heroHealth;
            hero3HPLbl.Text = "HP: " + wizard.heroHealth;
            //enemy health
            //stages 1-8 have 3 enemies each
            if (GameData.stage <= 8)
            {
                enemy1HPLbl.Text = "HP: " + stageEnemies[0].enemyHealth;
                enemy2HPLbl.Text = "HP: " + stageEnemies[1].enemyHealth;
                enemy3HPLbl.Text = "HP: " + stageEnemies[2].enemyHealth;
            }
            //final stage only has 1 enemy
            else
            {
                enemy2HPLbl.Text = "HP: " + stageEnemies[0].enemyHealth;
            }
        }


        //method to load the background and add enemies to the stage
        private void stageBuilder()
        {
            //clear enemy list from previous stage
            enemyList.Clear();
            int keyLoc = GameData.randomNumber.Next(1, 4);
            //checks the stage and loads appropriate data
            switch (GameData.stage)
            {
                case 1: //forest1
                    //resets userScore to 0
                    GameData.userScore -= GameData.userScore;
                    //create enemies and add them to the enemy list
                    Enemies gnome = new Enemies("Gnome", Properties.Resources.Gnome, "Dwarf", "Elf");
                    Enemies woodNymph = new Enemies("Wood Nymph", Properties.Resources.WoodNymph, "Wizard", "Dwarf");
                    Enemies forestTroll = new Enemies("Forest Troll", Properties.Resources.ForestTroll, "Elf", "Wizard");
                    enemyList.Add(gnome);
                    enemyList.Add(woodNymph);
                    enemyList.Add(forestTroll);
                    stageEnemies = new Enemies[] { gnome, woodNymph, forestTroll };

                    //load background
                    BackgroundImage = Properties.Resources.DarkForest1;
                    switch (keyLoc)
                    {
                        case 1:
                            stage1KeyPicBx1.Visible = true;
                            break;
                        case 2:
                            stage1KeyPicBx2.Visible = true;
                            break;
                        case 3:
                            stage1KeyPicBx3.Visible = true;
                            break;
                    }
                    break;

                case 2: //forest2
                    //create enemies and add them to the enemy list
                    Enemies goblin = new Enemies("Goblin", Properties.Resources.Goblin, "Elf", "Wizard");
                    Enemies dryad = new Enemies("Dryad", Properties.Resources.Dryad, "Dwarf", "Elf");
                    Enemies treant = new Enemies("Treant", Properties.Resources.Treant, "Wizard", "Dwarf");
                    enemyList.Add(goblin);
                    enemyList.Add(dryad);
                    enemyList.Add(treant);
                    stageEnemies = new Enemies[] { goblin, dryad, treant };

                    //load background
                    BackgroundImage = Properties.Resources.DarkForest2;
                    break;

                case 3: //river1
                    //create enemies and add them to the enemy list
                    Enemies waterSprite = new Enemies("Water Sprite", Properties.Resources.WaterSprite, "Dwarf", "Wizard");
                    Enemies siren = new Enemies("Siren", Properties.Resources.Siren, "Wizard", "Elf");
                    Enemies riverTroll = new Enemies("River Troll", Properties.Resources.RiverTroll, "Elf", "Dwarf");
                    enemyList.Add(waterSprite);
                    enemyList.Add(siren);
                    enemyList.Add(riverTroll);
                    stageEnemies = new Enemies[] { waterSprite, siren, riverTroll };

                    //load background
                    BackgroundImage = Properties.Resources.DarkRiver1;
                    break;

                case 4: //river2
                    //create enemies and add them to the enemy list
                    Enemies naiad = new Enemies("Naiad", Properties.Resources.Naiad, "Elf", "Dwarf");
                    Enemies sahuagin = new Enemies("Sahuagin", Properties.Resources.Sahuagin, "Dwarf", "Wizard");
                    Enemies waterGolem = new Enemies("Water Golem", Properties.Resources.WaterGolem, "Wizard", "Elf");
                    enemyList.Add(naiad);
                    enemyList.Add(sahuagin);
                    enemyList.Add(waterGolem);
                    stageEnemies = new Enemies[] { naiad, sahuagin, waterGolem };

                    //load background
                    BackgroundImage = Properties.Resources.DarkRiver2;
                    switch (keyLoc)
                    {
                        case 1:
                            stage4KeyPicBx1.Visible = true;
                            break;
                        case 2:
                            stage4KeyPicBx2.Visible = true;
                            break;
                        case 3:
                            stage4KeyPicBx3.Visible = true;
                            break;
                    }
                    break;

                case 5: //mountain1
                    //create enemies and add them to the enemy list
                    Enemies caveDweller = new Enemies("Cave Dweller", Properties.Resources.CaveDweller, "Wizard", "Dwarf");
                    Enemies harpy = new Enemies("Harpy", Properties.Resources.Harpy, "Elf", "Wizard");
                    Enemies frostGiant = new Enemies("Frost Giant", Properties.Resources.FrostGiant, "Dwarf", "Elf");
                    enemyList.Add(caveDweller);
                    enemyList.Add(harpy);
                    enemyList.Add(frostGiant);
                    stageEnemies = new Enemies[] { caveDweller, harpy, frostGiant };

                    //load background
                    BackgroundImage = Properties.Resources.Mountain1;
                    break;

                case 6: //mountain2
                    //create enemies and add them to the enemy list
                    Enemies satyr = new Enemies("Satyr", Properties.Resources.Satyr, "Dwarf", "Elf");
                    Enemies iceWitch = new Enemies("Ice Witch", Properties.Resources.IceWitch, "Wizard", "Dwarf");
                    Enemies yeti = new Enemies("Yeti", Properties.Resources.Yeti, "Elf", "Wizard");
                    enemyList.Add(satyr);
                    enemyList.Add(iceWitch);
                    enemyList.Add(yeti);
                    stageEnemies = new Enemies[] { satyr, iceWitch, yeti };

                    //load background
                    BackgroundImage = Properties.Resources.Mountain2;
                    switch (keyLoc)
                    {
                        case 1:
                            stage6KeyPicBx1.Visible = true;
                            break;
                        case 2:
                            stage6KeyPicBx2.Visible = true;
                            break;
                        case 3:
                            stage6KeyPicBx3.Visible = true;
                            break;
                    }
                    break;

                case 7: //undead1
                    //create enemies and add them to the enemy list
                    Enemies ghoul = new Enemies("Ghoul", Properties.Resources.Ghoul, "Wizard", "Elf");
                    Enemies banshee = new Enemies("Banshee", Properties.Resources.Banshee, "Elf", "Dwarf");
                    Enemies revenant = new Enemies("Revenant", Properties.Resources.Revenant, "Dwarf", "Wizard");
                    enemyList.Add(ghoul);
                    enemyList.Add(banshee);
                    enemyList.Add(revenant);
                    stageEnemies = new Enemies[] { ghoul, banshee, revenant };

                    //load background
                    BackgroundImage = Properties.Resources.Castle1;
                    switch (keyLoc)
                    {
                        case 1:
                            stage7KeyPicBx1.Visible = true;
                            break;
                        case 2:
                            stage7KeyPicBx2.Visible = true;
                            break;
                        case 3:
                            stage7KeyPicBx3.Visible = true;
                            break;
                    }
                    break;

                case 8: //undead2
                    //create enemies and add them to the enemy list
                    Enemies skeletonKnight = new Enemies("Skeleton Knight", Properties.Resources.SkeletonKnight, "Wizard", "Dwarf");
                    Enemies wraith = new Enemies("Wraith", Properties.Resources.Wraith, "Elf", "Wizard");
                    Enemies lichKing = new Enemies("Lich King", Properties.Resources.LichKing, "Dwarf", "Elf");
                    enemyList.Add(skeletonKnight);
                    enemyList.Add(wraith);
                    enemyList.Add(lichKing);
                    stageEnemies = new Enemies[] { skeletonKnight, wraith, lichKing };

                    //load background
                    BackgroundImage = Properties.Resources.Castle2;
                    switch (keyLoc)
                    {
                        case 1:
                            stage8KeyPicBx1.Visible = true;
                            break;
                        case 2:
                            stage8KeyPicBx2.Visible = true;
                            break;
                        case 3:
                            stage8KeyPicBx3.Visible = true;
                            break;
                    }
                    break;

                case 9: //final boss
                    //create final boss and add it to the enemy list
                    Enemies dragon = new Enemies("Dragon", Properties.Resources.Dragon, "All", "None");
                    enemyList.Add(dragon);
                    stageEnemies = new Enemies[] { dragon };
                    dragon.enemyHealth = 75;
                    if (GameData.dragonAmuletFound)
                    {
                        dragon.enemyHealth = 60;
                    }

                    //load background and hide unneeded objects
                    BackgroundImage = Properties.Resources.DragonBackground;
                    enemy1RBtn.Enabled = false;
                    enemy1RBtn.Visible = false;
                    enemy1NameLbl.Visible = false;
                    enemy1HPLbl.Visible = false;
                    enemy1StLbl.Visible = false;
                    enemy1WkLbl.Visible = false;
                    enemy3RBtn.Enabled = false;
                    enemy3RBtn.Visible = false;
                    enemy3NameLbl.Visible = false;
                    enemy3HPLbl.Visible = false;
                    enemy3StLbl.Visible = false;
                    enemy3WkLbl.Visible = false;

                    //populate enemy information
                    enemy2PicBx.BackgroundImage = dragon.enemyPicture;
                    enemy2NameLbl.Text = dragon.enemyName;
                    enemy2StLbl.Text = "StAgnst: " + dragon.enemyStrength;
                    enemy2WkLbl.Text = "WkAgnst: " + dragon.enemyWeakness;
                    break;
            }

            //gernerate enemy hp and load them into the stage (stages 1-8)
            if (GameData.stage <= 8)
            {
                hpGenerator();
                enemyLoader();
            }
            //load health for stage 9
            else
            {
                healthLoader();
            }
        }


        //randomly generate hp for each enemy so total hp is equal to 30
        private void hpGenerator()
        {
            //declare variables for total health and individual health of each enemy
            int totalHealth = 40;
            int[] individualHealth = new int[3];
            int sumGeneratedHealth = 0;

            for (int i = 0; i < 3; i++)
            {
                individualHealth[i] = GameData.randomNumber.Next(4, 20);
                sumGeneratedHealth += individualHealth[i];
            }

            //calculate a scaling factor
            float scalingFactor = (float)totalHealth / sumGeneratedHealth;

            //adjust randomly generated health values
            for (int i = 0; i < 3; ++i)
            {
                individualHealth[i] *= (int)scalingFactor;

                if (individualHealth[i] < 4)
                {
                    individualHealth[i] = 4;
                }
                if (individualHealth[i] > 20)
                {
                    individualHealth[i] = 20;
                }
            }

            //calculate the total after scaling
            int newSumGeneratedHealth = individualHealth.Sum();

            //if sum is still less than 30, distribute reamining health
            int remainingHealth = totalHealth - newSumGeneratedHealth;
            for(int i = 0; remainingHealth > 0; i = (i + 1) % 3)
            {
                if (individualHealth[i] < 20)
                {
                    individualHealth[i]++;
                    remainingHealth--;
                }
            }

            //assign generated health to each enemy
            for (int i = 0; i < 3; i++)
            {
                stageEnemies[i].enemyHealth = individualHealth[i];
            }
        }


        //load enemies into the stage builder
        private void enemyLoader()
        {
            enemy1PicBx.BackgroundImage = stageEnemies[0].enemyPicture;
            enemy1NameLbl.Text = stageEnemies[0].enemyName;
            enemy1StLbl.Text = "StAgnst: " + stageEnemies[0].enemyStrength;
            enemy1WkLbl.Text = "WkAgnst: " + stageEnemies[0].enemyWeakness;

            enemy2PicBx.BackgroundImage = stageEnemies[1].enemyPicture;
            enemy2NameLbl.Text = stageEnemies[1].enemyName;
            enemy2StLbl.Text = "StAgnst: " + stageEnemies[1].enemyStrength;
            enemy2WkLbl.Text = "WkAgnst: " + stageEnemies[1].enemyWeakness;

            enemy3PicBx.BackgroundImage = stageEnemies[2].enemyPicture;
            enemy3NameLbl.Text = stageEnemies[2].enemyName;
            enemy3StLbl.Text = "StAgnst: " + stageEnemies[2].enemyStrength;
            enemy3WkLbl.Text = "WkAgnst: " + stageEnemies[2].enemyWeakness;

            //call method to load health data
            healthLoader();
        }


        //quit game and return to main menu
        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            //verify is user really wants to equit the game
            DialogResult result = MessageBox.Show("All progress will be lost, are you sure you want to quit?",
                "Quit Game", MessageBoxButtons.YesNo);

            //if yes, quit game and return to main menu
            if (result == DialogResult.Yes)
            {
                this.Close();
                _mainMenuFrm.Show();
            }
        }


        //secret keys
        //area 1 stage 1 secret keys
        private void stage1KeyPicBx1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I wonder what this unlocks?", "Secret Key!");
            GameData.areaOneKey = true;
            stage1KeyPicBx1.Visible = false;
            GameData.userScore += 200;
        }
        private void stage1KeyPicBx2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I wonder what this unlocks?", "Secret Key!");
            GameData.areaOneKey = true;
            stage1KeyPicBx2.Visible = false;
            GameData.userScore += 200;
        }
        private void stage1KeyPicBx3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I wonder what this unlocks?", "Secret Key!");
            GameData.areaOneKey = true;
            stage1KeyPicBx3.Visible = false;
            GameData.userScore += 200;
        }
        //area 2 stage 4 secret keys
        private void stage4KeyPicBx1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I wonder what this unlocks?", "Secret Key!");
            GameData.areaTwoKey = true;
            stage4KeyPicBx1.Visible = false;
            GameData.userScore += 200;
        }
        private void stage4KeyPicBx2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I wonder what this unlocks?", "Secret Key!");
            GameData.areaTwoKey = true;
            stage4KeyPicBx2.Visible = false;
            GameData.userScore += 200;
        }
        private void stage4KeyPicBx3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I wonder what this unlocks?", "Secret Key!");
            GameData.areaTwoKey = true;
            stage4KeyPicBx3.Visible = false;
            GameData.userScore += 200;
        }
        //area 3 stage 6 secrety keys
        private void stage6KeyPicBx1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I wonder what this unlocks?", "Secret Key!");
            GameData.areaThreeKey = true;
            stage6KeyPicBx1.Visible = false;
            GameData.userScore += 200;
        }
        private void stage6KeyPicBx2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I wonder what this unlocks?", "Secret Key!");
            GameData.areaThreeKey = true;
            stage6KeyPicBx2.Visible = false;
            GameData.userScore += 200;
        }
        private void stage6KeyPicBx3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I wonder what this unlocks?", "Secret Key!");
            GameData.areaThreeKey = true;
            stage6KeyPicBx3.Visible = false;
            GameData.userScore += 200;
        }
        //area 4 stage 7 secret keys
        private void stage7KeyPicBx1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I wonder what this unlocks?", "Secret Key!");
            GameData.areaFourKey1 = true;
            stage7KeyPicBx1.Visible = false;
            GameData.userScore += 200;
        }
        private void stage7KeyPicBx2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I wonder what this unlocks?", "Secret Key!");
            GameData.areaFourKey1 = true;
            stage7KeyPicBx2.Visible = false;
            GameData.userScore += 200;
        }
        private void stage7KeyPicBx3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I wonder what this unlocks?", "Secret Key!");
            GameData.areaFourKey1 = true;
            stage7KeyPicBx3.Visible = false;
            GameData.userScore += 200;
        }
        //area 4 stage 8 secret keys
        private void stage8KeyPicBx1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I wonder what this unlocks?", "Secret Key!");
            GameData.areaFourKey2 = true;
            stage8KeyPicBx1.Visible = false;
            GameData.userScore += 200;
        }
        private void stage8KeyPicBx2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I wonder what this unlocks?", "Secret Key!");
            GameData.areaFourKey2 = true;
            stage8KeyPicBx2.Visible = false;
            GameData.userScore += 200;
        }
        private void stage8KeyPicBx3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I wonder what this unlocks?", "Secret Key!");
            GameData.areaFourKey2 = true;
            stage8KeyPicBx3.Visible = false;
            GameData.userScore += 200;
        }


        public void UpdateHighScores()
        {
            try
            {
                //create a list to populate with high score data
                List<(string name, int score)> highScores = new List<(string, int)>();

                //locate file path for highscores.txt
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "highscores.txt");
                //create an object to upload high score data
                using (StreamReader loadHighScoreFileObject = new StreamReader(filePath))
                {
                    //loop through the object until the end of the file
                    while (!loadHighScoreFileObject.EndOfStream)
                    {
                        //read line and split name and score
                        string line = loadHighScoreFileObject.ReadLine();
                        var parts = line.Split(',');

                        //parse the score part into an int
                        int.TryParse(parts[1], out int score);

                        //load the high score data into highScores list
                        highScores.Add((parts[0], score));
                    }

                    //access user information
                    string newName = GameData.userName;
                    int newScore = GameData.userScore;
                    //add user information to highScores list
                    highScores.Add((newName, newScore));
                }
                //bubble sort highScores list
                for (int i = 0; i < highScores.Count; i++)
                {
                    for (int j = 0; j < highScores.Count - 1 - i; j++)
                    {
                        if (highScores[j].score < highScores[j + 1].score)
                        {
                            var tempScore = highScores[j];
                            highScores[j] = highScores[j + 1];
                            highScores[j + 1] = tempScore;
                        }
                    }
                }
                //take just the top 10 scores
                highScores = highScores.Take(10).ToList();

                //write the top 10 scores back to the file
                using (StreamWriter saveHighScoreFileObject = new StreamWriter(filePath))
                {
                    foreach (var highScore in highScores)
                    {
                        saveHighScoreFileObject.WriteLine(highScore.name + "," + highScore.score);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("High Score file failed to load/save.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
