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

namespace SurveySystem.Usercontrols                                 // <--- Notice the name space, we are using usercontrols...
{
    public partial class UC_ViewAnalysis : UserControl
    {
        string chosen_survey;
        List<Label> questions_analysis_labels = new List<Label>();
        int lbl_position = 16;

        public UC_ViewAnalysis()
        {
            InitializeComponent();
        }

        private void UC_ViewAnalysis_Load(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.FixedSingle;
            cmd_create.Enabled = false;
        }

        private void cmb_select_survey_SelectedIndexChanged(object sender, EventArgs e)         /// once again, making use of dynamic controls to display data 
                                                                                                    // accordingly..
        {
            try
            {
                chosen_survey = cmb_select_survey.SelectedItem.ToString();
                questions_analysis_labels.Clear();
                question_panel.Controls.Clear();
                lbl_position = 30;
                cmd_create.Enabled = true;

                desc_lbl.Text = $"Survey description: {get_survey_desc(chosen_survey, UC_createSurvey.list_of_surveys)}";
                count_lbl.Text = $"Number of questions: {get_num_of_quests(chosen_survey, UC_createSurvey.list_of_surveys)}";

                int len_of_survey = return_len(chosen_survey);
                int[] yes_arr = count_yes(chosen_survey);
                int[] no_arr = count_no(chosen_survey);
                question_type[] q_type = get_q_type(chosen_survey);
                
                
                int number_of_surveys_taken = find_no_of_surveys(chosen_survey);
                double[] arr_of_avg = find_average_for_scale_quests(chosen_survey);
                write();

                for (int j = 0; j < len_of_survey; j++)
                {

                    Label label = new Label();
                    questions_analysis_labels.Add(label);

                    questions_analysis_labels[j].AutoSize = true;
                    questions_analysis_labels[j].Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    questions_analysis_labels[j].ForeColor = System.Drawing.Color.White;
                    questions_analysis_labels[j].Location = new System.Drawing.Point(34, lbl_position);
                    questions_analysis_labels[j].Size = new System.Drawing.Size(126, 25);
                    questions_analysis_labels[j].TabIndex = 55;


                    questions_analysis_labels[j].Text = $"Question {j + 1}:                         " +
                    $"{q_type[j]}                                       {yes_arr[j]}" +
                    $"                                          {no_arr[j]}                             {Convert.ToDouble(arr_of_avg[j] / number_of_surveys_taken)}";

                    

                    lbl_position += 70;

                }

                add_labels();
            }
            catch (Exception error1)
            {
                MessageBox.Show(error1.Message);
            }
        }
        // we will need to have a lot of functions to take care of all the searching and keeping track of all the data and representing data correctly 

        // all of these functions are made below....
        private void add_labels()
        {
            foreach (Label label in questions_analysis_labels)
            {
                question_panel.Controls.Add(label);
            }
        }

        private double[] find_average_for_scale_quests(string chosen_survey)
        {
            double[] arr_of_avg = new double[19];

            for(int i = 0; i < Survey_answers.list_of_answers.Count; i++)
            {
                if(Survey_answers.list_of_answers[i].survey_nm == chosen_survey)
                {
                    for (int j = 0; j < Survey_answers.list_of_answers[i].list_of_ans.Count; j++)
                    {
                        if (Survey_answers.list_of_answers[i].list_of_ans[j].q_type == question_type.Scale)
                        {
                            arr_of_avg[j] += Convert.ToInt32(Survey_answers.list_of_answers[i].list_of_ans[j].ans);
                        }
                    }
                }
            }

            return arr_of_avg;

        }

        private void write()
        {
            for (int i = 0; i < Survey_answers.list_of_answers.Count; i++)
            {
                if (Survey_answers.list_of_answers[i].survey_nm == chosen_survey)
                {
                    for (int j = 0; j < Survey_answers.list_of_answers[i].list_of_ans.Count; j++)
                    {
                        Console.WriteLine(Survey_answers.list_of_answers[i].list_of_ans[j].q_type.ToString());
                        
                    }
                    break;
                }
            }
        }

        private int find_no_of_surveys(string chosen_survey)
        {
            int ans = 0;

            for (int i = 0; i < Survey_answers.list_of_answers.Count; i++)
            {
                if (Survey_answers.list_of_answers[i].survey_nm == chosen_survey)
                {
                    ans += 1;
                }
            }

            return ans;
        }

        private int[] count_yes(string chosen_survey)
        {
            int[] yes_tracker = new int[19];

            for(int i = 0; i < Survey_answers.list_of_answers.Count; i++)
            {
                if (Survey_answers.list_of_answers[i].survey_nm == chosen_survey)
                {
                    for(int j = 0; j < Survey_answers.list_of_answers[i].list_of_ans.Count; j++)
                    {
                        if (Survey_answers.list_of_answers[i].list_of_ans[j].ans == "Yes")
                        {
                            yes_tracker[j] += 1;
                        }
                    }
                }
            }

            return yes_tracker;
        }
        private int[] count_no(string chosen_survey)
        {
            int[] no_tracker = new int[19];

            for (int i = 0; i < Survey_answers.list_of_answers.Count; i++)
            {
                if (Survey_answers.list_of_answers[i].survey_nm == chosen_survey)
                {
                    for (int j = 0; j < Survey_answers.list_of_answers[i].list_of_ans.Count; j++)
                    {
                        if (Survey_answers.list_of_answers[i].list_of_ans[j].ans == "No")
                        {
                            no_tracker[j] += 1;
                        }
                    }
                }
            }

            return no_tracker;
        }

        private int return_len(string chosen_survey)
        {
            int len = 0;

            for (int i = 0; i < Survey_answers.list_of_answers.Count; i++)
            {
                if (chosen_survey == Survey_answers.list_of_answers[i].survey_nm)
                {
                    len = Survey_answers.list_of_answers[i].list_of_ans.Count;
                    break;
                }
            }

            return len;
        }

        private question_type[] get_q_type(string chosen_survey)
        {
            question_type[] q_type = new question_type[19];

            for (int i = 0; i < Survey_answers.list_of_answers.Count; i++)
            {
                if (Survey_answers.list_of_answers[i].survey_nm == chosen_survey)
                {
                    for (int j = 0; j < Survey_answers.list_of_answers[i].list_of_ans.Count; j++)
                    {

                        q_type[j] = Survey_answers.list_of_answers[i].list_of_ans[j].q_type;
                        
                    }

                    break;
                    
                }
            }

            return q_type;
        }

        private string get_survey_desc(string chosen_survey, List<Survey> list)
        {
            string desc = "";

            for (int i = 0; i < list.Count; i++)
            {
                if (chosen_survey == list[i].get_survey_name())
                {
                    desc = list[i].get_survey_desc();
                }
               
            }

            return desc;
        }

        private int get_num_of_quests(string chosen_survey, List<Survey> list)
        {
            int num = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (chosen_survey == list[i].get_survey_name())
                {
                    num = list[i].get_num_of_quests();
                }

            }

            return num;
        }

        

        private void question_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmd_create_Click(object sender, EventArgs e)
        {
            StreamWriter output;
            SaveFileDialog ofd;
            string file;
            DialogResult selected;

            ofd = new SaveFileDialog();

            selected = ofd.ShowDialog();

            if(selected == DialogResult.OK)
            {
                file = ofd.FileName;
            }
            else
            {
                return;
            }

            output = new StreamWriter(file);

            try
            {


                output.WriteLine("                      The following is the report of the survey\n                     The following results were gathered as analysis for each question in the survey\n");
                output.WriteLine("Survey name: " + cmb_select_survey.SelectedItem.ToString());
                output.WriteLine("Survey description : " + desc_lbl.Text);
                output.WriteLine(count_lbl.Text + "\n");

                MessageBox.Show("Saved successfully !");

            }
            catch(Exception error)
            {
                MessageBox.Show("Please select a survey to save as a report.\n" + error.Message);
            }

            for(int i = 0; i < questions_analysis_labels.Count; i++)
            {
                output.WriteLine(questions_analysis_labels[i].Text); 
            }

            output.Close();
        }
    }
}
//shihab mirza 2021..