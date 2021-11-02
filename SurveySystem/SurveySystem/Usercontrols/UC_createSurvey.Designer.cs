using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SurveySystem.Usercontrols
{
    partial class UC_createSurvey
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
            this.cmb_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_question = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_add = new Guna.UI2.WinForms.Guna2Button();
            this.cmd_create = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_desc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.grp_likert_option = new System.Windows.Forms.GroupBox();
            this.opt5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.opt3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.opt4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.opt2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.opt1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.grp_likert_option.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_type
            // 
            this.cmb_type.BackColor = System.Drawing.Color.Transparent;
            this.cmb_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_type.FocusedState.Parent = this.cmb_type;
            this.cmb_type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_type.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmb_type.HoverState.Parent = this.cmb_type;
            this.cmb_type.ItemHeight = 20;
            this.cmb_type.Items.AddRange(new object[] {
            "5- Point likert",
            "Rating scale 1 - 10",
            "Yes or No"});
            this.cmb_type.ItemsAppearance.Parent = this.cmb_type;
            this.cmb_type.Location = new System.Drawing.Point(406, 186);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.ShadowDecoration.Parent = this.cmb_type;
            this.cmb_type.Size = new System.Drawing.Size(173, 26);
            this.cmb_type.TabIndex = 0;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(166, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question type:";
            // 
            // txt_question
            // 
            this.txt_question.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_question.DefaultText = "";
            this.txt_question.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_question.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_question.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_question.DisabledState.Parent = this.txt_question;
            this.txt_question.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_question.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_question.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_question.FocusedState.Parent = this.txt_question;
            this.txt_question.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_question.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_question.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_question.HoverState.Parent = this.txt_question;
            this.txt_question.Location = new System.Drawing.Point(406, 110);
            this.txt_question.MaxLength = 300;
            this.txt_question.Name = "txt_question";
            this.txt_question.PasswordChar = '\0';
            this.txt_question.PlaceholderText = "";
            this.txt_question.SelectedText = "";
            this.txt_question.ShadowDecoration.Parent = this.txt_question;
            this.txt_question.Size = new System.Drawing.Size(887, 33);
            this.txt_question.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(166, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter question here:";
            // 
            // cmd_add
            // 
            this.cmd_add.Animated = true;
            this.cmd_add.CheckedState.Parent = this.cmd_add;
            this.cmd_add.CustomImages.Parent = this.cmd_add;
            this.cmd_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cmd_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cmd_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cmd_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cmd_add.DisabledState.Parent = this.cmd_add;
            this.cmd_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(230)))));
            this.cmd_add.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmd_add.ForeColor = System.Drawing.Color.White;
            this.cmd_add.HoverState.Parent = this.cmd_add;
            this.cmd_add.Location = new System.Drawing.Point(723, 176);
            this.cmd_add.Name = "cmd_add";
            this.cmd_add.ShadowDecoration.Parent = this.cmd_add;
            this.cmd_add.Size = new System.Drawing.Size(180, 36);
            this.cmd_add.TabIndex = 4;
            this.cmd_add.Text = "Add Question.";
            this.cmd_add.Click += new System.EventHandler(this.cmd_add_Click);
            // 
            // cmd_create
            // 
            this.cmd_create.Animated = true;
            this.cmd_create.CheckedState.Parent = this.cmd_create;
            this.cmd_create.CustomImages.Parent = this.cmd_create;
            this.cmd_create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cmd_create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cmd_create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cmd_create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cmd_create.DisabledState.Parent = this.cmd_create;
            this.cmd_create.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(230)))));
            this.cmd_create.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmd_create.ForeColor = System.Drawing.Color.White;
            this.cmd_create.HoverState.Parent = this.cmd_create;
            this.cmd_create.Location = new System.Drawing.Point(658, 483);
            this.cmd_create.Name = "cmd_create";
            this.cmd_create.ShadowDecoration.Parent = this.cmd_create;
            this.cmd_create.Size = new System.Drawing.Size(180, 46);
            this.cmd_create.TabIndex = 5;
            this.cmd_create.Text = "Create Survey!";
            this.cmd_create.Click += new System.EventHandler(this.cmd_create_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(81, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(779, 50);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add Atleast 6 questions to the survey then hit Create. \r\nIf you choose 5 point li" +
    "kert type questions, please specify the options as well";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(166, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Survey Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(166, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Survey Name:";
            // 
            // txt_desc
            // 
            this.txt_desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_desc.DefaultText = "";
            this.txt_desc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_desc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_desc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_desc.DisabledState.Parent = this.txt_desc;
            this.txt_desc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_desc.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_desc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_desc.FocusedState.Parent = this.txt_desc;
            this.txt_desc.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_desc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_desc.HoverState.Parent = this.txt_desc;
            this.txt_desc.Location = new System.Drawing.Point(403, 335);
            this.txt_desc.MaxLength = 100;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.PasswordChar = '\0';
            this.txt_desc.PlaceholderText = "";
            this.txt_desc.SelectedText = "";
            this.txt_desc.ShadowDecoration.Parent = this.txt_desc;
            this.txt_desc.Size = new System.Drawing.Size(887, 33);
            this.txt_desc.TabIndex = 10;
            // 
            // txtname
            // 
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.DefaultText = "";
            this.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.DisabledState.Parent = this.txtname;
            this.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.FocusedState.Parent = this.txtname;
            this.txtname.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.HoverState.Parent = this.txtname;
            this.txtname.Location = new System.Drawing.Point(406, 406);
            this.txtname.MaxLength = 20;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "";
            this.txtname.SelectedText = "";
            this.txtname.ShadowDecoration.Parent = this.txtname;
            this.txtname.Size = new System.Drawing.Size(432, 33);
            this.txtname.TabIndex = 11;
            // 
            // grp_likert_option
            // 
            this.grp_likert_option.Controls.Add(this.opt5);
            this.grp_likert_option.Controls.Add(this.label10);
            this.grp_likert_option.Controls.Add(this.opt3);
            this.grp_likert_option.Controls.Add(this.label9);
            this.grp_likert_option.Controls.Add(this.opt4);
            this.grp_likert_option.Controls.Add(this.label8);
            this.grp_likert_option.Controls.Add(this.opt2);
            this.grp_likert_option.Controls.Add(this.label7);
            this.grp_likert_option.Controls.Add(this.opt1);
            this.grp_likert_option.Controls.Add(this.label3);
            this.grp_likert_option.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_likert_option.Location = new System.Drawing.Point(171, 242);
            this.grp_likert_option.Name = "grp_likert_option";
            this.grp_likert_option.Size = new System.Drawing.Size(1122, 53);
            this.grp_likert_option.TabIndex = 12;
            this.grp_likert_option.TabStop = false;
            this.grp_likert_option.Text = "                    ";
            // 
            // opt5
            // 
            this.opt5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.opt5.DefaultText = "";
            this.opt5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.opt5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.opt5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.opt5.DisabledState.Parent = this.opt5;
            this.opt5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.opt5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.opt5.FocusedState.Parent = this.opt5;
            this.opt5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.opt5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.opt5.HoverState.Parent = this.opt5;
            this.opt5.Location = new System.Drawing.Point(1001, 18);
            this.opt5.MaxLength = 13;
            this.opt5.Name = "opt5";
            this.opt5.PasswordChar = '\0';
            this.opt5.PlaceholderText = "";
            this.opt5.SelectedText = "";
            this.opt5.ShadowDecoration.Parent = this.opt5;
            this.opt5.Size = new System.Drawing.Size(91, 18);
            this.opt5.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(911, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Option 5:";
            // 
            // opt3
            // 
            this.opt3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.opt3.DefaultText = "";
            this.opt3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.opt3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.opt3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.opt3.DisabledState.Parent = this.opt3;
            this.opt3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.opt3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.opt3.FocusedState.Parent = this.opt3;
            this.opt3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.opt3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.opt3.HoverState.Parent = this.opt3;
            this.opt3.Location = new System.Drawing.Point(562, 17);
            this.opt3.MaxLength = 13;
            this.opt3.Name = "opt3";
            this.opt3.PasswordChar = '\0';
            this.opt3.PlaceholderText = "";
            this.opt3.SelectedText = "";
            this.opt3.ShadowDecoration.Parent = this.opt3;
            this.opt3.Size = new System.Drawing.Size(92, 18);
            this.opt3.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(472, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Option 3:";
            // 
            // opt4
            // 
            this.opt4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.opt4.DefaultText = "";
            this.opt4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.opt4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.opt4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.opt4.DisabledState.Parent = this.opt4;
            this.opt4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.opt4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.opt4.FocusedState.Parent = this.opt4;
            this.opt4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.opt4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.opt4.HoverState.Parent = this.opt4;
            this.opt4.Location = new System.Drawing.Point(787, 18);
            this.opt4.MaxLength = 13;
            this.opt4.Name = "opt4";
            this.opt4.PasswordChar = '\0';
            this.opt4.PlaceholderText = "";
            this.opt4.SelectedText = "";
            this.opt4.ShadowDecoration.Parent = this.opt4;
            this.opt4.Size = new System.Drawing.Size(93, 18);
            this.opt4.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(689, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Option 4:";
            // 
            // opt2
            // 
            this.opt2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.opt2.DefaultText = "";
            this.opt2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.opt2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.opt2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.opt2.DisabledState.Parent = this.opt2;
            this.opt2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.opt2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.opt2.FocusedState.Parent = this.opt2;
            this.opt2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.opt2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.opt2.HoverState.Parent = this.opt2;
            this.opt2.Location = new System.Drawing.Point(325, 18);
            this.opt2.MaxLength = 13;
            this.opt2.Name = "opt2";
            this.opt2.PasswordChar = '\0';
            this.opt2.PlaceholderText = "";
            this.opt2.SelectedText = "";
            this.opt2.ShadowDecoration.Parent = this.opt2;
            this.opt2.Size = new System.Drawing.Size(95, 18);
            this.opt2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(235, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Option 2:";
            // 
            // opt1
            // 
            this.opt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.opt1.DefaultText = "";
            this.opt1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.opt1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.opt1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.opt1.DisabledState.Parent = this.opt1;
            this.opt1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.opt1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.opt1.FocusedState.Parent = this.opt1;
            this.opt1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.opt1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.opt1.HoverState.Parent = this.opt1;
            this.opt1.Location = new System.Drawing.Point(118, 18);
            this.opt1.MaxLength = 13;
            this.opt1.Name = "opt1";
            this.opt1.PasswordChar = '\0';
            this.opt1.PlaceholderText = "";
            this.opt1.SelectedText = "";
            this.opt1.ShadowDecoration.Parent = this.opt1;
            this.opt1.Size = new System.Drawing.Size(89, 18);
            this.opt1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Option 1:";
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(1124, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "*All Fields Mandatory";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_count.Location = new System.Drawing.Point(1135, 187);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(225, 25);
            this.lbl_count.TabIndex = 14;
            this.lbl_count.Text = "Questions Added = 0";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.White;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 77);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1479, 10);
            this.guna2Separator1.TabIndex = 15;
            // 
            // UC_createSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grp_likert_option);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmd_create);
            this.Controls.Add(this.cmd_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_question);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_type);
            this.Name = "UC_createSurvey";
            this.Size = new System.Drawing.Size(1479, 564);
            this.Load += new System.EventHandler(this.UC_createSurvey_Load);
            this.grp_likert_option.ResumeLayout(false);
            this.grp_likert_option.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmb_type;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_question;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button cmd_add;
        private Guna.UI2.WinForms.Guna2Button cmd_create;
        private Label label4;
        private Label label5;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_desc;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private GroupBox grp_likert_option;
        private Guna.UI2.WinForms.Guna2TextBox opt5;
        private Label label10;
        private Guna.UI2.WinForms.Guna2TextBox opt3;
        private Label label9;
        private Guna.UI2.WinForms.Guna2TextBox opt4;
        private Label label8;
        private Guna.UI2.WinForms.Guna2TextBox opt2;
        private Label label7;
        private Guna.UI2.WinForms.Guna2TextBox opt1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Label label11;
        private Label lbl_count;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
