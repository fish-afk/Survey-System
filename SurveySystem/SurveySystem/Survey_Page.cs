using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using SurveySystem.Usercontrols;

namespace SurveySystem
{
    public partial class Survey_Page : Form
    {
        // for the survey page, we will be using the help of usercontrols, which we will be able to witch through in the same form,
        // 5 user controls //

        UC_createSurvey create_survey;
        UC_DeleteSurvey delete_survey;
        UC_takeSurvey take_survey;
        UC_ViewAnalysis view_analysis;
        UC_home home;

        // we will need this if someone wants to log out..
        Login_Page login_page;

        public Survey_Page()
        {
            InitializeComponent();
        }

        private void Survey_Page_Load(object sender, EventArgs e)
        {

            create_survey = new UC_createSurvey();                                  //instantiate all user controls as form loads..
            delete_survey = new UC_DeleteSurvey();
            take_survey = new UC_takeSurvey();
            view_analysis = new UC_ViewAnalysis();
            home = new UC_home();
            this.MaximizeBox = false;

            cmd_home.PerformClick();                                            // be on the home usercontrol by default...

            this.Closing += Login_Page.Window_Closing;

            if (Login_Page.account_type == "Consumer")                             // if the person has a consumer account, the other buttons will be disabled
            {
                cmd_create_survey.Enabled = false; cmd_delete_survey.Enabled = false; cmd_view_analysis.Enabled = false;
            }

            lbl_user.Text += Login_Page.current_user;                               // for updating the label at the top with the current user name and account type.
            lbl_account_type.Text += Login_Page.account_type;

        }

        private void addUserControl(UserControl userControl)                    // function for helping us switch through the user controls, by the help of panel
        {
            userControl.Dock = DockStyle.Fill;
            container_panel.Controls.Clear();
            container_panel.Controls.Add(userControl);
            userControl.BringToFront();
        }
             // that function is then called accordingly as a person clicks a button for navigation, and the appropriate usercontrol is passed in as an arg.
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();                                            ///deserealzing all the survey objects into the main 
                Stream stream2;                                                                         /// Survey list...
                stream2 = File.Open("Surveys.dat", FileMode.Open);
                UC_createSurvey.list_of_surveys = (List<Survey>)bf.Deserialize(stream2);
                stream2.Close();


                //clearing current items, to avoid repetition of items
                take_survey.cmb_select_survey.Items.Clear();                                               // for this part, we are saying that whenever it is pressed
                                                                                                           // we want the combo box to update the items with the 
                for (int i = 1; i < UC_createSurvey.list_of_surveys.Count; i++)                                     // surveys we current have in the list
                {
                    take_survey.cmb_select_survey.Items.Add(UC_createSurvey.list_of_surveys[i].get_survey_name());
                }


                addUserControl(take_survey);
            }
            catch (Exception error1)
            {
                MessageBox.Show(error1.Message);
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            addUserControl(create_survey);
        }

        private void guna2Button3_Click(object sender, EventArgs e) {
            try
            {
                BinaryFormatter bf2 = new BinaryFormatter();                                            ///deserealzing all the survey objects into the main 
                Stream stream2;                                                                         /// Survey list...
                stream2 = File.Open("Surveys.dat", FileMode.Open);
                UC_createSurvey.list_of_surveys = (List<Survey>)bf2.Deserialize(stream2);
                stream2.Close();

                //clearing current items, to avoid repetition of items
                delete_survey.cmb_select_survey.Items.Clear();                                              // for this part, we are saying that whenever it is pressed
                                                                                                            // we want the combo box to update the items with the 
                for (int i = 1; i < UC_createSurvey.list_of_surveys.Count; i++)                                      // surveys we current have in the list
                {
                    delete_survey.cmb_select_survey.Items.Add(UC_createSurvey.list_of_surveys[i].get_survey_name());
                }

                if (UC_createSurvey.list_of_surveys.Count == 0)
                {
                    delete_survey.lbl_info.Text = "No surveys currently available.";
                }
                else
                {
                    delete_survey.lbl_info.Text = "Choose the survey that you want to delete permanently...";
                }

                addUserControl(delete_survey);
            }
            catch (Exception error1)
            {
                MessageBox.Show(error1.Message);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter bf2 = new BinaryFormatter();                                            ///deserealzing all the survey objects into the main 
                Stream stream2;                                                                         /// Survey list...
                stream2 = File.Open("Survey_answers.dat", FileMode.Open);
                Survey_answers.list_of_answers = (List<Survey_answers>)bf2.Deserialize(stream2);
                stream2.Close();

                BinaryFormatter bf3 = new BinaryFormatter();                                            ///deserealzing all the survey objects into the main 
                Stream stream3;                                                                         /// Survey list...
                stream3 = File.Open("Surveys.dat", FileMode.Open);
                UC_createSurvey.list_of_surveys = (List<Survey>)bf3.Deserialize(stream3);
                stream3.Close();

                //clearing current items, to avoid repetition of items
                view_analysis.cmb_select_survey.Items.Clear();                                              // for this part, we are saying that whenever it is pressed
                                                                                                            // we want the combo box to update the items with the 
                for (int i = 1; i < UC_createSurvey.list_of_surveys.Count; i++)                                      // surveys we current have in the list
                {

                    view_analysis.cmb_select_survey.Items.Add(UC_createSurvey.list_of_surveys[i].get_survey_name());

                }

                if (Survey_answers.list_of_answers.Count == 0)
                {
                    view_analysis.lbl_info.Text = "No surveys currently available to analyse.";
                }
                else
                {
                    view_analysis.lbl_info.Text = "Choose the survey that you wish to analyse.";
                }

                addUserControl(view_analysis);
            }
            catch (Exception error1)
            {
                MessageBox.Show(error1.Message);
            }
        }

        //logout button ...
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            
            DialogResult result;
            result = guna2MessageDialog2.Show("Are you sure you want to Log out?");             // Just asking if the user really wants to log out...

            if(result == DialogResult.Yes)
            {
                login_page = new Login_Page();
                login_page.Show();
                this.Hide();
            }
            
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {

            addUserControl(home);
            
        }

        private void container_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
