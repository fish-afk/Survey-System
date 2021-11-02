using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveySystem
{
    public partial class Login_Page : Form
    {
        int password_hide_count;                               //variable for keeping track of checkbox event
        Sign_Up_Page sign_up_frm;                               
        int admin_key_field_count;                             // varaible for the admin texbox to be enabled or disabled
        Survey_Page survey_Page;
        int count = 125;
        public static string current_user;                                   // this will keep track of the user that has logged in...
        public static string account_type;                                   // this will keep track of what kind of account has logged in.

        
        /// <summary>
        /// futher variables that will be used for other logic...
        /// </summary>
        bool allow_login;
        bool Is_admin= false;

        public static List<Users> list_of_all_accounts = new List<Users>();  /// <summary>
                                                                             ///This list will hold all of our accounts, (both types)(polymorphishm)
                                                                             /// it is static because it needs to be accessed globally through 
                                                                             /// the program..
                                                                             /// </summary>
        public Login_Page()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {
            //Setting up form for user....
            try
            {
                survey_Page = new Survey_Page();
                txt_admin_key.Enabled = false; txt_admin_key.BackColor = Color.DimGray; txt_admin_key.UseSystemPasswordChar = false;
                txt_password.UseSystemPasswordChar = true;
                this.Closing += Window_Closing;
                timer1.Stop();

                Timer_tick_lbl.Text = " ";
                Timer_tick_lbl.ForeColor = Color.Transparent;
            }catch(Exception error1)
            {
                MessageBox.Show(error1.Message);
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password_hide_count ++ ;

            bool GetState(int counter) => counter % 2 == 0 ? txt_password.UseSystemPasswordChar = true : txt_password.UseSystemPasswordChar = false;

            GetState(password_hide_count);

            //The code above is using a ternary operator "?" with the help of an arrow function, a shorter 1 line way of doing an if else statement... 
            
        }
        public static void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) // making this function static so that we dont have to make in all
        {                                                                                         // forms, and we can simply reference this one without making an
            //change the event to avoid close form                                                // object of this form
            Environment.Exit(0);
            
        }                                                                             
        

        private void SignUp_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up_frm = new Sign_Up_Page();
            txt_password.Text = "";     txt_username.Text = "";     txt_admin_key.Text = "";   //clearing textboxes before moving on to signup form...
            sign_up_frm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            admin_key_field_count++;

            if (admin_key_field_count % 2 == 0)
            {
                txt_admin_key.Clear();
                txt_admin_key.Enabled = false;
                txt_admin_key.BackColor = Color.DimGray;
            }
            else
            {
                txt_admin_key.Enabled = true;
                txt_admin_key.BackColor = Color.White;
            }

          
            // same logic as for the first checkbox, but using different way...
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string special_key_for_admins = txt_admin_key.Text;
            

            if (chk_admin.Checked == true)
            {
                Is_admin = true;
                Administrators.login_attempts -= 1;
            }
            else
            {
                Is_admin = false;
                Consumers.login_attempts -= 1;
            }

            if (Consumers.login_attempts == 0 || Administrators.login_attempts == 0)
            {
               
                Timer_tick_lbl.ForeColor = Color.Red;                                       //Disabling log in button once the attempts reach 0.
                timer1.Start();
                Login_btn.Enabled = false;                                                  //Also will trigger the timer.start() which will trigger tick event.
                Login_btn.BackColor = Color.DimGray;
                guna2MessageDialog1.Show("you have ran out of attempts....\n wait for 2 minutes");
                SignUp_link.Enabled = false;
                
            }
           
            
            check_credential_correctness(username, password, special_key_for_admins, Is_admin); // Function for checking validation of login credentials....

            if (Is_admin == true)
            {
                if (allow_login == true)
                {
                    survey_Page.Show();                                                                          // note that we cant just say that the username 
                    this.Hide();
                }                                                                                                 // is incorrect since that will be very 
                else
                {                                                                                                // easy for a malicious hacker to get into someones
                    guna2MessageDialog1.Show("The password , username or special key is Incorrect...");         // account if he already then knows one of the crednetials
                }
            }
            else
            {
                if (allow_login == true)
                {
                    survey_Page.Show();
                    this.Hide();
                }
                else
                {
                    guna2MessageDialog1.Show("The password or username is Incorrect...");
                }
            }
        }
        private void check_credential_correctness(string username, string password, string special_key_for_admins, bool admin_state)  //searching func
        {
            try
            {
                allow_login = false; // <--- False by default.

                List<string> spe_keys = new List<string>();                        // now to access the properties of the child classes will be tricky, so for that 
                                                                                   // we will have to iterate through all the child objects we are looking for 
                foreach (Users user in list_of_all_accounts)                        // in the main list and find their properties that we need
                {                                                                  // and store them in a separate list..
                    if (user is Administrators administrator)
                    {
                        spe_keys.Add(administrator.spe_key);
                    }
                }

                for (int i = 0; i < list_of_all_accounts.Count; i++)                // the following loop is a bit complex since the spe_keys has its own list
                {                                                                  // so we will have to iterate thorugh it as well, without getting index out of range
                    if (admin_state == true)                                       // error. so we use a nested for loop, A bit more tedious and Time and performance
                    {                                                              // consuming, but thats not what we are worried about for now ...
                        for (int c = 0; c < spe_keys.Count; c++)                   // --------------Time complexity O(n^2) if first case is true------------
                        {
                            if (username == list_of_all_accounts[i].username && password == list_of_all_accounts[i].password && special_key_for_admins == spe_keys[c])
                            {
                                allow_login = true;
                                current_user = username;
                                account_type = "Administrator";                     // variable to be used in survey form
                            }

                        }
                    }
                    else
                    {
                        if (username == list_of_all_accounts[i].username && password == list_of_all_accounts[i].password)
                        {
                            allow_login = true;
                            current_user = username;
                            account_type = "Consumer";                             // variable to be used in survey form
                        }
                    }
                }
                // -----------------------Time complexity O(n^2) --> if admin state is true, else: O(n)--------------------------
                //----------------------------------Space complexity O(1)--------------------------------------------------------
            }
            catch (Exception error2)
            {
                MessageBox.Show(error2.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)   //timer tick event..
        {

            count--;
            Timer_tick_lbl.Text = $"wait for {count} seconds..";

            if (count == 0)
            {
                Consumers.login_attempts = 6;                    // Resetting all the necessary things once timer reaches 0;
                Administrators.login_attempts = 3;                 // also stopping timer ..
                timer1.Stop();                                       // And enabling button again..
                count = 125;
                Login_btn.Enabled = true;
                Login_btn.BackColor = Color.White;
                Timer_tick_lbl.Text = " ";
                SignUp_link.Enabled = true;
            }
        }
    }
}
//Shihab Mirza 2021