using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Into_The_Void_Character_Gen
{
    class Careers
    {
        public static List<List<string>> CareerList = new List<List<string>>();
        public static int checkedBoxes = 0;
        public static bool overload = false;
        public static int maxCareers = 1;

        public void main()
        {            
            if(Details.CharacterList[0].Nationality == "Democratic Alliance of  Free Colonies")
            {
                CareerList.Add(new List<string> { "Cyborg", "Significant Portions of your body have been replaced by mechanical components. You may add one level to any attribute of your choice however you receive a Disadvantage for persuasion rolls against characters from a Democratic Alliance of Free Colonies world. Also you must healed by Basic Medicine (or Advanced Medicine) and Repair." });
                CareerList.Add(new List<string> { "Gene-Splicer", "Your genetics have been modified significantly. You may add one level to any attribute of your choice however you receive a Disadvantage for persuasion rolls against characters from a Democratic Alliance of Free Colonies world. You may only be healed by the Advanced Medicine Ability." });
                CareerList.Add(new List<string> { "Socially Inept", "You have always had difficulty grasping social conventions and interacting with others. You always work with a Disadvantage when attempting any Social checks, however you may select an additional ability from the Knowledge Category." });
                CareerList.Add(new List<string> { "Mechanically Inept", "You have always had difficulty working with your hands and technology always seems to fall apart around you. You always work with a Disadvantage when attempting to repair anything, however you may select one additional Combat, Social or Miscellaneous Ability." });
                CareerList.Add(new List<string> { "Old", "You might have trouble keeping up with your younger shipmates but you have a great deal of life experience to draw on. Your character loses one Level on their Resilience Stat (Resilience cannot be reduced below level 1) and always has disadvantage for environment resistance checks but may select an additional option from Backstory Generation Part 3." });
                CareerList.Add(new List<string> { "Afraid Of Guns", "You have always disliked weapons and go out of your way to stay away from all firearms. You always receive a Disadvantage for any shooting actions you take however you may select an additional ability from the Knowledge, Exploration, Social, Starship or Miscellaneous Categories." });
                CareerList.Add(new List<string> { "FTL Aversion", "You are afraid of flying faster than light. During FTL flight you receive a disadvantage for any actions you attempt. You may select an additional ability from the combat, exploration, knowledge or miscellaneous categories." });
                CareerList.Add(new List<string> { "Arachnophobia", "You receive a disadvantage whenever you take any actions against creatures with more than 4 legs. You may raise one additional attribute of your choice." });
                CareerList.Add(new List<string> { "Claustrophobia", "You receive a disadvantage for any action you take while you are in a confined space or underground. You may raise one additional attribute of your choice." });
                CareerList.Add(new List<string> { "Acrophobia", "You receive disadvantage for every action you take while you are anywhere that is high up. You may raise one additional attribute of your choice." });
                CareerList.Add(new List<string> { "Traumatic Past", "Describe a traumatic event on your character sheet. Whenever you experience a similar event make a Willpower check. If you fail the Willpower check you are unable to take any actions until your next turn. You make an additional Ability from any category." });
                CareerList.Add(new List<string> { "Coward", "You are a coward who has survived so far by running from danger. During Combat you must make a Willpower check. If you fail this check you must move towards the nearest piece of hard cover and hide. You may select an additional Knowledge or Exploration ability." });
                CareerList.Add(new List<string> { "Obsessive Survivalist", "You are motivated primarily by your own survival. You must always carry a weapon and where possible should attempt to fortify any location you spend a significant amount of time in. Fortifications can include: extra locks on doors, non-lethal traps, decoys or anything else the GM deems acceptable. You may gain an additional ability from the Exploration category." });
                CareerList.Add(new List<string> { "But I Need It…", "You have an item that you refuse to leave behind. This item may not be a weapon or a consumable. It occupies one of your inventory slots and you must do everything in your power to ensure it always stays on your person. As long as you are carrying this item you may add one level to your Willpower. If you ever lose the item you must subtract one level from your Willpower." });

            }

            else if(Details.CharacterList[0].Nationality == "Second Wave Colonies")
            {
                CareerList.Add(new List<string> { "Cyborg", "Significant Portions of your body have been replaced by mechanical components. You may add one level to any attribute of your choice however you receive a Disadvantage for persuasion rolls against characters from a Democratic Alliance of Free Colonies world. Also you must healed by Basic Medicine (or Advanced Medicine) and Repair." });
                CareerList.Add(new List<string> { "Gene-Splicer", "Your genetics have been modified significantly. You may add one level to any attribute of your choice however you receive a Disadvantage for persuasion rolls against characters from a Democratic Alliance of Free Colonies world. You may only be healed by the Advanced Medicine Ability." });
                CareerList.Add(new List<string> { "Socially Inept", "You have always had difficulty grasping social conventions and interacting with others. You always work with a Disadvantage when attempting any Social checks, however you may select an additional ability from the Knowledge Category." });
                CareerList.Add(new List<string> { "Mechanically Inept", "You have always had difficulty working with your hands and technology always seems to fall apart around you. You always work with a Disadvantage when attempting to repair anything, however you may select one additional Combat, Social or Miscellaneous Ability." });
                CareerList.Add(new List<string> { "Old", "You might have trouble keeping up with your younger shipmates but you have a great deal of life experience to draw on. Your character loses one Level on their Resilience Stat (Resilience cannot be reduced below level 1) and always has disadvantage for environment resistance checks but may select an additional option from Backstory Generation Part 3." });
                CareerList.Add(new List<string> { "Afraid Of Guns", "You have always disliked weapons and go out of your way to stay away from all firearms. You always receive a Disadvantage for any shooting actions you take however you may select an additional ability from the Knowledge, Exploration, Social, Starship or Miscellaneous Categories." });
                CareerList.Add(new List<string> { "FTL Aversion", "You are afraid of flying faster than light. During FTL flight you receive a disadvantage for any actions you attempt. You may select an additional ability from the combat, exploration, knowledge or miscellaneous categories." });
                CareerList.Add(new List<string> { "Arachnophobia", "You receive a disadvantage whenever you take any actions against creatures with more than 4 legs. You may raise one additional attribute of your choice." });
                CareerList.Add(new List<string> { "Claustrophobia", "You receive a disadvantage for any action you take while you are in a confined space or underground. You may raise one additional attribute of your choice." });
                CareerList.Add(new List<string> { "Acrophobia", "You receive disadvantage for every action you take while you are anywhere that is high up. You may raise one additional attribute of your choice." });
                CareerList.Add(new List<string> { "Traumatic Past", "Describe a traumatic event on your character sheet. Whenever you experience a similar event make a Willpower check. If you fail the Willpower check you are unable to take any actions until your next turn. You make an additional Ability from any category." });
                CareerList.Add(new List<string> { "Coward", "You are a coward who has survived so far by running from danger. During Combat you must make a Willpower check. If you fail this check you must move towards the nearest piece of hard cover and hide. You may select an additional Knowledge or Exploration ability." });
                CareerList.Add(new List<string> { "Obsessive Survivalist", "You are motivated primarily by your own survival. You must always carry a weapon and where possible should attempt to fortify any location you spend a significant amount of time in. Fortifications can include: extra locks on doors, non-lethal traps, decoys or anything else the GM deems acceptable. You may gain an additional ability from the Exploration category." });
                CareerList.Add(new List<string> { "But I Need It…", "You have an item that you refuse to leave behind. This item may not be a weapon or a consumable. It occupies one of your inventory slots and you must do everything in your power to ensure it always stays on your person. As long as you are carrying this item you may add one level to your Willpower. If you ever lose the item you must subtract one level from your Willpower." });
            }
            else if (Details.CharacterList[0].Nationality == "Construct Collective")
            {
                CareerList.Add(new List<string> { "Cyborg", "Significant Portions of your body have been replaced by mechanical components. You may add one level to any attribute of your choice however you receive a Disadvantage for persuasion rolls against characters from a Democratic Alliance of Free Colonies world. Also you must healed by Basic Medicine (or Advanced Medicine) and Repair." });
                CareerList.Add(new List<string> { "Gene-Splicer", "Your genetics have been modified significantly. You may add one level to any attribute of your choice however you receive a Disadvantage for persuasion rolls against characters from a Democratic Alliance of Free Colonies world. You may only be healed by the Advanced Medicine Ability." });
                CareerList.Add(new List<string> { "Socially Inept", "You have always had difficulty grasping social conventions and interacting with others. You always work with a Disadvantage when attempting any Social checks, however you may select an additional ability from the Knowledge Category." });
                CareerList.Add(new List<string> { "Mechanically Inept", "You have always had difficulty working with your hands and technology always seems to fall apart around you. You always work with a Disadvantage when attempting to repair anything, however you may select one additional Combat, Social or Miscellaneous Ability." });
                CareerList.Add(new List<string> { "Old", "You might have trouble keeping up with your younger shipmates but you have a great deal of life experience to draw on. Your character loses one Level on their Resilience Stat (Resilience cannot be reduced below level 1) and always has disadvantage for environment resistance checks but may select an additional option from Backstory Generation Part 3." });
                CareerList.Add(new List<string> { "Afraid Of Guns", "You have always disliked weapons and go out of your way to stay away from all firearms. You always receive a Disadvantage for any shooting actions you take however you may select an additional ability from the Knowledge, Exploration, Social, Starship or Miscellaneous Categories." });
                CareerList.Add(new List<string> { "FTL Aversion", "You are afraid of flying faster than light. During FTL flight you receive a disadvantage for any actions you attempt. You may select an additional ability from the combat, exploration, knowledge or miscellaneous categories." });
                CareerList.Add(new List<string> { "Arachnophobia", "You receive a disadvantage whenever you take any actions against creatures with more than 4 legs. You may raise one additional attribute of your choice." });
                CareerList.Add(new List<string> { "Claustrophobia", "You receive a disadvantage for any action you take while you are in a confined space or underground. You may raise one additional attribute of your choice." });
                CareerList.Add(new List<string> { "Acrophobia", "You receive disadvantage for every action you take while you are anywhere that is high up. You may raise one additional attribute of your choice." });
                CareerList.Add(new List<string> { "Traumatic Past", "Describe a traumatic event on your character sheet. Whenever you experience a similar event make a Willpower check. If you fail the Willpower check you are unable to take any actions until your next turn. You make an additional Ability from any category." });
                CareerList.Add(new List<string> { "Coward", "You are a coward who has survived so far by running from danger. During Combat you must make a Willpower check. If you fail this check you must move towards the nearest piece of hard cover and hide. You may select an additional Knowledge or Exploration ability." });
                CareerList.Add(new List<string> { "Obsessive Survivalist", "You are motivated primarily by your own survival. You must always carry a weapon and where possible should attempt to fortify any location you spend a significant amount of time in. Fortifications can include: extra locks on doors, non-lethal traps, decoys or anything else the GM deems acceptable. You may gain an additional ability from the Exploration category." });
                CareerList.Add(new List<string> { "But I Need It…", "You have an item that you refuse to leave behind. This item may not be a weapon or a consumable. It occupies one of your inventory slots and you must do everything in your power to ensure it always stays on your person. As long as you are carrying this item you may add one level to your Willpower. If you ever lose the item you must subtract one level from your Willpower." });
            }

            CareersGroup Career = new CareersGroup();
            Career.Text = "Career";
            Career.Location = new System.Drawing.Point(13, 13);
            var x = 0;

            foreach (List<string> L in CareerList)
            {
                var text = L[0];
                CheckBox newButton = new CheckBox();

                newButton.Text = text;
                newButton.Width = text.Length*15;
                Career.Controls.Add(newButton);
                newButton.Location = new Point(1, 15 + (20 * x));
                x++;
            }
            Career.AutoSize = true;
            Career.MinimumSize = new System.Drawing.Size(215, 20);
            Career.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Details.CareerPanel.Controls.Add(Career);
            Career.Visible = false;
            Career.Visible = true;
        }

        public class CareersGroup : GroupBox
        {
            private List<CheckBox> mButtons = new List<CheckBox>();
            protected override void OnVisibleChanged(EventArgs e)
            {
                // Hijack this event to initialize the control
                if (mButtons.Count == 0)
                {
                    // Build list of radio buttons
                    foreach (Control ctl in Controls)
                    {
                        CheckBox btn = ctl as CheckBox;
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
                CheckBox RadioButton = sender as CheckBox;

                if (RadioButton.Checked == true && checkedBoxes == maxCareers)
                {
                    overload = true;
                    RadioButton.Checked = false;
                    MessageBox.Show("Only " + maxCareers + " attributes may be increased.");
                    return;
                }

                else if (checkedBoxes != maxCareers & RadioButton.Checked == true)
                {
                    checkedBoxes++;
                    switch (RadioButton.TabIndex)
                    {
                        case 0:
                            MessageBox.Show(CareerList[0][1]);
                            break;
                        case 1:
                            MessageBox.Show(CareerList[1][1]);
                            break;
                        case 2:
                            MessageBox.Show(CareerList[2][1]);
                            break;
                        case 3:
                            MessageBox.Show(CareerList[3][1]);
                            break;
                        case 4:
                            MessageBox.Show(CareerList[4][1]);
                            break;
                        case 5:
                            MessageBox.Show(CareerList[5][1]);
                            break;
                        case 6:
                            MessageBox.Show(CareerList[6][1]);
                            break;
                        case 7:
                            MessageBox.Show(CareerList[7][1]);
                            break;
                        case 8:
                            MessageBox.Show(CareerList[8][1]);
                            break;
                        case 9:
                            MessageBox.Show(CareerList[9][1]);
                            break;
                        case 10:
                            MessageBox.Show(CareerList[10][1]);
                            break;
                        case 11:
                            MessageBox.Show(CareerList[11][1]);
                            break;
                        case 12:
                            MessageBox.Show(CareerList[12][1]);
                            break;
                        case 13:
                            MessageBox.Show(CareerList[13][1]);
                            break;
                        case 14:
                            MessageBox.Show(CareerList[14][1]);
                            break;
                        case 15:
                            MessageBox.Show(CareerList[15][1]);
                            break;
                    }
                }
                else if (RadioButton.Checked == false)
                {
                    if (overload == true)
                    {
                        overload = false;
                        return;
                    }
                    checkedBoxes--;
                }
            }
        }
    }
}
