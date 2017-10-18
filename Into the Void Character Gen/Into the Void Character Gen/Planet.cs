using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Into_The_Void_Character_Gen
{
    class BackgroundPanels
    {
        public void planetsPanel(Panel p)
        {
            int x = 0;
            ButtonGroup planet = new ButtonGroup();
            planet.Text = "Planet";
            planet.Name = "Planet";
            planet.Location = new System.Drawing.Point(22, 140);
            Details.buttonGroups[0] = planet;
            p.Controls.Add(planet);

            foreach (string s in Details.planet)
            {
                var text = s;
                RadioButton newButton = new RadioButton();
                if (x == 0)
                {
                    newButton.Checked = true;
                }
                newButton.Text = text;
                newButton.Width = newButton.Text.Length*6;
                planet.Controls.Add(newButton);
                newButton.Location = new Point(1, 15 + (20 * x));
                x++;
            }
            planet.AutoSize = true;
            planet.MinimumSize = new System.Drawing.Size(50, 20);
            planet.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            x = 0;
            p.Controls.Add(planet);
            planet.Visible = false;
            planet.Visible = true;
        }
        public void LifePanel(Panel p)
        {
            int x = 0;
            ButtonGroup life = new ButtonGroup();
            life.Text = "Early Life and Education";
            life.Name = "Life";
            life.Location = new System.Drawing.Point(22, 260);
            Details.buttonGroups[1] =life;
            p.Controls.Add(life);

            foreach (string s in Details.life)
            {
                var text = s;
                RadioButton newButton = new RadioButton();
                if (x == 0)
                {
                    newButton.Checked = true;
                }
                newButton.Text = text;
                newButton.Width = newButton.Text.Length * 6;
                life.Controls.Add(newButton);
                newButton.Location = new Point(1, 15 + (20 * x));
                x++;
            }
            life.AutoSize = true;
            life.MinimumSize = new System.Drawing.Size(50, 20);
            life.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            x = 0;
            p.Controls.Add(life);
            life.Visible = false;
            life.Visible = true;
        }
    }
}
