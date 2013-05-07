using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TeamCoV5.Sample.MVVM.Models
{
    [DataContract]
    public class SampleModel
    {
        [DataMember]
        public string Name;
    }
}
