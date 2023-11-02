using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SchoolSchedule.Teachers;
using SchoolSchedule.Subjects;
using System.Runtime.CompilerServices;
using System.IO;

namespace SchoolSchedule.Мусор
{
    internal class XmlSchoolSerializer<T> where T : Subject
    {
        public class XmlMusicSerializer
        {
            private XmlAttributes attributes = new XmlAttributes { XmlIgnore = false };
            private XmlSerializer serializer;
            private string path;

            public XmlMusicSerializer(string path)
            {
                this.path = path;
                serializer = new XmlSerializer(typeof(T));
            }

            private void Serialize(List<T> values)
            {
                using (var fs = new FileStream(path, FileMode.OpenOrCreate))
                    serializer.Serialize(fs, values);
            }
            private List<T> Deserialize()
            {
                using (var FileStream = new FileStream(path, FileMode.Open))
                    return serializer.Deserialize(FileStream) as List<T>;
            }
        }

    }
}
