using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SurveySystem.Usercontrols
{
    partial class UC_takeSurvey
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_guide = new System.Windows.Forms.Label();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.cmb_select_survey = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmd_take_survey = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Survey_area = new System.Windows.Forms.Panel();
            this.cmd_next = new Guna.UI2.WinForms.Guna2Button();
            this.cmd_submit = new Guna.UI2.WinForms.Guna2Button();
            this.cmd_quit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2MessageDialog2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialog3 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.surveyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Survey_area.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.surveyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_guide
            // 
            this.lbl_guide.AutoSize = true;
            this.lbl_guide.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guide.ForeColor = System.Drawing.Color.White;
            this.lbl_guide.Location = new System.Drawing.Point(22, 37);
            this.lbl_guide.Name = "lbl_guide";
            this.lbl_guide.Size = new System.Drawing.Size(477, 25);
            this.lbl_guide.TabIndex = 0;
            this.lbl_guide.Text = "Please choose a survey that you wish to take :";
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // cmb_select_survey
            // 
            this.cmb_select_survey.BackColor = System.Drawing.Color.Transparent;
            this.cmb_select_survey.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_select_survey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_select_survey.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_select_survey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_select_survey.FocusedState.Parent = this.cmb_select_survey;
            this.cmb_select_survey.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_select_survey.ForeColor = System.Drawing.Color.Red;
            this.cmb_select_survey.HoverState.Parent = this.cmb_select_survey;
            this.cmb_select_survey.ItemHeight = 15;
            this.cmb_select_survey.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmb_select_survey.ItemsAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_select_survey.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cmb_select_survey.ItemsAppearance.Parent = this.cmb_select_survey;
            this.cmb_select_survey.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_select_survey.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Red;
            this.cmb_select_survey.Location = new System.Drawing.Point(27, 102);
            this.cmb_select_survey.Name = "cmb_select_survey";
            this.cmb_select_survey.ShadowDecoration.Parent = this.cmb_select_survey;
            this.cmb_select_survey.Size = new System.Drawing.Size(208, 21);
            this.cmb_select_survey.TabIndex = 2;
            this.cmb_select_survey.SelectedIndexChanged += new System.EventHandler(this.cmb_select_survey_SelectedIndexChanged);
            // 
            // cmd_take_survey
            // 
            this.cmd_take_survey.Animated = true;
            this.cmd_take_survey.AutoRoundedCorners = true;
            this.cmd_take_survey.BorderRadius = 16;
            this.cmd_take_survey.CheckedState.Parent = this.cmd_take_survey;
            this.cmd_take_survey.CustomImages.Parent = this.cmd_take_survey;
            this.cmd_take_survey.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cmd_take_survey.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cmd_take_survey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cmd_take_survey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cmd_take_survey.DisabledState.Parent = this.cmd_take_survey;
            this.cmd_take_survey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmd_take_survey.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_take_survey.ForeColor = System.Drawing.Color.White;
            this.cmd_take_survey.HoverState.Parent = this.cmd_take_survey;
            this.cmd_take_survey.Location = new System.Drawing.Point(272, 88);
            this.cmd_take_survey.Name = "cmd_take_survey";
            this.cmd_take_survey.ShadowDecoration.Parent = this.cmd_take_survey;
            this.cmd_take_survey.Size = new System.Drawing.Size(176, 35);
            this.cmd_take_survey.TabIndex = 3;
            this.cmd_take_survey.Text = "Take survey";
            this.cmd_take_survey.Click += new System.EventHandler(this.cmd_take_survey_Click);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(936, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 386);
            this.panel1.TabIndex = 52;
            // 
            // Survey_area
            // 
            this.Survey_area.AutoScroll = true;
            this.Survey_area.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Survey_area.Controls.Add(this.label12);
            this.Survey_area.Controls.Add(this.label11);
            this.Survey_area.Controls.Add(this.label9);
            this.Survey_area.Controls.Add(this.label10);
            this.Survey_area.Controls.Add(this.label5);
            this.Survey_area.Controls.Add(this.label6);
            this.Survey_area.Controls.Add(this.label7);
            this.Survey_area.Controls.Add(this.label8);
            this.Survey_area.Controls.Add(this.label3);
            this.Survey_area.Controls.Add(this.label4);
            this.Survey_area.Controls.Add(this.label2);
            this.Survey_area.Controls.Add(this.label1);
            this.Survey_area.Controls.Add(this.panel1);
            this.Survey_area.Location = new System.Drawing.Point(256, 143);
            this.Survey_area.Name = "Survey_area";
            this.Survey_area.Size = new System.Drawing.Size(1176, 327);
            this.Survey_area.TabIndex = 5;
            this.Survey_area.Paint += new System.Windows.Forms.PaintEventHandler(this.Survey_area_Paint);
            // 
            // cmd_next
            // 
            this.cmd_next.Animated = true;
            this.cmd_next.AutoRoundedCorners = true;
            this.cmd_next.BorderRadius = 16;
            this.cmd_next.CheckedState.Parent = this.cmd_next;
            this.cmd_next.CustomImages.Parent = this.cmd_next;
            this.cmd_next.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cmd_next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cmd_next.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cmd_next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cmd_next.DisabledState.Parent = this.cmd_next;
            this.cmd_next.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmd_next.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_next.ForeColor = System.Drawing.Color.White;
            this.cmd_next.HoverState.Parent = this.cmd_next;
            this.cmd_next.Location = new System.Drawing.Point(490, 88);
            this.cmd_next.Name = "cmd_next";
            this.cmd_next.ShadowDecoration.Parent = this.cmd_next;
            this.cmd_next.Size = new System.Drawing.Size(176, 35);
            this.cmd_next.TabIndex = 6;
            this.cmd_next.Text = "Next Question --)";
            this.cmd_next.Click += new System.EventHandler(this.cmd_next_Click);
            // 
            // cmd_submit
            // 
            this.cmd_submit.Animated = true;
            this.cmd_submit.AutoRoundedCorners = true;
            this.cmd_submit.BorderRadius = 16;
            this.cmd_submit.CheckedState.Parent = this.cmd_submit;
            this.cmd_submit.CustomImages.Parent = this.cmd_submit;
            this.cmd_submit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cmd_submit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cmd_submit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cmd_submit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cmd_submit.DisabledState.Parent = this.cmd_submit;
            this.cmd_submit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmd_submit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_submit.ForeColor = System.Drawing.Color.White;
            this.cmd_submit.HoverState.Parent = this.cmd_submit;
            this.cmd_submit.Location = new System.Drawing.Point(1234, 488);
            this.cmd_submit.Name = "cmd_submit";
            this.cmd_submit.ShadowDecoration.Parent = this.cmd_submit;
            this.cmd_submit.Size = new System.Drawing.Size(176, 35);
            this.cmd_submit.TabIndex = 7;
            this.cmd_submit.Text = "Submit.";
            this.cmd_submit.Click += new System.EventHandler(this.cmd_submit_Click);
            // 
            // cmd_quit
            // 
            this.cmd_quit.Animated = true;
            this.cmd_quit.AutoRoundedCorners = true;
            this.cmd_quit.BorderRadius = 16;
            this.cmd_quit.CheckedState.Parent = this.cmd_quit;
            this.cmd_quit.CustomImages.Parent = this.cmd_quit;
            this.cmd_quit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cmd_quit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cmd_quit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cmd_quit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cmd_quit.DisabledState.Parent = this.cmd_quit;
            this.cmd_quit.FillColor = System.Drawing.Color.Red;
            this.cmd_quit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_quit.ForeColor = System.Drawing.Color.White;
            this.cmd_quit.HoverState.Parent = this.cmd_quit;
            this.cmd_quit.Location = new System.Drawing.Point(256, 488);
            this.cmd_quit.Name = "cmd_quit";
            this.cmd_quit.ShadowDecoration.Parent = this.cmd_quit;
            this.cmd_quit.Size = new System.Drawing.Size(176, 35);
            this.cmd_quit.TabIndex = 8;
            this.cmd_quit.Text = "Quit Survey.";
            this.cmd_quit.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2MessageDialog2
            // 
            this.guna2MessageDialog2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.guna2MessageDialog2.Caption = null;
            this.guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.guna2MessageDialog2.Parent = null;
            this.guna2MessageDialog2.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog2.Text = null;
            // 
            // guna2MessageDialog3
            // 
            this.guna2MessageDialog3.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog3.Caption = null;
            this.guna2MessageDialog3.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog3.Parent = null;
            this.guna2MessageDialog3.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog3.Text = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(319, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(368, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(466, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(417, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(664, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(613, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 25);
            this.label6.TabIndex = 59;
            this.label6.Text = "7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(564, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 25);
            this.label7.TabIndex = 58;
            this.label7.Text = "6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(515, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 25);
            this.label8.TabIndex = 57;
            this.label8.Text = "5";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(764, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 25);
            this.label9.TabIndex = 62;
            this.label9.Text = "10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(715, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 25);
            this.label10.TabIndex = 61;
            this.label10.Text = "9";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(917, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 25);
            this.label11.TabIndex = 63;
            this.label11.Text = "High";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(175, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 25);
            this.label12.TabIndex = 64;
            this.label12.Text = "Low";
            // 
            // surveyBindingSource
            // 
            this.surveyBindingSource.DataSource = typeof(SurveySystem.Usercontrols.Survey);
            // 
            // UC_takeSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.cmd_quit);
            this.Controls.Add(this.cmd_submit);
            this.Controls.Add(this.cmd_next);
            this.Controls.Add(this.Survey_area);
            this.Controls.Add(this.cmd_take_survey);
            this.Controls.Add(this.cmb_select_survey);
            this.Controls.Add(this.lbl_guide);
            this.Name = "UC_takeSurvey";
            this.Size = new System.Drawing.Size(1479, 564);
            this.Load += new System.EventHandler(this.UC_takeSurvey_Load);
            this.Survey_area.ResumeLayout(false);
            this.Survey_area.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.surveyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_guide;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        public  Guna.UI2.WinForms.Guna2ComboBox cmb_select_survey;
        private Guna.UI2.WinForms.Guna2Button cmd_take_survey;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Panel panel1;
        private Panel Survey_area;
        private BindingSource surveyBindingSource;
        private Guna.UI2.WinForms.Guna2Button cmd_next;
        private Guna.UI2.WinForms.Guna2Button cmd_submit;
        private Guna.UI2.WinForms.Guna2Button cmd_quit;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog2;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog3;
        private Label label1;
        private Label label9;
        private Label label10;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label12;
        private Label label11;
    }
}
