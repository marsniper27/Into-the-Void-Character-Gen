using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Into_The_Void_Character_Gen
{
    public class ButtonGroup : GroupBox
    {
        private List<RadioButton> mButtons = new List<RadioButton>();
        protected override void OnVisibleChanged(EventArgs e)
        {
            // Hijack this event to initialize the control
            if (mButtons.Count == 0)
            {
                // Build list of radio buttons
                foreach (Control ctl in Controls)
                {
                    RadioButton btn = ctl as RadioButton;
                    if (btn != null)
                    {
                        mButtons.Add(btn);
                        btn.CheckedChanged += radioButtons_CheckedChanged;
                    }
                }
            }
            base.OnVisibleChanged(e);
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            var human = new Human();
            var construct = new Construct();
            var p = new BackgroundPanels();
            RadioButton radioButton = sender as RadioButton;

            if (Details.buttonGroups.Count != 0 && radioButton.Checked == true)
            {

                var C1 = Details.CharacterList[0];
                C1.STR = 1;
                C1.DEX = 1;
                C1.WILL = 1;
                C1.RES = 1;
                C1.INT = 1;
                C1.PER = 1;
                C1.Skills.Clear();

                if (radioButton.Parent.Text.ToString() == "Nation")
                {
                    GroupBox rb = Details.buttonGroups[0];
                    rb.Dispose();
                    Details.buttonGroups[0] = null;
                }
                else if (radioButton.Parent.Text.ToString() == "Planet")
                {
                    GroupBox rb1 = Details.buttonGroups[1];
                    rb1.Dispose();
                    Details.buttonGroups[1] = null;
                }
            }

            if (radioButton.Parent.Text.ToString() == "Nation" && radioButton.Checked == true)
            {
                if (radioButton.TabIndex == 0)
                {
                    p.planetsPanel(Details.panel);
                    foreach (Control ctl in Details.characterPanel.Controls)
                    {
                        if (ctl.Name == "nation")
                        {
                            Details.planet = Human.freeColonies;
                            Details.CharacterList[0].Nationality = radioButton.Text;
                            ctl.Text = "Nationality: " + Details.CharacterList[0].Nationality;
                        }
                    }
                }
                if (radioButton.TabIndex == 1)
                {
                    p.planetsPanel(Details.panel);
                    foreach (Control ctl in Details.characterPanel.Controls)
                    {
                        if (ctl.Name == "nation")
                        {
                            Details.planet = Human.secondColonies;
                            Details.CharacterList[0].Nationality = radioButton.Text;
                            ctl.Text = "Nationality: " + Details.CharacterList[0].Nationality;

                        }
                    }
                }
            }

            else if (radioButton.Parent.Text.ToString() == "Planet" && radioButton.Checked == true)
            {
                Details.CharacterList[0].Planet = radioButton.Text;

                if (Details.CharacterList[0].Nationality == "Democratic Alliance of  Free Colonies")
                {
                    switch (radioButton.TabIndex)
                    {
                        case 0:
                            Details.life = Human.Earthborn;
                            break;
                        case 1:
                            Details.life = Human.FirstExpansion;
                            break;
                        case 2:
                            Details.life = Human.FrontierWorld;
                            break;
                        case 3:
                            Details.life = Human.OrbitalString;
                            break;
                    }
                }
                if (Details.CharacterList[0].Nationality == "Second Wave Colonies")
                {
                    switch (radioButton.TabIndex)
                    {
                        case 0:
                            Details.life = Human.JungleWorld;
                            break;
                        case 1:
                            Details.life = Human.IceWorld;
                            break;
                        case 2:
                            Details.life = Human.DesertWorld;
                            break;
                        case 3:
                            Details.life = Human.MegaCity;
                            break;
                    }
                }
                p.LifePanel(Details.panel);

            }
            else if (radioButton.Parent.Name.ToString() == "Life" && radioButton.Checked == true)
            {
                Details.CharacterList[0].Life = radioButton.Text;
            }

            if (Details.CharacterList[0].Race == "Human")
            {
                human.Update("update", Details.panel);
            }
            else if (Details.CharacterList[0].Race == "Construct")
            {
                construct.Update("update", Details.panel);
            }

            foreach (Control ctl in Details.characterPanel.Controls)
            {
                switch (ctl.Name)
                {
                    case "Planet":
                        ctl.Text = "Planet: " + Details.CharacterList[0].Planet;
                        break;
                    case "Willpower":
                        ctl.Text = "Willpower: " + Details.CharacterList[0].WILL;
                        break;
                    case "Strength":
                        ctl.Text = "Strength: " + Details.CharacterList[0].STR;
                        break;
                    case "Resiliance":
                        ctl.Text = "Resiliance: " + Details.CharacterList[0].RES;
                        break;
                    case "Dexterity":
                        ctl.Text = "Dexterity: " + Details.CharacterList[0].DEX;
                        break;
                    case "Intelligence":
                        ctl.Text = "Intelligence: " + Details.CharacterList[0].INT;
                        break;
                    case "Perception":
                        ctl.Text = "Perception: " + Details.CharacterList[0].PER;
                        break;
                    case "Abilities":
                        ctl.Text = "Abilities: ";
                        foreach (string x in Details.CharacterList[0].Skills)
                        {
                            ctl.Text += x + "\n";
                        }
                        break;
                }
            }
        }
    }
}