using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Into_The_Void_Character_Gen
{
    class Abilities
    {
        public static List<List<List<string>>> Abilites = new List<List<List<string>>>();
        public static List<string> Categories = new List<string>();

        public void generate()
        {
            Categories.Add("Spacecraft Abilities:");
            Categories.Add("Combat Abilities:");
            Categories.Add("Knowledge Abilities:");
            Categories.Add("Social Abilities:");
            Categories.Add("Miscellaneous Abilities:");

            List<List<string>> Spacecraft = new List<List<string>>();
            List<List<string>> Combat = new List<List<string>>();
            List<List<string>> Knowledge = new List<List<string>>();
            List<List<string>> Social = new List<List<string>>();
            List<List<string>> Misc = new List<List<string>>();
            List<string> Gunnery = new List<string>();
            List<string> Piloting = new List<string>();
            List<string> Navigation = new List<string>();
            List<string> StarshipRepair = new List<string>();
            List<string> FTLSystems = new List<string>();
            List<string> Communications = new List<string>();
            List<string> AtmosphericManeuvers = new List<string>();

            

            Gunnery.Add("    Gunnery:");
            Gunnery.Add("        Uses the Dexterity Attribute for action checks");
            Gunnery.Add("        Allows you to fire starship mounted weapons.");
            Gunnery.Add("        Gives you advantage with starship mounted weapons.");
            Gunnery.Add("        Adds +1 to action checks with starship mounted weapons. (replaces the advantage from level 3)");
            Gunnery.Add("        Gives advantage and +1 for all checks with starship mounted weapons. ");

            Piloting.Add("    Piloting: ");
            Piloting.Add("        Uses the Dexterity Attribute for action checks");
            Piloting.Add("        Allows you to pilot starships");
            Piloting.Add("        Gain advantage for action checks while piloting");
            Piloting.Add("        Add +1 to the result of all piloting checks (replaces advantage from level 2)");
            Piloting.Add("        Gain advantage and +1 for all piloting checks.");

            Navigation.Add("    Navigation: ");
            Navigation.Add("        Uses Intelligence for action checks");
            Navigation.Add("        Allows you to navigate");
            Navigation.Add("        Gain advantage for navigation checks");
            Navigation.Add("        Add +1 to the result of all navigation checks (replaces advantage from level 2)");
            Navigation.Add("        Gain advantage and +1 for all navigation checks.");

            StarshipRepair.Add("    Starship Repair: ");
            StarshipRepair.Add("        Uses Intelligence for action checks");
            StarshipRepair.Add("        Allows you to make repairs to starships out of combat, restoring hitpoints equal to your level in intelligence");
            StarshipRepair.Add("        Grants Advantage for Starship Repair Actions out of combat");
            StarshipRepair.Add("        Allows you to make repairs to starships during combat, restoring hitpoints equal to your level in intelligence");
            StarshipRepair.Add("        Grants Advantage for Starship Repair Actions during combat");

            FTLSystems.Add("    FTL Systems: ");
            FTLSystems.Add("        Uses Intelligence for action checks");
            FTLSystems.Add("        Allows you to plot basic FTL Jumps and routine maintenance on FTL Drives");
            FTLSystems.Add("        Allows you to plot jumps ending closer to planets and repair damaged FTL Drives");
            FTLSystems.Add("        Allows you to travel further per jump");

            AtmosphericManeuvers.Add("    Atmospheric Maneuvers: ");
            AtmosphericManeuvers.Add("        Uses Dexterity for action checks ");
            AtmosphericManeuvers.Add("        Allows you to fly certain ships in atmosphere");
            AtmosphericManeuvers.Add("        Gain advantage for action checks while piloting in atmospheres");
            AtmosphericManeuvers.Add("        Add +1 to the result of all piloting checks in atmospheres (replaces advantage from level 2)");
            AtmosphericManeuvers.Add("        Gain advantage and +1 for all piloting checks in atmospheres.");

            Communications.Add("    Communications and Sensor operations: ");
            Communications.Add("        Uses Intelligence for action checks");
            Communications.Add("        Allows you to operate sensors and communications suites");
            Communications.Add("        Allows you to identify points of interest from orbit");
            Communications.Add("        Allows you to keep communications channels open even when your communications are being actively jammed");

            Spacecraft.Add(Gunnery);
            Spacecraft.Add(Piloting);
            Spacecraft.Add(Navigation);
            Spacecraft.Add(StarshipRepair);
            Spacecraft.Add(FTLSystems);
            Spacecraft.Add(Communications);
            Spacecraft.Add(AtmosphericManeuvers);

            Abilites.Add(Spacecraft);

            List<string> SmallArms = new List<string>();
            List<string> HeavyWeapons = new List<string>();
            List<string> Sniping = new List<string>();
            List<string> Hand2Hand = new List<string>();
            List<string> Survivalism = new List<string>();
            List<string> Stealth = new List<string>();
            List<string> BasicMedicine = new List<string>();

            SmallArms.Add("    Small Arms:");
            SmallArms.Add("        Uses Dexterity for action checks");
            SmallArms.Add("        Allows you to use weapons with Small Arms as a prerequisite");
            SmallArms.Add("        Allows you to reroll attacks with small arms weapons");
            SmallArms.Add("        Grants advantage for Small Arms attacks");
            SmallArms.Add("        Grants +1 to all Small Arms rolls. ");

            HeavyWeapons.Add("    Heavy Weapons: ");
            HeavyWeapons.Add("        Uses Strength for action checks");
            HeavyWeapons.Add("        Allows you to use weapons with Heavy Weapons as a prerequisite");
            HeavyWeapons.Add("        Allows you to reroll attacks with heavy weapons");
            HeavyWeapons.Add("        Grants advantage for Heavy Weapon attacks");
            HeavyWeapons.Add("        Grants +1 to all Heavy Weapon rolls. ");

            Sniping.Add("    Sniping: ");
            Sniping.Add("        Uses Dexterity for action checks");
            Sniping.Add("        Allows you to use weapons with Sniping as a prerequisite");
            Sniping.Add("        Allows you to reroll attacks with Sniping weapons");
            Sniping.Add("        Grants advantage for Sniping attacks");
            Sniping.Add("        Grants +1 to all Sniping rolls. ");

            Hand2Hand.Add("    Hand to Hand:");
            Hand2Hand.Add("        Uses Strength for action checks");
            Hand2Hand.Add("        Allows you to use weapons with Hand to Hand as a prerequisite");
            Hand2Hand.Add("        Allows you to reroll attacks with Hand to Hand weapons");
            Hand2Hand.Add("        Grants advantage for Hand to Hand attacks");
            Hand2Hand.Add("        Grants +1 to all Hand to Hand rolls. ");

            Survivalism.Add("    Survivalism: ");
            Survivalism.Add("        Uses Resilience for action checks");
            Survivalism.Add("        Grants advantage when performing checks to resist harsh weather");
            Survivalism.Add("        Allows you to construct small shelters, protecting yourself from harsh weather, cold or heat.");
            Survivalism.Add("        Allows you to construct larger shelters capable of protecting the entire party.");

            BasicMedicine.Add("    Basic Medicine:");
            BasicMedicine.Add("        Uses Intelligence for action checks");
            BasicMedicine.Add("        Allows you to restore hitpoints equal to half your level in Intelligence");
            BasicMedicine.Add("        Allows you to restore hitpoints equal to your intelligence level");
            BasicMedicine.Add("        Allows you to heal one Major Injury");

            Stealth.Add("    Stealth: ");
            Stealth.Add("        Uses Dexterity for action checks");
            Stealth.Add("        Allows you to hide from enemies ");
            Stealth.Add("        Grants +1 Damage to ranged attacks while you are undetected. Attacking reveals your location");
            Stealth.Add("        Grants +2 damage to melee attacks while you are undetected. Attacking reveals your location");

            Combat.Add(SmallArms);
            Combat.Add(HeavyWeapons);
            Combat.Add(Sniping);
            Combat.Add(Hand2Hand);
            Combat.Add(Survivalism);
            Combat.Add(Stealth);
            Combat.Add(BasicMedicine);

            Abilites.Add(Combat);

        }

        public void abilityPanel(Button btn, TextBox L)
        {
            string x = "";

            switch (btn.Text)
            {
                case "Spacecraft Abilites":
                    foreach(List<List<String>> type in Abilites)
                    {
                        if (Abilites.IndexOf(type) == 0)
                        {
                            x += "Spacecraft Abilites:\r\n";
                        }
                        foreach (List<string> ability in type)
                        {
                            foreach (string info in ability)
                            {
                                x += info + "\r\n";
                            }
                            x += "\r\n";
                        }
                    }
                    break;
            }
            L.Text = x;
        }

        }
    }
