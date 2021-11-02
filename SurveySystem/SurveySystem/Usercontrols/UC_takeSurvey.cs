using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SurveySystem.Usercontrols          // <--- Notice the name space, we are using usercontrols...
{
    public partial class UC_takeSurvey : UserControl                                                    // For the take_survey page we will need to add 
    {                                                                                                   // controls dynamically on triggering of different events.
        int pos = 0;
        Label description_label;                                                                        // all these different labels will get added dynamically.
        Label question_label;                                                                           // as well as the radiobuttons and 
        Guna2RadioButton rb_yes;
        Guna2RadioButton rb_no;
        string chosen_survey;
        int question_count = 1;
        Guna2Panel[] scale_panels = new Guna2Panel[10];                                                 // panels 
        int panel_pos = 316;                                                                            // this is the x position of the first panel.

        int chosen_scale_number = 0;                                                                    // this var is for keeping track of the chosen scale.

        Guna2RadioButton[] likert_opt_radiobtns = new Guna2RadioButton[5];                              // more radiobuttons
        int radio_pos = 130;

        List<Question> questions_for_chosen_survey;                                                     // this will hold all question objects for the current chosen
        List<Answer> list_of_answers;                                                                   // survey ...
        int current_question_index = 0;                                                                 

        public UC_takeSurvey()
        {
            InitializeComponent();
        }

        private void UC_takeSurvey_Load(object sender, EventArgs e)                                     // We need to configure lots of stuff when this uc loads.
        {
            this.Survey_area.MouseWheel += new MouseEventHandler(this.panel2_MouseWheel);
            Survey_area.ForeColor = Color.White;
            list_of_answers = new List<Answer>();

            try                                                                                        // just to be safe, we use a try catch block...
            {
                description_label = new Label                                                           // now we start instantiating and configuring different
                {                                                                                      // controls
                    Text = "",
                    AutoSize = true,
                    Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = System.Drawing.Color.White,
                    Location = new System.Drawing.Point(29, 27),
                    Name = "desc",
                    Size = new System.Drawing.Size(211, 25),
                    TabIndex = 54
                };

                question_label = new Label
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = System.Drawing.Color.White,
                    Location = new System.Drawing.Point(36, 37),
                    Name = "question_lbl",
                    Size = new System.Drawing.Size(477, 25),
                    TabIndex = 53,
                    Text = ""
                };

                label1.Visible = false; label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false;
                label7.Visible = false; label8.Visible = false; label9.Visible = false; label10.Visible = false;label11.Visible = false; label12.Visible = false;

                rb_yes = new Guna2RadioButton();

                rb_yes.Animated = true;
                rb_yes.AutoSize = true;
                rb_yes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
                rb_yes.CheckedState.BorderThickness = 0;
                rb_yes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                rb_yes.CheckedState.InnerColor = System.Drawing.Color.White;
                rb_yes.CheckedState.InnerOffset = -4;
                rb_yes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
                rb_yes.ForeColor = System.Drawing.Color.White;
                rb_yes.Location = new System.Drawing.Point(330, 173);
                rb_yes.Name = "guna2RadioButton1";
                rb_yes.Size = new System.Drawing.Size(60, 27);
                rb_yes.TabIndex = 53;
                rb_yes.Text = "Yes";
                rb_yes.UncheckedState.BorderColor = System.Drawing.Color.White;
                rb_yes.UncheckedState.BorderThickness = 2;
                rb_yes.UncheckedState.FillColor = System.Drawing.Color.Transparent;
                rb_yes.UncheckedState.InnerColor = System.Drawing.Color.Transparent;


                rb_no = new Guna2RadioButton();

                rb_no.Animated = true;
                rb_no.AutoSize = true;
                rb_no.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
                rb_no.CheckedState.BorderThickness = 0;
                rb_no.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                rb_no.CheckedState.InnerColor = System.Drawing.Color.White;
                rb_no.CheckedState.InnerOffset = -4;
                rb_no.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
                rb_no.ForeColor = System.Drawing.Color.White;
                rb_no.Location = new System.Drawing.Point(721, 173);
                rb_no.Name = "guna2RadioButton2";
                rb_no.Size = new System.Drawing.Size(54, 27);
                rb_no.TabIndex = 54;
                rb_no.Text = "No";
                rb_no.UncheckedState.BorderColor = System.Drawing.Color.White;
                rb_no.UncheckedState.BorderThickness = 2;
                rb_no.UncheckedState.FillColor = System.Drawing.Color.Transparent;
                rb_no.UncheckedState.InnerColor = System.Drawing.Color.Transparent;

                for (int j = 0; j < scale_panels.Length; j++)
                {
                    scale_panels[j] = new Guna2Panel();
                }

                for (int c = 0; c < likert_opt_radiobtns.Length; c++)
                {
                    likert_opt_radiobtns[c] = new Guna2RadioButton();
                }

                for (int i = 0; i < scale_panels.Length; i++)
                {
                    scale_panels[i].FillColor = System.Drawing.Color.White;
                    scale_panels[i].Location = new System.Drawing.Point(panel_pos, 191);
                    scale_panels[i].ShadowDecoration.Parent = this.scale_panels[i];
                    scale_panels[i].Size = new System.Drawing.Size(43, 40);
                    scale_panels[i].TabIndex = 53;
                    scale_panels[i].Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);

                    scale_panels[0].Click += new EventHandler(this.change_back_color_for_1);                                // we need to add event handlers to 
                    scale_panels[1].Click += new EventHandler(this.change_back_color_for_2);                                // each of this panels for 
                    scale_panels[2].Click += new EventHandler(this.change_back_color_for_3);                                // keeping track of the chosen 
                    scale_panels[3].Click += new EventHandler(this.change_back_color_for_4);                                // scale rating..
                    scale_panels[4].Click += new EventHandler(this.change_back_color_for_5);
                    scale_panels[5].Click += new EventHandler(this.change_back_color_for_6);
                    scale_panels[6].Click += new EventHandler(this.change_back_color_for_7);
                    scale_panels[7].Click += new EventHandler(this.change_back_color_for_8);
                    scale_panels[8].Click += new EventHandler(this.change_back_color_for_9);
                    scale_panels[9].Click += new EventHandler(this.change_back_color_for_10);

                    panel_pos += 49;
                }

                for (int f = 0; f < 5; f++)
                {
                    likert_opt_radiobtns[f].AutoSize = true;
                    likert_opt_radiobtns[f].CheckedState.BorderColor = System.Drawing.Color.Aqua;
                    likert_opt_radiobtns[f].CheckedState.BorderThickness = 0;
                    likert_opt_radiobtns[f].CheckedState.FillColor = System.Drawing.Color.Aqua;
                    likert_opt_radiobtns[f].CheckedState.InnerColor = System.Drawing.Color.White;
                    likert_opt_radiobtns[f].CheckedState.InnerOffset = -4;
                    likert_opt_radiobtns[f].Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    likert_opt_radiobtns[f].ForeColor = System.Drawing.Color.White;
                    likert_opt_radiobtns[f].Location = new System.Drawing.Point(radio_pos, 202);
                    likert_opt_radiobtns[f].Size = new System.Drawing.Size(154, 21);
                    likert_opt_radiobtns[f].TabIndex = 53;
                    likert_opt_radiobtns[f].UncheckedState.BorderColor = System.Drawing.Color.White;
                    likert_opt_radiobtns[f].UncheckedState.BorderThickness = 2;
                    likert_opt_radiobtns[f].UncheckedState.FillColor = System.Drawing.Color.Transparent;
                    likert_opt_radiobtns[f].UncheckedState.InnerColor = System.Drawing.Color.Transparent;
                    radio_pos += 200;
                }
                                                                                                                   // Until this part....
                cmd_next.Visible = false;
                cmd_submit.Visible = false;
                cmd_quit.Visible = false;
            }
            catch(Exception error)
            {
                guna2MessageDialog1.Show("Something went wrong \n" + error.Message);
            }

        }

        private void panel2_MouseWheel(object sender, MouseEventArgs e)
        {
            pos += 2;
            Survey_area.AutoScrollPosition = new Point(0, pos);
        }

        private void cmb_select_survey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Survey_area.Controls.Clear();
            try                                                                                             // On this event, we want to set the chosen survey to 
            {                                                                                               // the survey selected 
                cmd_take_survey.Visible = true;
                chosen_survey = cmb_select_survey.SelectedItem.ToString();                                  

                for (int i = 1; i < UC_createSurvey.list_of_surveys.Count; i++)                             // linear search
                {
                    if (cmb_select_survey.SelectedItem.ToString() == UC_createSurvey.list_of_surveys[i].get_survey_name())          // then look for the survey 
                    {                                                                                                                           
                        description_label.Text = "Survey description:\n " + UC_createSurvey.list_of_surveys[i].get_survey_desc();   // and display its description..
                    }
                }

                Survey_area.Controls.Add(description_label);                                                    // finally add the label to the panel
            }
            catch(Exception exception)
            {
                guna2MessageDialog1.Show("Something went wrong \n" + exception.Message);                        // any errors shall be caught..
            }
            
        }

        private void cmd_take_survey_Click(object sender, EventArgs e)
        {

            try                                                                                                 // on clicking this button, we will show the 
            {
                Survey_area.Controls.Clear();                                                                   // first question using the dynamic controls
                cmd_next.Visible = true;
                cmd_take_survey.Visible = false;                                                                // we created and configured..
                cmb_select_survey.Visible = false;
                questions_for_chosen_survey = new List<Question>();                                             // this list will store all current questions          

                for (int i = 0; i < UC_createSurvey.list_of_surveys.Count; i++)                                 // linear search
                {
                    if (chosen_survey == UC_createSurvey.list_of_surveys[i].get_survey_name())
                    {
                        questions_for_chosen_survey = UC_createSurvey.list_of_surveys[i].get_list_of_questions();  // the same list being update here 
                    }
                }

                question_label.Text = $"Question {question_count}:\n{questions_for_chosen_survey[0].get_question()}";
                                                                                                                        // <summary> 

                if (questions_for_chosen_survey[current_question_index].get_question_type() == question_type.YesNo)     // this conditional part is for 
                {                                                                                                       // checking the question type and 
                    Survey_area.Controls.Add(rb_yes);                                                                   // displaying the appropriate 
                    Survey_area.Controls.Add(rb_no);
                    rb_yes.Checked = true;                                                                              // controls accordingly...

                                                                                                                        // </summary>
                }
                else if (questions_for_chosen_survey[current_question_index].get_question_type() == question_type.Scale)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Survey_area.Controls.Add(scale_panels[i]);
                    }
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true;
                    label7.Visible = true; label8.Visible = true; label9.Visible = true; label10.Visible = true; label11.Visible = true; label12.Visible = true;

                    Survey_area.Controls.Add(label1);
                    Survey_area.Controls.Add(label2);
                    Survey_area.Controls.Add(label3);
                    Survey_area.Controls.Add(label4);
                    Survey_area.Controls.Add(label5);
                    Survey_area.Controls.Add(label6);
                    Survey_area.Controls.Add(label7);
                    Survey_area.Controls.Add(label8);
                    Survey_area.Controls.Add(label9);
                    Survey_area.Controls.Add(label10);
                    Survey_area.Controls.Add(label11);
                    Survey_area.Controls.Add(label12);

                }
                else if (questions_for_chosen_survey[current_question_index].get_question_type() == question_type.Likert)
                {
                    likert_opt_radiobtns[0].Text = questions_for_chosen_survey[current_question_index].opt1;
                    likert_opt_radiobtns[1].Text = questions_for_chosen_survey[current_question_index].opt2;
                    likert_opt_radiobtns[2].Text = questions_for_chosen_survey[current_question_index].opt3;
                    likert_opt_radiobtns[3].Text = questions_for_chosen_survey[current_question_index].opt4;
                    likert_opt_radiobtns[4].Text = questions_for_chosen_survey[current_question_index].opt5;
                    Console.WriteLine(likert_opt_radiobtns[4].Text = questions_for_chosen_survey[current_question_index].opt5);

                    for (int i = 0; i < 5; i++)
                    {
                        likert_opt_radiobtns[0].Text = questions_for_chosen_survey[current_question_index].opt1;
                        Survey_area.Controls.Add(likert_opt_radiobtns[i]);
                    }
                }

                Survey_area.Controls.Add(question_label);


            }
            catch (NullReferenceException)                                                                  // if the person clicks take survey without
            {
                guna2MessageDialog1.Show("Please select a survey");                                         // choosing a survey, that will throw an error.
                cmd_take_survey.Visible = true;
                cmb_select_survey.Visible = true;
                cmd_next.Visible = false;
            }
            catch(Exception exception)
            {
                guna2MessageDialog1.Show("Something went wrong \n" + exception.Message);
            }
            finally
            {
                cmd_quit.Visible = true;
            }

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmd_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (questions_for_chosen_survey[current_question_index].get_question_type() == question_type.YesNo)          // this part is for finally submitting the 
                {                                                                                                            // survey and adding it to the list and serialzing   
                    Answer answer = new Answer();
                    answer.q_type = question_type.YesNo;                                                                    // that list 

                    if (rb_yes.Checked == true)                                                                             /// different types of answer objects will be 
                    {                                                                                                       // made according to the type of question
                        answer.ans = "Yes";

                        list_of_answers.Add(answer);
                    }
                    else if (rb_no.Checked == true)
                    {
                        answer.ans = "No";

                        list_of_answers.Add(answer);
                    }

                }
                if (questions_for_chosen_survey[current_question_index].get_question_type() == question_type.Scale)
                {
                    Answer answer = new Answer();
                    answer.q_type = question_type.Scale;

                    answer.ans = chosen_scale_number.ToString();
                    list_of_answers.Add(answer);

                }
                if (questions_for_chosen_survey[current_question_index].get_question_type() == question_type.Likert)
                {
                    Answer answer = new Answer();
                    answer.q_type = question_type.Likert;

                    if (likert_opt_radiobtns[0].Checked == true)
                    {
                        answer.ans = "1";
                        list_of_answers.Add(answer);
                    }
                    else if (likert_opt_radiobtns[1].Checked == true)
                    {
                        answer.ans = "2";
                        list_of_answers.Add(answer);
                    }
                    else if (likert_opt_radiobtns[2].Checked == true)
                    {
                        answer.ans = "3";
                        list_of_answers.Add(answer);
                    }
                    else if (likert_opt_radiobtns[3].Checked == true)
                    {
                        answer.ans = "4";
                        list_of_answers.Add(answer);
                    }
                    else if (likert_opt_radiobtns[4].Checked == true)
                    {
                        answer.ans = "5";
                        list_of_answers.Add(answer);
                    }

                }

                Survey_answers survey_answers = new Survey_answers();
                survey_answers.list_of_ans = list_of_answers;
                survey_answers.survey_nm = cmb_select_survey.SelectedItem.ToString();                         // creating a survey answers object and adding the list 
                                                                                                              // of answers to it and also giving it the name
                Survey_answers.list_of_answers.Add(survey_answers);                                             // adding that object to the main list..


                BinaryFormatter bf2 = new BinaryFormatter();
                Stream stream1;
                stream1 = File.Open("Survey_answers.dat", FileMode.Open);                  // serializing updated list
                bf2.Serialize(stream1, Survey_answers.list_of_answers);
                stream1.Close();




                cmb_select_survey.Visible = true;
                cmd_take_survey.Visible = false;
                cmd_submit.Visible = false;
                cmd_quit.Visible = false;
                cmd_next.Visible = false;
                current_question_index = 0;
                list_of_answers.Clear();
                questions_for_chosen_survey.Clear();
                question_count = 1;


                Survey_area.Controls.Clear();
            }
            catch (Exception error1)
            {
                MessageBox.Show(error1.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = guna2MessageDialog2.Show("Are you sure you want to quit? \n all current data will be lost.", "Warning");

            if(result == DialogResult.Yes)                                              // asking the user if they really want to quit the survey and that all 
            {                                                                           // data will be lost if so..
                cmb_select_survey.Visible = true;
                cmd_take_survey.Visible = true;
                cmd_submit.Visible = false;
                cmd_quit.Visible = false;
                cmd_next.Visible = false;
                current_question_index = 0;
                question_count = 1;
                

                Survey_area.Controls.Clear();
            }

        }

        private void cmd_next_Click(object sender, EventArgs e)
        {
            current_question_index += 1;
            question_count += 1;

            try
            {
                if (questions_for_chosen_survey[current_question_index].get_question_type() == question_type.YesNo)
                {
                    Answer answer = new Answer();
                    answer.q_type = question_type.YesNo;

                    if (rb_yes.Checked == true)
                    {
                        answer.ans = "Yes";

                        list_of_answers.Add(answer);
                    }
                    else if (rb_no.Checked == true)
                    {
                        answer.ans = "No";

                        list_of_answers.Add(answer);
                    }

                }
                if (questions_for_chosen_survey[current_question_index].get_question_type() == question_type.Scale)
                {
                    Answer answer = new Answer();
                    answer.q_type = question_type.Scale;

                    answer.ans = chosen_scale_number.ToString();
                    list_of_answers.Add(answer);

                }
                if (questions_for_chosen_survey[current_question_index].get_question_type() == question_type.Likert)
                {
                    Answer answer = new Answer();
                    answer.q_type = question_type.Likert;

                    if (likert_opt_radiobtns[0].Checked == true)
                    {
                        answer.ans = "1";
                        list_of_answers.Add(answer);
                    }
                    else if (likert_opt_radiobtns[1].Checked == true)
                    {
                        answer.ans = "2";
                        list_of_answers.Add(answer);
                    }
                    else if (likert_opt_radiobtns[2].Checked == true)
                    {
                        answer.ans = "3";
                        list_of_answers.Add(answer);
                    }
                    else if (likert_opt_radiobtns[3].Checked == true)
                    {
                        answer.ans = "4";
                        list_of_answers.Add(answer);
                    }
                    else if (likert_opt_radiobtns[4].Checked == true)
                    {
                        answer.ans = "5";
                        list_of_answers.Add(answer);
                    }

                }



                Survey_area.Controls.Clear();


                question_label.Text = $"Question {question_count}:\n{questions_for_chosen_survey[current_question_index].get_question()}";

                if (questions_for_chosen_survey[current_question_index].get_question_type() == question_type.YesNo)
                {
                    label1.Visible = false; label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false;
                    label7.Visible = false; label8.Visible = false; label9.Visible = false; label10.Visible = false;

                    Survey_area.Controls.Add(rb_yes);
                    Survey_area.Controls.Add(rb_no);
                    rb_yes.Checked = true;
                }
                else if (questions_for_chosen_survey[current_question_index].get_question_type() == question_type.Scale)
                {
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true;
                    label7.Visible = true; label8.Visible = true; label9.Visible = true; label10.Visible = true; label11.Visible = true; label12.Visible = true;

                    Survey_area.Controls.Add(label1);
                    Survey_area.Controls.Add(label2);
                    Survey_area.Controls.Add(label3);
                    Survey_area.Controls.Add(label4);
                    Survey_area.Controls.Add(label5);
                    Survey_area.Controls.Add(label6);
                    Survey_area.Controls.Add(label7);
                    Survey_area.Controls.Add(label8);
                    Survey_area.Controls.Add(label9);
                    Survey_area.Controls.Add(label10);
                    Survey_area.Controls.Add(label11);
                    Survey_area.Controls.Add(label12);

                    for (int i = 0; i < scale_panels.Length; i++)
                    {
                        scale_panels[i].FillColor = Color.White;
                        Survey_area.Controls.Add(scale_panels[i]);

                    }



                }
                else if (questions_for_chosen_survey[current_question_index].get_question_type() == question_type.Likert)
                {
                    label1.Visible = false; label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false;
                    label7.Visible = false; label8.Visible = false; label9.Visible = false; label10.Visible = false;

                    likert_opt_radiobtns[0].Text = questions_for_chosen_survey[current_question_index].opt1;
                    likert_opt_radiobtns[1].Text = questions_for_chosen_survey[current_question_index].opt2;
                    likert_opt_radiobtns[2].Text = questions_for_chosen_survey[current_question_index].opt3;
                    likert_opt_radiobtns[3].Text = questions_for_chosen_survey[current_question_index].opt4;
                    likert_opt_radiobtns[4].Text = questions_for_chosen_survey[current_question_index].opt5;

                    for (int i = 0; i < likert_opt_radiobtns.Length; i++)
                    {
                        Survey_area.Controls.Add(likert_opt_radiobtns[i]);
                    }
                }


                if (current_question_index == questions_for_chosen_survey.Count - 1)
                {
                    cmd_submit.Visible = true;
                    cmd_next.Visible = false;




                }

                Survey_area.Controls.Add(question_label);
                chosen_scale_number = 0;
            }
            catch (Exception error1)
            {
                MessageBox.Show(error1.Message);
            }

        }


        // Event handlers to change back colors for scales for scale type questions..
        private void change_back_color_for_1(object sender, EventArgs e)
        {
            chosen_scale_number = 1;

            scale_panels[0].FillColor = Color.Yellow;

            for(int i = 1; i < scale_panels.Length; i++)
            {
                scale_panels[i].FillColor = Color.White;
            }
        }

        private void change_back_color_for_2(object sender, EventArgs e)
        {
            chosen_scale_number = 2;

            scale_panels[0].FillColor = Color.Yellow;
            scale_panels[1].FillColor = Color.Yellow;

            for (int i = 2; i < scale_panels.Length; i++)
            {
                scale_panels[i].FillColor = Color.White;
            }
        }

        private void change_back_color_for_3(object sender, EventArgs e)
        {
            chosen_scale_number = 3;

            scale_panels[0].FillColor = Color.Yellow;
            scale_panels[1].FillColor = Color.Yellow;
            scale_panels[2].FillColor = Color.Yellow;

            for (int i = 3; i < scale_panels.Length; i++)
            {
                scale_panels[i].FillColor = Color.White;
            }
        }
        private void change_back_color_for_4(object sender, EventArgs e)
        {
            chosen_scale_number = 4;

            scale_panels[0].FillColor = Color.Yellow;
            scale_panels[1].FillColor = Color.Yellow;
            scale_panels[2].FillColor = Color.Yellow;
            scale_panels[3].FillColor = Color.Yellow;

            for (int i = 4; i < scale_panels.Length; i++)
            {
                scale_panels[i].FillColor = Color.White;
            }
        }
        private void change_back_color_for_5(object sender, EventArgs e)
        {
            chosen_scale_number = 5;

            scale_panels[0].FillColor = Color.Yellow;
            scale_panels[1].FillColor = Color.Yellow;
            scale_panels[2].FillColor = Color.Yellow;
            scale_panels[3].FillColor = Color.Yellow;
            scale_panels[4].FillColor = Color.Yellow;

            for (int i = 5; i < scale_panels.Length; i++)
            {
                scale_panels[i].FillColor = Color.White;
            }
        }

        private void change_back_color_for_6(object sender, EventArgs e)
        {
            chosen_scale_number = 6;

            scale_panels[0].FillColor = Color.Yellow;
            scale_panels[1].FillColor = Color.Yellow;
            scale_panels[2].FillColor = Color.Yellow;
            scale_panels[3].FillColor = Color.Yellow;
            scale_panels[4].FillColor = Color.Yellow;
            scale_panels[5].FillColor = Color.Yellow;

            for (int i = 6; i < scale_panels.Length; i++)
            {
                scale_panels[i].FillColor = Color.White;
            }
        }
        private void change_back_color_for_7(object sender, EventArgs e)
        {
            chosen_scale_number = 7;

            scale_panels[0].FillColor = Color.Yellow;
            scale_panels[1].FillColor = Color.Yellow;
            scale_panels[2].FillColor = Color.Yellow;
            scale_panels[3].FillColor = Color.Yellow;
            scale_panels[4].FillColor = Color.Yellow;
            scale_panels[5].FillColor = Color.Yellow;
            scale_panels[6].FillColor = Color.Yellow;

            for (int i = 7; i < scale_panels.Length; i++)
            {
                scale_panels[i].FillColor = Color.White;
            }
        }

        private void change_back_color_for_8(object sender, EventArgs e)
        {
            chosen_scale_number = 8;

            scale_panels[0].FillColor = Color.Yellow;
            scale_panels[1].FillColor = Color.Yellow;
            scale_panels[2].FillColor = Color.Yellow;
            scale_panels[3].FillColor = Color.Yellow;
            scale_panels[4].FillColor = Color.Yellow;
            scale_panels[5].FillColor = Color.Yellow;
            scale_panels[6].FillColor = Color.Yellow;
            scale_panels[7].FillColor = Color.Yellow;

            for (int i = 8; i < scale_panels.Length; i++)
            {
                scale_panels[i].FillColor = Color.White;
            }
        }

        private void change_back_color_for_9(object sender, EventArgs e)
        {
            chosen_scale_number = 9;

            scale_panels[0].FillColor = Color.Yellow;
            scale_panels[1].FillColor = Color.Yellow;
            scale_panels[2].FillColor = Color.Yellow;
            scale_panels[3].FillColor = Color.Yellow;
            scale_panels[4].FillColor = Color.Yellow;
            scale_panels[5].FillColor = Color.Yellow;
            scale_panels[6].FillColor = Color.Yellow;
            scale_panels[7].FillColor = Color.Yellow;
            scale_panels[8].FillColor = Color.Yellow;

            for (int i = 9; i < scale_panels.Length; i++)
            {
                scale_panels[i].FillColor = Color.White;
            }
        }
        private void change_back_color_for_10(object sender, EventArgs e)
        {
            chosen_scale_number = 10;

            scale_panels[0].FillColor = Color.Yellow;
            scale_panels[1].FillColor = Color.Yellow;
            scale_panels[2].FillColor = Color.Yellow;
            scale_panels[3].FillColor = Color.Yellow;
            scale_panels[4].FillColor = Color.Yellow;
            scale_panels[5].FillColor = Color.Yellow;
            scale_panels[6].FillColor = Color.Yellow;
            scale_panels[7].FillColor = Color.Yellow;
            scale_panels[8].FillColor = Color.Yellow;
            scale_panels[9].FillColor = Color.Yellow;

        }

        private void Survey_area_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
//Shihab mirza 2021...