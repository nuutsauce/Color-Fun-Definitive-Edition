using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Fun_Definitive_Edition
{
    public partial class ResultsForm : Form
    {
        private int percentage;

        public ResultsForm()
        {
            InitializeComponent();
        }

        public ResultsForm(GameInfo gameInfo, bool sound)
        {
            percentage = gameInfo.timesPast != 0 ? gameInfo.correctAnswers * 100 / gameInfo.timesPast : 0;

            InitializeComponent();

            resultsLabel.Text = $"You got {gameInfo.correctAnswers} out of {gameInfo.timesPast}";
            percentageLabel.Text = percentage.ToString();

            if (sound)
            {
                Shown += Results_Shown;
            }
        }

        private void Results_Shown(Object sender, EventArgs e)
        {
            this.Refresh();

            if (percentage > 80)
            {
                using (SoundPlayer simpleSound = ColorInfo.EXCEL)
                {
                    simpleSound.PlaySync();
                }
                return;
            }

            if (percentage > 70)
            {
                using (SoundPlayer simpleSound = ColorInfo.VERYGOOD)
                {
                    simpleSound.PlaySync();
                }
                return;
            }

            using (SoundPlayer simpleSound = ColorInfo.WORK)
            {
                simpleSound.PlaySync();
            }
            return;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
