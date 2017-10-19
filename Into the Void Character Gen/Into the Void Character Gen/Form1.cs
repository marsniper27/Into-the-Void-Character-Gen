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
            CharacterPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            var f = new Flaws();
            f.main();

            int x = 0;
            var p = new BackgroundPanels();
            Details.panel = HumanPanel;
            this.Controls.Add(CharacterPanel);
            Continue.Visible = true;
            Continue.Location = new System.Drawing.Point(Continue.Parent.Width / 2, Continue.Parent.Height - 40);

            panel1.Visible = false;
            HumanPanel.Visible = false;
            ConstructPanel.Visible = true;
            ConstructPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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


            foreach (string s in Construct.Nationality)
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
            Nation.MinimumSize = new System.Drawing.Size(50, 20);
            Nation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            x = 0;
            ConstructPanel.Controls.Add(Nation);
            Nation.Visible = false;
            Nation.Visible = true;
            Details.planet = Construct.Collectives;
            p.planetsPanel(ConstructPanel);
            p.LifePanel(ConstructPanel);
            CharacterPanel.Location = new System.Drawing.Point(HumanPanel.Width + 10, 13);
            Continue.Location = new System.Drawing.Point(Continue.Parent.Width / 2, Continue.Parent.Height - 40);

        }

        ////////////////////////////////////////
        // Continue Button
        /////////////////////////////////////
        private void Continue_Click(object sender, EventArgs e)
        {
            var human = new Human();
            var construct = new Construct();

            // Life Stage
            if (Details.Stage == "Life")
            {
                var c = new Careers();
                c.main();

                if (Details.CharacterList[0].Race == "Human")
                {
                    human.Update("Button", HumanPanel);
                    Details.Stage = "Career";
                }
                else if (Details.CharacterList[0].Race == "Construct")
                {
                    construct.Update("Button", Details.panel);
                    Details.Stage = "Career";
                }
            }

            // Career Stage
            else if (Details.Stage == "Career")
            {
                if (Attributes.checkedBoxes != 3)
                {
                    int x = Careers.maxCareers - Careers.checkedBoxes;
                    DialogResult dr = MessageBox.Show("You have only selected " + Careers.checkedBoxes + " areers you may select " + x + " more.\n Would you like to use your remaining points?", "Additional Points", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        MessageBox.Show("Please select " + x + " additional Careers");
                    }
                    else if (dr == DialogResult.No)
                    {
                        AttributePanel.Visible = false;
                        Details.Stage = "Flaws";
                        FlawsPanel.Visible = true;
                    }
                }
                else
                {
                    CareerPanel.Visible = false;
                    Details.Stage = "Attributes";
                    AttributePanel.Visible = true;
                }
            }
                

            // Attributes Stage
            else if (Details.Stage == "Attributes")
            {
                if (Attributes.checkedBoxes != 3)
                {
                    int x = Attributes.maxAttributes - Attributes.checkedBoxes;
                    DialogResult dr = MessageBox.Show("You have only selected " + Attributes.checkedBoxes + " attributes you may select " + x + " more.\n Would you like to use your remaining points?", "Additional Points", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        MessageBox.Show("Please select " + x + " additional attributes");
                    }
                    else if (dr == DialogResult.No)
                    {
                        AttributePanel.Visible = false;
                        Details.Stage = "Flaws";
                        FlawsPanel.Visible = true;
                    }
                }
                else
                {
                    AttributePanel.Visible = false;
                    Details.Stage = "Flaws";
                    FlawsPanel.Visible = true;
                }
            }

            // Flaws stage
            else if (Details.Stage == "Flaws")
            {
                MessageBox.Show("Flaws complete more code to come.");
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
            FlawsPanel.Visible = false;
            CareerPanel.Visible = false;
            HumanPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ConstructPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Details.AttributesPanel = AttributePanel;
            Details.FlawsPanel = FlawsPanel;
            Details.CareerPanel = CareerPanel;

            Details.buttonGroups.Add(null);
            Details.buttonGroups.Add(null);
        }
    }
}
