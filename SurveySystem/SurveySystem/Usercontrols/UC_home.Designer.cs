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
    partial class UC_home
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
            this.lbl_guide = new System.Windows.Forms.Label();
            this.lbl_greeting = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_guide
            // 
            this.lbl_guide.AutoSize = true;
            this.lbl_guide.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guide.ForeColor = System.Drawing.Color.White;
            this.lbl_guide.Location = new System.Drawing.Point(374, 189);
            this.lbl_guide.Name = "lbl_guide";
            this.lbl_guide.Size = new System.Drawing.Size(19, 28);
            this.lbl_guide.TabIndex = 7;
            this.lbl_guide.Text = " ";
            // 
            // lbl_greeting
            // 
            this.lbl_greeting.AutoSize = true;
            this.lbl_greeting.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_greeting.ForeColor = System.Drawing.Color.White;
            this.lbl_greeting.Location = new System.Drawing.Point(609, 137);
            this.lbl_greeting.Name = "lbl_greeting";
            this.lbl_greeting.Size = new System.Drawing.Size(130, 28);
            this.lbl_greeting.TabIndex = 6;
            this.lbl_greeting.Text = "Welcome ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1344, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Code box is a website/app product for posting and looking for answers to coding/p" +
    "rogramming related questions.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1352, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "The following survey app/system has been created to survey consumers about the so" +
    "ftware product (Code box).";
            // 
            // UC_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_guide);
            this.Controls.Add(this.lbl_greeting);
            this.Name = "UC_home";
            this.Size = new System.Drawing.Size(1479, 564);
            this.Load += new System.EventHandler(this.UC_home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_guide;
        private System.Windows.Forms.Label lbl_greeting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
