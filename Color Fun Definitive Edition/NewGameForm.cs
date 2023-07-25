using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Fun_Definitive_Edition
{
    public partial class NewGameForm : Form
    {
        GameInfo gameInfo;

        public NewGameForm()
        {
            InitializeComponent();
        }

        private void checkRadioButtons(string lastCheckedGameTag, string lastCheckedTimesTag)
        {
            if ((string) selectTheColorRadioButton.Tag == lastCheckedGameTag) selectTheColorRadioButton.Checked = true;
            if ((string) pushTheColorRadioButton.Tag == lastCheckedGameTag) pushTheColorRadioButton.Checked = true;
            if ((string) oneOfThreeRadioButton.Tag == lastCheckedGameTag) oneOfThreeRadioButton.Checked = true;
            if ((string) guessThePictureRadioButton.Tag == lastCheckedGameTag) guessThePictureRadioButton.Checked = true;

            if ((string) fiveRadioButton.Tag == lastCheckedTimesTag) fiveRadioButton.Checked = true;
            if ((string) tenRadioButton.Tag == lastCheckedTimesTag) tenRadioButton.Checked = true;
            if ((string) fifteenRadioButton.Tag == lastCheckedTimesTag) fifteenRadioButton.Checked = true;
            if ((string) twentyRadioButton.Tag == lastCheckedTimesTag) twentyRadioButton.Checked = true;
        }

        public NewGameForm(GameInfo gameInfo, GameName lastCheckedGameTag, Times lastCheckedTimesTag)
        {
            this.gameInfo = gameInfo;

            InitializeComponent();

            checkRadioButtons(lastCheckedGameTag.ToString(), lastCheckedTimesTag.ToString());
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.gameInfo.gameName = selectedGame();
            this.gameInfo.amountOfTimes = selectedTimes(); 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private GameName selectedGame()
        {
            if (selectTheColorRadioButton.Checked) return GameName.SelectTheColor;
            if (pushTheColorRadioButton.Checked) return GameName.PushTheColor;
            if (oneOfThreeRadioButton.Checked) return GameName.OneOfThree;
            if (guessThePictureRadioButton.Checked) return GameName.GuessThePicture;

            return GameName.SelectTheColor;
        }

        private Times selectedTimes()
        {
            if (fiveRadioButton.Checked) return Times.Five;
            if (tenRadioButton.Checked) return Times.Ten;
            if (fifteenRadioButton.Checked) return Times.Fifteen;
            if (twentyRadioButton.Checked) return Times.Twenty; 

            return Times.Ten;
        }

        private void NewGameForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help\\game-new.html");
        }
    }
}
