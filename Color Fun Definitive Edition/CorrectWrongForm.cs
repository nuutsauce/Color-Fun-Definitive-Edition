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
    public partial class CorrectWrongForm : Form
    {
        public CorrectWrongForm()
        {
            InitializeComponent();
        }

        public CorrectWrongForm(bool thing)
        {
            InitializeComponent();
            if (thing)
            {
                correctWrongLabel.Text = "Correct";
                facePictureBox.Image = ColorInfo.correct;
            }
            else
            {
                correctWrongLabel.Text = "Wrong";
                facePictureBox.Image = ColorInfo.wrong;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
