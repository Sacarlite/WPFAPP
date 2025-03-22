using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPFAPP.Pages.Chart2D;

namespace WPFAPP
{
    public partial class MainViewModel : ObservableObject
    {
        private ChartViewModel viewModel;
        [ObservableProperty]
        Page chart_2D;
        public MainViewModel()
        {
            viewModel = new ChartViewModel();
            Chart_2D = new Chart2D(viewModel);
        }

        [RelayCommand]
        void Calc()
        {
            viewModel.DrawChart();
        }
    }
}
