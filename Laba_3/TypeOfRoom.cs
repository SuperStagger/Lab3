using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3
{
    [DataContract]

    public enum TypeOfRoom // Тип комнати
    {
        [EnumMember]
        Cage,
        [EnumMember]
        Aviary,
        [EnumMember]
        Aquarium,
        [EnumMember]
        Terrarium
    }
}
