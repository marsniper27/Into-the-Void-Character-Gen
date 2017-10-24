using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Into_The_Void_Character_Gen
{
    class DieRoller
    {
        public static Panel Dice;

        public static List<int> Roll(int Die, int x)
        {
            var rand = new Random();
            List<int> result = new List<int>();
            int total = 0;

            for (int z = 0; z < x; z++)
            {
                for (int i = 0; i < 10; i++)
                {
                    total += rand.Next(1, Die);
                }
                total = total / 10;
                result.Add(total);
            }

            return (result);
        }

        public void Create(Panel p)
        {
            Dice = p;
            Button Roll = new Button();
            Roll.Text = "Roll";
            Roll.Location = new System.Drawing.Point(13, 80);
            Roll.Click += Roll_Clicked;
            p.Controls.Add(Roll);
        }

        private void Roll_Clicked(object sender, EventArgs e)
        {
            int Die = 0;
            int num = 0;
            string output = "Result ";

            foreach (Control ctl in Dice.Controls)
            {
                if (ctl.Name == "Die")
                {
                    Int32.TryParse(ctl.Text, out Die);
                }
                if (ctl.Name == "NumberDice")
                {
                    Int32.TryParse(ctl.Text, out num);
                }
            }
            if (Die > 0 & num > 0)
            {
                var result = DieRoller.Roll(Die, num);
                foreach (int z in result)
                {
                    output += z + ", ";
                }
                MessageBox.Show(output);
            }
        }
    }
}
