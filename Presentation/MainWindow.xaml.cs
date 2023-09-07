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
using System.Runtime;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using Presentation.View;
using System.Linq.Expressions;

namespace Presentation
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMswg, int wParam, int lParam);

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);
        }
        private void Window_MouserEnter(object sender, MouseEventArgs e) {
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }
        private void btn_MinWindow(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void btn_MaxWindow(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else{  
                this.WindowState = WindowState.Normal;
            }
                
        }
        private void btn_CloseWindow(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btn_Dashboard(object sender, RoutedEventArgs e)
        {
          DataContext = new Dashboard();
        }

        private void btn_Registro(object sender, RoutedEventArgs e)
        {
            DataContext = new Registros();
        }

        private void btn_Residuos(object sender, RoutedEventArgs e)
        {
            DataContext = new Residuos();
        }

        private void btn_Operaciones(object sender, RoutedEventArgs e)
        {
            DataContext = new Operaciones();
        }

        private void btn_Instructivo(object sender, RoutedEventArgs e)
        {
            DataContext = new Instructivo();
        }
    }
}
