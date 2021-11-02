using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SurveySystem
{
    [Serializable()]
    public class Users :ISerializable
    {
        string name;
        string pass;
        string real;

        public string username
        {
            get { return name; }
            set { name = value; }
        }
        public string password
        {
            get { return pass; }
            set { pass = value; }
        }
        public string realname
        {
            get { return real; }
            set { real = value; }
        }

        public Users(SerializationInfo info, StreamingContext context) // for constructing deserialized objects out of a file...
        {
            name = (string)info.GetValue("USER", typeof(string));
            pass = (string)info.GetValue("PASS", typeof(string));
            real = (string)info.GetValue("REAL", typeof(string));
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)  // for serializing objects into a stream of bytes for file storage..
        {                                                                                    // this may be overridden later for different types of users...
            info.AddValue("PASS", pass);
            info.AddValue("USER", name);
            info.AddValue("REAL", real);
        }
        public Users(){}
        
    }
}
//Shihab Mirza 2021
