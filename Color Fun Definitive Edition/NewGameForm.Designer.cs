namespace Color_Fun_Definitive_Edition
{
    partial class NewGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newGameTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.selectGameGroupBox = new System.Windows.Forms.GroupBox();
            this.guessThePictureRadioButton = new System.Windows.Forms.RadioButton();
            this.oneOfThreeRadioButton = new System.Windows.Forms.RadioButton();
            this.pushTheColorRadioButton = new System.Windows.Forms.RadioButton();
            this.selectTheColorRadioButton = new System.Windows.Forms.RadioButton();
            this.timesGroupBox = new System.Windows.Forms.GroupBox();
            this.twentyRadioButton = new System.Windows.Forms.RadioButton();
            this.fifteenRadioButton = new System.Windows.Forms.RadioButton();
            this.tenRadioButton = new System.Windows.Forms.RadioButton();
            this.fiveRadioButton = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.newGameTableLayoutPanel.SuspendLayout();
            this.selectGameGroupBox.SuspendLayout();
            this.timesGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newGameTableLayoutPanel
            // 
            this.newGameTableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newGameTableLayoutPanel.ColumnCount = 2;
            this.newGameTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.02594F));
            this.newGameTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.97406F));
            this.newGameTableLayoutPanel.Controls.Add(this.selectGameGroupBox, 0, 0);
            this.newGameTableLayoutPanel.Controls.Add(this.timesGroupBox, 1, 0);
            this.newGameTableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.newGameTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newGameTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGameTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.newGameTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.newGameTableLayoutPanel.Name = "newGameTableLayoutPanel";
            this.newGameTableLayoutPanel.RowCount = 2;
            this.newGameTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.35294F));
            this.newGameTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.64706F));
            this.newGameTableLayoutPanel.Size = new System.Drawing.Size(347, 170);
            this.newGameTableLayoutPanel.TabIndex = 0;
            // 
            // selectGameGroupBox
            // 
            this.selectGameGroupBox.Controls.Add(this.guessThePictureRadioButton);
            this.selectGameGroupBox.Controls.Add(this.oneOfThreeRadioButton);
            this.selectGameGroupBox.Controls.Add(this.pushTheColorRadioButton);
            this.selectGameGroupBox.Controls.Add(this.selectTheColorRadioButton);
            this.selectGameGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectGameGroupBox.Location = new System.Drawing.Point(4, 4);
            this.selectGameGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectGameGroupBox.Name = "selectGameGroupBox";
            this.selectGameGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.selectGameGroupBox.Size = new System.Drawing.Size(176, 115);
            this.selectGameGroupBox.TabIndex = 0;
            this.selectGameGroupBox.TabStop = false;
            this.selectGameGroupBox.Text = "&Select game";
            // 
            // guessThePictureRadioButton
            // 
            this.guessThePictureRadioButton.AutoSize = true;
            this.guessThePictureRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.guessThePictureRadioButton.Location = new System.Drawing.Point(4, 87);
            this.guessThePictureRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.guessThePictureRadioButton.Name = "guessThePictureRadioButton";
            this.guessThePictureRadioButton.Size = new System.Drawing.Size(168, 22);
            this.guessThePictureRadioButton.TabIndex = 3;
            this.guessThePictureRadioButton.Tag = "GuessThePicture";
            this.guessThePictureRadioButton.Text = "Guess the picture";
            this.guessThePictureRadioButton.UseVisualStyleBackColor = true;
            // 
            // oneOfThreeRadioButton
            // 
            this.oneOfThreeRadioButton.AutoSize = true;
            this.oneOfThreeRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.oneOfThreeRadioButton.Location = new System.Drawing.Point(4, 65);
            this.oneOfThreeRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.oneOfThreeRadioButton.Name = "oneOfThreeRadioButton";
            this.oneOfThreeRadioButton.Size = new System.Drawing.Size(168, 22);
            this.oneOfThreeRadioButton.TabIndex = 2;
            this.oneOfThreeRadioButton.Tag = "OneOfThree";
            this.oneOfThreeRadioButton.Text = "One of three";
            this.oneOfThreeRadioButton.UseVisualStyleBackColor = true;
            // 
            // pushTheColorRadioButton
            // 
            this.pushTheColorRadioButton.AutoSize = true;
            this.pushTheColorRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pushTheColorRadioButton.Location = new System.Drawing.Point(4, 43);
            this.pushTheColorRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.pushTheColorRadioButton.Name = "pushTheColorRadioButton";
            this.pushTheColorRadioButton.Size = new System.Drawing.Size(168, 22);
            this.pushTheColorRadioButton.TabIndex = 1;
            this.pushTheColorRadioButton.Tag = "PushTheColor";
            this.pushTheColorRadioButton.Text = "Push the color";
            this.pushTheColorRadioButton.UseVisualStyleBackColor = true;
            // 
            // selectTheColorRadioButton
            // 
            this.selectTheColorRadioButton.AutoSize = true;
            this.selectTheColorRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectTheColorRadioButton.Location = new System.Drawing.Point(4, 21);
            this.selectTheColorRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectTheColorRadioButton.Name = "selectTheColorRadioButton";
            this.selectTheColorRadioButton.Size = new System.Drawing.Size(168, 22);
            this.selectTheColorRadioButton.TabIndex = 0;
            this.selectTheColorRadioButton.Tag = "SelectTheColor";
            this.selectTheColorRadioButton.Text = "Select the color";
            this.selectTheColorRadioButton.UseVisualStyleBackColor = true;
            // 
            // timesGroupBox
            // 
            this.timesGroupBox.Controls.Add(this.twentyRadioButton);
            this.timesGroupBox.Controls.Add(this.fifteenRadioButton);
            this.timesGroupBox.Controls.Add(this.tenRadioButton);
            this.timesGroupBox.Controls.Add(this.fiveRadioButton);
            this.timesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timesGroupBox.Location = new System.Drawing.Point(188, 4);
            this.timesGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.timesGroupBox.Name = "timesGroupBox";
            this.timesGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.timesGroupBox.Size = new System.Drawing.Size(155, 115);
            this.timesGroupBox.TabIndex = 1;
            this.timesGroupBox.TabStop = false;
            this.timesGroupBox.Text = "&Times";
            // 
            // twentyRadioButton
            // 
            this.twentyRadioButton.AutoSize = true;
            this.twentyRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.twentyRadioButton.Location = new System.Drawing.Point(4, 87);
            this.twentyRadioButton.Name = "twentyRadioButton";
            this.twentyRadioButton.Size = new System.Drawing.Size(147, 22);
            this.twentyRadioButton.TabIndex = 3;
            this.twentyRadioButton.Tag = "Twenty";
            this.twentyRadioButton.Text = "Twenty";
            this.twentyRadioButton.UseVisualStyleBackColor = true;
            // 
            // fifteenRadioButton
            // 
            this.fifteenRadioButton.AutoSize = true;
            this.fifteenRadioButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.fifteenRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.fifteenRadioButton.Location = new System.Drawing.Point(4, 65);
            this.fifteenRadioButton.Name = "fifteenRadioButton";
            this.fifteenRadioButton.Size = new System.Drawing.Size(147, 22);
            this.fifteenRadioButton.TabIndex = 2;
            this.fifteenRadioButton.Tag = "Fifteen";
            this.fifteenRadioButton.Text = "Fifteen";
            this.fifteenRadioButton.UseVisualStyleBackColor = true;
            // 
            // tenRadioButton
            // 
            this.tenRadioButton.AutoSize = true;
            this.tenRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.tenRadioButton.Location = new System.Drawing.Point(4, 43);
            this.tenRadioButton.Name = "tenRadioButton";
            this.tenRadioButton.Size = new System.Drawing.Size(147, 22);
            this.tenRadioButton.TabIndex = 1;
            this.tenRadioButton.Tag = "Ten";
            this.tenRadioButton.Text = "Ten";
            this.tenRadioButton.UseVisualStyleBackColor = true;
            // 
            // fiveRadioButton
            // 
            this.fiveRadioButton.AutoSize = true;
            this.fiveRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.fiveRadioButton.Location = new System.Drawing.Point(4, 21);
            this.fiveRadioButton.Name = "fiveRadioButton";
            this.fiveRadioButton.Size = new System.Drawing.Size(147, 22);
            this.fiveRadioButton.TabIndex = 0;
            this.fiveRadioButton.Tag = "Five";
            this.fiveRadioButton.Text = "Five";
            this.fiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.newGameTableLayoutPanel.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.okButton);
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.Controls.Add(this.helpButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 127);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(339, 39);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.AutoSize = true;
            this.okButton.Location = new System.Drawing.Point(10, 3);
            this.okButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(93, 28);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Location = new System.Drawing.Point(123, 3);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 28);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.AutoSize = true;
            this.helpButton.Location = new System.Drawing.Point(236, 3);
            this.helpButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 5);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(93, 28);
            this.helpButton.TabIndex = 2;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 170);
            this.Controls.Add(this.newGameTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewGameForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game New";
            this.Load += new System.EventHandler(this.NewGameForm_Load);
            this.newGameTableLayoutPanel.ResumeLayout(false);
            this.selectGameGroupBox.ResumeLayout(false);
            this.selectGameGroupBox.PerformLayout();
            this.timesGroupBox.ResumeLayout(false);
            this.timesGroupBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel newGameTableLayoutPanel;
        private System.Windows.Forms.GroupBox selectGameGroupBox;
        private System.Windows.Forms.GroupBox timesGroupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton selectTheColorRadioButton;
        private System.Windows.Forms.RadioButton guessThePictureRadioButton;
        private System.Windows.Forms.RadioButton oneOfThreeRadioButton;
        private System.Windows.Forms.RadioButton pushTheColorRadioButton;
        private System.Windows.Forms.RadioButton twentyRadioButton;
        private System.Windows.Forms.RadioButton fifteenRadioButton;
        private System.Windows.Forms.RadioButton tenRadioButton;
        private System.Windows.Forms.RadioButton fiveRadioButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button helpButton;
    }
}