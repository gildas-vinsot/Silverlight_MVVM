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

namespace TeamCoV5.Sample.MVVM.Silverlight.ViewModels
{
    public class SampleManager
    {
        private static SampleManager _instance;
        
        public static SampleManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SampleManager();
                }
                return _instance;
            }
        }

        private SampleManager()
        {
        }

        private SampleViewModel _currentSampleViewModel = null;
        public SampleViewModel CurrentSampleViewModel
        {
            get
            {
                if (_currentSampleViewModel == null)
                {
                    _currentSampleViewModel = new SampleViewModel();
                    _currentSampleViewModel.LoadData();
                }
                return _currentSampleViewModel;
            }
        }
    }
}
