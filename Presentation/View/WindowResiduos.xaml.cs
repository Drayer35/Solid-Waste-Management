using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace Presentation.View
{
    /// <summary>
    /// Lógica de interacción para WindowResiduos.xaml
    /// </summary>
    public partial class WindowResiduos : Window
    {
        public WindowResiduos()
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
        private void btn_MinWindow(object sender, RoutedEventArgs e) { this.WindowState = WindowState.Minimized; }
        private void btn_CloseWindow(object sender, RoutedEventArgs e) { this.Close(); }
        private void PaintBoxDescripcion()
        {
            TxtDescriptionResiduo.Text = "Descripcion";
            TxtDescriptionResiduo.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A6A6A7"));
        }
        private void PaintBoxResiduo()
        {
            TxtNameResiduo.Text = "Nombre de Residuo";
            TxtNameResiduo.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A6A6A7"));
        }
        private void TextResiduoEnter(object sender, EventArgs e) {
            if (TxtNameResiduo.Text == "Nombre de Residuo") TxtNameResiduo.Text = "";
            TxtNameResiduo.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000012"));
        }
        private void TextResiduoLeave(object sender, EventArgs e) {
            string residuo = TxtNameResiduo.Text.Trim(); // Elimina espacios en blanco al principio y al final
            if (string.IsNullOrEmpty(residuo)) PaintBoxResiduo();
        }    
        private void TextDescriptionEnter(object sender, EventArgs e) {
            if (TxtDescriptionResiduo.Text == "Descripcion") TxtDescriptionResiduo.Text = "";
            TxtDescriptionResiduo.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000012"));
        }
        private void TexDescriptionLeave(object sender, EventArgs e)
        {
            string residuo = TxtDescriptionResiduo.Text.Trim(); // Elimina espacios en blanco al principio y al final
            if (string.IsNullOrEmpty(residuo)) PaintBoxDescripcion();
        }
    }
}
