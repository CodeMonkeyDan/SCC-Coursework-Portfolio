//Daniel Schiefer
//CPT-185-A80H-2024FA
//Final Project: Fantasy Fighters: Mystic Dice Battle


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Schiefer_Final_Project_Fantasy_Fighters_Mystic_Dice_Battle
{
    public partial class storyFrm : Form
    {
        //declare variable to hold the reference of mainMenuFrm
        private mainMenuFrm _mainMenuFrm;

        //constructor that takes mainMenuFrm as a parameter
        public storyFrm(mainMenuFrm existingMainMenuFrm)
        {
            InitializeComponent();
            //store the reference mainMenuFrm
            _mainMenuFrm = existingMainMenuFrm;
        }


        //loads story into form depending on what stage of the game you are at
        private void storyFrm_Load(object sender, EventArgs e)
        {
            highScoreLbl.Visible = false;

            if (GameData.stage == 1)
            {
                chapterTitleLbl.Text = "The Call to Adventure";
                storyLbl.Text = "In the heart of the peaceful kingdom of Eldoria, chaos brews as " +
                    "a terrifying dragon awakens from centuries of slumber. The dragon’s roar " +
                    "echoes across the land, signaling destruction as its minions—dark creatures, " +
                    "river beasts, mountain dwellers, and undead abominations—emerge to prepare for " +
                    "the dragon’s dominion.\r\n\r\nA dwarf, an elf, and a wizard are summoned by " +
                    "the kingdom’s dying monarch, who entrusts them with an ancient prophecy. The " +
                    "prophecy speaks of three champions chosen to wield the power of mystic dice, " +
                    "tools said to shape fate itself. Guided by the magical dice, they must travel " +
                    "through perilous lands to confront the dragon and save Eldoria. Their journey " +
                    "begins in a dark and ominous forest, where the first signs of the dragon’s " +
                    "corruption have taken root.";
            }
            else if (GameData.stage == 2)
            {
                chapterTitleLbl.Text = "The Whispering Woods";
                storyLbl.Text = "After defeating the gnome, wood nymph, and forest troll, the " +
                    "heroes press deeper into the forest, now darker and more sinister. They " +
                    "encounter an ancient tree spirit who warns them of the dangers that lie ahead. " +
                    "The spirit speaks of the dragon’s growing power but also offers hope: the " +
                    "mystic dice have chosen them for this quest, and their strength and courage " +
                    "will be their greatest allies. With renewed determination, the heroes " +
                    "continue into the heart of the forest.";
            }
            else if (GameData.stage == 3)
            {
                chapterTitleLbl.Text = "The River of Shadows";
                storyLbl.Text = "The forest opens into a wide, dark river, its surface " +
                    "unnervingly calm. The silence is unnatural, with no sound of wind, birds, " +
                    "or flowing water—everything is too quiet. The heroes feel a heavy sense of " +
                    "dread as they prepare to cross, knowing the river is cursed and hides " +
                    "terrible dangers beneath its still surface. The mystic dice glow faintly, " +
                    "urging them forward toward their next challenge.";
            }
            else if (GameData.stage == 4)
            {
                chapterTitleLbl.Text = "The Siren’s Song";
                storyLbl.Text = "Having conquered the river troll and other horrors, the " +
                    "heroes follow the river until it begins to dry up, exposing jagged rocks " +
                    "and eerie shadows. In the distance, the mountains loom under the cold light " +
                    "of the moon, their peaks piercing the night sky. The silence is unsettling, " +
                    "broken only by strange echoes that seem to come from nowhere. They press " +
                    "forward, knowing the next challenge awaits them on the dried-up riverbed.";
            }
            else if (GameData.stage == 5)
            {
                chapterTitleLbl.Text = "The Frostbitten Heights";
                storyLbl.Text = "The river gives way to jagged cliffs as the heroes ascend the " +
                    "snowy mountain. Bitter winds whip at their faces, and the trail becomes " +
                    "treacherous. They find signs of a lost expedition—broken gear and frozen " +
                    "bodies—suggesting the dragon’s minions control these peaks.\r\n\r\nA cave " +
                    "provides temporary shelter, and the dwarf shares tales of frost giants, " +
                    "cautioning the group. The wizard uses a spell to conjure warmth, but they " +
                    "all sense they’re being watched. They prepare to face their next foes in " +
                    "this icy wilderness.";
            }
            else if (GameData.stage == 6)
            {
                chapterTitleLbl.Text = "The Sunset Castle";
                storyLbl.Text = "After narrowly escaping the frost giant, the heroes climb " +
                    "higher, and as the trail bends, they come across a massive castle " +
                    "silhouetted against the setting sun. The castle exudes an evil presence, " +
                    "its ancient towers reaching into the fiery sky. A long, crumbling stone " +
                    "bridge stretches toward the castle gates, flanked by sheer drops into icy " +
                    "ravines.\r\n\r\nThe elf senses dark magic emanating from within, and the " +
                    "heroes steel themselves for the battles that await in the castle's depths. " +
                    "They cross the bridge, their footsteps echoing ominously in the still air.";
            }
            else if (GameData.stage == 7)
            {
                chapterTitleLbl.Text = "The Shadowed Hall";
                storyLbl.Text = "The heroes enter the castle, stepping into a vast great room " +
                    "lined with towering stone pillars and arched ceilings. The air is thick " +
                    "with decay, and eerie shadows flicker as if alive. Undead knights rise from " +
                    "the darkness, their rusted armor clanking as they move.\r\n\r\nThe wizard " +
                    "warns the group to stay close, as the shadows themselves seem to drain " +
                    "their energy. They realize they must clear this hall of enemies to press " +
                    "further into the castle. The mystic dice hum faintly, guiding their " +
                    "movements as they fight.";
            }
            else if (GameData.stage == 8)
            {
                chapterTitleLbl.Text = "The Throne of the Lich King";
                storyLbl.Text = "The heroes push deeper into the castle and find themselves " +
                    "in a grand throne room, its walls adorned with faded banners and broken " +
                    "chandeliers. On the throne sits the Lich King, his hollow eyes glowing " +
                    "with malice. He rises slowly, gripping a staff crackling with dark energy." +
                    "\r\n\r\nThe Lich King mocks the heroes, claiming they are unworthy to face " +
                    "his master. The air grows heavy with dark magic as the Lich King summons " +
                    "his minions, ready to crush any who oppose him.";
            }
            else if (GameData.stage == 9)
            {
                chapterTitleLbl.Text = "The Dragon’s Lair";
                storyLbl.Text = "The heroes emerge into a massive courtyard in the center of " +
                    "the castle, its walls blackened with soot and scorch marks. The sky above " +
                    "churns with ash and smoke, and the air is heavy with the stench of sulfur. " +
                    "In the middle of the courtyard lies the dragon, its massive body coiled like " +
                    "a serpent, its scales glinting with fiery hues.\r\n\r\nThe dragon raises its " +
                    "head, its eyes burning with fury, and lets out a deafening roar. It taunts " +
                    "the heroes, declaring that they are too late to stop it. The mystic dice " +
                    "glow brighter than ever, signaling the final battle has begun.";
            }
            else if (GameData.stage == 10)
            {
                chapterTitleLbl.Text = "The Victory";
                storyLbl.Text = "After an epic battle, the heroes emerge victorious, the dragon " +
                    "defeated. The courtyard crumbles as the dragon takes its last breath, and " +
                    "the castle begins to collapse around them. They narrowly escape, stepping " +
                    "out into a world now bathed in light.\r\n\r\nThe skies clear, and the " +
                    "oppressive darkness that had plagued the land lifts. The heroes return to " +
                    "Eldoria as legends, celebrated for their courage and determination. The " +
                    "mystic dice, having fulfilled their purpose, vanish, leaving the heroes " +
                    "with only the memories of their journey. Though they part ways, their bond " +
                    "remains unbreakable, knowing they have changed the fate of the world forever.";
                DisplayScore();
            }
            else
            {
                chapterTitleLbl.Text = "The World in Chaos";
                storyLbl.Text = "The heroes fell, their courage and strength not enough to " +
                    "overcome the relentless trials they faced. Whether it was the cunning of " +
                    "their enemies, the overwhelming odds, or simply the wear of the journey, " +
                    "they perished before their quest could be fulfilled.\r\n\r\nWith their loss, " +
                    "the world spirals into ruin. The balance they sought to preserve collapses, " +
                    "leaving Eldoria at the mercy of the unchecked forces of darkness. Forests " +
                    "rot into lifeless husks, rivers dry to cracked beds, and mountains crumble " +
                    "into silent, jagged tombs.\r\n\r\nAcross the land, whispers tell of an " +
                    "unstoppable force spreading fear and death, consuming all in its path. " +
                    "Villages vanish without a trace, their people swallowed by the shadows. " +
                    "The sun no longer rises, leaving the skies forever cloaked in gray despair." +
                    "\r\n\r\nThe prophecy dies with the heroes, leaving no one to fight for the " +
                    "realm. The light fades, and with it, the hope of Eldoria. All that remains " +
                    "is silence, as the world succumbs to an age of endless darkness and despair.";
                DisplayScore();
            }
        }


        //display high score at end of game
        private void DisplayScore()
        {
            highScoreLbl.Visible = true;
            highScoreLbl.Text += GameData.userScore;
        }


        //checks to see what stage user is at before proceeding,
        //if user is at end of the game or has died, sends back to main menu
        private void continueBtn_Click(object sender, EventArgs e)
        {
            if (GameData.stage <= 9)
            {
                battleFrm newBattleFrm = new battleFrm(_mainMenuFrm);
                this.Close();
                newBattleFrm.Show();
            }
            if (GameData.stage > 9)
            {
                this.Close();
                _mainMenuFrm.Show();
            }
        }
    }
}
