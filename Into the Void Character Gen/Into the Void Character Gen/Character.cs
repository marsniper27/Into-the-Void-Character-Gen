using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Into_The_Void_Character_Gen
{
    public class Character
    {
        public string NAME { get; set; }


        public string Race { get; set; }
        public string Nationality { get; set; }
        public string Planet { get; set; }
        public string Life { get; set; }
        public string Appearance { get; set; }

        public int STR { get; set; }
        public int WILL { get; set; }
        public int RES { get; set; }
        public int DEX { get; set; }
        public int INT { get; set; }
        public int PER { get; set; }

        public List<string> Skills = new List<string>();

        public Character()
        {
            Details.Attributes.Add("Strength");
            Details.Attributes.Add("Willpower");
            Details.Attributes.Add("Resiliance");
            Details.Attributes.Add("Dexterity");
            Details.Attributes.Add("Intelligence");
            Details.Attributes.Add("Perception");
            STR = 1;
            WILL = 1;
            RES = 1;
            DEX = 1;
            INT = 1;
            PER = 1;
        }

        public void characterPanel(Panel p)
        {
            List<int> row = new List<int>();

            for (int x = 0; x < 15; x++)
            {
                row.Add(10 + (x * 20));
            }

            foreach (Control ctl in p.Controls)
            {
                if (ctl.Name == "name")
                {
                    ctl.Text = "Name: " + Details.CharacterList[0].NAME;
                    ctl.Size = new System.Drawing.Size(75, 20);
                    ctl.Location = new System.Drawing.Point(22, row[0]);
                }
            }

            Label race = new Label();
            race.Name = "race";
            race.Location = new System.Drawing.Point(22, row[1]);
            race.Size = new System.Drawing.Size(75, 20);
            race.AutoSize = true;
            p.Controls.Add(race);

            if (Details.CharacterList[0].Race == "Human")
            {
                Label Nation = new Label();
                Nation.Name = "nation";
                Nation.Location = new System.Drawing.Point(22, row[2]);
                Nation.Size = new System.Drawing.Size(75, 20);
                Nation.AutoSize = true;
                Nation.Text = "Nationality: " + Details.CharacterList[0].Nationality;
                p.Controls.Add(Nation);

                Label Life = new Label();
                Life.Name = "Life";
                Life.Location = new System.Drawing.Point(22, row[4]);
                Life.Size = new System.Drawing.Size(75, 20);
                Life.AutoSize = true;
                Life.Text = "Life: " + Details.CharacterList[0].Life;
                p.Controls.Add(Life);
            }

            else if (Details.CharacterList[0].Race == "Construct")
            {
                Label Appearance = new Label();
                Appearance.Name = "Appearance";
                Appearance.Location = new System.Drawing.Point(22, row[2]);
                Appearance.Size = new System.Drawing.Size(75, 20);
                Appearance.AutoSize = true;
                Appearance.Text = "Appearance: " + Details.CharacterList[0].Appearance;
                p.Controls.Add(Appearance);
            }

            Label Planet = new Label();
            Planet.Name = "Planet";
            Planet.Location = new System.Drawing.Point(22, row[3]);
            Planet.Size = new System.Drawing.Size(75, 20);
            Planet.AutoSize = true;
            Planet.Text = "Planet: " + Details.CharacterList[0].Planet;
            p.Controls.Add(Planet);

            Label Strength = new Label();
            Strength.Name = "Strength";
            Strength.Location = new System.Drawing.Point(22, row[5]);
            Strength.Size = new System.Drawing.Size(75, 20);
            Strength.AutoSize = true;
            Strength.Text = "Strength: " + Details.CharacterList[0].STR;
            p.Controls.Add(Strength);

            Label Willpower = new Label();
            Willpower.Name = "Willpower";
            Willpower.Location = new System.Drawing.Point(22, row[6]);
            Willpower.Size = new System.Drawing.Size(75, 20);
            Willpower.AutoSize = true;
            Willpower.Text = "Willpower: " + Details.CharacterList[0].WILL;
            p.Controls.Add(Willpower);

            Label Resiliance = new Label();
            Resiliance.Name = "Resiliance";
            Resiliance.Location = new System.Drawing.Point(22, row[7]);
            Resiliance.Size = new System.Drawing.Size(75, 20);
            Resiliance.AutoSize = true;
            Resiliance.Text = "Resiliance: " + Details.CharacterList[0].RES;
            p.Controls.Add(Resiliance);

            Label Dexterity = new Label();
            Dexterity.Name = "Dexterity";
            Dexterity.Location = new System.Drawing.Point(22, row[8]);
            Dexterity.Size = new System.Drawing.Size(75, 20);
            Dexterity.AutoSize = true;
            Dexterity.Text = "Dexterity: " + Details.CharacterList[0].DEX;
            p.Controls.Add(Dexterity);

            Label Intelligence = new Label();
            Intelligence.Name = "Intelligence";
            Intelligence.Location = new System.Drawing.Point(22, row[9]);
            Intelligence.Size = new System.Drawing.Size(75, 20);
            Intelligence.AutoSize = true;
            Intelligence.Text = "Planet: " + Details.CharacterList[0].INT;
            p.Controls.Add(Intelligence);

            Label Perception = new Label();
            Perception.Name = "Perception";
            Perception.Location = new System.Drawing.Point(22, row[10]);
            Perception.Size = new System.Drawing.Size(75, 20);
            Perception.AutoSize = true;
            Perception.Text = "Perception: " + Details.CharacterList[0].PER;
            p.Controls.Add(Perception);

            Label Abilities = new Label();
            Abilities.Name = "Abilities";
            Abilities.Location = new System.Drawing.Point(22, row[11]);
            Abilities.Size = new System.Drawing.Size(75, 20);
            Abilities.AutoSize = true;
            Abilities.Text = "Abilities: ";
            p.Controls.Add(Abilities);
        }
    }
}
