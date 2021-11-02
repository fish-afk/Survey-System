
namespace SurveySystem
{
    partial class Survey_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Survey_Page));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_account_type = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_system_name = new System.Windows.Forms.Label();
            this.logo_view = new System.Windows.Forms.PictureBox();
            this.button_panel = new System.Windows.Forms.Panel();
            this.cmd_home = new Guna.UI2.WinForms.Guna2Button();
            this.cmd_logout = new Guna.UI2.WinForms.Guna2Button();
            this.cmd_view_analysis = new Guna.UI2.WinForms.Guna2Button();
            this.cmd_delete_survey = new Guna.UI2.WinForms.Guna2Button();
            this.cmd_create_survey = new Guna.UI2.WinForms.Guna2Button();
            this.cmd_take_survey = new Guna.UI2.WinForms.Guna2Button();
            this.container_panel = new System.Windows.Forms.Panel();
            this.lbl_guide = new System.Windows.Forms.Label();
            this.lbl_greeting = new System.Windows.Forms.Label();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialog2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_view)).BeginInit();
            this.button_panel.SuspendLayout();
            this.container_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.lbl_account_type);
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Controls.Add(this.lbl_system_name);
            this.panel1.Controls.Add(this.logo_view);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbl_account_type
            // 
            this.lbl_account_type.AutoSize = true;
            this.lbl_account_type.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_account_type.ForeColor = System.Drawing.Color.White;
            this.lbl_account_type.Location = new System.Drawing.Point(1105, 58);
            this.lbl_account_type.Name = "lbl_account_type";
            this.lbl_account_type.Size = new System.Drawing.Size(168, 25);
            this.lbl_account_type.TabIndex = 6;
            this.lbl_account_type.Text = "Account type : ";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.White;
            this.lbl_user.Location = new System.Drawing.Point(1200, 21);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(73, 25);
            this.lbl_user.TabIndex = 5;
            this.lbl_user.Text = "User : ";
            // 
            // lbl_system_name
            // 
            this.lbl_system_name.AutoSize = true;
            this.lbl_system_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_system_name.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_system_name.ForeColor = System.Drawing.Color.White;
            this.lbl_system_name.Location = new System.Drawing.Point(148, 38);
            this.lbl_system_name.Name = "lbl_system_name";
            this.lbl_system_name.Size = new System.Drawing.Size(232, 30);
            this.lbl_system_name.TabIndex = 1;
            this.lbl_system_name.Text = "Code Box/Surveys.";
            // 
            // logo_view
            // 
            this.logo_view.Image = global::SurveySystem.Properties.Resources.f7e5324882f3decde61dd29deb9cad561;
            this.logo_view.Location = new System.Drawing.Point(0, 0);
            this.logo_view.Name = "logo_view";
            this.logo_view.Size = new System.Drawing.Size(123, 100);
            this.logo_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_view.TabIndex = 0;
            this.logo_view.TabStop = false;
            // 
            // button_panel
            // 
            this.button_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.button_panel.Controls.Add(this.cmd_home);
            this.button_panel.Controls.Add(this.cmd_logout);
            this.button_panel.Controls.Add(this.cmd_view_analysis);
            this.button_panel.Controls.Add(this.cmd_delete_survey);
            this.button_panel.Controls.Add(this.cmd_create_survey);
            this.button_panel.Controls.Add(this.cmd_take_survey);
            this.button_panel.Location = new System.Drawing.Point(-2, 100);
            this.button_panel.Name = "button_panel";
            this.button_panel.Size = new System.Drawing.Size(1482, 67);
            this.button_panel.TabIndex = 1;
            // 
            // cmd_home
            // 
            this.cmd_home.Animated = true;
            this.cmd_home.AutoRoundedCorners = true;
            this.cmd_home.BorderRadius = 29;
            this.cmd_home.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.cmd_home.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.cmd_home.CheckedState.Parent = this.cmd_home;
            this.cmd_home.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmd_home.CustomImages.Parent = this.cmd_home;
            this.cmd_home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cmd_home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cmd_home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cmd_home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cmd_home.DisabledState.Parent = this.cmd_home;
            this.cmd_home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(130)))));
            this.cmd_home.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmd_home.ForeColor = System.Drawing.Color.White;
            this.cmd_home.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmd_home.HoverState.Parent = this.cmd_home;
            this.cmd_home.IndicateFocus = true;
            this.cmd_home.Location = new System.Drawing.Point(1096, 3);
            this.cmd_home.Name = "cmd_home";
            this.cmd_home.ShadowDecoration.Parent = this.cmd_home;
            this.cmd_home.Size = new System.Drawing.Size(190, 61);
            this.cmd_home.TabIndex = 6;
            this.cmd_home.Text = "Home";
            this.cmd_home.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // cmd_logout
            // 
            this.cmd_logout.Animated = true;
            this.cmd_logout.AutoRoundedCorners = true;
            this.cmd_logout.BorderRadius = 29;
            this.cmd_logout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.cmd_logout.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.cmd_logout.CheckedState.Parent = this.cmd_logout;
            this.cmd_logout.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmd_logout.CustomImages.Parent = this.cmd_logout;
            this.cmd_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cmd_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cmd_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cmd_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cmd_logout.DisabledState.Parent = this.cmd_logout;
            this.cmd_logout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(130)))));
            this.cmd_logout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmd_logout.ForeColor = System.Drawing.Color.White;
            this.cmd_logout.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmd_logout.HoverState.Parent = this.cmd_logout;
            this.cmd_logout.IndicateFocus = true;
            this.cmd_logout.Location = new System.Drawing.Point(1292, 0);
            this.cmd_logout.Name = "cmd_logout";
            this.cmd_logout.ShadowDecoration.Parent = this.cmd_logout;
            this.cmd_logout.Size = new System.Drawing.Size(190, 61);
            this.cmd_logout.TabIndex = 5;
            this.cmd_logout.Text = "Log out";
            this.cmd_logout.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // cmd_view_analysis
            // 
            this.cmd_view_analysis.Animated = true;
            this.cmd_view_analysis.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.cmd_view_analysis.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.cmd_view_analysis.CheckedState.Parent = this.cmd_view_analysis;
            this.cmd_view_analysis.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmd_view_analysis.CustomImages.Parent = this.cmd_view_analysis;
            this.cmd_view_analysis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cmd_view_analysis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cmd_view_analysis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cmd_view_analysis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cmd_view_analysis.DisabledState.Parent = this.cmd_view_analysis;
            this.cmd_view_analysis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(230)))));
            this.cmd_view_analysis.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_view_analysis.ForeColor = System.Drawing.Color.White;
            this.cmd_view_analysis.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmd_view_analysis.HoverState.Parent = this.cmd_view_analysis;
            this.cmd_view_analysis.IndicateFocus = true;
            this.cmd_view_analysis.Location = new System.Drawing.Point(591, 0);
            this.cmd_view_analysis.Name = "cmd_view_analysis";
            this.cmd_view_analysis.ShadowDecoration.Parent = this.cmd_view_analysis;
            this.cmd_view_analysis.Size = new System.Drawing.Size(183, 67);
            this.cmd_view_analysis.TabIndex = 3;
            this.cmd_view_analysis.Text = "View Analysis";
            this.cmd_view_analysis.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // cmd_delete_survey
            // 
            this.cmd_delete_survey.Animated = true;
            this.cmd_delete_survey.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.cmd_delete_survey.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.cmd_delete_survey.CheckedState.Parent = this.cmd_delete_survey;
            this.cmd_delete_survey.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmd_delete_survey.CustomImages.Parent = this.cmd_delete_survey;
            this.cmd_delete_survey.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cmd_delete_survey.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cmd_delete_survey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cmd_delete_survey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cmd_delete_survey.DisabledState.Parent = this.cmd_delete_survey;
            this.cmd_delete_survey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(230)))));
            this.cmd_delete_survey.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_delete_survey.ForeColor = System.Drawing.Color.White;
            this.cmd_delete_survey.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmd_delete_survey.HoverState.Parent = this.cmd_delete_survey;
            this.cmd_delete_survey.IndicateFocus = true;
            this.cmd_delete_survey.Location = new System.Drawing.Point(395, 0);
            this.cmd_delete_survey.Name = "cmd_delete_survey";
            this.cmd_delete_survey.ShadowDecoration.Parent = this.cmd_delete_survey;
            this.cmd_delete_survey.Size = new System.Drawing.Size(190, 67);
            this.cmd_delete_survey.TabIndex = 2;
            this.cmd_delete_survey.Text = "Delete Survey";
            this.cmd_delete_survey.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // cmd_create_survey
            // 
            this.cmd_create_survey.Animated = true;
            this.cmd_create_survey.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.cmd_create_survey.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.cmd_create_survey.CheckedState.Parent = this.cmd_create_survey;
            this.cmd_create_survey.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmd_create_survey.CustomImages.Parent = this.cmd_create_survey;
            this.cmd_create_survey.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cmd_create_survey.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cmd_create_survey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cmd_create_survey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cmd_create_survey.DisabledState.Parent = this.cmd_create_survey;
            this.cmd_create_survey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(230)))));
            this.cmd_create_survey.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_create_survey.ForeColor = System.Drawing.Color.White;
            this.cmd_create_survey.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmd_create_survey.HoverState.Parent = this.cmd_create_survey;
            this.cmd_create_survey.IndicateFocus = true;
            this.cmd_create_survey.Location = new System.Drawing.Point(199, 0);
            this.cmd_create_survey.Name = "cmd_create_survey";
            this.cmd_create_survey.ShadowDecoration.Parent = this.cmd_create_survey;
            this.cmd_create_survey.Size = new System.Drawing.Size(190, 67);
            this.cmd_create_survey.TabIndex = 1;
            this.cmd_create_survey.Text = "Create Survey";
            this.cmd_create_survey.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // cmd_take_survey
            // 
            this.cmd_take_survey.Animated = true;
            this.cmd_take_survey.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.cmd_take_survey.Checked = true;
            this.cmd_take_survey.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.cmd_take_survey.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(130)))));
            this.cmd_take_survey.CheckedState.Parent = this.cmd_take_survey;
            this.cmd_take_survey.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmd_take_survey.CustomImages.Parent = this.cmd_take_survey;
            this.cmd_take_survey.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cmd_take_survey.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cmd_take_survey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cmd_take_survey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cmd_take_survey.DisabledState.Parent = this.cmd_take_survey;
            this.cmd_take_survey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(230)))));
            this.cmd_take_survey.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_take_survey.ForeColor = System.Drawing.Color.White;
            this.cmd_take_survey.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmd_take_survey.HoverState.Parent = this.cmd_take_survey;
            this.cmd_take_survey.IndicateFocus = true;
            this.cmd_take_survey.Location = new System.Drawing.Point(3, 0);
            this.cmd_take_survey.Name = "cmd_take_survey";
            this.cmd_take_survey.ShadowDecoration.Parent = this.cmd_take_survey;
            this.cmd_take_survey.Size = new System.Drawing.Size(190, 67);
            this.cmd_take_survey.TabIndex = 0;
            this.cmd_take_survey.Text = "Take Survey";
            this.cmd_take_survey.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // container_panel
            // 
            this.container_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.container_panel.Controls.Add(this.lbl_guide);
            this.container_panel.Controls.Add(this.lbl_greeting);
            this.container_panel.Location = new System.Drawing.Point(1, 173);
            this.container_panel.Name = "container_panel";
            this.container_panel.Size = new System.Drawing.Size(1479, 564);
            this.container_panel.TabIndex = 2;
            this.container_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.container_panel_Paint);
            // 
            // lbl_guide
            // 
            this.lbl_guide.AutoSize = true;
            this.lbl_guide.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guide.ForeColor = System.Drawing.Color.White;
            this.lbl_guide.Location = new System.Drawing.Point(551, 192);
            this.lbl_guide.Name = "lbl_guide";
            this.lbl_guide.Size = new System.Drawing.Size(19, 28);
            this.lbl_guide.TabIndex = 5;
            this.lbl_guide.Text = " ";
            // 
            // lbl_greeting
            // 
            this.lbl_greeting.AutoSize = true;
            this.lbl_greeting.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_greeting.ForeColor = System.Drawing.Color.White;
            this.lbl_greeting.Location = new System.Drawing.Point(639, 140);
            this.lbl_greeting.Name = "lbl_greeting";
            this.lbl_greeting.Size = new System.Drawing.Size(130, 28);
            this.lbl_greeting.TabIndex = 4;
            this.lbl_greeting.Text = "Welcome ";
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // guna2MessageDialog2
            // 
            this.guna2MessageDialog2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.guna2MessageDialog2.Caption = null;
            this.guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.guna2MessageDialog2.Parent = null;
            this.guna2MessageDialog2.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog2.Text = null;
            // 
            // Survey_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1481, 738);
            this.Controls.Add(this.container_panel);
            this.Controls.Add(this.button_panel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Survey_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Survey Page.";
            this.Load += new System.EventHandler(this.Survey_Page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_view)).EndInit();
            this.button_panel.ResumeLayout(false);
            this.container_panel.ResumeLayout(false);
            this.container_panel.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel button_panel;
        private System.Windows.Forms.PictureBox logo_view;
        private System.Windows.Forms.Label lbl_system_name;
        private System.Windows.Forms.Panel container_panel;
        private Guna.UI2.WinForms.Guna2Button cmd_take_survey;
        private Guna.UI2.WinForms.Guna2Button cmd_view_analysis;
        private Guna.UI2.WinForms.Guna2Button cmd_delete_survey;
        private Guna.UI2.WinForms.Guna2Button cmd_create_survey;
        private System.Windows.Forms.Label lbl_greeting;
        private Guna.UI2.WinForms.Guna2Button cmd_logout;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_account_type;
        private System.Windows.Forms.Label lbl_guide;
        private Guna.UI2.WinForms.Guna2Button cmd_home;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog2;
    }
}