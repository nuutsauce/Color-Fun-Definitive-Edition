using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Fun_Definitive_Edition
{
    public partial class SelectTheColorForm : Form
    {
        private int index = 0;
        private bool sound;
        private Random rnd;

        public SelectTheColorForm()
        {
            InitializeComponent();
        }

        public SelectTheColorForm(Random rnd, bool sound)
        {
            this.rnd = rnd;
            index = rnd.Next(0, ColorInfo.listOfColors.Count);
            this.sound = sound;

            InitializeComponent();

            radioButton1.Text = ColorInfo.listOfColorNames[0];
            radioButton2.Text = ColorInfo.listOfColorNames[1];
            radioButton3.Text = ColorInfo.listOfColorNames[2];
            radioButton4.Text = ColorInfo.listOfColorNames[3];
            radioButton5.Text = ColorInfo.listOfColorNames[4];
            radioButton6.Text = ColorInfo.listOfColorNames[5];
            radioButton7.Text = ColorInfo.listOfColorNames[6];
            radioButton8.Text = ColorInfo.listOfColorNames[7];

            colorPictureBox.BackColor = ColorInfo.listOfColors[index];
            if (sound)
            {
                Shown += SelectTheColor_Shown;
            }
        }

        private void SelectTheColor_Shown(Object sender, EventArgs e)
        {


            this.Refresh();

            using (SoundPlayer simpleSound = ColorInfo.THISCOL)
            {
                simpleSound.PlaySync();
            }

            using (SoundPlayer simpleSound = ColorInfo.listOfColorSounds[index])
            {
                simpleSound.PlaySync();
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkTheOption(object sender, EventArgs e)
        {
            var button = sender as RadioButton;
            int option = (int)button.Tag;

            if (option == index)
            {
                this.facePictureBox.Image = ColorInfo.correct;
                this.DialogResult = DialogResult.Yes;
            }
            else 
            {
                this.facePictureBox.Image = ColorInfo.wrong;
                this.DialogResult = DialogResult.No;
            }

            this.facePictureBox.Refresh();

            if (sound)
            {
                int number = rnd.Next(0, 2);
                if (option == index)
                {
                    if (number == 0)
                    {
                        using (SoundPlayer simpleSound = ColorInfo.CORRECT)
                        {
                            simpleSound.PlaySync();
                        }
                    }
                    else
                    {
                        using (SoundPlayer simpleSound = ColorInfo.YA)
                        {
                            simpleSound.PlaySync();
                        }
                    }
                }
                else
                {
                    if (number == 0)
                    {
                        using (SoundPlayer simpleSound = ColorInfo.WRONG)
                        {
                            simpleSound.PlaySync();
                        }
                    }
                    else
                    {
                        using (SoundPlayer simpleSound = ColorInfo.BLAH)
                        {
                            simpleSound.PlaySync();
                        }
                    }
                }
            }
            else
            {
                using (var form = new CorrectWrongForm(option == index))
                {
                    form.ShowDialog();
                    form.Dispose();
                }
            }

            this.Close();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help\\select-the-color.html");
        }
    }
}
