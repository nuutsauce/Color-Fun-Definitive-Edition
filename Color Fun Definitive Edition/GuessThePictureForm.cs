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
    public partial class GuessThePictureForm : Form
    {
        private int index;
        private int[] indexes = new int[3];
        private bool sound;
        private Random rnd;

        public GuessThePictureForm()
        {
            InitializeComponent();
        }

        public GuessThePictureForm(Random rnd, bool sound)
        {
            this.rnd = rnd;
            this.sound = sound;

            List<int> list = Enumerable.Range(0, ColorInfo.listOfColors.Count).ToList();

            index = rnd.Next(0, list.Count);
            indexes[0] = list[index];
            list.RemoveAt(index);

            index = rnd.Next(0, list.Count);
            indexes[1] = list[index];
            list.RemoveAt(index);

            index = rnd.Next(0, list.Count);
            indexes[2] = list[index];
            list.RemoveAt(index);

            index = rnd.Next(0, 3);

            InitializeComponent();

            pictureBox1.Image = ColorInfo.listOfColorImages[indexes[0]];
            pictureBox2.Image = ColorInfo.listOfColorImages[indexes[1]];
            pictureBox3.Image = ColorInfo.listOfColorImages[indexes[2]];

            colorLabel.Text = ColorInfo.listOfColorNames[indexes[index]];

            if (sound)
            {
                Shown += OneOfThree_Shown;
            }
        }

        private void OneOfThree_Shown(Object sender, EventArgs e)
        {
            this.Refresh();

            using (SoundPlayer simpleSound = ColorInfo.THISCOL)
            {
                simpleSound.PlaySync();
            }

            using (SoundPlayer simpleSound = ColorInfo.listOfColorSounds[indexes[index]])
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
            var button = sender as PictureBox;
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

        private void GuessThePictureForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void GuessThePictureForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                checkTheOption(this.pictureBox1, e);
            }
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                checkTheOption(this.pictureBox2, e);
            }
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                checkTheOption(this.pictureBox3, e);
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help\\guess-the-picture.html");
        }
    }
}
