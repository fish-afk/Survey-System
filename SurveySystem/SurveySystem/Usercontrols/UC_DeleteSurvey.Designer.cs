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
    partial class UC_DeleteSurvey
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
            this.lbl_info = new System.Windows.Forms.Label();
            this.cmd_delete = new Guna.UI2.WinForms.Guna2Button();
            this.cmb_select_survey = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Survey_area = new System.Windows.Forms.Panel();
            this.lbl_quest_count = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.Survey_area.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.ForeColor = System.Drawing.Color.White;
            this.lbl_info.Location = new System.Drawing.Point(43, 31);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(593, 25);
            this.lbl_info.TabIndex = 8;
            this.lbl_info.Text = "Choose the survey that you want to delete permanently...";
            // 
            // cmd_delete
            // 
            this.cmd_delete.Animated = true;
            this.cmd_delete.CheckedState.Parent = this.cmd_delete;
            this.cmd_delete.CustomImages.Parent = this.cmd_delete;
            this.cmd_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cmd_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cmd_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cmd_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cmd_delete.DisabledState.Parent = this.cmd_delete;
            this.cmd_delete.FillColor = System.Drawing.Color.Maroon;
            this.cmd_delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmd_delete.ForeColor = System.Drawing.Color.White;
            this.cmd_delete.HoverState.Parent = this.cmd_delete;
            this.cmd_delete.Location = new System.Drawing.Point(726, 481);
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.ShadowDecoration.Parent = this.cmd_delete;
            this.cmd_delete.Size = new System.Drawing.Size(180, 46);
            this.cmd_delete.TabIndex = 9;
            this.cmd_delete.Text = "Delete Survey !";
            this.cmd_delete.Click += new System.EventHandler(this.cmd_delete_Click);
            // 
            // cmb_select_survey
            // 
            this.cmb_select_survey.BackColor = System.Drawing.Color.Transparent;
            this.cmb_select_survey.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_select_survey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_select_survey.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_select_survey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_select_survey.FocusedState.Parent = this.cmb_select_survey;
            this.cmb_select_survey.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_select_survey.ForeColor = System.Drawing.Color.Red;
            this.cmb_select_survey.HoverState.Parent = this.cmb_select_survey;
            this.cmb_select_survey.ItemHeight = 15;
            this.cmb_select_survey.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmb_select_survey.ItemsAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_select_survey.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cmb_select_survey.ItemsAppearance.Parent = this.cmb_select_survey;
            this.cmb_select_survey.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_select_survey.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Red;
            this.cmb_select_survey.Location = new System.Drawing.Point(48, 97);
            this.cmb_select_survey.Name = "cmb_select_survey";
            this.cmb_select_survey.ShadowDecoration.Parent = this.cmb_select_survey;
            this.cmb_select_survey.Size = new System.Drawing.Size(140, 21);
            this.cmb_select_survey.TabIndex = 10;
            this.cmb_select_survey.SelectedIndexChanged += new System.EventHandler(this.cmb_select_survey_SelectedIndexChanged);
            // 
            // Survey_area
            // 
            this.Survey_area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Survey_area.Controls.Add(this.lbl_quest_count);
            this.Survey_area.Controls.Add(this.lbl_description);
            this.Survey_area.Controls.Add(this.label3);
            this.Survey_area.Controls.Add(this.label2);
            this.Survey_area.Controls.Add(this.panel1);
            this.Survey_area.Location = new System.Drawing.Point(236, 145);
            this.Survey_area.Name = "Survey_area";
            this.Survey_area.Size = new System.Drawing.Size(1171, 310);
            this.Survey_area.TabIndex = 11;
            // 
            // lbl_quest_count
            // 
            this.lbl_quest_count.AutoSize = true;
            this.lbl_quest_count.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quest_count.ForeColor = System.Drawing.Color.White;
            this.lbl_quest_count.Location = new System.Drawing.Point(240, 234);
            this.lbl_quest_count.Name = "lbl_quest_count";
            this.lbl_quest_count.Size = new System.Drawing.Size(30, 25);
            this.lbl_quest_count.TabIndex = 57;
            this.lbl_quest_count.Text = "   ";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.White;
            this.lbl_description.Location = new System.Drawing.Point(213, 48);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(30, 25);
            this.lbl_description.TabIndex = 56;
            this.lbl_description.Text = "   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = "Question count :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Description :";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1015, 734);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 386);
            this.panel1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(744, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Survey Info";
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
            // UC_DeleteSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.Survey_area);
            this.Controls.Add(this.cmb_select_survey);
            this.Controls.Add(this.cmd_delete);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.label1);
            this.Name = "UC_DeleteSurvey";
            this.Size = new System.Drawing.Size(1479, 564);
            this.Load += new System.EventHandler(this.UC_DeleteSurvey_Load);
            this.Survey_area.ResumeLayout(false);
            this.Survey_area.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label lbl_info;
        private Guna.UI2.WinForms.Guna2Button cmd_delete;
        public Guna.UI2.WinForms.Guna2ComboBox cmb_select_survey;
        private Panel Survey_area;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label lbl_quest_count;
        private Label lbl_description;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}
