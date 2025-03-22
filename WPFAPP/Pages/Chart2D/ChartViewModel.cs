using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAPP.Pages.Chart2D
{
    public class ChartViewModel
    {
        public event EventHandler<(List<double> x, List<double> y, List<double> z)>? SomeEvent;
        public ChartViewModel()
        {
        }
        public void DrawChart()
        {
            var x = new List<double>();
            var y = new List<double>();
            var z = new List<double>();
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    x.Add(i);
                    y.Add(j);
                    z.Add(i*j);
                }
            }
            if (SomeEvent != null) {
                SomeEvent.Invoke(this,(x,y,z));
            }
        }
      
    }
}
