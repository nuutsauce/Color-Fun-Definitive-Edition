namespace Color_Fun_Definitive_Edition
{
    partial class ResultsForm
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
            this.resultsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.percentageGroupBox = new System.Windows.Forms.GroupBox();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.resultsTableLayoutPanel.SuspendLayout();
            this.resultsGroupBox.SuspendLayout();
            this.percentageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultsTableLayoutPanel
            // 
            this.resultsTableLayoutPanel.ColumnCount = 2;
            this.resultsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.resultsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.resultsTableLayoutPanel.Controls.Add(this.resultsGroupBox, 0, 0);
            this.resultsTableLayoutPanel.Controls.Add(this.percentageGroupBox, 1, 0);
            this.resultsTableLayoutPanel.Controls.Add(this.okButton, 0, 1);
            this.resultsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.resultsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.resultsTableLayoutPanel.Name = "resultsTableLayoutPanel";
            this.resultsTableLayoutPanel.RowCount = 2;
            this.resultsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.60163F));
            this.resultsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.39837F));
            this.resultsTableLayoutPanel.Size = new System.Drawing.Size(384, 123);
            this.resultsTableLayoutPanel.TabIndex = 0;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.resultsLabel);
            this.resultsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsGroupBox.Location = new System.Drawing.Point(14, 14);
            this.resultsGroupBox.Margin = new System.Windows.Forms.Padding(14, 14, 7, 5);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.resultsGroupBox.Size = new System.Drawing.Size(235, 58);
            this.resultsGroupBox.TabIndex = 0;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // resultsLabel
            // 
            this.resultsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsLabel.Location = new System.Drawing.Point(4, 21);
            this.resultsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(227, 33);
            this.resultsLabel.TabIndex = 0;
            this.resultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // percentageGroupBox
            // 
            this.percentageGroupBox.Controls.Add(this.percentageLabel);
            this.percentageGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.percentageGroupBox.Location = new System.Drawing.Point(263, 14);
            this.percentageGroupBox.Margin = new System.Windows.Forms.Padding(7, 14, 14, 5);
            this.percentageGroupBox.Name = "percentageGroupBox";
            this.percentageGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.percentageGroupBox.Size = new System.Drawing.Size(107, 58);
            this.percentageGroupBox.TabIndex = 1;
            this.percentageGroupBox.TabStop = false;
            this.percentageGroupBox.Text = "Percentage";
            // 
            // percentageLabel
            // 
            this.percentageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.percentageLabel.Location = new System.Drawing.Point(4, 21);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(99, 33);
            this.percentageLabel.TabIndex = 0;
            this.percentageLabel.Text = "0";
            this.percentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resultsTableLayoutPanel.SetColumnSpan(this.okButton, 2);
            this.okButton.Location = new System.Drawing.Point(13, 87);
            this.okButton.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(110, 26);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 123);
            this.ControlBox = false;
            this.Controls.Add(this.resultsTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Results";
            this.resultsTableLayoutPanel.ResumeLayout(false);
            this.resultsGroupBox.ResumeLayout(false);
            this.percentageGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel resultsTableLayoutPanel;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.GroupBox percentageGroupBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label percentageLabel;
    }
}