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
            LoadDataComboBox(); 
            DataContext = new ResiduosTable();
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
        private void OpenFormMateria(object sender, EventArgs e) {
            if (!(DataContext is FormEstadoMateria))
            {
                FormEstadoMateria formEstadoMateria=new FormEstadoMateria();
                DataContext = formEstadoMateria;
                formEstadoMateria.RefreshComboBoxEstado += UpdateDataComboBox;

                LinkActive.Visibility = Visibility.Visible;
            }
        }
        private void OpenFormTipoResiduo(object sender, EventArgs e)
        {
            if (!(DataContext is FormTipoResiduo))
            {
                FormTipoResiduo formTipo = new FormTipoResiduo();
                DataContext = formTipo;
                formTipo.RefreshComboBoxTipo += UpdateDataComboBox;
                LinkActive.Visibility = Visibility.Visible;
            }
        }

        private void OpenFormGrado(object sender, EventArgs e) {

            LinkActive.Visibility = Visibility.Visible;
        }
        private void BtnAddResiduo_Click(object sender, RoutedEventArgs e)
        {

        }
        private void OpenTableResiduos(object sender, RoutedEventArgs e) {
            if (!(DataContext is ResiduosTable))
            {
                DataContext = new ResiduosTable();
                LinkActive.Visibility = Visibility.Hidden;
            }

        }
        private void UpdateDataComboBox(object sender, EventArgs e)
        {
            LoadDataComboBox();
        }
        private void LoadDataComboBox()
        {
            EstadoMateriaModel estadoMateriaModel = new EstadoMateriaModel();
            var estadosMateria = estadoMateriaModel.GetCantidadEstadosMateria().DefaultView;
            cmbEstadoMateria.DisplayMemberPath = "DESCRIPCION"; // Establece la columna a mostrar
            cmbEstadoMateria.SelectedValuePath = "ID";
            cmbEstadoMateria.ItemsSource = estadosMateria;

            TipoResiduoModel tipoResiduoModel = new TipoResiduoModel();
            var tipoResiduo = tipoResiduoModel.ToListTipoResiduo().DefaultView;
            cmbTipoResiduo.DisplayMemberPath = "DESCRIPCION";
            cmbTipoResiduo.SelectedValuePath = "ID";
            cmbTipoResiduo.ItemsSource = tipoResiduo;

            
        }


        private void cmbTipoResiduo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int id = Convert.ToInt32(cmbTipoResiduo.SelectedValue);
            TipoGradoModel tipoGradoModel = new TipoGradoModel();
            var tipoGrado = tipoGradoModel.ToListTipoGrado(id).DefaultView;
            cmbGradoPeligrosidad.DisplayMemberPath = "GRADO_ID";
            cmbGradoPeligrosidad.SelectedValuePath = "GRADO_ID";
            cmbGradoPeligrosidad.ItemsSource = tipoGrado;
        }
    }
}
