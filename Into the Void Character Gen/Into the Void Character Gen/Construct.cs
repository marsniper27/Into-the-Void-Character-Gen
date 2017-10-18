using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Into_The_Void_Character_Gen
{
    class Construct
    {
        public static List<String> Nationality = new List<String>();
        public static List<String> Collectives = new List<String>();
        public static List<String> Appearance = new List<String>();
        public static List<String> FriendlyAppearance = new List<String>();
        public static List<String> MechanicalAppearance = new List<String>();
        

        public void main()
        {
            Nationality.Add("Construct Collective");

            Collectives.Add("Barren Planet: Strength + 1, Resilience + 1");
            Collectives.Add("Factory World: Intelligence + 1, Strength + 1");
            Collectives.Add("Space Station: Intelligence + 1, Dexterity + 1");
            Collectives.Add("Capital Planet: Intelligence + 1, Willpower + 1");

            Appearance.Add("Friendly Apperance");
            Appearance.Add("Mechanical Apperance");

            FriendlyAppearance.Add("Critical System Backups: Resilience + 1, Survivalism");
            FriendlyAppearance.Add("Communications Package: Willpower + 1, Comms and Sensors");
            FriendlyAppearance.Add("Expanded Memory Drives: Intelligence + 1, Computer Specialist");
            FriendlyAppearance.Add("Precision Servomotors: Dexterity + 1, Repair");


            MechanicalAppearance.Add("Integrated Defense Systems: Resilience + 1, Small arms");
            MechanicalAppearance.Add("Industrial Tool Harness: Intelligence + 1, Repair");
            MechanicalAppearance.Add("Extra Limb: Dexterity + 1, Hand to Hand");
            MechanicalAppearance.Add("Heavy Lifting Gear: Strength + 1, Heavy Weapons");


            Details.CharacterList[0].Nationality = "Construct Collective";
            Details.CharacterList[0].Planet = "Barren Planet: Strength + 1, Resilience + 1";
            Details.CharacterList[0].Appearance = "Big City Upbringing: Dexterity +1, Barter";
            
            Update("update", Details.panel);

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
                        foreach (string x in Details.CharacterList[0].Skills)
                        {
                            ctl.Text += x + "\n";
                        }
                        break;
                }
            }
        }

        public void Update(string controller, Panel p)
        {
            var C1 = Details.CharacterList[0];

            if (controller == "Button")
            {
                p.Visible = false;
                Details.AttributesPanel.Visible = true;
                return;
            }

            switch (C1.Planet)
            {
                case "Barren Planet: Strength + 1, Resilience + 1":
                    C1.STR ++;
                    C1.RES ++;
                    break;
                case "Factory World: Intelligence + 1, Strength + 1":
                    C1.STR ++;
                    C1.INT ++;
                    break;
                case "Space Station: Intelligence + 1, Dexterity + 1":
                    C1.DEX ++;
                    C1.INT ++;
                    break;
                case "Capital Planet: Intelligence + 1, Willpower + 1":
                    C1.WILL ++;
                    C1.INT ++;
                    break;
            }

            switch (C1.Appearance)
            {
                case "Critical System Backups: Resilience + 1, Survivalism":
                    C1.RES++;
                    break;
                case "Communications Package: Willpower + 1, Comms and Sensors":
                    C1.WILL++;
                    break;
                case "Expanded Memory Drives: Intelligence + 1, Computer Specialist":
                    C1.INT++;
                    break;
                case "Precision Servomotors: Dexterity + 1, Repair":
                    C1.DEX++;
                    break;
                case "Integrated Defense Systems: Resilience + 1, Small arms":
                    C1.RES++;
                    break;
                case "Industrial Tool Harness: Intelligence + 1, Repair":
                    C1.INT++;
                    break;
                case "Extra Limb: Dexterity + 1, Hand to Hand":
                    C1.DEX++;
                    break;
                case "Heavy Lifting Gear: Strength + 1, Heavy Weapons":
                    C1.STR++;
                    break;
            }
            
        }
    }
}
