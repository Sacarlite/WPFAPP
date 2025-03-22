using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFAPP
{
    public class Bootstrapper
    {
        public Window Run()
        {
            
            return new MainWindow(new MainViewModel());
        }
    }
}
