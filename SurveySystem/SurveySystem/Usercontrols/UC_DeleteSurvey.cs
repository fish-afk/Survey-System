using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;               // we will need binary formatters for serialization & deserialization .

namespace SurveySystem.Usercontrols                                 // <--- Notice the name space, we are using usercontrols...
{
    public partial class UC_DeleteSurvey : UserControl
    {
        string chosen_survey_name = "";                             // we need to keep track of the selected durvey name 

        Stream Deletion_stream;                                     // we will also have to make changes to the survey.dat file 
        BinaryFormatter bf;                                         
        public UC_DeleteSurvey()
        {
            InitializeComponent();
        }

        private void UC_DeleteSurvey_Load(object sender, EventArgs e)
        {

            if (Survey.survey_count == 0)
            {
                lbl_info.Text = "No surveys currently available.";
            }
            else
            {
                lbl_info.Text = "Choose the survey that you want to delete permanently...";
            }
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            if(UC_createSurvey.list_of_surveys.Count >= 1)
            {
                try
                {
                    chosen_survey_name = cmb_select_survey.SelectedItem.ToString();                                     // we take the selected survey name 
                }
                catch (System.NullReferenceException)                                                                   // if the user selects nothing, that will
                {                                                                                                       // throw an exception, so we just handle it
                    chosen_survey_name = null;                                                                          // by setting the variable to null..

                }
            }
            else
            {
                guna2MessageDialog1.Show("No surveys currently available");
            }

            if(chosen_survey_name == null)
            {
                guna2MessageDialog1.Show("Please select a survey you want to delete", "Info");                  
            }
            else if(chosen_survey_name != "")
            {
                for(int i = 0; i < UC_createSurvey.list_of_surveys.Count; i++)                                  // look for the survey name in the list 
                {                                                                                               // which survey it belongs to.
                    if (chosen_survey_name == UC_createSurvey.list_of_surveys[i].get_survey_name())
                    {
                        UC_createSurvey.list_of_surveys.Remove(UC_createSurvey.list_of_surveys[i]);             // remove that survey from the list
                        

                        bf = new BinaryFormatter();
                        Deletion_stream = File.Open("Surveys.dat", FileMode.Open);                              // serialize updated list.
                        bf.Serialize(Deletion_stream, UC_createSurvey.list_of_surveys);
                        Deletion_stream.Close();

                    }
                }

                for (int i = 0; i < Survey_answers.list_of_answers.Count; i++)                                  // look for the survey name in the list 
                {                                                                                               // which survey it belongs to.
                    if (chosen_survey_name == Survey_answers.list_of_answers[i].survey_nm)
                    {
                        Survey_answers.list_of_answers.Remove(Survey_answers.list_of_answers[i]);             // remove that survey from the list


                        bf = new BinaryFormatter();
                        Deletion_stream = File.Open("Survey_answers.dat", FileMode.Open);                              // serialize updated list.
                        bf.Serialize(Deletion_stream, Survey_answers.list_of_answers);
                        Deletion_stream.Close();

                    }
                }


                guna2MessageDialog1.Show("Survey deleted succesfully !");
            }


        }

        private void cmb_select_survey_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosen_survey_name = cmb_select_survey.SelectedItem.ToString();                                     // this part is just for showing the user

            // some info about the survey..

            try
            {
                for (int i = 1; i < UC_createSurvey.list_of_surveys.Count; i++)
                {
                    if (UC_createSurvey.list_of_surveys[i].get_survey_name() == chosen_survey_name)
                    {
                        lbl_description.Text = UC_createSurvey.list_of_surveys[i].get_survey_desc();                        // Survey description
                        lbl_quest_count.Text = Convert.ToString(UC_createSurvey.list_of_surveys[i].get_num_of_quests());    // Survey question count.
                    }

                }
            }
            catch (Exception error1)
            {
                MessageBox.Show(error1.Message);
            }
        }
    }
}
// Shihab Mirza 2021..