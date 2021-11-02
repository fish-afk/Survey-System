using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveySystem.Usercontrols                                         // <--- Notice the name space, we are using usercontrols...
{
    public partial class UC_home : UserControl
    {
        public UC_home()
        {
            InitializeComponent();
        }

        private void UC_home_Load(object sender, EventArgs e)
        {
            if (Login_Page.account_type == "Consumer")
            {
                lbl_greeting.Text += $" {Login_Page.current_user} !\n";
                lbl_guide.Text = "Please feel free to take a survey...\n       Your account is limited.\n You have a consumer role!";
                

            }
            else if (Login_Page.account_type == "Administrator")
            {
                lbl_greeting.Text += $" {Login_Page.current_user} !\n";
                lbl_guide.Text += $"You may use any features. You have An Admin role!";

            }
        }
    }
}
