using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using TeamCoV5.Sample.MVVM.Silverlight.Interfaces;
using TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService;
using System.ServiceModel;

namespace TeamCoV5.Sample.MVVM.Silverlight.ViewModels
{
    public class SampleViewModel : BaseViewModel, ISampleViewModel
    {
        private SampleModel _model = null;

        public string Name 
        {
            get
            {
                if (_model != null)
                {
                    return _model.Name;
                }
                else
                {
                    return "Default value"; 
                }
            }
            set
            {
                if (_model!=null && value != _model.Name)
                {
                    _model.Name = value;
                    RaisePropertyChanged(() => Name);
                }
            }
        }

        public void LoadData()
        {
            var endpoint = new EndpointAddress("../Services/SampleService.svc");
            SampleServiceClient client = new SampleServiceClient(new BasicHttpBinding(), endpoint);
            client.GetSampleObjetCompleted += new EventHandler<GetSampleObjetCompletedEventArgs>(client_GetSampleObjetCompleted);
            client.GetSampleObjetAsync();
        }

        void client_GetSampleObjetCompleted(object sender, GetSampleObjetCompletedEventArgs e)
        {
            _model = e.Result;
            RaisePropertyChanged(() => Name);
        }
    }
}
