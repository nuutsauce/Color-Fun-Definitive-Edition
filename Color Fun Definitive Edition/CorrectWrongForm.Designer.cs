namespace Color_Fun_Definitive_Edition
{
    partial class CorrectWrongForm
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
            this.correctWrongTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.facePictureBox = new System.Windows.Forms.PictureBox();
            this.okButton = new System.Windows.Forms.Button();
            this.correctWrongLabel = new System.Windows.Forms.Label();
            this.correctWrongTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // correctWrongTableLayoutPanel
            // 
            this.correctWrongTableLayoutPanel.ColumnCount = 2;
            this.correctWrongTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.correctWrongTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.correctWrongTableLayoutPanel.Controls.Add(this.facePictureBox, 0, 0);
            this.correctWrongTableLayoutPanel.Controls.Add(this.okButton, 1, 0);
            this.correctWrongTableLayoutPanel.Controls.Add(this.correctWrongLabel, 1, 1);
            this.correctWrongTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.correctWrongTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.correctWrongTableLayoutPanel.Name = "correctWrongTableLayoutPanel";
            this.correctWrongTableLayoutPanel.RowCount = 2;
            this.correctWrongTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.correctWrongTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.correctWrongTableLayoutPanel.Size = new System.Drawing.Size(380, 157);
            this.correctWrongTableLayoutPanel.TabIndex = 0;
            // 
            // facePictureBox
            // 
            this.facePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facePictureBox.Location = new System.Drawing.Point(3, 3);
            this.facePictureBox.Name = "facePictureBox";
            this.correctWrongTableLayoutPanel.SetRowSpan(this.facePictureBox, 2);
            this.facePictureBox.Size = new System.Drawing.Size(184, 151);
            this.facePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.facePictureBox.TabIndex = 0;
            this.facePictureBox.TabStop = false;
            this.facePictureBox.WaitOnLoad = true;
            // 
            // okButton
            // 
            this.okButton.AutoSize = true;
            this.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.okButton.Location = new System.Drawing.Point(190, 10);
            this.okButton.Margin = new System.Windows.Forms.Padding(0, 10, 20, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(170, 28);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // correctWrongLabel
            // 
            this.correctWrongLabel.AutoSize = true;
            this.correctWrongLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.correctWrongLabel.Location = new System.Drawing.Point(190, 88);
            this.correctWrongLabel.Margin = new System.Windows.Forms.Padding(0, 10, 20, 10);
            this.correctWrongLabel.Name = "correctWrongLabel";
            this.correctWrongLabel.Size = new System.Drawing.Size(170, 59);
            this.correctWrongLabel.TabIndex = 2;
            this.correctWrongLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CorrectWrongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 157);
            this.ControlBox = false;
            this.Controls.Add(this.correctWrongTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CorrectWrongForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Color Fun";
            this.correctWrongTableLayoutPanel.ResumeLayout(false);
            this.correctWrongTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel correctWrongTableLayoutPanel;
        private System.Windows.Forms.PictureBox facePictureBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label correctWrongLabel;
    }
}