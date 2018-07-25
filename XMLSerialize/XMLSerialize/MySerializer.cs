using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace XMLSerialize
{
   public  class MySerializer
    {
        static XmlSerializer serializer = new XmlSerializer(typeof(Person));

        static public void Serialize(TextWriter writer, Person person)
        {
            serializer.Serialize(writer, person);
            writer.Close();
         }

        static public Person Deserialize(StreamReader reader)
        {
            Person person;
            person = (Person)serializer.Deserialize(reader);
            return person;
        }


    }
}
