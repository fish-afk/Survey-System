using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;                   // we will need binary formatters for serialization & deserialization .

namespace SurveySystem.Usercontrols                                    // <--- Notice the name space, we are using usercontrols...
{
    public partial class UC_createSurvey : UserControl
    {
        List<Question> list_of_questions = new List<Question>();                             // we will need a list of questions that we will keep fillin up
        public static List<Survey> list_of_surveys = new List<Survey>();                     // <--- THIS list is the mian list which will hold all survey objects. 
        int question_count;

        BinaryFormatter bf;

        public UC_createSurvey()
        {
            InitializeComponent();
        }

        private void UC_createSurvey_Load(object sender, EventArgs e)
        {
            cmb_type.SelectedItem = cmb_type.Items[1];
            grp_likert_option.Enabled = false;
            grp_likert_option.Visible = false;

            txtname.Enabled = false;
            txt_desc.Enabled = false;
            cmd_create.Enabled = false;

        }

        private void cmd_add_Click(object sender, EventArgs e)
        {
            string question = txt_question.Text;
            string question_types = cmb_type.SelectedItem.ToString();
            List<string> list_of_opts = new List<string>();


            question_type selected_question_Type;
            
            switch (question_types)
            {                                      
                case "5- Point likert":
                    

                    selected_question_Type = question_type.Likert;
                    try
                    {

                        list_of_opts.Add(opt1.Text);
                        list_of_opts.Add(opt2.Text);
                        list_of_opts.Add(opt3.Text);
                        list_of_opts.Add(opt4.Text);
                        list_of_opts.Add(opt5.Text);

                    }
                    catch (Exception)
                    {
                        guna2MessageDialog1.Show("please enter in all the option fields", "Info");
                    }
                    break;

                case "Yes or No":

                    selected_question_Type = question_type.YesNo;
                    break;

                case "Rating scale 1 - 10":

                    selected_question_Type = question_type.Scale;
                    break;

                default:

                    selected_question_Type = question_type.Likert;
                    break;
            }

            if(question.Length <= 25)
            {
                guna2MessageDialog1.Show("Please enter a longer more valid question", "Info");
            }
            else
            {
                if(selected_question_Type == question_type.Likert)
                {

                    if (opt1.Text == "" || opt2.Text == "" || opt3.Text == "" || opt4.Text == "" || opt5.Text == "")
                    {
                        guna2MessageDialog1.Show("Please specify the options as well..", "Info");
                    }
                    else
                    {
                        Create_likert_question(list_of_opts, question, selected_question_Type);
                        
                    }
                    
                }
                else
                {
                    Create_question(question, selected_question_Type);
                    
                }
            }

            lbl_count.Text = "Question count = " + question_count;

            if(Question.question_count == 6)
            {
                txtname.Enabled = true;
                txt_desc.Enabled = true;
                cmd_create.Enabled = true; 
            }


        }

        private void Create_question(string question, question_type question_Type)
        {
            if (Question.question_count <= 15)
            {

                Question question_ = new Question(question, question_Type);
                list_of_questions.Add(question_);
                question_count += 1;

            }
            else
            {
                guna2MessageDialog1.Show("You have reached the max limit of questions\n Now Please hit create survey..", "Info");
            }   
        }

        private void Create_likert_question(List<string> options, string question, question_type question_Type)
        {
            if (Question.question_count <= 15)
            {
                Question question_ = new Question(question, question_Type);
                question_.opt1 = options[0]; question_.opt2 = options[1]; question_.opt3 = options[2]; question_.opt4 = options[3]; question_.opt5 = options[4];
                
                list_of_questions.Add(question_);
                question_count += 1;

            }
            else
            {
                guna2MessageDialog1.Show("You have reached the max limit of questions\n Now Please hit create survey..", "Info");
            }
        }

        private void Create_survey(List<Question> list, string survey_name, string survey_description)
        {
            try
            {
                if (list_of_surveys.Count <= 20)
                {
                    Survey survey_ = new Survey(list, survey_name, survey_description);
                    UC_createSurvey.list_of_surveys.Add(survey_);



                    bf = new BinaryFormatter();
                    Stream stream1;
                    stream1 = File.Open("Surveys.dat", FileMode.Open);                        // serializing updated list.
                    bf.Serialize(stream1, UC_createSurvey.list_of_surveys);
                    stream1.Close();

                    Console.WriteLine(list_of_surveys[list_of_surveys.Count - 1].get_num_of_quests());

                    txtname.Clear(); txt_desc.Clear(); txt_question.Clear(); opt1.Clear(); opt2.Clear(); opt3.Clear(); opt4.Clear(); opt5.Clear();
                    cmd_create.Enabled = false;

                    guna2MessageDialog1.Show($"Created survey successfully.\n Number of questions = {question_count}.", "Info");

                }
                else
                {
                    guna2MessageDialog1.Show("          You are at a max limit of surveys \n Please delete some surveys to add a new survey..", "Info");
                }
            }
            catch (Exception error1)
            {
                MessageBox.Show(error1.Message);
            }
        }

        private void cmd_create_Click(object sender, EventArgs e)
        {
            string survey_name = txtname.Text;
            string survey_description = txt_desc.Text;
            

            if(name_search(survey_name) == true)
            {
                if (survey_name.Length >= 5 && survey_description.Length >= 30)
                {
                    Create_survey(list_of_questions, survey_name, survey_description);
                    Question.question_count = 0;
                    question_count = 0;
                    lbl_count.Text = "Question count = 0";
                    list_of_questions.Clear();

                }
                else
                {
                    guna2MessageDialog1.Show("survey name cannot be null,\n and survey description cannot be less than 30 letters", "Info");
                }
            }
            else
            {
                guna2MessageDialog1.Show("This survey name already exists.");
            }
            
        }

        private bool name_search(string name)
        {
            int i = 0;
            
            while (i < UC_createSurvey.list_of_surveys.Count)
            {
                if (name == list_of_surveys[i].get_survey_name())
                {

                    return false;
                }
                i++;
            }

            return true;
            
        }

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_type.SelectedIndex == 0)
            {
                grp_likert_option.Enabled = true;
                grp_likert_option.Visible = true;
            }
            else
            {
                grp_likert_option.Enabled = false;
                grp_likert_option.Visible = false;
                opt1.Clear(); opt2.Clear(); opt3.Clear(); opt4.Clear(); opt5.Clear();
            }
        }
    }
}
