using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StandaloneKinectViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Initialization
        KinectSensor _sensor;
        MultiSourceFrameReader _reader;

        _sensor = KinectSensor.GetDefault();

        if (_sensor != null)
        {
            _sensor.Open();
        }

        //Reading the streams
        _reader = _sensor.OpenMultiSourceFrameReader(FrameSourceTypes.Color |
                                             FrameSourceTypes.Depth |
                                             FrameSourceTypes.Infrared);
        _reader = MultiSourceFrameArrive += Reader_MultiSourceFrameArrived;

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
