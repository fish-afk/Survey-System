using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SurveySystem.Usercontrols
{
    [Serializable()]
    public class Survey: Question, ISerializable                                             // the following survey class will have properties namely, a list of questions,  
    {                                                                              // the survey name and survey description
        List<Question> survey_questions;                                                
        string survey_name;
        string survey_description;

        public static int survey_count = 0;                                        // this property is static, meaning it belongs to the class itself and not one
                                                                                    // specific object..

        public Survey(List<Question> list_of_questions, string survey_name, string survey_description)              // constructor
        {
            this.survey_questions = list_of_questions;
            this.survey_name = survey_name;
            this.survey_description = survey_description;

            survey_count += 1;
        }
        public int get_num_of_quests()
        {
            return survey_questions.Count;
        }

        public List<Question> get_list_of_questions()
        {
            return this.survey_questions;
        }

        public string get_survey_name()
        {
            return this.survey_name;
        }

        public string get_survey_desc()
        {
            return this.survey_description;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)                // all info about surveys will need to be serialized and
        {                                                                                                   // deserialized..
            info.AddValue("list_of_quests", survey_questions);
            info.AddValue("survey_name", survey_name);
            info.AddValue("survey_desc", survey_description);
            
        }

        public Survey(SerializationInfo info, StreamingContext context)
        {
            survey_name = (string)info.GetValue("survey_name", typeof(string));
            survey_description = (string)info.GetValue("survey_desc", typeof(string));
            survey_questions = (List<Question>)info.GetValue("list_of_quests", typeof(List<Question>));
            survey_count += 1;

        }

        public Survey() { }                             // empty constructor to help us make a dummy account without giving it a list of questions and what not.
    }
}
//Shihab Mirza 2021
