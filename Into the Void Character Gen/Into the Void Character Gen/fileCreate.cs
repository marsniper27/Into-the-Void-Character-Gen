using System.IO;
using System.Diagnostics;
using System.Linq;

namespace Into_The_Void_Character_Gen
{
    class fileCreate
    {
        string Output;
        int x;
        int y = 0;
        string name = Details.CharacterList[0].NAME;

        public void main()
        {
            Output += $"((\"attribute[fmw_Test Team Lead]\" == ";

            string path = $@"c:\temp\{name}.txt";

            File.WriteAllText(path, Output);

            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Process.Start("notepad.exe", path);
        }
    }
}
