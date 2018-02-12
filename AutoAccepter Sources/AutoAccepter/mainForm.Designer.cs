namespace AutoAccepter
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.monitoringWorker = new System.ComponentModel.BackgroundWorker();
            this.stringTimer = new System.Windows.Forms.Timer(this.components);
            this.bunifuTheme = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.headerPanel = new System.Windows.Forms.Panel();
            this.infoButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.headerLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.statusLabel = new System.Windows.Forms.Label();
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.startMonitoringButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.backgroundImage = new System.Windows.Forms.PictureBox();
            this.fadeInTimer = new System.Windows.Forms.Timer(this.components);
            this.stopMonitoringButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tokenTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.notifycationCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.sendNotifyLabel = new System.Windows.Forms.Label();
            this.notificationPanel = new System.Windows.Forms.Panel();
            this.registerLink = new System.Windows.Forms.Label();
            this.notificationWorker = new System.ComponentModel.BackgroundWorker();
            this.dragControlLabel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).BeginInit();
            this.notificationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // monitoringWorker
            // 
            this.monitoringWorker.WorkerSupportsCancellation = true;
            this.monitoringWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.monitoringWorker_DoWork);
            this.monitoringWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.monitoringWorker_RunWorkerCompleted);
            // 
            // stringTimer
            // 
            this.stringTimer.Tick += new System.EventHandler(this.stringTimer_Tick);
            // 
            // bunifuTheme
            // 
            this.bunifuTheme.ElipseRadius = 0;
            this.bunifuTheme.TargetControl = this;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.headerPanel.Controls.Add(this.infoButton);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Controls.Add(this.minimizeButton);
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(345, 35);
            this.headerPanel.TabIndex = 8;
            // 
            // infoButton
            // 
            this.infoButton.Activecolor = System.Drawing.Color.Transparent;
            this.infoButton.BackColor = System.Drawing.Color.Transparent;
            this.infoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoButton.BackgroundImage")));
            this.infoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.infoButton.BorderRadius = 0;
            this.infoButton.ButtonText = "";
            this.infoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoButton.DisabledColor = System.Drawing.Color.Gray;
            this.infoButton.Iconcolor = System.Drawing.Color.Transparent;
            this.infoButton.Iconimage = null;
            this.infoButton.Iconimage_right = null;
            this.infoButton.Iconimage_right_Selected = null;
            this.infoButton.Iconimage_Selected = null;
            this.infoButton.IconMarginLeft = 0;
            this.infoButton.IconMarginRight = 0;
            this.infoButton.IconRightVisible = true;
            this.infoButton.IconRightZoom = 0D;
            this.infoButton.IconVisible = true;
            this.infoButton.IconZoom = 35D;
            this.infoButton.IsTab = false;
            this.infoButton.Location = new System.Drawing.Point(242, 0);
            this.infoButton.Name = "infoButton";
            this.infoButton.Normalcolor = System.Drawing.Color.Transparent;
            this.infoButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.infoButton.OnHoverTextColor = System.Drawing.Color.White;
            this.infoButton.selected = false;
            this.infoButton.Size = new System.Drawing.Size(35, 35);
            this.infoButton.TabIndex = 14;
            this.infoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoButton.Textcolor = System.Drawing.Color.White;
            this.infoButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(154, 17);
            this.headerLabel.TabIndex = 13;
            this.headerLabel.Text = "Auto Accepter for Dota 2";
            // 
            // minimizeButton
            // 
            this.minimizeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizeButton.BorderRadius = 0;
            this.minimizeButton.ButtonText = "";
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.minimizeButton.DisabledColor = System.Drawing.Color.Gray;
            this.minimizeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.minimizeButton.Iconimage = null;
            this.minimizeButton.Iconimage_right = null;
            this.minimizeButton.Iconimage_right_Selected = null;
            this.minimizeButton.Iconimage_Selected = null;
            this.minimizeButton.IconMarginLeft = 0;
            this.minimizeButton.IconMarginRight = 0;
            this.minimizeButton.IconRightVisible = true;
            this.minimizeButton.IconRightZoom = 0D;
            this.minimizeButton.IconVisible = true;
            this.minimizeButton.IconZoom = 35D;
            this.minimizeButton.IsTab = false;
            this.minimizeButton.Location = new System.Drawing.Point(276, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Normalcolor = System.Drawing.Color.Transparent;
            this.minimizeButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.minimizeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.minimizeButton.selected = false;
            this.minimizeButton.Size = new System.Drawing.Size(35, 35);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minimizeButton.Textcolor = System.Drawing.Color.White;
            this.minimizeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButton.BorderRadius = 0;
            this.closeButton.ButtonText = "";
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.closeButton.DisabledColor = System.Drawing.Color.Gray;
            this.closeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.closeButton.Iconimage = null;
            this.closeButton.Iconimage_right = null;
            this.closeButton.Iconimage_right_Selected = null;
            this.closeButton.Iconimage_Selected = null;
            this.closeButton.IconMarginLeft = 0;
            this.closeButton.IconMarginRight = 0;
            this.closeButton.IconRightVisible = true;
            this.closeButton.IconRightZoom = 0D;
            this.closeButton.IconVisible = true;
            this.closeButton.IconZoom = 35D;
            this.closeButton.IsTab = false;
            this.closeButton.Location = new System.Drawing.Point(310, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Normalcolor = System.Drawing.Color.Transparent;
            this.closeButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.closeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.closeButton.selected = false;
            this.closeButton.Size = new System.Drawing.Size(35, 35);
            this.closeButton.TabIndex = 0;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.Textcolor = System.Drawing.Color.Black;
            this.closeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.statusLabel.Location = new System.Drawing.Point(193, 38);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(153, 17);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "Click \"AFK\" and go away!";
            // 
            // dragControl
            // 
            this.dragControl.Fixed = true;
            this.dragControl.Horizontal = true;
            this.dragControl.TargetControl = this.headerPanel;
            this.dragControl.Vertical = true;
            // 
            // startMonitoringButton
            // 
            this.startMonitoringButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.startMonitoringButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(16)))));
            this.startMonitoringButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startMonitoringButton.BorderRadius = 2;
            this.startMonitoringButton.ButtonText = "AFK";
            this.startMonitoringButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.startMonitoringButton.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.startMonitoringButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startMonitoringButton.Iconcolor = System.Drawing.Color.Transparent;
            this.startMonitoringButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("startMonitoringButton.Iconimage")));
            this.startMonitoringButton.Iconimage_right = null;
            this.startMonitoringButton.Iconimage_right_Selected = null;
            this.startMonitoringButton.Iconimage_Selected = null;
            this.startMonitoringButton.IconMarginLeft = 0;
            this.startMonitoringButton.IconMarginRight = 0;
            this.startMonitoringButton.IconRightVisible = true;
            this.startMonitoringButton.IconRightZoom = 0D;
            this.startMonitoringButton.IconVisible = false;
            this.startMonitoringButton.IconZoom = 90D;
            this.startMonitoringButton.IsTab = false;
            this.startMonitoringButton.Location = new System.Drawing.Point(17, 198);
            this.startMonitoringButton.Name = "startMonitoringButton";
            this.startMonitoringButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(16)))));
            this.startMonitoringButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(11)))), ((int)(((byte)(0)))));
            this.startMonitoringButton.OnHoverTextColor = System.Drawing.Color.White;
            this.startMonitoringButton.selected = false;
            this.startMonitoringButton.Size = new System.Drawing.Size(150, 40);
            this.startMonitoringButton.TabIndex = 0;
            this.startMonitoringButton.Text = "AFK";
            this.startMonitoringButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startMonitoringButton.Textcolor = System.Drawing.Color.White;
            this.startMonitoringButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMonitoringButton.Click += new System.EventHandler(this.startMonitoringButton_Click);
            // 
            // backgroundImage
            // 
            this.backgroundImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.backgroundImage.Image = ((System.Drawing.Image)(resources.GetObject("backgroundImage.Image")));
            this.backgroundImage.Location = new System.Drawing.Point(-3, 34);
            this.backgroundImage.Name = "backgroundImage";
            this.backgroundImage.Size = new System.Drawing.Size(347, 215);
            this.backgroundImage.TabIndex = 9;
            this.backgroundImage.TabStop = false;
            // 
            // stopMonitoringButton
            // 
            this.stopMonitoringButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.stopMonitoringButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(16)))));
            this.stopMonitoringButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopMonitoringButton.BorderRadius = 2;
            this.stopMonitoringButton.ButtonText = "I\'m Here!";
            this.stopMonitoringButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.stopMonitoringButton.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.stopMonitoringButton.Enabled = false;
            this.stopMonitoringButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopMonitoringButton.Iconcolor = System.Drawing.Color.Transparent;
            this.stopMonitoringButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("stopMonitoringButton.Iconimage")));
            this.stopMonitoringButton.Iconimage_right = null;
            this.stopMonitoringButton.Iconimage_right_Selected = null;
            this.stopMonitoringButton.Iconimage_Selected = null;
            this.stopMonitoringButton.IconMarginLeft = 0;
            this.stopMonitoringButton.IconMarginRight = 0;
            this.stopMonitoringButton.IconRightVisible = true;
            this.stopMonitoringButton.IconRightZoom = 0D;
            this.stopMonitoringButton.IconVisible = false;
            this.stopMonitoringButton.IconZoom = 90D;
            this.stopMonitoringButton.IsTab = false;
            this.stopMonitoringButton.Location = new System.Drawing.Point(178, 198);
            this.stopMonitoringButton.Name = "stopMonitoringButton";
            this.stopMonitoringButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(16)))));
            this.stopMonitoringButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(11)))), ((int)(((byte)(0)))));
            this.stopMonitoringButton.OnHoverTextColor = System.Drawing.Color.White;
            this.stopMonitoringButton.selected = false;
            this.stopMonitoringButton.Size = new System.Drawing.Size(150, 40);
            this.stopMonitoringButton.TabIndex = 10;
            this.stopMonitoringButton.Text = "I\'m Here!";
            this.stopMonitoringButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stopMonitoringButton.Textcolor = System.Drawing.Color.White;
            this.stopMonitoringButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopMonitoringButton.Click += new System.EventHandler(this.stopMonitoringButton_Click);
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tokenTextBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.tokenTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.tokenTextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.tokenTextBox.BorderThickness = 1;
            this.tokenTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tokenTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tokenTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.tokenTextBox.isPassword = false;
            this.tokenTextBox.Location = new System.Drawing.Point(12, 41);
            this.tokenTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.Size = new System.Drawing.Size(321, 35);
            this.tokenTextBox.TabIndex = 13;
            this.tokenTextBox.Text = "PushBullet Token";
            this.tokenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // notifycationCheckBox
            // 
            this.notifycationCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.notifycationCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.notifycationCheckBox.Checked = false;
            this.notifycationCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(16)))));
            this.notifycationCheckBox.ForeColor = System.Drawing.Color.White;
            this.notifycationCheckBox.Location = new System.Drawing.Point(12, 14);
            this.notifycationCheckBox.Name = "notifycationCheckBox";
            this.notifycationCheckBox.Size = new System.Drawing.Size(20, 20);
            this.notifycationCheckBox.TabIndex = 14;
            this.notifycationCheckBox.OnChange += new System.EventHandler(this.notifycationCheckBox_OnChange);
            // 
            // sendNotifyLabel
            // 
            this.sendNotifyLabel.AutoSize = true;
            this.sendNotifyLabel.BackColor = System.Drawing.Color.Transparent;
            this.sendNotifyLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendNotifyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.sendNotifyLabel.Location = new System.Drawing.Point(34, 15);
            this.sendNotifyLabel.Name = "sendNotifyLabel";
            this.sendNotifyLabel.Size = new System.Drawing.Size(111, 17);
            this.sendNotifyLabel.TabIndex = 15;
            this.sendNotifyLabel.Text = "Send notification?";
            this.sendNotifyLabel.Click += new System.EventHandler(this.sendNotifyLabel_Click);
            // 
            // notificationPanel
            // 
            this.notificationPanel.Controls.Add(this.registerLink);
            this.notificationPanel.Controls.Add(this.notifycationCheckBox);
            this.notificationPanel.Controls.Add(this.sendNotifyLabel);
            this.notificationPanel.Controls.Add(this.tokenTextBox);
            this.notificationPanel.Location = new System.Drawing.Point(0, 97);
            this.notificationPanel.Name = "notificationPanel";
            this.notificationPanel.Size = new System.Drawing.Size(346, 87);
            this.notificationPanel.TabIndex = 16;
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.BackColor = System.Drawing.Color.Transparent;
            this.registerLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.registerLink.Location = new System.Drawing.Point(277, 15);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(56, 17);
            this.registerLink.TabIndex = 16;
            this.registerLink.Text = "Register";
            this.registerLink.Click += new System.EventHandler(this.registerLink_Click);
            this.registerLink.MouseLeave += new System.EventHandler(this.registerLink_MouseLeave);
            this.registerLink.MouseMove += new System.Windows.Forms.MouseEventHandler(this.registerLink_MouseMove);
            // 
            // notificationWorker
            // 
            this.notificationWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.notificationWorker_DoWork);
            // 
            // dragControlLabel
            // 
            this.dragControlLabel.Fixed = true;
            this.dragControlLabel.Horizontal = true;
            this.dragControlLabel.TargetControl = this.headerLabel;
            this.dragControlLabel.Vertical = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(345, 250);
            this.ControlBox = false;
            this.Controls.Add(this.notificationPanel);
            this.Controls.Add(this.stopMonitoringButton);
            this.Controls.Add(this.startMonitoringButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.backgroundImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).EndInit();
            this.notificationPanel.ResumeLayout(false);
            this.notificationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker monitoringWorker;
        private System.Windows.Forms.Timer stringTimer;
        private Bunifu.Framework.UI.BunifuElipse bunifuTheme;
        private System.Windows.Forms.Panel headerPanel;
        private Bunifu.Framework.UI.BunifuFlatButton closeButton;
        private Bunifu.Framework.UI.BunifuFlatButton minimizeButton;
        private Bunifu.Framework.UI.BunifuDragControl dragControl;
        private Bunifu.Framework.UI.BunifuFlatButton startMonitoringButton;
        private System.Windows.Forms.PictureBox backgroundImage;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer fadeInTimer;
        private Bunifu.Framework.UI.BunifuFlatButton stopMonitoringButton;
        private System.Windows.Forms.Label headerLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox tokenTextBox;
        private Bunifu.Framework.UI.BunifuCheckbox notifycationCheckBox;
        private System.Windows.Forms.Panel notificationPanel;
        private System.Windows.Forms.Label sendNotifyLabel;
        private System.ComponentModel.BackgroundWorker notificationWorker;
        private System.Windows.Forms.Label registerLink;
        private Bunifu.Framework.UI.BunifuFlatButton infoButton;
        private Bunifu.Framework.UI.BunifuDragControl dragControlLabel;
    }
}

