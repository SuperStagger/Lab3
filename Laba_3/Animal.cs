using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3
{
    [DataContract]
    class Animal
    {
        [DataMember]
        public string species;
        [DataMember]
        public string country;
        [DataMember]
        public string name;
        [DataMember]
        public DateTime dateOfBirth;

        public Animal(string species, string country, string name, DateTime dateOfBirth)
        {
            this.species = species;
            this.country = country;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return name;
        }

        //public Animal
    }
}
