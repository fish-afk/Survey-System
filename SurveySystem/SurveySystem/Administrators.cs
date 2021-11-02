using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;                                                 

namespace SurveySystem
{
    [Serializable()]
    class Administrators : Users, ISerializable
    {
        string special_access_key;                                     // An extra layer of security for Admin users...
        public static int login_attempts = 3;                          // 3 login attempts.<A bit more strict for admins>
                                                                       // in This system.
        public string spe_key
        {
            get { return this.special_access_key; }
            set { special_access_key = value; }
        }

        public Administrators(SerializationInfo info, StreamingContext context) : base(info, context)             //this deserialize method will still also use
        {                                                                                                       // the parent classes properties as well.
            special_access_key = (string)info.GetValue("SPE_KEY", typeof(string));
        }


        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {                                                                                                       //this will still use the parent classes properties
            base.GetObjectData(info, context);                                                                 //but also this new field which is unique to admins.
            info.AddValue("SPE_KEY", special_access_key);
        }

        public Administrators(){}
    }
}
//Shihab Mirza 2021