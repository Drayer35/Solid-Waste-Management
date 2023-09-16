using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Domain;

namespace Presentation.View
{
    /// <summary>
    /// Lógica de interacción para LoginUser.xaml
    /// </summary>
    public partial class LoginUser : Window
    {
        public LoginUser()
        {
            InitializeComponent();
            txtUser.Focus();
        }
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMswg, int wParam, int lParam);
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);
        }
        private void btn_MinWindow(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void btn_CloseWindow(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Hyperlink link = (Hyperlink)sender;
            string navigateUri = link.NavigateUri.AbsoluteUri;

            // Abre el enlace en el navegador web predeterminado
            Process.Start(new ProcessStartInfo(navigateUri));
            e.Handled = true; // Evita que el evento siga propagándo
        }
        private void txtUserName_Enter(object sender,EventArgs e) {
            if (txtUser.Text == "UserName") {
                txtUser.Text = "";
                txtUser.Foreground = Brushes.White;
            }
        }
        private void txtUserName_Leave(object sender, EventArgs e)
        {
            string userInput = txtUser.Text.Trim(); // Elimina espacios en blanco al principio y al final
            if (string.IsNullOrEmpty(userInput))
            {
                txtUser.Text = "UserName";

                txtUser.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A6A6A7"));
            }
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Password == "***********")
            {
                txtPass.Password = "";
                txtPass.Foreground = Brushes.White;
            }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            string passInput = txtPass.Password.Trim(); // Elimina espacios en blanco al principio y al final
            if (string.IsNullOrEmpty(passInput))
            {
                txtPass.Password = "";
                txtPass.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A6A6A7"));
            }
        }
        private void sendLoginClick(object sender, EventArgs e) {
            if (txtUser.Text != "UserName") {
                if (txtPass.Password != "")
                {

                }
                else { showErrorAlert("Por Favor Ingrese Contraseña"); }
            } 
            else { showErrorAlert("Por Favor Ingrese Nombre de Usuario"); }

        
        }
        private void showErrorAlert(string msg) {
            lblAlert.Visibility = Visibility;
            lblAlertText.Text = msg;
        }



    }
}
