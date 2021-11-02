using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SurveySystem.Usercontrols
{
    [Serializable()]    
    class Answer: ISerializable
    {
        question_type question_Type;
        string answer;

        public question_type q_type
        {
            get { return this.question_Type; }
            set { question_Type = value; }
        }

        public string ans
        {
            get { return this.answer; }
            set { answer = value; }
        }
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)             // this part is a function and a constructor/
        {                                                                                       //for serializing and deserializing question objects..
            info.AddValue("answer", answer);
            info.AddValue("question_type", question_Type);
        }
        public Answer(SerializationInfo info, StreamingContext context)
        {
            answer = (string)info.GetValue("answer", typeof(string));
            question_Type = (question_type)info.GetValue("question_type", typeof(question_type));
        }

        public Answer() { }
    }
}
