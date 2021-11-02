using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using SurveySystem.Usercontrols;
using System.Runtime.Serialization.Formatters.Binary;                   // we will need binary formatters for serialization & deserialization .

namespace SurveySystem
{
    public partial class Loading_screen : Form
    {
        Login_Page login_frm = new Login_Page();      // instantiating Login form.
        BinaryFormatter bf;                           // binary formatter for serialization
        Stream file_stream;                           // a file stream for creating required files...

        string[] loading_animation_text =
        {
            "Loading...",
            "Loading..",
            "Loading."
        };

        int index;

        public Loading_screen()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)                             // creating the system_users file once the form loads if the file 
        {                                                                               // does not exist..
                                                                                        // this file stores all account objects which will later be deserialized.
            if ( ! File.Exists("system_users.dat"))                                      // and also new accounts will be serialized onto this file
            {
                try
                {
                    file_stream = File.Create("system_users.dat");
                    file_stream.Close();

                    Administrators dummy_account = new Administrators();                       // this account will have to be created since an empty file cannot be 
                                                                                               // Deserialized...
                    Login_Page.list_of_all_accounts.Add(dummy_account);                        // adding account to list

                    BinaryFormatter bf2 = new BinaryFormatter();
                    Stream stream1;
                    stream1 = File.Open("system_users.dat", FileMode.Append);                  // serializing updated list
                    bf2.Serialize(stream1, Login_Page.list_of_all_accounts);
                    stream1.Close();

                }
                catch(Exception exception)
                {
                    guna2MessageDialog1.Show(exception.Message);
                }
            }

            if (File.Exists("Surveys.dat") == false)                                     //  creating the surveys file once the form loads if the file 
            {                                                                            // does not exist.
                try                                                                      // this file is for storing all surveys which will be later 
                {                                                                        // deserialized into a data stucture..
                    file_stream = File.Create("Surveys.dat");                            // and also new accounts will be serialized onto to this file
                    file_stream.Close();

                    Survey dummy_survey = new Survey();                                   // same concept as before, we need to serialze a 'dummy survey'
                    UC_createSurvey.list_of_surveys.Add(dummy_survey);                             

                    BinaryFormatter bf3 = new BinaryFormatter();
                    Stream stream2;
                    stream2 = File.Open("Surveys.dat", FileMode.Append);                        // serializing updated list
                    bf3.Serialize(stream2, UC_createSurvey.list_of_surveys);
                    stream2.Close();

                }
                catch (Exception exception)
                {
                    guna2MessageDialog1.Show(exception.Message);
                }
            }

            if (File.Exists("Survey_answers.dat") == false)                                 //  creating the surveys file once the form loads if the file 
            {                                                                               // does not exist.
                try                                                                         // this file is for storing all surveys which will be later 
                {                                                                           // deserialized into a data stucture..
                    file_stream = File.Create("Survey_answers.dat");                        // and also new accounts will be serialized onto to this file
                    file_stream.Close();

                    Survey_answers dummy_survey_answers = new Survey_answers();             // same concept as before, we need to serialze a 'dummy answer'
                    Survey_answers.list_of_answers.Add(dummy_survey_answers);

                    BinaryFormatter bf3 = new BinaryFormatter();
                    Stream stream2;
                    stream2 = File.Open("Survey_answers.dat", FileMode.Append);                        // serializing updated list
                    bf3.Serialize(stream2, Survey_answers.list_of_answers);
                    stream2.Close();

                }
                catch (Exception exception)
                {
                    guna2MessageDialog1.Show(exception.Message);
                }
            }


            this.MaximizeBox = false;
            timer1.Start();                     // as soon as form loads, timer will start after all of the above.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            load_panel.Width += 5;              // on each timer tick, the panel width will increase by 5.

            try
            {
                Loading_animation();                //function for having a loading animation on the text...

                if (load_panel.Width == 112)                                                                //<Summary>
                {
                    ///This part will be for loading and
                    info_lbl.Text = "Deserealizing Account objects...";

                    bf = new BinaryFormatter();                                                             ///deserealzing all the objects into the main 
                    Stream stream1;                                                                         /// user list...
                    stream1 = File.Open("system_users.dat", FileMode.Open);
                    Login_Page.list_of_all_accounts = (List<Users>)bf.Deserialize(stream1);                 /// the label will update accordingly....
                    stream1.Close();

                }

                if (load_panel.Width == 312)
                {

                    info_lbl.Text = "Deserealizing Survey objects...";

                    BinaryFormatter bf4 = new BinaryFormatter();                                            ///deserealzing all the survey objects into the main 
                    Stream stream2;                                                                         /// Survey list...
                    stream2 = File.Open("Surveys.dat", FileMode.Open);
                    UC_createSurvey.list_of_surveys = (List<Survey>)bf4.Deserialize(stream2);                         /// the label will update accordingly....
                    stream2.Close();

                }

                if (load_panel.Width == 512)
                {
                    info_lbl.Text = "Deserealizing Survey Answer objects...";

                    BinaryFormatter bf5 = new BinaryFormatter();                                            ///deserealzing all the survey answer objects into the main 
                    Stream stream2;                                                                         /// Survey answer list...
                    stream2 = File.Open("Survey_answers.dat", FileMode.Open);
                    Survey_answers.list_of_answers = (List<Survey_answers>)bf5.Deserialize(stream2);                         /// the label will update accordingly....
                    stream2.Close();
                    
                }

                if (load_panel.Width < 100)
                {
                    info_lbl.Text = "Starting up...";
                }

                if (load_panel.Width == 622)
                {
                    info_lbl.Text = "Finishing up...";
                }                                                                                           //<Summary>

                if (load_panel.Width >= panel1.Width)
                {
                    Thread.Sleep(200);              // will sleep for 200ms after reaching the end of loading (as a cool down) ...

                    try
                    {
                        login_frm.Show();               // will then show login form...
                        this.Hide();
                        timer1.Stop();
                    }
                    catch (Exception exception)
                    {
                        guna2MessageDialog1.Show(exception.Message);
                    }

                }
            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        private void Loading_animation()                  // just a function for animations for loading text///
        {
            if (index < 2)
            {
                index += 1;
            }
            else
            {
                index = 0;
            }

            label1.Text = loading_animation_text[index];
        }

    }
}                               // SUMMARY >---  SO AS WE CAN SEE, THE LOADING SCREEN IS ESSENTIAL FOR THE PROGRAM AND NOT JUST THERE FOR DECOR ..

//Shihab mirza 2021..
