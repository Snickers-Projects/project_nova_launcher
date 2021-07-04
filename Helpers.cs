using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Project_Nova_Launcher;

namespace Project_Nova_Launcher
{
    public partial class Helpers
    {
        public string DetectGame()
        {
            if (File.Exists("iw5mp.exe")) return "Call of Duty Modern Warfare 3";
            if (File.Exists("iw5sp.exe")) return "Call of Duty Modern Warfare 3";

            if (File.Exists("iw6mp64_ship.exe")) return "Call of Duty Ghosts";
            if (File.Exists("iw6sp64_ship.exe")) return "Call of Duty Ghosts";

            if (File.Exists("s1_mp64_ship.exe")) return "Call of Duty Advanced Warfare";
            if (File.Exists("s1_sp64_ship.exe")) return "Call of Duty Advanced Warfare";

            if (File.Exists("blackops.exe")) return "Call of Duty Black Ops";
            if (File.Exists("blackopsmp.exe")) return "Call of Duty Black Ops";

            if (File.Exists("t6mp.exe")) return "Call of Duty Black Ops 2";
            if (File.Exists("t6sp.exe")) return "Call of Duty Black Ops 2";
            if (File.Exists("t6zm.exe")) return "Call of Duty Black Ops 2";

            if (File.Exists("h1_sp64_ship.exe")) return "Call of Duty Modern Warfare Remastered";
            if (File.Exists("h1_mp64_ship.exe")) return "Call of Duty Modern Warfare Remastered";

            if (File.Exists("blur.exe")) return "Blur";

            return "Unknown/Unsupported";
        }
    }
}
