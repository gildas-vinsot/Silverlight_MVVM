using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TeamCoV5.Sample.MVVM.Interfaces;
using TeamCoV5.Sample.MVVM.Models;

namespace TeamCoV5.Sample.MVVM.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SampleService" in both code and config file together.
    public class SampleService : ISampleService
    {
        public SampleModel GetSampleObjet()
        {
            return new SampleModel()
            {
                Name = "Toto"
            };
        }
    }
}
