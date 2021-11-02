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
    partial class UC_ViewAnalysis
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.cmb_select_survey = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.Survey_area = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.question_panel = new System.Windows.Forms.Panel();
            this.count_lbl = new System.Windows.Forms.Label();
            this.desc_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_create = new Guna.UI2.WinForms.Guna2Button();
            this.Survey_area.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
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
            this.cmb_select_survey.Location = new System.Drawing.Point(60, 96);
            this.cmb_select_survey.Name = "cmb_select_survey";
            this.cmb_select_survey.ShadowDecoration.Parent = this.cmb_select_survey;
            this.cmb_select_survey.Size = new System.Drawing.Size(208, 21);
            this.cmb_select_survey.TabIndex = 4;
            this.cmb_select_survey.SelectedIndexChanged += new System.EventHandler(this.cmb_select_survey_SelectedIndexChanged);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.ForeColor = System.Drawing.Color.White;
            this.lbl_info.Location = new System.Drawing.Point(55, 36);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(506, 25);
            this.lbl_info.TabIndex = 3;
            this.lbl_info.Text = "Please choose a survey that you wish to analyse:";
            // 
            // Survey_area
            // 
            this.Survey_area.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Survey_area.Controls.Add(this.guna2Separator1);
            this.Survey_area.Controls.Add(this.label8);
            this.Survey_area.Controls.Add(this.label7);
            this.Survey_area.Controls.Add(this.label6);
            this.Survey_area.Controls.Add(this.label5);
            this.Survey_area.Controls.Add(this.label3);
            this.Survey_area.Controls.Add(this.question_panel);
            this.Survey_area.Controls.Add(this.count_lbl);
            this.Survey_area.Controls.Add(this.desc_lbl);
            this.Survey_area.Controls.Add(this.panel1);
            this.Survey_area.Location = new System.Drawing.Point(279, 96);
            this.Survey_area.Name = "Survey_area";
            this.Survey_area.Size = new System.Drawing.Size(1176, 406);
            this.Survey_area.TabIndex = 6;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(3, 146);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1171, 10);
            this.guna2Separator1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1018, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 56;
            this.label8.Text = "Average";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(789, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 25);
            this.label7.TabIndex = 59;
            this.label7.Text = "No responses";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(541, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "Yes responses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(277, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 58;
            this.label5.Text = "Question type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "Question no.";
            // 
            // question_panel
            // 
            this.question_panel.AutoScroll = true;
            this.question_panel.Location = new System.Drawing.Point(-2, 146);
            this.question_panel.Name = "question_panel";
            this.question_panel.Size = new System.Drawing.Size(1176, 258);
            this.question_panel.TabIndex = 56;
            this.question_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.question_panel_Paint);
            // 
            // count_lbl
            // 
            this.count_lbl.AutoSize = true;
            this.count_lbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_lbl.ForeColor = System.Drawing.Color.White;
            this.count_lbl.Location = new System.Drawing.Point(32, 67);
            this.count_lbl.Name = "count_lbl";
            this.count_lbl.Size = new System.Drawing.Size(227, 25);
            this.count_lbl.TabIndex = 54;
            this.count_lbl.Text = "Number of questions:";
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_lbl.ForeColor = System.Drawing.Color.White;
            this.desc_lbl.Location = new System.Drawing.Point(32, 26);
            this.desc_lbl.Name = "desc_lbl";
            this.desc_lbl.Size = new System.Drawing.Size(204, 25);
            this.desc_lbl.TabIndex = 53;
            this.desc_lbl.Text = "Survey description:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(936, 636);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 65);
            this.panel1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(756, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Analysis area.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(1014, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "*Only participated surveys can be analysed";
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
            this.cmd_create.Location = new System.Drawing.Point(750, 508);
            this.cmd_create.Name = "cmd_create";
            this.cmd_create.ShadowDecoration.Parent = this.cmd_create;
            this.cmd_create.Size = new System.Drawing.Size(180, 36);
            this.cmd_create.TabIndex = 9;
            this.cmd_create.Text = "Save As report.";
            this.cmd_create.Click += new System.EventHandler(this.cmd_create_Click);
            // 
            // UC_ViewAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.cmd_create);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Survey_area);
            this.Controls.Add(this.cmb_select_survey);
            this.Controls.Add(this.lbl_info);
            this.Name = "UC_ViewAnalysis";
            this.Size = new System.Drawing.Size(1479, 564);
            this.Load += new System.EventHandler(this.UC_ViewAnalysis_Load);
            this.Survey_area.ResumeLayout(false);
            this.Survey_area.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        public Guna.UI2.WinForms.Guna2ComboBox cmb_select_survey;
        public Label lbl_info;
        private Panel Survey_area;
        private Panel panel1;
        public Label label1;
        public Label count_lbl;
        public Label desc_lbl;
        public Label label2;
        private Panel question_panel;
        public Label label8;
        public Label label7;
        public Label label6;
        public Label label5;
        public Label label3;
        private Guna.UI2.WinForms.Guna2Button cmd_create;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
