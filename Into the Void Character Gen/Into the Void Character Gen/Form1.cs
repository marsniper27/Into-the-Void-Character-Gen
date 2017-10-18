using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Into_The_Void_Character_Gen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void human_Click(object sender, EventArgs e)
        {
            Character C1 = new Character();
            Details.CharacterList.Add(C1);
            Details.CharacterList[0].Race = "Human";
            C1.characterPanel(CharacterPanel);
            Details.characterPanel = CharacterPanel;
            var a = new Attributes();
            a.main();

            int x = 0;
            var p = new BackgroundPanels();
            Details.panel = HumanPanel;
            this.Controls.Add(CharacterPanel);
            Continue.Visible = true;
            Continue.Location = new System.Drawing.Point(Continue.Parent.Width / 2, Continue.Parent.Height - 40);

            panel1.Visible = false;
            ConstructPanel.Visible = false;
            HumanPanel.Visible = true;
            HumanPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CharacterPanel.Visible = true;
            var human = new Human();
            human.main();

            foreach (Control ctl in CharacterPanel.Controls)
            {
                if (ctl.Name == "race")
                {
                    ctl.Text = "Race: " + Details.CharacterList[0].Race;
                }
                if (ctl.Name == "nation")
                {
                    ctl.Text = "Nationality: " + Details.CharacterList[0].Nationality;
                }
            }

            HumanPanel.Controls.Add(this.textBox1);
            HumanPanel.Controls.Add(this.label1);
            label1.Text = "Human";

            ButtonGroup Nation = new ButtonGroup();
            Nation.Text = "Nation";
            Nation.Location = new System.Drawing.Point(22, 60);


            foreach (string s in Human.Nationality)
            {
                var text = s;
                RadioButton newButton = new RadioButton();

                if (x == 0)
                {
                    newButton.Checked = true;
                }

                newButton.Text = text;
                newButton.Width = newButton.Text.Length * 6;
                Nation.Controls.Add(newButton);
                newButton.Location = new Point(1, 15 + (20 * x));
                x++;
            }
            Nation.AutoSize = true;
            Nation.MinimumSize = new System.Drawing.Size(50, 20);
            Nation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            x = 0;
            HumanPanel.Controls.Add(Nation);
            Nation.Visible = false;
            Nation.Visible = true;
            Details.planet = Human.freeColonies;
            Details.life = Human.Earthborn;
            p.planetsPanel(HumanPanel);
            p.LifePanel(HumanPanel);
            CharacterPanel.Location = new System.Drawing.Point(HumanPanel.Width + 10, 13);
            Continue.Location = new System.Drawing.Point(Continue.Parent.Width / 2, Continue.Parent.Height - 40);
        }

        private void construct_Click(object sender, EventArgs e)
        {
            Character C1 = new Character();
            Details.CharacterList.Add(C1);
            Details.CharacterList[0].Race = "Construct";
            C1.characterPanel(CharacterPanel);
            Details.characterPanel = CharacterPanel;
            var a = new Attributes();
            a.main();

            int x = 0;
            var p = new BackgroundPanels();
            Details.panel = HumanPanel;
            this.Controls.Add(CharacterPanel);
            Continue.Visible = true;
            panel1.Visible = false;
            HumanPanel.Visible = false;
            ConstructPanel.Visible = true;
            CharacterPanel.Visible = true;
            CharacterPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            var construct = new Construct();
            construct.main();
            
            foreach (Control ctl in CharacterPanel.Controls)
            {
                if (ctl.Name == "race")
                {
                    ctl.Text = "Race: " + Details.CharacterList[0].Race;
                }
                if (ctl.Name == "nation")
                {
                    ctl.Text = "Nationality: " + Details.CharacterList[0].Nationality;
                }
            }

            ConstructPanel.Controls.Add(this.textBox1);
            ConstructPanel.Controls.Add(this.label1);
            label1.Text = "Constuct";

            ButtonGroup Nation = new ButtonGroup();
            Nation.Text = "Nation";
            Nation.Location = new System.Drawing.Point(22, 60);


            foreach (string s in Into_The_Void_Character_Gen.Construct.Nationality)
            {
                var text = s;
                RadioButton newButton = new RadioButton();

                if (x == 0)
                {
                    newButton.Checked = true;
                }

                newButton.Text = text;
                newButton.Width = 250;
                Nation.Controls.Add(newButton);
                newButton.Location = new Point(1, 15 + (20 * x));
                x++;
            }
            Nation.AutoSize = true;
            Nation.MinimumSize = new System.Drawing.Size(318, 20);
            Nation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            x = 0;
            ConstructPanel.Controls.Add(Nation);
            Nation.Visible = false;
            Nation.Visible = true;
            Details.planet = Into_The_Void_Character_Gen.Construct.Collectives;
            p.planetsPanel(ConstructPanel);
            p.LifePanel(ConstructPanel);
            Continue.Location = new System.Drawing.Point(Continue.Parent.Width / 2, Continue.Parent.Height - 40);

        }


        private void Continue_Click(object sender, EventArgs e)
        {
            var human = new Human();
            var construct = new Construct();
            if (Details.Stage == "Life")
            {
                if (Details.CharacterList[0].Race == "Human")
                {
                    human.Update("Button", HumanPanel);
                    Details.Stage = "Attributes";
                }
                else if (Details.CharacterList[0].Race == "Construct")
                {
                    construct.Update("Button", Details.panel);
                    Details.Stage = "Attributes";
                }
            }
            else if (Details.Stage == "Attributes")
            {
                if (Attributes.checkedBoxes != 3)
                {
                    int x = 3 - Attributes.checkedBoxes;
                    MessageBox.Show("You have only selected " + Attributes.checkedBoxes + " attributes you may select " + x + " more.");
                }
                else
                {

                }
            }
        }

        private void textBox1_Changed(object sender, EventArgs e)
        {
            TextBox textBox1 = sender as TextBox;
            Details.CharacterList[0].NAME = textBox1.Text;
            name.Text = "Name: " + Details.CharacterList[0].NAME;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            HumanPanel.Visible = false;
            ConstructPanel.Visible = false;
            AttributePanel.Visible = false;
            HumanPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ConstructPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Details.AttributesPanel = AttributePanel;

            Details.buttonGroups.Add(null);
            Details.buttonGroups.Add(null);
        }
    }
}
