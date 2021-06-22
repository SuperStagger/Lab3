using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3
{
    [DataContract]
    class Accounting // Облік
    {
        [DataMember]
        public Animal animal;
        [DataMember]
        public DateTime dateOfArrival; //Дата надходження
        [DataMember]
        public int price;

        public Accounting(Animal animal, DateTime dateOfArrival, int price)
        {
            this.animal = animal;
            this.dateOfArrival = dateOfArrival;
            this.price = price;
        }

        public override string ToString()
        {
            return animal.ToString() + " " + dateOfArrival.ToString();
        }
    }
}
