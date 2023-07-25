namespace Color_Fun_Definitive_Edition
{
    partial class OneOfThreeForm
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
            this.colorsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.facePictureBox = new System.Windows.Forms.PictureBox();
            this.colorsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // colorsTableLayoutPanel
            // 
            this.colorsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorsTableLayoutPanel.AutoSize = true;
            this.colorsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorsTableLayoutPanel.ColumnCount = 3;
            this.colorsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.colorsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.colorsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.colorsTableLayoutPanel.Controls.Add(this.pictureBox1, 0, 0);
            this.colorsTableLayoutPanel.Controls.Add(this.pictureBox2, 1, 0);
            this.colorsTableLayoutPanel.Controls.Add(this.pictureBox3, 2, 0);
            this.colorsTableLayoutPanel.Location = new System.Drawing.Point(19, 19);
            this.colorsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.colorsTableLayoutPanel.Name = "colorsTableLayoutPanel";
            this.colorsTableLayoutPanel.RowCount = 1;
            this.colorsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.colorsTableLayoutPanel.Size = new System.Drawing.Size(459, 153);
            this.colorsTableLayoutPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 153);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = 0;
            this.pictureBox1.Click += new System.EventHandler(this.checkTheOption);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(153, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 153);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = 1;
            this.pictureBox2.Click += new System.EventHandler(this.checkTheOption);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(306, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 153);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = 2;
            this.pictureBox3.Click += new System.EventHandler(this.checkTheOption);
            // 
            // helpButton
            // 
            this.helpButton.AutoSize = true;
            this.helpButton.Location = new System.Drawing.Point(19, 180);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(99, 28);
            this.helpButton.TabIndex = 1;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.AutoSize = true;
            this.quitButton.Location = new System.Drawing.Point(19, 215);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(99, 28);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.Location = new System.Drawing.Point(326, 180);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(152, 63);
            this.colorLabel.TabIndex = 3;
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // facePictureBox
            // 
            this.facePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.facePictureBox.Location = new System.Drawing.Point(172, 180);
            this.facePictureBox.Name = "facePictureBox";
            this.facePictureBox.Size = new System.Drawing.Size(152, 63);
            this.facePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.facePictureBox.TabIndex = 4;
            this.facePictureBox.TabStop = false;
            // 
            // OneOfThreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(493, 251);
            this.ControlBox = false;
            this.Controls.Add(this.facePictureBox);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.colorsTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OneOfThreeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Color Fun";
            this.Load += new System.EventHandler(this.OneOfThreeForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OneOfThreeForm_KeyDown);
            this.colorsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel colorsTableLayoutPanel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox facePictureBox;
    }
}