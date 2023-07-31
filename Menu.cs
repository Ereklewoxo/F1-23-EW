namespace F1_Season_2023_Ew
{
    public class Intro
    {
        public static void IntroPressAnyKey()
        {
            Util.ClearKey();
            bool pulse = true;
            int i = 1, windowSize = Console.WindowWidth + Console.WindowHeight;
            var logo = new string[] 
            {
                "       ▄▄████████████████████▀ ▄██████▀",
                "     ▄████▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▄██████▀",
                "   ▄████▀ ▄██████████████▀ ▄██████▀",
                " ▄████▀ ▄████▀▀▀▀▀▀▀▀▀▀▀ ▄██████▀",
                "▀▀▀▀▀  ▀▀▀▀▀            ▀▀▀▀▀▀▀",
                "",
                "      PRESS ANY KEY TO START"
            };
            Console.SetCursorPosition(Console.WindowWidth / 2 - (logo[0].Length / 2 + 4), Console.WindowHeight / 2 - logo.Length);
            while (true)
            {
                for (int j = 0; j < logo.Length; j++)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2 - (logo[0].Length / 2 + 4), Console.WindowHeight / 2 - logo.Length + j);
                    Console.Write($"\x1b[38;2;{i};0;0m" + logo[j]);
                }
                i = pulse ? i + 2 : i - 2;
                pulse = i > 255 || i < 0 ? !pulse : pulse;
                if (Console.KeyAvailable == true)
                    break;
                if (Console.WindowWidth + Console.WindowHeight != windowSize)
                {
                    Util.ClearPart(0);
                    windowSize = Console.WindowWidth + Console.WindowHeight;
                }
                Task.Delay(1).Wait();
            }
            Util.ClearKey();
            Util.ClearPart(0);
        }
        public static void IntroLogo()
        {
            for (int i = 0; i < 256; i += 3)
            {
                Console.Write($"\x1b[38;2;{i};0;0m" +
                "     ______________  __" + '\n' +
                "   /  ____________//  /" + '\n' +
                "  /  /  _________//  /" + '\n' +
                " /__/__/         /__/");
                Console.SetCursorPosition(0, Console.CursorTop - 3);
                Task.Delay(1).Wait();
            }
            var logo = new string[] 
            {
                @"  ___   ____  ___  ____  ",
                @" |__ \ / __ \|__ \ \__ \ ",
                @" / __// /_/ // __//__  / ",
                @"/____/\____//____/____/  " 
            };
            for (int i = logo[0].Length; i > 0; i -= 2)
            {
                for (int j = 0; j < logo.Length; j++)
                {
                    Console.SetCursorPosition(23, j);
                    Console.WriteLine(Colors.Text + logo[j].Remove(logo[j].Length - i, logo[j].Length - (logo[j].Length - i)));
                }
                Console.SetCursorPosition(0, Console.CursorTop - 4);
                Task.Delay(1).Wait();
            }
        }
    }
    public class Display
    {
        public static void Logo()
        {
            string r = Colors.Red, w = Colors.Text;
            Console.WriteLine("" +
                   @$"{r}     ______________  __{w}  ___   ____  ___  ____ " + '\n' +
                   @$"{r}   /  ____________//  /{w} |__ \ / __ \|__ \ \__ \" + '\n' +
                   @$"{r}  /  /  _________//  /{w}  / __// /_/ // __//__  /" + '\n' +
                   @$"{r} /__/__/         /__/{w}  /____/\____//____/____/ " + '\n');
        }
        public static void DifficultyBar(string color)
        {
            for (int i = 0; i < Data.Difficulty; i++)
                Console.Write(color + "▐");
            for (int i = 0; i < 5 - Data.Difficulty; i++)
                Console.Write(Colors.Dark + "▐");
        }
        public static void MenuDefault()
        {
            Console.WriteLine(Colors.Red + "\r      /Quick Race        " + '\n' + Colors.Text + "     /Career Mode                                             \n    /Settings            \n   /Exit Game                                 ");
        }
        public static void MenuReset()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.Text + "\r      /Quick Race                                       \n     /Career Mode                                        \n    /Settings                  \n   /Exit Game                 ");
        }
        public static void QuickRaceSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.Red + "      /Quick Race" + '\n' + Colors.Text + "     /Career Mode\n    /Settings\n   /Exit Game");
        }
        public static void CareerModeSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.Text + "      /Quick Race" + Colors.Red + '\n' + "     /Career Mode" + Colors.Text + '\n' + "    /Settings\n   /Exit Game");
        }
        public static void SettingsSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.Text + "      /Quick Race\n     /Career Mode" + '\n' + Colors.Red + "    /Settings" + '\n' + Colors.Text + "   /Exit Game");
        }
        public static void ExitGameSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.Text + "      /Quick Race\n     /Career Mode\n    /Settings" + '\n' + Colors.Red + "   /Exit Game");
        }
        public static void QuickRaceDefault()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.Write(Colors.Red + "      /Quick Race");
            Menu.MenuAnimOne();
            Console.WriteLine(Colors.Red + "/Start Random Race" + '\n' + Colors.Gray + "     /Career Mode      " + Colors.Text + "/Choose a Circuit" + '\n' + Colors.Gray + "    /Settings\n   /Exit Game");
        }
        public static void StartRandomSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.Red + "      /Quick Race_______/Start Random Race" + '\n' + Colors.Gray + "     /Career Mode      " + Colors.Text + "/Choose a Circuit" + '\n' + Colors.Gray + "    /Settings\n   /Exit Game");
        }
        public static void ChooseCircuitSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.Red + "      /Quick Race_______" + Colors.Text + "/Start Random Race" + '\n' + Colors.Gray + "     /Career Mode      " + Colors.Red + "/Choose a Circuit" + '\n' + Colors.Gray + "    /Settings\n   /Exit Game");
        }
        public static void CareerModeDefault()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.Write(Colors.Text + "      /Quick Race" + '\n' + Colors.Red + "     /Career Mode");
            Menu.MenuAnimTwo();
            Console.WriteLine(Colors.Red + "/New Game" + '\n' + "     /Career Mode___/  " + Colors.Text + "/Load Game" + '\n' + Colors.Gray + "    /Settings\n   /Exit Game");
        }
        public static void NewGameSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            if (CareerMode.ThereIsNoSave())
                Console.WriteLine(Colors.Gray + "      /Quick Race    " + Colors.Red + "___/New Game" + '\n' + "     /Career Mode___/  " + Colors.Gray + "/Load Game" + '\n' + Colors.Gray + "    /Settings\n   /Exit Game");
            else
                Console.WriteLine(Colors.Gray + "      /Quick Race    " + Colors.Red + "___/New Game" + '\n' + "     /Career Mode___/  " + Colors.Text + "/Load Game" + '\n' + Colors.Gray + "    /Settings\n   /Exit Game");
        }
        public static void LoadGameSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.Gray + "      /Quick Race    " + Colors.Red + "___" + Colors.Text + "/New Game" + '\n' + Colors.Red + "     /Career Mode___/  /Load Game" + '\n' + Colors.Gray + "    /Settings\n   /Exit Game");
        }
        public static void SettingsDefault()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.Write(Colors.Text + "      /Quick Race\n     /Career Mode" + '\n' + Colors.Red + "    /Settings");
            Menu.MenuAnimThree();
            Console.WriteLine("/Difficulty" + Colors.Gray + '\n' + "     /Career Mode  " + '\n' + Colors.Red + '/' + '\n' + Colors.Gray + "   /Exit Game");
        }
        public static void DifficultySelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.Write(Colors.Gray + "      /Quick Race   " + Colors.Red + "____/Difficulty");
            DifficultyBar(Colors.Red);
            Console.WriteLine('\n' + Colors.Gray + "     /Career Mode  " + Colors.Red + '/' + Colors.Text + "   /Change User Data" + '\n' + Colors.Red + "    /Settings" + '\n' + Colors.Gray + "   /Exit Game");
        }
        public static void ChangeUserDataSelected()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.Gray + "      /Quick Race   " + Colors.Red + "____" + Colors.Text + "/Difficulty               " + '\n' + Colors.Gray + "     /Career Mode  " + Colors.Red + '/' + "   /Change User Data" + '\n' + "    /Settings" + '\n' + Colors.Gray + "   /Exit Game");
        }
        public static void ChangeingUserData()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 4);
            Console.WriteLine(Colors.Gray + "      /Quick Race   " + Colors.Red + "____" + Colors.Gray + "/Difficulty               " + '\n' + "     /Career Mode  " + Colors.Red + '/' + "   /Change User Data");
            Menu.MenuAnimFour();
        }
    }
    public class Menu
    {
        private static readonly int AnimSpeed = 30;
        public static void MenuAnimOne()
        {
            Console.Write(Colors.Red);
            for (int i = 0; i < 7; i++)
            {
                Console.Write("_");
                Task.Delay(AnimSpeed).Wait();
            }
        }
        public static void MenuAnimTwo()
        {
            Console.Write(Colors.Red);
            for (int i = 0; i < 7; i++)
            {
                if (i is 3)
                {
                    Console.Write("/");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(Colors.Text + "      /Quick Race    " + Colors.Red);
                }
                else
                    Console.Write("_");
                if (i is 6)
                    Console.Write(Colors.Text + "\r      /Quick Race    " + Colors.Red + "___");
                Task.Delay(AnimSpeed).Wait();
            }
        }
        public static void MenuAnimThree()
        {
            Console.Write(Colors.Red);
            for (int i = 0; i < 11; i++)
            {
                if (i is 5)
                {
                    Console.Write("/");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }
                else if (i is 6)
                {
                    Console.Write(Colors.Text + "     /Career Mode  " + Colors.Red + '/');
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }
                else if (i is 7)
                    Console.Write(Colors.Text + "      /Quick Race   " + Colors.Red + '_');
                else
                    Console.Write("_");
                Task.Delay(AnimSpeed).Wait();
            }
        }
        public static void MenuAnimFour()
        {
            Console.Write(Colors.Red + "    /Settings_____/   /" + '\n' + Colors.Gray + "   /Exit Game        ");
            Task.Delay(AnimSpeed).Wait();
            Console.WriteLine(Colors.Red + '/');
            Task.Delay(AnimSpeed).Wait();
            Console.Write("                    /" + Colors.Text);
            Task.Delay(AnimSpeed).Wait();
        }
        public static void MenuAnimFourClear()
        {
            Console.WriteLine(Colors.Red + "    /Settings_____/                   " + '\n' + Colors.Gray + "   /Exit Game                         " + Colors.Text);
        }
        public static short MainMenu()
        {
            ConsoleKeyInfo key;
            short outcome = 4;
            int selMenu = 0, selMenuQuick = 0, selMenuCarrer = 0, selMenuSettings = 0;
            bool firstTime = true;
            Display.MenuDefault();
            key = Console.ReadKey(true);
            do
            {
                Display.MenuReset();
                do
                {
                    while (selMenu is 0)
                    {
                        Display.QuickRaceSelected();
                        if (firstTime is false)
                        {
                            Util.ClearKey();
                            key = Console.ReadKey(true);
                        }
                        firstTime = false;
                        if (key.Key is ConsoleKey.DownArrow or ConsoleKey.S)
                            selMenu = 1;
                        else if (key.Key is ConsoleKey.Enter)
                            break;
                    }
                    while (selMenu is 1)
                    {
                        Display.CareerModeSelected();
                        Util.ClearKey();
                        key = Console.ReadKey(true);
                        if (key.Key is ConsoleKey.DownArrow or ConsoleKey.S)
                            selMenu = 2;
                        else if (key.Key is ConsoleKey.UpArrow or ConsoleKey.W)
                            selMenu = 0;
                        else if (key.Key is ConsoleKey.Enter)
                            break;
                    }
                    while (selMenu is 2)
                    {
                        Display.SettingsSelected();
                        Util.ClearKey();
                        key = Console.ReadKey(true);
                        if (key.Key is ConsoleKey.UpArrow or ConsoleKey.W)
                            selMenu = 1;
                        else if (key.Key is ConsoleKey.DownArrow or ConsoleKey.S)
                            selMenu = 3;
                        else if (key.Key is ConsoleKey.Enter)
                            break;
                    }
                    while (selMenu is 3)
                    {
                        Display.ExitGameSelected();
                        Util.ClearKey();
                        key = Console.ReadKey(true);
                        if (key.Key is ConsoleKey.UpArrow or ConsoleKey.W)
                            selMenu = 2;
                        else if (key.Key is ConsoleKey.Enter)
                            break;
                    }
                } while (key.Key is not ConsoleKey.Enter);
                while (selMenu is 0)
                {
                    while (selMenuQuick is 0)
                    {
                        Display.QuickRaceDefault();
                        selMenuQuick = 1;
                    }
                    while (selMenuQuick is 1)
                    {
                        Display.StartRandomSelected();
                        Util.ClearKey();
                        key = Console.ReadKey(true);
                        if (key.Key is ConsoleKey.DownArrow or ConsoleKey.S)
                            selMenuQuick = 2;
                        else if (key.Key is ConsoleKey.Escape)
                            break;
                        else if (key.Key is ConsoleKey.Enter)
                        {
                            outcome = 0;
                            break;
                        }
                    }
                    while (selMenuQuick is 2)
                    {
                        Display.ChooseCircuitSelected();
                        Util.ClearKey();
                        key = Console.ReadKey(true);
                        if (key.Key is ConsoleKey.UpArrow or ConsoleKey.W)
                            selMenuQuick = 1;
                        else if (key.Key is ConsoleKey.Escape)
                            break;
                        else if (key.Key is ConsoleKey.Enter)
                        {
                            outcome = 1;
                            break;
                        }
                    }
                    if (key.Key is ConsoleKey.Escape)
                    {
                        selMenuQuick = 0;
                        break;
                    }
                    else if (key.Key is ConsoleKey.Enter)
                        break;
                }
                while (selMenu is 1)
                {
                    while (selMenuCarrer is 0)
                    {
                        Display.CareerModeDefault();
                        selMenuCarrer = 1;
                    }
                    while (selMenuCarrer is 1)
                    {
                        Display.NewGameSelected();
                        Util.ClearKey();
                        key = Console.ReadKey(true);
                        if ((key.Key is ConsoleKey.DownArrow or ConsoleKey.S) && !CareerMode.ThereIsNoSave())
                            selMenuCarrer = 2;
                        else if (key.Key is ConsoleKey.Escape)
                            break;
                        else if (key.Key is ConsoleKey.Enter)
                        {
                            outcome = 2;
                            break;
                        }
                    }
                    while (selMenuCarrer is 2)
                    {
                        Display.LoadGameSelected();
                        Util.ClearKey();
                        key = Console.ReadKey(true);
                        if (key.Key is ConsoleKey.UpArrow or ConsoleKey.W)
                            selMenuCarrer = 1;
                        else if (key.Key is ConsoleKey.Escape)
                            break;
                        else if (key.Key is ConsoleKey.Enter)
                        {
                            outcome = 3;
                            break;
                        }
                    }
                    if (key.Key is ConsoleKey.Escape)
                    {
                        selMenuCarrer = 0;
                        break;
                    }
                    else if (key.Key is ConsoleKey.Enter)
                        break;
                }
                while (selMenu is 2)
                {
                    while (selMenuSettings is 0)
                    {
                        Display.SettingsDefault();
                        selMenuSettings = 1;
                    }
                    while (selMenuSettings is 1)
                    {
                        Display.DifficultySelected();
                        Util.ClearKey();
                        key = Console.ReadKey(true);
                        if (key.Key is ConsoleKey.LeftArrow or ConsoleKey.A)
                        { Data.Difficulty = Math.Max(Data.Difficulty - 1, 1); Data.SaveDifficulty(); }
                        else if (key.Key is ConsoleKey.RightArrow or ConsoleKey.D)
                        { Data.Difficulty = Math.Min(Data.Difficulty + 1, 5); Data.SaveDifficulty(); }
                        else if (key.Key is ConsoleKey.DownArrow or ConsoleKey.S)
                            selMenuSettings = 2;
                        else if (key.Key is ConsoleKey.Escape)
                            break;
                        else if (key.Key is ConsoleKey.Enter)
                            break;
                    }
                    while (selMenuSettings is 2)
                    {
                        Display.ChangeUserDataSelected();
                        Util.ClearKey();
                        key = Console.ReadKey(true);
                        if (key.Key is ConsoleKey.UpArrow or ConsoleKey.W)
                            selMenuSettings = 1;
                        else if (key.Key is ConsoleKey.Escape)
                            break;
                        else if (key.Key is ConsoleKey.Enter)
                        {
                            Data data = new()
                            { ChangeUserData = true };
                            Display.ChangeingUserData();
                            data.UserData();
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            Console.WriteLine("" +
                                "                                                                       \n" +
                                "                                                                       \n" +
                                "                                                                       \n" +
                                "                                                                       \n" +
                                "                                                                       ");
                            data.ChangeUserData = false;
                            Console.SetCursorPosition(0, Console.CursorTop - 7);
                            MenuAnimFourClear();
                            break;
                        }
                    }
                    if (key.Key is ConsoleKey.Escape)
                    {
                        selMenuSettings = 0;
                        break;
                    }
                }
                if (selMenu is 3)
                    break;
            } while (outcome > 3);
            return outcome;
        }
    }
}