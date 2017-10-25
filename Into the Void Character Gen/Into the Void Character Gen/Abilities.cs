using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Into_The_Void_Character_Gen
{
    class Abilities
    {
        public static List<List<string>> Abilites = new List<List<string>>();
        public static List<string> Categories = new List<string>();

        public void humanAbilities()
        {
            List<string> x = new List<string>();

            x.Add("Gunnery:");
            x.Add("Uses the Dexterity Attribute for action checks");
            x.Add("Allows you to fire starship mounted weapons.");
            x.Add("Gives you advantage with starship mounted weapons.");
            x.Add("Adds +1 to action checks with starship mounted weapons. (replaces the advantage from level 3)");
            x.Add("Gives advantage and +1 for all checks with starship mounted weapons. ");
            Abilites.Add(x);
            x.Clear();
            x.Add("Piloting: ");
            x.Add("Uses the Dexterity Attribute for action checks");
            x.Add("Allows you to pilot starships");
            x.Add("Gain advantage for action checks while piloting");
            x.Add("Add +1 to the result of all piloting checks (replaces advantage from level 2)");
            x.Add("Gain advantage and +1 for all piloting checks.");
            Abilites.Add(x);
            x.Clear();
            x.Add("Navigation: ");
            x.Add("Uses Intelligence for action checks");
            x.Add("Allows you to navigate");
            x.Add("Gain advantage for navigation checks");
            x.Add("Add +1 to the result of all navigation checks (replaces advantage from level 2)");
            x.Add("Gain advantage and +1 for all navigation checks.");
            Abilites.Add(x);
            x.Clear();
            x.Add("Starship Repair: ");
            x.Add("Uses Intelligence for action checks");
            x.Add("Allows you to make repairs to starships out of combat, restoring hitpoints equal to your level in intelligence");
            x.Add("Grants Advantage for Starship Repair Actions out of combat");
            x.Add("Allows you to make repairs to starships during combat, restoring hitpoints equal to your level in intelligence");
            x.Add("Grants Advantage for Starship Repair Actions during combat");
            Abilites.Add(x);
            x.Clear();
            x.Add("FTL Systems: ");
            x.Add("Uses Intelligence for action checks");
            x.Add("Allows you to plot basic FTL Jumps and routine maintenance on FTL Drives");
            x.Add("Allows you to plot jumps ending closer to planets and repair damaged FTL Drives");
            x.Add("Allows you to travel further per jump");
            Abilites.Add(x);
            x.Clear();
            x.Add("Atmospheric Maneuvers: ");
            x.Add("Uses Dexterity for action checks ");
            x.Add("Allows you to fly certain ships in atmosphere");
            x.Add("Gain advantage for action checks while piloting in atmospheres");
            x.Add("Add +1 to the result of all piloting checks in atmospheres (replaces advantage from level 2)");
            x.Add("Gain advantage and +1 for all piloting checks in atmospheres.");
            Abilites.Add(x);
            x.Clear();
            x.Add("Communications and Sensor operations: ");
            x.Add("Uses Intelligence for action checks");
            x.Add("Allows you to operate sensors and communications suites");
            x.Add("Allows you to identify points of interest from orbit");
            x.Add("Allows you to keep communications channels open even when your communications are being actively jammed");
            Abilites.Add(x);
            x.Clear();
        }

    }
}
