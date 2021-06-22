using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;

namespace WindowsFormsApp1
{
    [DataContract]
    public class Compititor
    {
        [DataMember]
        private string name { get; set; }
        [DataMember]
        private string surname { get; set; }
        [DataMember]
        private DateTime age { get; set; }


        public Compititor(string name, string surname, DateTime age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public Compititor(Compititor compititor)
        {
            this.name = compititor.name;
            this.surname = compititor.surname;
            this.age = compititor.age;
        }

        public Compititor(string name)
        {
            this.name = name;
            this.surname = "";
            //this.age = RandomDay();
        }

        public override string ToString()
        {
            return name + " " + surname + " " + age.ToShortDateString() ;
        }

        private Random gen = new Random();
        private DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}
