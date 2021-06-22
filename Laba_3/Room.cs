using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3
{
    [DataContract]
    class Room
    {
        [DataMember]
        internal List<Accounting> accounting = new List<Accounting>();
        [DataMember]
        private TypeOfRoom room;
        [DataMember]
        private int roomIndex;
        [DataMember]
        private int size; //Размер комнаты в м^2
        [DataMember]
        private int priceOfCleaning;

        public Room(TypeOfRoom room, int roomIndex, int size, int priceOfCleaning)
        {
            this.room = room;
            this.roomIndex = roomIndex;
            this.size = size;
            this.priceOfCleaning = priceOfCleaning;
        }

        public override string ToString()
        {
            return $"{roomIndex}";
        }
    }
}
