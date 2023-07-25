using Color_Fun_Definitive_Edition.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Color_Fun_Definitive_Edition
{
    public partial class ColorFunMenu : Form
    {
        // this two colors need for gradient
        private Color color1;
        private Color color2;
        // info about last games (default first game, 10 times)
        public GameName lastCheckedGameTag = GameName.SelectTheColor;
        public Times lastCheckedTimesTag = Times.Ten;
        // random number generetao (need for colorful background and logic in game modes)
        public Random rnd = new Random();
        // check secrets
        private string secretString = "";

        public ColorFunMenu()
        {
            List<Color> backColors = new List<Color>() {Color.FromArgb(255, 0, 255), Color.Red,
                Color.Yellow, Color.Blue, Color.Cyan, Color.Green, Color.Black};

            int index = rnd.Next(0, backColors.Count);
            color1 = backColors[index];
            backColors.RemoveAt(index);
            color2 = backColors[rnd.Next(0, backColors.Count)];

            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // MenuStrip overlaps background            sad :(
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       color1,
                                                                       color2,
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameInfo gameInfo = new GameInfo();

            if (!skipSetupToolStripMenuItem.Checked)
            {
                using (var form = new NewGameForm(gameInfo, this.lastCheckedGameTag, this.lastCheckedTimesTag))
                {
                    var result = form.ShowDialog();
                    form.Dispose();
                    if (result != DialogResult.OK) return;
                }
                lastCheckedGameTag = gameInfo.gameName;
                lastCheckedTimesTag = gameInfo.amountOfTimes;
            }
            else
            {
                gameInfo.gameName = lastCheckedGameTag;
                gameInfo.amountOfTimes = lastCheckedTimesTag;
            }

            List<Func<DialogResult>> gameModesForms = new List<Func<DialogResult>>() 
            { 
                Action1, Action2, Action3, Action4
            };

            Func<DialogResult> gameModeForm = gameModesForms[(int) gameInfo.gameName];

            for (int i = 0; i < (int) gameInfo.amountOfTimes; i++)
            {
                DialogResult result = gameModeForm();
                if (result == DialogResult.Yes)
                {
                    gameInfo.correctAnswers++;
                    gameInfo.timesPast++;
                    continue;
                }
                if (result == DialogResult.No)
                {
                    gameInfo.timesPast++;
                    continue;
                }
                break;
            }

            using (var form = new ResultsForm(gameInfo, soundToolStripMenuItem.Checked))
            {
                form.ShowDialog();
                form.Dispose();
            }
        }

        private DialogResult Action1()
        {
            using (var form = new SelectTheColorForm(rnd, soundToolStripMenuItem.Checked))
            {
                return form.ShowDialog();
            }
        }

        private DialogResult Action2()
        {
            using (var form = new PushTheColorForm(rnd, soundToolStripMenuItem.Checked))
            {
                return form.ShowDialog();
            }
        }

        private DialogResult Action3()
        {
            using (var form = new OneOfThreeForm(rnd, soundToolStripMenuItem.Checked))
            {
                return form.ShowDialog();
            }
        }

        private DialogResult Action4()
        {
            using (var form = new GuessThePictureForm(rnd, soundToolStripMenuItem.Checked))
            {
                return form.ShowDialog();
            }
        }

        private void ColorFunMenu_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void ColorFunMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.G)
            {
                newGameToolStripMenuItem.PerformClick();
            }
        }

        private void ColorFunMenu_KeyUp(object sender, KeyEventArgs e)
        {
            secretString += e.KeyCode.ToString();

            if (secretString.Length >= 4)
            {
                if (secretString.Contains("JOEL"))
                {
                    secretString = "";

                    ColorInfo.Update("mods\\joel\\");

                    joelFacePictureBox.Visible = true;
                    joelFacePictureBox.Refresh();

                    logoPictureBox.Image = Resources.logo2;
                    logoPictureBox.Refresh();

                    if (soundToolStripMenuItem.Checked)
                    {
                        SoundPlayer jj = new SoundPlayer(Properties.Resources.JOEL);
                        jj.PlaySync();
                    }
                }
                else
                {
                    secretString = secretString.Remove(0, secretString.Length - 3);
                }
            }
        }

        private void indexToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help\\index.html");
        }

        private void commandsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help\\commands.html");
        }

        private void secret()
        {
            joelFacePictureBox.Visible = true;
        }

        // if we will have problem with Gradient
        //private void Form1_Resize(object sender, EventArgs e)
        //{
        //    this.Invalidate();
        //}
    }
}
