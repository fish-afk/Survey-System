using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using SurveySystem.Usercontrols;

namespace SurveySystem
{   
    [Serializable()]
    class Consumers: Users, ISerializable
    {
        public static int login_attempts = 6;                                       // 6 login attempts to //
                                                                                    // The system.

        public Consumers(SerializationInfo info, StreamingContext context) : base(info, context)             //this deserialize method will still also use
        {                                                                                                       // the parent classes properties as well.

        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {                                                                                                       //this will still use the parent classes properties
            base.GetObjectData(info, context);                                                                 //but also this new field which is unique to admins.

        }

        public Consumers() { }

    }
}
//Shihab Mirza 2021