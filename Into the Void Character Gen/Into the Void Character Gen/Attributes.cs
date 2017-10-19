using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Into_The_Void_Character_Gen
{
    class Attributes
    {
        public static int checkedBoxes = 0;
        public static bool overload = false;
        public static int maxAttributes = 3;

        public void main()
        {

            CheckGroup Attributes = new CheckGroup();
            Attributes.Text = "Attributes";
            Attributes.Location = new System.Drawing.Point(13, 13);
            var x = 0;

            foreach (string s in Details.Attributes)
            {
                var text = s;
                CheckBox newButton = new CheckBox();

                newButton.Text = text;
                newButton.Width = 250;
                Attributes.Controls.Add(newButton);
                newButton.Location = new Point(1, 15 + (20 * x));
                x++;
            }
            Attributes.AutoSize = true;
            Attributes.MinimumSize = new System.Drawing.Size(318, 20);
            Attributes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Details.AttributesPanel.Controls.Add(Attributes);
            Attributes.Visible = false;
            Attributes.Visible = true;
        }
    }

    public class CheckGroup : GroupBox
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
                        btn.CheckedChanged += checkbox_CheckedChanged;
                    }
                }
            }
            base.OnVisibleChanged(e);
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            var human = new Human();
            var construct = new Construct();
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Checked == true && Attributes.checkedBoxes == 3)
            {
                Attributes.overload = true;
                checkBox.Checked = false;
                MessageBox.Show("Only 3 attributes may be increased.");
                return;
            }

            else if (checkBox.Checked == true && Attributes.checkedBoxes != 3)
            {
                Attributes.checkedBoxes++;
                switch (checkBox.Text)
                {
                    case "Strength":
                        Details.CharacterList[0].STR++;
                        break;
                    case "Willpower":
                        Details.CharacterList[0].WILL++;
                        break;
                    case "Resiliance":
                        Details.CharacterList[0].RES++;
                        break;
                    case "Perception":
                        Details.CharacterList[0].PER++;
                        break;
                    case "Dexterity":
                        Details.CharacterList[0].DEX++;
                        break;
                    case "Intelligence":
                        Details.CharacterList[0].INT++;
                        break;
                }
            }
             
            else if (checkBox.Checked == false)
            {
                if (Attributes.overload == true)
                {
                    Attributes.overload = false;
                    return;
                }
                Attributes.checkedBoxes--;
                switch (checkBox.Text)
                {
                    case "Strength":
                        Details.CharacterList[0].STR--;
                        break;
                    case "Willpower":
                        Details.CharacterList[0].WILL--;
                        break;
                    case "Resiliance":
                        Details.CharacterList[0].RES--;
                        break;
                    case "Perception":
                        Details.CharacterList[0].PER--;
                        break;
                    case "Dexterity":
                        Details.CharacterList[0].DEX--;
                        break;
                    case "Intelligence":
                        Details.CharacterList[0].INT--;
                        break;
                }
            }
            foreach (Control ctl in Details.characterPanel.Controls)
            {
                switch (ctl.Name)
                {
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
                }
            }
        }
    }
}
