namespace Color_Fun_Definitive_Edition
{
    partial class ColorFunMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorFunMenu));
            this.colorFunMenuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skipSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.joelFacePictureBox = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.colorFunMenuStrip.SuspendLayout();
            this.helpMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joelFacePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // colorFunMenuStrip
            // 
            this.colorFunMenuStrip.AutoSize = false;
            this.colorFunMenuStrip.BackColor = System.Drawing.Color.White;
            this.colorFunMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.colorFunMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.colorFunMenuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.colorFunMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.colorFunMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.colorFunMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.colorFunMenuStrip.Name = "colorFunMenuStrip";
            this.colorFunMenuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.colorFunMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.colorFunMenuStrip.Size = new System.Drawing.Size(111, 19);
            this.colorFunMenuStrip.TabIndex = 1;
            this.colorFunMenuStrip.Text = "colorFunMenuStrip";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newGameToolStripMenuItem.ShortcutKeyDisplayString = "G";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.newGameToolStripMenuItem.Text = "&New";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundToolStripMenuItem,
            this.skipSetupToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // soundToolStripMenuItem
            // 
            this.soundToolStripMenuItem.Checked = true;
            this.soundToolStripMenuItem.CheckOnClick = true;
            this.soundToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            this.soundToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.soundToolStripMenuItem.Text = "&Sound";
            // 
            // skipSetupToolStripMenuItem
            // 
            this.skipSetupToolStripMenuItem.CheckOnClick = true;
            this.skipSetupToolStripMenuItem.Name = "skipSetupToolStripMenuItem";
            this.skipSetupToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.skipSetupToolStripMenuItem.Text = "&Skip setup";
            // 
            // helpMenuStrip
            // 
            this.helpMenuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpMenuStrip.AutoSize = false;
            this.helpMenuStrip.BackColor = System.Drawing.Color.White;
            this.helpMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.helpMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.helpMenuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.helpMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.helpMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.helpMenuStrip.Location = new System.Drawing.Point(111, 0);
            this.helpMenuStrip.Name = "helpMenuStrip";
            this.helpMenuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.helpMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.helpMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.helpMenuStrip.Size = new System.Drawing.Size(689, 19);
            this.helpMenuStrip.TabIndex = 2;
            this.helpMenuStrip.Text = "helpMenuStrip";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexToolStripMenuItem1,
            this.commandsToolStripMenuItem1});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // indexToolStripMenuItem1
            // 
            this.indexToolStripMenuItem1.Name = "indexToolStripMenuItem1";
            this.indexToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.indexToolStripMenuItem1.Text = "&Index";
            this.indexToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.indexToolStripMenuItem1.Click += new System.EventHandler(this.indexToolStripMenuItem1_Click);
            // 
            // commandsToolStripMenuItem1
            // 
            this.commandsToolStripMenuItem1.Name = "commandsToolStripMenuItem1";
            this.commandsToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.commandsToolStripMenuItem1.Text = "&Commands";
            this.commandsToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.commandsToolStripMenuItem1.Click += new System.EventHandler(this.commandsToolStripMenuItem1_Click);
            // 
            // joelFacePictureBox
            // 
            this.joelFacePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.joelFacePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.joelFacePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.joelFacePictureBox.Image = global::Color_Fun_Definitive_Edition.Properties.Resources.joel_logo;
            this.joelFacePictureBox.Location = new System.Drawing.Point(561, 222);
            this.joelFacePictureBox.Margin = new System.Windows.Forms.Padding(30);
            this.joelFacePictureBox.Name = "joelFacePictureBox";
            this.joelFacePictureBox.Size = new System.Drawing.Size(200, 200);
            this.joelFacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.joelFacePictureBox.TabIndex = 3;
            this.joelFacePictureBox.TabStop = false;
            this.joelFacePictureBox.Visible = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Image = global::Color_Fun_Definitive_Edition.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(53, 74);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(668, 70);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.WaitOnLoad = true;
            // 
            // ColorFunMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.joelFacePictureBox);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.colorFunMenuStrip);
            this.Controls.Add(this.helpMenuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.colorFunMenuStrip;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "ColorFunMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Fun Definitive Edition";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ColorFunMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColorFunMenu_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ColorFunMenu_KeyUp);
            this.colorFunMenuStrip.ResumeLayout(false);
            this.colorFunMenuStrip.PerformLayout();
            this.helpMenuStrip.ResumeLayout(false);
            this.helpMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joelFacePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.MenuStrip colorFunMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skipSetupToolStripMenuItem;
        private System.Windows.Forms.MenuStrip helpMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem1;
        private System.Windows.Forms.PictureBox joelFacePictureBox;
    }
}

