using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.VisualBasic;

namespace SurveySystem
{
    public partial class Sign_Up_Page : Form
    {

        Login_Page login_Page;                                                          // <the sign up page will be able to create both types of accounts>
        BinaryFormatter bf;                                                              // we will need binary formatters for serialization.
        BinaryFormatter bf2;
        bool allow_username = false;                                                    // turns true if username is given is unique..
        Survey_Page survey_page;                                                                                    

        public Sign_Up_Page()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void Sign_Up_Form_Load(object sender, EventArgs e)
        {
            this.Closing += Login_Page.Window_Closing;                                                      // setting up all basic things as form is loaded..

            radioButton1.Checked = true;
            txt_admin_key.Enabled = false;
            txt_admin_key.BackColor = Color.DimGray;

            survey_page = new Survey_Page();

        }

        private void create_btn_Click(object sender, EventArgs e)                                           //create account function called on click
        {                                                                                                   // all the validation checks done 
            string realname = txt_realname.Text;                                                            //all values retrieved and checked for validation
            string username = txt_username.Text;                                                            //values then passed into the create account function
            string password = txt_password.Text;
            string special_key = txt_admin_key.Text;

            switch (txt_admin_key.Enabled)
            {
                case false:
                                                                    // -<VALIDATION>- //

                    if (realname.Length < 1 || username.Length < 5 || password.Length < 7)
                    {

                        guna2MessageDialog1.Show("please make sure Your:\nusername is atleast 5 \n password is atleast 7\n Characters", "WARNING");
                    }
                    else
                    {
                        Create_account(realname, username, password, special_key);
                        
                    }
                    break;

                case true:

                    
                    if (realname.Length < 1 || username.Length < 5 || password.Length < 7 || special_key.Length < 5)
                    {

                        guna2MessageDialog1.Show("please make sure Your:\nusername is atleast 5 \n password is atleast 7\n special key atleast 5 \nCharacters" , "WARNING");
                    }
                    else
                    {
                        
                        Create_account(realname, username, password, special_key);
                        
                    }
                                                                   // -<VALIDATION>- //
                    break;
            }

            
        }

        private void Create_account(string realname, string username, string password, string specialkey) // function for creating accounts
        {
            username_exists_check_algo(Login_Page.list_of_all_accounts, username);
            DialogResult result;

            try
            {
                if (allow_username == true)
                {
                    switch (radioButton1.Checked)      // creating accounts according to the type chosen, (consumer or admin), if username is valid and unique...
                    {
                        case true:

                            Consumers account = new Consumers();
                            account.realname = realname;
                            account.username = username;
                            account.password = password;

                            Login_Page.list_of_all_accounts.Add(account);                           // Adding consumer account to the main list 

                            bf = new BinaryFormatter();
                            Stream stream1;
                            stream1 = File.Open("system_users.dat", FileMode.Open);                        // serializing updated list.
                            bf.Serialize(stream1, Login_Page.list_of_all_accounts);
                            stream1.Close();

                            result = guna2MessageDialog2.Show("Created account successfully\n Go to survey page?", "INFO");  // asking the user to 
                                                                                                                             //be taken to survey page
                            if (result == DialogResult.Yes)
                            {
                                Login_Page.account_type = "Consumer";                               // setting the static variable to Consumer type
                                Login_Page.current_user = username;                                 // setting static current user to username.
                                survey_page.Show();
                                this.Hide();
                            }
                            else
                            {
                                txt_admin_key.Clear(); txt_password.Clear(); txt_realname.Clear(); txt_username.Clear();
                            }

                            break;

                        case false:

                            string secret_access_key = Interaction.InputBox("To create an admin account\n you need to enter secret phrase");       // this key is what will make sure that only 
                                                                                                          // authorised people are going to make admin accounts
                            if (secret_access_key == "birdchirper123")                                    // the key can be found by: other admins or in user docs.
                            {
                                Administrators account_ = new Administrators();
                                account_.realname = realname;
                                account_.username = username;
                                account_.password = password;
                                account_.spe_key = specialkey;

                                Login_Page.list_of_all_accounts.Add(account_);                          //Adding administrator account to main list

                                bf2 = new BinaryFormatter();
                                Stream stream2;
                                stream2 = File.Open("system_users.dat", FileMode.Open);                        // serializing updated list.
                                bf2.Serialize(stream2, Login_Page.list_of_all_accounts);
                                stream2.Close();

                                result = guna2MessageDialog2.Show("Created account successfully\n Go to survey page?", "INFO");  // asking the user to 
                                if (result == DialogResult.Yes)                                                                                 //be taken to survey page
                                {
                                    Login_Page.account_type = "Administrator";                               // setting the static variable to Admin type
                                    Login_Page.current_user = username;                                 // setting static current user to username.
                                    survey_page.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    txt_admin_key.Clear(); txt_password.Clear(); txt_realname.Clear(); txt_username.Clear();
                                }
                            }
                            else
                            {
                                guna2MessageDialog1.Show("The key is wrong,\n Please ask other admins for the key\nor check in the user documentation");
                            }


                            break;
                    }
                }
                else
                {
                    MessageBox.Show("This Username already Exists...");
                }
            }
            catch (Exception error1)
            {
                MessageBox.Show(error1.Message);
            }
        }

        private void username_exists_check_algo(List<Users> list, string username)    // this function is for checking if the given username exists in the list
        {                                                                             // this is to make sure duplicate are avoided since an account is 
            int c = 0;                                                                // unique because of its username..
                                                                                            
            allow_username = true;

            while (c < list.Count)                                    // -< Linear search - Time complexity O(n). >-
            {
                if(username == list[c].username)
                {
                    allow_username = false;
                }
                c++;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            switch (radioButton2.Checked)                                                           // the textbox for special key gets enabled or disabled accoding to the 
            {                                                                                       // user being an admin or not
                case true:
                    txt_admin_key.Enabled = true;
                    txt_admin_key.BackColor = Color.White;
                    break;

                case false:
                    txt_admin_key.Enabled = false;
                    txt_admin_key.BackColor = Color.DimGray;
                    break;

                default:
                    txt_admin_key.Enabled = true;
                    txt_admin_key.BackColor = Color.White;
                    break;
            }
        }

        private void LogIn_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login_Page = new Login_Page();                                                                  // this link takes you to login page...
            login_Page.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_realname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//Shihab Mirza 2021