using Syncfusion.UI.Xaml.Gauges;
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

namespace SfGauge_LabelPositioning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class CircularScaleExt : CircularScale
    {
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            var panel = GetTemplateChild("LabelsPanel") as CircularPanel;
            if (panel != null)
                panel.Margin = new Thickness(0, 20, 0, 0);
        }
    }
}
