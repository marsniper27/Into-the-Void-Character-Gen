using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Into_The_Void_Character_Gen
{
    class Details
    {
        public static List<Character> CharacterList = new List<Character>();
        public static List<String> planet = new List<String>();
        public static List<String> life = new List<String>();
        public static Panel panel = new Panel();
        public static Panel characterPanel = new Panel();
        public static Panel AttributesPanel = new Panel();
        public static Panel CareerPanel = new Panel();
        public static Panel FlawsPanel = new Panel();
        public static List<GroupBox> buttonGroups = new List<GroupBox>();
        public static List<String> Attributes = new List<String>();
        public static string Stage = "Life";
    }
}
