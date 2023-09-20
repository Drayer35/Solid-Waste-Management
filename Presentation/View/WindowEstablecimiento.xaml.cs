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
    /// Lógica de interacción para WindowEstablecimiento.xaml
    /// </summary>
    public partial class WindowEstablecimiento : Window
    {
        public WindowEstablecimiento()
        {
            InitializeComponent();
            ActualizarTablaEstablecimiento();
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
        private void txtEstablecimiento_Enter(object sender, EventArgs e)
        {
            if (txtEstablecimiento.Text == "Nombre Establecimiento") txtEstablecimiento.Text = "";
            txtEstablecimiento.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000012"));
        }
        private void txtEstablecimiento_Leave(object sender, EventArgs e)
        {
            string establecimiento = txtEstablecimiento.Text.Trim(); // Elimina espacios en blanco al principio y al final
            if (string.IsNullOrEmpty(establecimiento))
            {
                PintarCasillaEstablecimiento();
            }
        }
        private void AddEstablecimiento_Click(object sender, RoutedEventArgs e)
        {
            if (txtEstablecimiento.Text != "Nombre Establecimiento")
            {
                EstablecimientoModel establecimientoModel = new EstablecimientoModel();
                if (establecimientoModel.InsertarEstablecimiento(txtEstablecimiento.Text))
                {
                    ActualizarTablaEstablecimiento();
                    MessageBox.Show("Se añadió " + txtEstablecimiento.Text + " a la base de datos", "Inserción Exitosa");
                    PintarCasillaEstablecimiento();
                }
                else {
                    MessageBox.Show("Hubo un error ", "Fracaso de Inserción");
                    PintarCasillaEstablecimiento();
                }
            }
            else { MessageBox.Show("Ingresa el nombre del Establecimiento ", "Variable vacía"); }
        }
        private void ActualizarTablaEstablecimiento() {
            EstablecimientoModel establecimiento = new EstablecimientoModel();
            TablaEstablecimientos.DataContext = establecimiento.ListarEstablecientos();
        }
        private void PintarCasillaEstablecimiento() {
            txtEstablecimiento.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A6A6A7"));
            txtEstablecimiento.Text = "Nombre Establecimiento";
        }
        private void EditarRegistro(object sender, RoutedEventArgs e) {
            MessageBox.Show("Quiere Editar el registro?");
        }
        private void EliminarRegistro(object sender, RoutedEventArgs e) {
            MessageBox.Show("Quiere Eliminar el registro?");
        }
    }
}
