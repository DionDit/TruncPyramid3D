using Manipulator3D.MVVM.ViewModels;
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
using System.Windows.Shapes;

namespace Manipulator3D.MVVM.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            View3D.Children.Add((DataContext as MainWindowViewModel).Model.Model);
            View3D.Camera = (DataContext as MainWindowViewModel).Camera.CurrentCamera;
            (DataContext as MainWindowViewModel).View3D = View3D;
        }
    }
}
