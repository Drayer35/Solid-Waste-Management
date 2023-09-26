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
        public event EventHandler RefreshTablaResiduo;
        public WindowResiduos()
        {
            InitializeComponent();
            LoadDataComboBox();
            OpenTable();
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
                this.Width = 1000;
                FormTipoResiduo formTipo = new FormTipoResiduo();
                DataContext = formTipo;
                formTipo.RefreshComboBoxTipo += UpdateDataComboBox;
                LinkActive.Visibility = Visibility.Visible;
            }
        }
        private void OpenFormGrado(object sender, EventArgs e) {
            if (!(DataContext is FormGradoPeligrosidad)) {
                FormGradoPeligrosidad formGrado = new FormGradoPeligrosidad();
                DataContext = formGrado;
                formGrado.RefreshComboBoxGrado += UpdateDataComboBox;
                LinkActive.Visibility = Visibility.Visible;
            }
        }

        private void OpenTable() {
            if (!(DataContext is ResiduosTable))
            {
                ResiduosTable formResiduosTable = new ResiduosTable();
                RefreshTablaResiduo += formResiduosTable.ListTableResiduo;
                DataContext = formResiduosTable;
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
            cmbGradoPeligrosidad.DisplayMemberPath = "DESCRIPCION";
            cmbGradoPeligrosidad.SelectedValuePath = "ID";
            cmbGradoPeligrosidad.ItemsSource = tipoGrado;
        }
        private void LinkOpenTable(object sender, RoutedEventArgs e) { 
            OpenTable();
        }
        private void AddResiduo(object sender, RoutedEventArgs e)
        {
            
            string nombre = Convert.ToString(TxtNameResiduo.Text);
            string descripcion = Convert.ToString(TxtDescriptionResiduo.Text);
            int tipoResiduo = Convert.ToInt32(cmbTipoResiduo.SelectedValue);
            int gradoPeligro = Convert.ToInt32(cmbGradoPeligrosidad.SelectedValue);
            int estadoMateria = Convert.ToInt32(cmbEstadoMateria.SelectedValue);
            if (TxtNameResiduo.Text != "Nombre de Residuo" && TxtDescriptionResiduo.Text !="Descripcion" && cmbTipoResiduo.SelectedIndex != -1  && cmbGradoPeligrosidad.SelectedIndex !=-1 && cmbEstadoMateria.SelectedIndex !=-1)
            {
                ResiduoModel residuoModel = new ResiduoModel();
                if (TextAddResiduo.Text == "Agregar")
                {
                    if (residuoModel.InsertResiduo(nombre,descripcion,tipoResiduo,gradoPeligro,estadoMateria))
                    {
                        RefreshTablaResiduo?.Invoke(this, EventArgs.Empty);
                        PaintBoxResiduo();
                        PaintBoxDescripcion();
                        LoadDataComboBox();
                        MessageBox.Show("Se añadió " + nombre + " a la base de datos", "Inserción Exitosa");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error ", "Fracaso de Inserción");
                        PaintBoxResiduo();
                        PaintBoxDescripcion();
                        LoadDataComboBox();
                    }
                }
                else
                {
                    int id = Convert.ToInt32(TxtIdResiduo.Text);
                    residuoModel.UpdateResiduo(id,nombre, descripcion,tipoResiduo,gradoPeligro,estadoMateria);
                    RefreshTablaResiduo?.Invoke(this, EventArgs.Empty);
                    PaintBoxResiduo();
                    PaintBoxDescripcion();
                    LoadDataComboBox();
                    MessageBox.Show("Se actualizó el ID: " + id);
                };

            }
            else { MessageBox.Show("Complete todo los campos", "Casilla Vacía"); }
        }


    }
}
