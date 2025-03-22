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
using ChartDirector;

namespace WPFAPP.Pages.Chart2D
{
    /// <summary>
    /// Логика взаимодействия для Chart2D.xaml
    /// </summary>
    public partial class Chart2D : Page
    {
        //Data
        private List<double> dataX = new();
        private List<double> dataY = new();
        private List<double> dataZ = new();
        public Chart2D(ChartViewModel chartViewModel)
        {
            InitializeComponent();
            chartViewModel.SomeEvent += ChartViewModel_SomeEvent;
        }

        private void ChartViewModel_SomeEvent(object? sender, (List<double> x, List<double> y, List<double> z) e)
        {
            XYChart _chart = new XYChart(600, 600);
            _chart.addTitle("2D тепловая карта", "Arial Italic", 15);
            _chart.setPlotArea(65, 40, 360, 360, -1, -1, -1, unchecked((int)0xc0000000), -1);

            _chart.xAxis().setTitle("T1", "Arial Bold Italic", 10);
            _chart.yAxis().setTitle("T2", "Arial Bold Italic", 10);
            _chart.xAxis().setLabelStyle("Arial Bold");
            _chart.yAxis().setLabelStyle("Arial Bold");
            _chart.xAxis().setColors(Chart.Transparent);
            _chart.yAxis().setColors(Chart.Transparent);

            ContourLayer layer = _chart.addContourLayer(
                dataX.ToArray(),
                dataY.ToArray(),
                dataZ.ToArray()
            );
            _chart.getPlotArea().moveGridBefore(layer);
            ColorAxis cAxis = layer.setColorAxis(245, 455, Chart.TopCenter, 330, Chart.Top);
            cAxis.setBoundingBox(Chart.Transparent, Chart.LineColor);
            cAxis.setTitle("Color Legend Title Place Holder", "Arial Bold Italic", 10);
            cAxis.setLabelStyle("Arial Bold");
            cAxis.setLinearScale(0, 20, 2);
            WPFChartViewer1.Chart = _chart;
            
        
    }
    }
}
