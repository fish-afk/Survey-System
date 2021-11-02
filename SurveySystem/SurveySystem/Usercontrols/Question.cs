using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SurveySystem.Usercontrols
{                                                           // we will need a question class for constructing questions. 

    public enum question_type                              // enum for the type of questions we are going to use..
    {
        YesNo,
        Likert,
        Scale
    }

    [Serializable()]
    public class Question: ISerializable
    {
        
        string question;                                                // A question will have 2 properties, 
        question_type question_Type;                                    // the question itself 
                                                                        // and the type of question it is, this will be done using the enum above
        string opt1_for_likert;                             
        string opt2_for_likert;
        string opt3_for_likert;                                         // likert questions will have 5 more properties, since we also need to store their 
        string opt4_for_likert;                                         //options as well
        string opt5_for_likert;

        public static int question_count = 0;                           // we will also need to keep track of the amount of questions in a survey 
                                                                        // minimum 6 maximum 20, (which can be changed if you want).
        public Question(string question, question_type question_type)   // constructor 
        {
            this.question = question;
            this.question_Type = question_type;
            question_count += 1;
        }

        public string opt1                                              // this part is for getting and setting likert question, options properties...
        {
            get { return this.opt1_for_likert; }
            set { opt1_for_likert = value; }
        }
        public string opt2
        {
            get { return this.opt2_for_likert; }
            set { opt2_for_likert = value; }
        }
        public string opt3
        {
            get { return this.opt3_for_likert; }
            set { opt3_for_likert = value; }
        }
        public string opt4
        {
            get { return this.opt4_for_likert; }
            set { opt4_for_likert = value; }
        }
        public string opt5
        {
            get { return this.opt5_for_likert; }
            set { opt5_for_likert = value; }
        }                                                           // until this part.

        public question_type get_question_type()
        {
            return this.question_Type;
        }

        public string get_question()
        {
            return this.question;
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)             // this part is a function and a constructor/
        {                                                                                       //for serializing and deserializing question objects..
            info.AddValue("question", question);
            info.AddValue("question_type", question_Type);
            info.AddValue("opt1", opt1_for_likert); info.AddValue("opt2", opt2_for_likert);
            info.AddValue("opt3", opt3_for_likert); info.AddValue("opt4", opt4_for_likert); info.AddValue("opt5", opt5_for_likert);
        }
        public Question(SerializationInfo info, StreamingContext context)
        {
            question = (string)info.GetValue("question", typeof(string));
            question_Type = (question_type)info.GetValue("question_type", typeof(question_type));

            opt1_for_likert = (string)info.GetValue("opt1", typeof(string));
            opt2_for_likert = (string)info.GetValue("opt2", typeof(string));
            opt3_for_likert = (string)info.GetValue("opt3", typeof(string));
            opt4_for_likert = (string)info.GetValue("opt4", typeof(string));
            opt5_for_likert = (string)info.GetValue("opt5", typeof(string));

            
        }
        public Question() { }
        
    }
}
//Shihab Mirza 2021
