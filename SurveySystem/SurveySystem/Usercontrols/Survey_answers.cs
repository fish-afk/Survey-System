using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SurveySystem.Usercontrols
{
    [Serializable()]
    class Survey_answers:Answer, ISerializable
    {
        List<Answer> answers = new List<Answer>();
        string survey_name;
        public static List<Survey_answers> list_of_answers = new List<Survey_answers>();

        public List<Answer> list_of_ans
        {
            get { return this.answers; }
            set { answers = value; }
        }

        public string survey_nm
        {
            get { return this.survey_name; }
            set { survey_name = value; }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)             // this part is a function and a constructor/
        {                                                                                       //for serializing and deserializing question objects..
            info.AddValue("list_of_answers", answers);
            info.AddValue("survey_name", survey_name);
            info.AddValue("list_of_survey_answers", list_of_answers);
        }
        public Survey_answers(SerializationInfo info, StreamingContext context)
        {
            survey_name = (string)info.GetValue("survey_name", typeof(string));
            answers = (List<Answer>)info.GetValue("list_of_answers", typeof(List<Answer>));
            list_of_answers = (List<Survey_answers>)info.GetValue("list_of_survey_answers", typeof(List<Survey_answers>));
        }
        public Survey_answers() { }
    }
}
