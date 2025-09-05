namespace EventDriven.Project.Enrollment.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            SATAUiFramework.BorderRadius borderRadius2 = new SATAUiFramework.BorderRadius();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new CuoreUI.Controls.cuiLabel();
            this.lblBNHS = new System.Windows.Forms.Label();
            this.ptbLogo1 = new SATAUiFramework.Controls.SATAPictureBox();
            this.ptgBG = new System.Windows.Forms.PictureBox();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.txtPassword = new SATATextBox();
            this.txtUserName = new SATATextBox();
            this.btnLogin = new FrameworkTest.SATAButton();
            this.lblSchool = new System.Windows.Forms.Label();
            this.ptgLogo2 = new SATAUiFramework.Controls.SATAPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptgBG)).BeginInit();
            this.sataPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptgLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblBNHS);
            this.panel1.Controls.Add(this.ptbLogo1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 68);
            this.panel1.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Content = "X";
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.btnExit.Location = new System.Drawing.Point(877, 13);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 38);
            this.btnExit.TabIndex = 8;
            this.btnExit.VerticalAlignment = System.Drawing.StringAlignment.Near;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblBNHS
            // 
            this.lblBNHS.AutoSize = true;
            this.lblBNHS.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBNHS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBNHS.Location = new System.Drawing.Point(121, 20);
            this.lblBNHS.Name = "lblBNHS";
            this.lblBNHS.Size = new System.Drawing.Size(307, 26);
            this.lblBNHS.TabIndex = 2;
            this.lblBNHS.Text = "Balayan National High School";
            // 
            // ptbLogo1
            // 
            this.ptbLogo1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.ptbLogo1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ptbLogo1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ptbLogo1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.ptbLogo1.BorderSize = 1;
            this.ptbLogo1.GradientAngle = 50F;
            this.ptbLogo1.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo1.Image")));
            this.ptbLogo1.Location = new System.Drawing.Point(27, -16);
            this.ptbLogo1.Name = "ptbLogo1";
            this.ptbLogo1.Size = new System.Drawing.Size(96, 96);
            this.ptbLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo1.TabIndex = 1;
            this.ptbLogo1.TabStop = false;
            // 
            // ptgBG
            // 
            this.ptgBG.Image = ((System.Drawing.Image)(resources.GetObject("ptgBG.Image")));
            this.ptgBG.Location = new System.Drawing.Point(-55, 63);
            this.ptgBG.Name = "ptgBG";
            this.ptgBG.Size = new System.Drawing.Size(1068, 540);
            this.ptgBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptgBG.TabIndex = 5;
            this.ptgBG.TabStop = false;
            // 
            // sataPanel1
            // 
            this.sataPanel1.BackColor2 = System.Drawing.SystemColors.Control;
            this.sataPanel1.BorderColor = System.Drawing.Color.Black;
            borderRadius2.BottomLeft = 10;
            borderRadius2.BottomRight = 10;
            borderRadius2.TopLeft = 10;
            borderRadius2.TopRight = 10;
            this.sataPanel1.BorderRadius = borderRadius2;
            this.sataPanel1.BorderThickness = 0;
            this.sataPanel1.Controls.Add(this.txtPassword);
            this.sataPanel1.Controls.Add(this.txtUserName);
            this.sataPanel1.Controls.Add(this.btnLogin);
            this.sataPanel1.Controls.Add(this.lblSchool);
            this.sataPanel1.Controls.Add(this.ptgLogo2);
            this.sataPanel1.Location = new System.Drawing.Point(283, 94);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(355, 450);
            this.sataPanel1.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtPassword.Icon")));
            this.txtPassword.IconSize = new System.Drawing.Size(20, 20);
            this.txtPassword.Location = new System.Drawing.Point(48, 300);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(266, 34);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "sataTextBox2";
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUserName.BorderColor = System.Drawing.Color.Silver;
            this.txtUserName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.txtUserName.BorderRadius = 5;
            this.txtUserName.BorderSize = 1;
            this.txtUserName.Icon = ((System.Drawing.Image)(resources.GetObject("txtUserName.Icon")));
            this.txtUserName.IconSize = new System.Drawing.Size(20, 20);
            this.txtUserName.Location = new System.Drawing.Point(48, 243);
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = false;
            this.txtUserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.Size = new System.Drawing.Size(266, 34);
            this.txtUserName.TabIndex = 7;
            this.txtUserName.Text = "sataTextBox1";
            this.txtUserName.Texts = "";
            this.txtUserName.UnderlinedStyle = false;
            // 
            // btnLogin
            // 
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.CheckedBackground = System.Drawing.Color.Firebrick;
            this.btnLogin.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogin.CheckedImageTint = System.Drawing.Color.White;
            this.btnLogin.CheckedOutline = System.Drawing.Color.Transparent;
            this.btnLogin.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnLogin.HoverForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverImage = null;
            this.btnLogin.HoverImageTint = System.Drawing.Color.White;
            this.btnLogin.HoverOutline = System.Drawing.Color.Empty;
            this.btnLogin.Image = null;
            this.btnLogin.ImageAutoCenter = true;
            this.btnLogin.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnLogin.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogin.ImageTint = System.Drawing.Color.White;
            this.btnLogin.IsToggleButton = false;
            this.btnLogin.IsToggled = false;
            this.btnLogin.Location = new System.Drawing.Point(48, 383);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormalBackground = System.Drawing.Color.Firebrick;
            this.btnLogin.NormalForeColor = System.Drawing.Color.White;
            this.btnLogin.NormalOutline = System.Drawing.Color.Empty;
            this.btnLogin.OutlineThickness = 2F;
            this.btnLogin.PressedBackground = System.Drawing.Color.Brown;
            this.btnLogin.PressedForeColor = System.Drawing.Color.White;
            this.btnLogin.PressedImageTint = System.Drawing.Color.White;
            this.btnLogin.PressedOutline = System.Drawing.Color.Empty;
            this.btnLogin.Rounding = new System.Windows.Forms.Padding(5);
            this.btnLogin.Size = new System.Drawing.Size(266, 37);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.TextAutoCenter = true;
            this.btnLogin.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.BackColor = System.Drawing.Color.Transparent;
            this.lblSchool.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSchool.Location = new System.Drawing.Point(44, 178);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(272, 22);
            this.lblSchool.TabIndex = 3;
            this.lblSchool.Text = "Balayan National High School";
            // 
            // ptgLogo2
            // 
            this.ptgLogo2.BackColor = System.Drawing.Color.Transparent;
            this.ptgLogo2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.ptgLogo2.BorderColor = System.Drawing.SystemColors.Control;
            this.ptgLogo2.BorderColor2 = System.Drawing.SystemColors.Control;
            this.ptgLogo2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.ptgLogo2.BorderSize = 1;
            this.ptgLogo2.GradientAngle = 50F;
            this.ptgLogo2.Image = ((System.Drawing.Image)(resources.GetObject("ptgLogo2.Image")));
            this.ptgLogo2.Location = new System.Drawing.Point(80, 0);
            this.ptgLogo2.Name = "ptgLogo2";
            this.ptgLogo2.Size = new System.Drawing.Size(197, 197);
            this.ptgLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptgLogo2.TabIndex = 3;
            this.ptgLogo2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(957, 577);
            this.Controls.Add(this.sataPanel1);
            this.Controls.Add(this.ptgBG);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptgBG)).EndInit();
            this.sataPanel1.ResumeLayout(false);
            this.sataPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptgLogo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBNHS;
        private SATAUiFramework.Controls.SATAPictureBox ptbLogo1;
        private System.Windows.Forms.PictureBox ptgBG;
        private SATAUiFramework.SATAPanel sataPanel1;
        private SATAUiFramework.Controls.SATAPictureBox ptgLogo2;
        private System.Windows.Forms.Label lblSchool;
        private FrameworkTest.SATAButton btnLogin;
        private SATATextBox txtPassword;
        private SATATextBox txtUserName;
        private CuoreUI.Controls.cuiLabel btnExit;
    }
}