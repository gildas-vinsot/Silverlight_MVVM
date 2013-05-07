using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.ServiceModel;
using TeamCoV5.Sample.MVVM.Models;

namespace TeamCoV5.Sample.MVVM.Interfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISampleService" in both code and config file together.
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        SampleModel GetSampleObjet();
    }
}
