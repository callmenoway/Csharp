using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace MW3
{

    class Program
    {


        static bool Rebuild = true;

        static bool CheckVersion = true;
        static string[] args_;
        static string[] weapon_arr = { "USP.45", "MP412", ".44 Magnum", "Desert Eagle", "P99", "FiveSeven", "ACR 6.8", "Type95", "M4A1", "AK-47", "M16A4", "MK14", "G36C", "SCAR-L", "FAD", "CM901", "MP5", "PM-9", "P90", "PP90M1", "UMP45", "MP7", "G18", "MP9", "FMG9", "Skorpion", "SPAS-12", "AA-12", "Striker", "Model 1887", "USAS 12", "KSG12", "M60E4", "MK46", "PKP PECHENEG", "L86 LSW", "MG36", "Barrett .50cal", "MSR", "RSASS", "Dragunov", "AS50", "L118A", "RPG-7", "Javelin", "Stinger", "SMAW", "Riot Shield", "XM25" };

        #region WeaponAddresses
        enum WEAPONS : int
        {
            ADR_USP45 = 0x1ccc13c, // 0x1ccc13c
            ADR_MP412 = 0x1ccc0e4, // 0x1ccc0e4
            ADR_44Magnum = 0x1ccc0f4, // 0x1ccc0f4
            ADR_DesertEagle = 0x1ccc15c, // 0x1ccc15c
            ADR_P99 = 0x1ccc144, // 0x1ccc144
            ADR_FiveSeven = 0x1ccc150, //0x1ccc150
            ADR_ACR68 = 0x1ccc1b8, // 0x1ccc1b8
            ADR_Type95 = 0x1ccc14c, // 0x1ccc14c
            ADR_M4A1 = 0x1ccc104, // 0x1ccc104
            ADR_AK47 = 0x1ccc0ec, // 0x1ccc0ec
            ADR_M16A4 = 0x1ccc130, // 0x1ccc130
            ADR_MK14 = 0x1ccc1b0, // 0x1ccc1b0
            ADR_G36C = 0x1ccc154, // 0x1ccc154
            ADR_SCARL = 0x1ccc0f8, // 0x1ccc0f8
            ADR_FAD = 0x1ccc100, // 0x1ccc100
            ADR_CM901 = 0x1ccc158, //0x1ccc158
            ADR_MP5 = 0x1ccc108, // 0x1ccc108
            ADR_PM9 = 0x1ccc10c, // 0x1ccc10c
            ADR_P90 = 0x1ccc110, // 0x1ccc110
            ADR_PP90M1 = 0x1ccc0fc, // 0x1ccc0fc
            ADR_UMP45 = 0x1ccc11c, //0x1ccc11c
            ADR_MP7 = 0x1ccc118, // 0x1ccc118
            ADR_G18 = 0x1ccc140, // 0x1ccc140
            ADR_MP9 = 0x1ccc12c, // 0x1ccc12c
            ADR_FMG9 = 0x1ccc128, // 0x1ccc128
            ADR_Skorpion = 0x1ccc18c, //0x1ccc18c
            ADR_SPAS12 = 0x1ccc174, //0x1ccc174
            ADR_AA12 = 0x1ccc16c, // 0x1ccc16c
            ADR_Striker = 0x1ccc168, // 0x1ccc168
            ADR_Model1887 = 0x1ccc164, //0x1ccc164
            ADR_USAS12 = 0x1ccc17c, //0x1ccc17c
            ADR_KSG12 = 0x1ccc170, //0x1ccc170
            ADR_M60E4 = 0x1ccc124, //0x1ccc124
            ADR_MK46 = 0x1ccc120, //0x1ccc120
            ADR_PKPPECHENEG = 0x1ccc0e8, //0x1ccc0e8
            ADR_L86LSW = 0x1ccc0e0, //0x1ccc0e0 
            ADR_MG36 = 0x1ccc0f0, //0x1ccc0f0
            ADR_Barrett50cal = 0x1ccc134, //0x1ccc134
            ADR_MSR = 0x1ccc180, //0x1ccc180
            ADR_RSASS = 0x1ccc188, //0x1ccc188
            ADR_Dragunov = 0x1ccc178, //0x1ccc178
            ADR_AS50 = 0x1ccc184, //0x1ccc184
            ADR_L118A = 0x1ccc138, //0x1ccc138
            ADR_RPG7 = 0x1ccc1e4, //0x1ccc1e4
            ADR_Javelin = 0x1ccc1d8, //0x1ccc1d8
            ADR_Stinger = 0x1ccc1b4, //0x1ccc1b4
            ADR_SMAW = 0x1ccc160, //0x1ccc160
            ADR_RiotShield = 0x1ccc114, //0x1ccc114
            ADR_XM25 = 0x1ccc134 //0x1ccc134
        }
        #endregion


        //1.4.364
        static int ADR_EXPRANK = 0x1CCC0D4; // Updated
        static int ADR_PRESTIGE = 0x1CCC2E4; // Updated
        static int ADR_TOKENS = 0x1CCE143; // Updated
        static int ADR_TOKENS2 = 0x58CC58C; // Updated
        static int ADR_KILLS = 0x1CCC314; // Updated
        static int ADR_DEATHS = 0x1CCC31C; // Updated
        static int ADR_VER = 0x1E39FD8; // Updated
        static int ADR_ACCURACY = 0x1CCC36C; // Updated
        static int ADR_RATIO = 0x1CCC344; // Updated
        static int ADR_WINSTREAK = 0x1CCC354; // Updated
        static int ADR_WINS = 0x1CCC348; // Updated
        static int ADR_LOSES = 0x1CCC34C; // Updated

        //Private:
        static int ADR_EMBLEM = 0x1CCDEDC; // 350 emblems
        static int ADR_TITLE = 0x1CCDEE0; // 512 titles 
        static int ADR_DOUBLEXP = 0x1CCE198; // unknown calculation 
        static int ADR_DOUBLEXP_GUNS = 0x1CCE1A0; // unknown calculation
        static int ADR_NICKNAME = 0x05CB7DD8; // not updated
        static int ADR_CLASSNAME = 0x1CCC694; // (+[62]i)

        static string version = "1.0.0";
        static string processName = "iw5mp";

        static void Main(string[] args)
        {
            //
            args_ = args;
            //
            Console.Title = "Call of Duty Modern Warfare 3 Level Hack";
            Console.SetWindowSize(Console.WindowWidth, 40);
            Console.WriteLine(" ##############################################");
            Console.WriteLine("#   Call of Duty Modern Warfare 3 Level Hack   #");
            Console.WriteLine("# Console Edition by noway - Version " + version + "     #");
            Console.WriteLine(" ##############################################\n\n");

            Console.WriteLine("Waiting for Modern Warfare 3 Multiplayer...");
            while (!IsProcessActive(processName)) { }
            Console.WriteLine("Process found...\nFetching stats...");

            if (Rebuild)
            {
                //AddHack(<name>, <address>);

                AddHack("EXP", new int[] { ADR_EXPRANK });
                AddHack("Prestige", new int[] { ADR_PRESTIGE });
                AddHack("Tokens", new int[] { ADR_TOKENS, ADR_TOKENS2 });
                AddHack("Kills", new int[] { ADR_KILLS });
                AddHack("Deaths", new int[] { ADR_DEATHS });
                AddHack("K/D Ratio", new int[] { ADR_RATIO });
                AddHack("Wins", new int[] { ADR_WINS });
                AddHack("Loses", new int[] { ADR_LOSES });
                AddHack("Accuracy", new int[] { ADR_ACCURACY });
                AddHack("Winstreak", new int[] { ADR_WINSTREAK });
                //AddHack("Weapon EXP", 1337);

                Rebuild = false;
            }

            /* Do not edit under here */


            if (CheckVersion)
            {
                if (GetVal(ADR_VER) == version.Replace(".", ""))
                {
                    Console.WriteLine("\nStats:");
                    DisplayStats();
                    Console.WriteLine("\nOptions:");
                    DisplayOptions();
                    Console.WriteLine("\nHit a number from the list above to start patching..");
                    PatchSub();

                    Console.Read();
                    Console.Clear();
                    Main(args);
                }
                else
                {
                    Console.WriteLine("This program does not support any other versions other then " + version + "({0})!!", GetVal(ADR_VER));
                    Console.Read();
                }
            }
            else
            {
                Console.WriteLine("\nStats:");
                DisplayStats();
                Console.WriteLine("\nOptions:");
                DisplayOptions();
                Console.WriteLine("\nHit a number from the list above to start patching..");
                PatchSub();

                Console.Read();
                Console.Clear();
                Main(args);
            }
        }

        #region Functions

        static List<HackStore> HACKS = new List<HackStore>();
        public class HackStore // class
        {
            public string Name { get; set; }
            public int[] Address { get; set; }
        }
        static public void AddHack(string name, int[] address) // add hack to list
        {
            HackStore temp_item = new HackStore();
            temp_item.Name = name;
            temp_item.Address = address;
            HACKS.Add(temp_item);
        }
        static void DisplayStats()
        {
            foreach (HackStore hs in HACKS)
            {
                if (hs.Address[0] != 1337) // weapon hack
                {
                    Console.WriteLine("{0}: {1}", hs.Name, GetVal(hs.Address[0]));
                }
            }
        }
        static void DisplayOptions()
        {
            int i = 1;
            foreach (HackStore hs in HACKS)
            {
                Console.WriteLine("{0}. Change {1}", i, hs.Name);
                i++;
            }
        }
        static int GetWeaponAddress(string name)
        {
            int i = 0;
            foreach (string names in Enum.GetNames(typeof(WEAPONS)))
            {
                if (names.ToLower().Contains(name.ToLower())) { return Convert.ToInt32(Enum.GetValues(typeof(WEAPONS)).GetValue(i)); }
                i++;
            }
            return 0;
        }
        static string GetWeaponName(int address)
        {
            int i = 0;
            foreach (int values in Enum.GetValues(typeof(WEAPONS)))
            {
                if (values == address) { return Enum.GetName(typeof(WEAPONS), address); }
                i++;
            }
            return "0"; // will never happen if you use GWA first..
        }


        static int val = 0;
        static void PatchSub(int inputopt = 0)
        {
            bool ispassed = false;
            int input = 0;
            if (inputopt == 0) { input = Convert.ToInt32(Console.ReadLine()); } else { input = inputopt; }
            if (HACKS[input - 1].Address[0] != 1337)
            {
                // updated 23-11-2011 -> patch multiple addresses
                foreach (int i in HACKS[input - 1].Address)
                {
                    if (!ispassed)
                    {
                        DoPatching(HACKS[input - 1].Address[0], HACKS[input - 1].Name);
                        ispassed = true;
                    }
                    else
                    {
                        WriteInteger(processName, i, val); // patch the other addresses.
                    }
                }
            }

            if (HACKS[input - 1].Address[0] == 1337) // weapon hack
            {
                Console.WriteLine("Enter the name of the gun you want to patch (E.G: .44 Magnum = Magnum)(Typ all to patch all guns to 31):");
                string read = Console.ReadLine();
                if (read == "all")
                {
                    foreach (int values in Enum.GetValues(typeof(WEAPONS)))
                    {
                        DirectPatch(values, 179601);
                    }
                }
                int address_ = GetWeaponAddress(read);
                if (address_ != 0)
                {
                    Console.WriteLine("Current value of this weapon: {0} (Level 31 = 179601)", GetVal(address_));
                    DoPatching(address_, GetWeaponName(address_).Replace("ADR_", ""));
                }
                else
                {
                    Console.WriteLine("Weapon not found..");
                    PatchSub(input); // try again
                }
            }

            Console.WriteLine("Succeed!\nPress a key to continue...");
            Console.ReadLine();
            Console.Clear();
            Main(args_);

        }

        static string GetVal(int Address)
        {
            return ReadInteger(processName, Address).ToString();
        }

        static string GetString(int Address, int size = 4)
        {
            return ReadString(processName, Address, size);
        }

        static void DirectPatch(int address, int value)
        {
            WriteInteger(processName, address, value);
        }

        static void DoPatching(int adress, string name)
        {
            Console.WriteLine("Enter a new value to change your {0}:", name);
            val = Convert.ToInt32(Console.ReadLine());
            WriteInteger(processName, adress, val);
        }

        static bool IsProcessActive(string name)
        {
            Process[] processesByName = Process.GetProcessesByName(name);
            if (processesByName.Length == 1)
            {
                return true;
            }
            return false;
        }

        [DllImport("kernel32.dll")]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, UIntPtr nSize, out IntPtr lpNumberOfBytesWritten);
        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern int OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);
        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern int WriteProcessMemory(int hProcess, int lpBaseAddress, ref int lpBuffer, int nSize, ref int lpNumberOfBytesWritten);
        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern int ReadProcessMemory(int hProcess, int lpBaseAddress, ref int lpBuffer, int nSize, ref int lpNumberOfBytesWritten);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        //write
        public static void WriteAddress(string ProcessName, int Address, byte[] data)
        {
            if (ProcessName.EndsWith(".exe"))
            {
                ProcessName = ProcessName.Replace(".exe", "");
            }
            Process[] processesByName = Process.GetProcessesByName(ProcessName);
            if (processesByName.Length == 0)
            {
                //process isn't running
                return;
            }
            IntPtr intPtr = (IntPtr)OpenProcess(127231, 0, processesByName[0].Id);
            if (intPtr == IntPtr.Zero)
            {
                //failed to open process (protected memory)
                return;
            }
            IntPtr bytesout;
            WriteProcessMemory(intPtr, (IntPtr)Address, data, (UIntPtr)data.Length, out bytesout);
        }

        //writing
        public static void WriteInteger(string ProcessName, int Address, int Value, int nsize = 4)
        {
            if (ProcessName.EndsWith(".exe"))
            {
                ProcessName = ProcessName.Replace(".exe", "");
            }
            Process[] processesByName = Process.GetProcessesByName(ProcessName);
            if (processesByName.Length == 0)
            {
                //process isn't running
                return;
            }
            IntPtr intPtr = (IntPtr)OpenProcess(127231, 0, processesByName[0].Id);
            if (intPtr == IntPtr.Zero)
            {
                //failed to open process (protected memory)
                return;
            }
            int handle = (int)intPtr;
            int num = Value;
            int num2 = 0;
            WriteProcessMemory(handle, Address, ref num, nsize, ref num2);
        }

        //reading
        public static int ReadInteger(string ProcessName, int Address, int nsize = 4)
        {
            if (ProcessName.EndsWith(".exe"))
            {
                ProcessName = ProcessName.Replace(".exe", "");
            }
            Process[] processesByName = Process.GetProcessesByName(ProcessName);
            if (processesByName.Length == 0)
            {
                //process isn't running
            }
            else
            {
                IntPtr intPtr = (IntPtr)OpenProcess(127231, 0, processesByName[0].Id);
                if (!(intPtr == IntPtr.Zero))
                {
                    int handle = (int)intPtr;
                    int num = 0;
                    int result = 0;
                    ReadProcessMemory(handle, Address, ref result, nsize, ref num);
                    return result;
                }
                //cannot access
            }
            int result2 = 0;
            return result2;
        }

        public static string ReadString(string ProcessName, int Address, int nsize = 4)
        {
            if (ProcessName.EndsWith(".exe"))
            {
                ProcessName = ProcessName.Replace(".exe", "");
            }
            Process[] processesByName = Process.GetProcessesByName(ProcessName);
            if (processesByName.Length == 0)
            {
                //process isn't running
            }
            else
            {
                IntPtr intPtr = (IntPtr)OpenProcess(127231, 0, processesByName[0].Id);
                if (!(intPtr == IntPtr.Zero))
                {
                    int num = 0;
                    IntPtr based = (IntPtr)Address;
                    byte[] result = new byte[nsize];
                    ReadProcessMemory(intPtr, based, result, nsize, out num);
                    string str;
                    System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                    str = enc.GetString(result);
                    return str;
                }
                //cannot access
            }
            string result2 = "0";
            return result2;
        }
        #endregion

    }
}
