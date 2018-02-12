namespace AutoAccepter
{
    partial class AboutForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.bunifuTheme = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.closeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.inneraLogo = new System.Windows.Forms.PictureBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fadeInTimer = new System.Windows.Forms.Timer(this.components);
            this.donateButton = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.inneraLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTheme
            // 
            this.bunifuTheme.ElipseRadius = 0;
            this.bunifuTheme.TargetControl = this;
            // 
            // dragControl
            // 
            this.dragControl.Fixed = true;
            this.dragControl.Horizontal = true;
            this.dragControl.TargetControl = this;
            this.dragControl.Vertical = true;
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
            this.closeButton.Location = new System.Drawing.Point(262, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Normalcolor = System.Drawing.Color.Transparent;
            this.closeButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.closeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.closeButton.selected = false;
            this.closeButton.Size = new System.Drawing.Size(35, 35);
            this.closeButton.TabIndex = 4;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.Textcolor = System.Drawing.Color.Black;
            this.closeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // inneraLogo
            // 
            this.inneraLogo.Image = ((System.Drawing.Image)(resources.GetObject("inneraLogo.Image")));
            this.inneraLogo.Location = new System.Drawing.Point(27, 38);
            this.inneraLogo.Name = "inneraLogo";
            this.inneraLogo.Size = new System.Drawing.Size(250, 125);
            this.inneraLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inneraLogo.TabIndex = 5;
            this.inneraLogo.TabStop = false;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.versionLabel.Location = new System.Drawing.Point(24, 184);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(51, 15);
            this.versionLabel.TabIndex = 13;
            this.versionLabel.Text = "Version: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(24, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Essavian | Dota2.ru";
            // 
            // donateButton
            // 
            this.donateButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.donateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.donateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("donateButton.BackgroundImage")));
            this.donateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.donateButton.BorderRadius = 2;
            this.donateButton.ButtonText = "";
            this.donateButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.donateButton.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.donateButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.donateButton.Iconcolor = System.Drawing.Color.Transparent;
            this.donateButton.Iconimage = null;
            this.donateButton.Iconimage_right = null;
            this.donateButton.Iconimage_right_Selected = null;
            this.donateButton.Iconimage_Selected = null;
            this.donateButton.IconMarginLeft = 47;
            this.donateButton.IconMarginRight = 0;
            this.donateButton.IconRightVisible = true;
            this.donateButton.IconRightZoom = 0D;
            this.donateButton.IconVisible = true;
            this.donateButton.IconZoom = 20D;
            this.donateButton.IsTab = false;
            this.donateButton.Location = new System.Drawing.Point(157, 169);
            this.donateButton.Name = "donateButton";
            this.donateButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.donateButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(11)))), ((int)(((byte)(0)))));
            this.donateButton.OnHoverTextColor = System.Drawing.Color.White;
            this.donateButton.selected = false;
            this.donateButton.Size = new System.Drawing.Size(120, 30);
            this.donateButton.TabIndex = 15;
            this.donateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.donateButton.Textcolor = System.Drawing.Color.White;
            this.donateButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donateButton.Click += new System.EventHandler(this.donateButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(300, 210);
            this.ControlBox = false;
            this.Controls.Add(this.donateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.inneraLogo);
            this.Controls.Add(this.closeButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AboutForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutForm";
            ((System.ComponentModel.ISupportInitialize)(this.inneraLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuTheme;
        private Bunifu.Framework.UI.BunifuDragControl dragControl;
        private Bunifu.Framework.UI.BunifuFlatButton closeButton;
        private System.Windows.Forms.PictureBox inneraLogo;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer fadeInTimer;
        private Bunifu.Framework.UI.BunifuFlatButton donateButton;
    }
}