using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Fun_Definitive_Edition
{
    public enum GameName
    {
        SelectTheColor,
        PushTheColor,
        OneOfThree,
        GuessThePicture
    }

    public enum Times
    {
        Five = 5,
        Ten = 10,
        Fifteen = 15,
        Twenty = 20
    }

    public static class ColorInfo
    {
        public static List<string> listOfColorNames;

        public static List<Color> listOfColors = new List<Color>()
        {
            Color.Black, Color.Blue, Color.Gray, Color.Green, 
            Color.Purple, Color.Red, Color.White, Color.Yellow
        };

        public static List<SoundPlayer> listOfColorSounds;

        public static List<Image> listOfColorImages;

        public static Image correct;
        public static Image wrong;
        public static SoundPlayer BLAH;
        public static SoundPlayer CORRECT;
        public static SoundPlayer EXCEL;
        public static SoundPlayer THISCOL;
        public static SoundPlayer VERYGOOD;
        public static SoundPlayer WORK;
        public static SoundPlayer WRONG;
        public static SoundPlayer YA;

        public static void Update(string mode)
        {
            correct = Image.FromFile(mode + "images\\CORRECT.png");
            wrong = Image.FromFile(mode + "images\\WRONG.png");

            BLAH = new SoundPlayer(mode + "sounds\\BLAH.WAV");
            CORRECT = new SoundPlayer(mode + "sounds\\CORRECT.WAV");
            EXCEL = new SoundPlayer(mode + "sounds\\EXCEL.WAV");
            THISCOL = new SoundPlayer(mode + "sounds\\THISCOL.WAV");
            VERYGOOD = new SoundPlayer(mode + "sounds\\VERYGOOD.WAV");
            WORK = new SoundPlayer(mode + "sounds\\WORK.WAV");
            WRONG = new SoundPlayer(mode + "sounds\\WRONG.WAV");
            YA = new SoundPlayer(mode + "sounds\\YA.WAV");

            listOfColorImages = new List<Image>()
            {
                Image.FromFile(mode + "images\\BLACK.png"),
                Image.FromFile(mode + "images\\BLUE.png"),
                Image.FromFile(mode + "images\\GRAY.png"),
                Image.FromFile(mode + "images\\GREEN.png"),
                Image.FromFile(mode + "images\\PURPLE.png"),
                Image.FromFile(mode + "images\\RED.png"),
                Image.FromFile(mode + "images\\WHITE.png"),
                Image.FromFile(mode + "images\\YELLOW.png")
            };

            listOfColorSounds = new List<SoundPlayer>()
            {
                new SoundPlayer(mode + "sounds\\BLACK.WAV"),
                new SoundPlayer(mode + "sounds\\BLUE.WAV"),
                new SoundPlayer(mode + "sounds\\GRAY.WAV"),
                new SoundPlayer(mode + "sounds\\GREEN.WAV"),
                new SoundPlayer(mode + "sounds\\PURPLE.WAV"),
                new SoundPlayer(mode + "sounds\\RED.WAV"),
                new SoundPlayer(mode + "sounds\\WHITE.WAV"),
                new SoundPlayer(mode + "sounds\\YELLOW.WAV")
            };

            if (mode == "")
            {
                listOfColorNames = new List<string>()
                {
                    "Black", "Blue", "Gray", "Green", "Purple", "Red", "White", "Yellow"
                };
            }
            else 
            {
                listOfColorNames = new List<string>()
                {
                    "BlAch", "BlU", "Graaa", "Grin", "Pulpl", "RED", "Whute", "Yelaw"
                };
            }
        }
    }

    public partial class GameInfo
    {
        public GameName gameName = GameName.SelectTheColor;
        public Times amountOfTimes = Times.Ten;
        public int correctAnswers = 0;
        public int timesPast = 0;
    }

    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ColorInfo.Update("");

            Application.Run(new ColorFunMenu());
        }
    }
}
