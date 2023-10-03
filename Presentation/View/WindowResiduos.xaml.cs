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
        string nombre;
        string descripcion;
        int tipoResiduo;
        int gradoPeligro;
        int estadoMateria;
        ResiduosTable formResiduosTable = new ResiduosTable();
        public event EventHandler RefreshTablaResiduo;
        public WindowResiduos()
        {
            InitializeComponent();
            PaintAllBox();
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

        private void FocusTextBox(TextBox text, string cadena)
        {
            if (text.Text == cadena) text.Text = "";
            text.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000012"));
        }

        private void LeaveTextBox(TextBox text, string cadena)
        {
            string textbox = text.Text.Trim(); // Elimina espacios en blanco al principio y al final
            if (string.IsNullOrEmpty(textbox)) PaintBox(text, cadena);
        }

        private void TextResiduoEnter(object sender, EventArgs e) { FocusTextBox(TxtNameResiduo, "Nombre de Residuo");}
        private void TextResiduoLeave(object sender, EventArgs e) {LeaveTextBox(TxtNameResiduo, "Nombre de Residuo");}

        private void TextDescriptionEnter(object sender, EventArgs e) {FocusTextBox(TxtDescriptionResiduo,"Descripcion");}
        private void TexDescriptionLeave(object sender, EventArgs e){LeaveTextBox(TxtDescriptionResiduo, "Descripcion");}
        
        private void OpenFormMateria(object sender, EventArgs e) {
            if (!(DataContext is FormEstadoMateria))
            {
                FormEstadoMateria formEstadoMateria = new FormEstadoMateria();
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

        private void PaintBox(TextBox text, string cadena)
        {
            text.Text = cadena;
            text.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A6A6A7"));
        }

        private void PaintAllBox() {
            cmbGradoPeligrosidad.IsEnabled = false;
            TextAddResiduo.Text = "Agregar";
            PaintBox(TxtIdResiduo, "ID");
            PaintBox(TxtNameResiduo, "Nombre de Residuo");
            PaintBox(TxtDescriptionResiduo, "Descripcion");
            LoadDataComboBox();
        }
        private void Color(object sender, EventArgs e)
        {
            FocusTextBox(TxtNameResiduo, "Nombre de Residuo");
            FocusTextBox(TxtDescriptionResiduo, "Descripcion");
        }

        private bool VerficarEstadoBoton() {
            if (TextAddResiduo.Text == "Agregar") return true;
            else { return false; }
        }
       
        private void OpenTable() {
            if (!(DataContext is ResiduosTable))
            {
                RefreshTablaResiduo += formResiduosTable.ListTableResiduo;
                formResiduosTable.RowUpdated += ResiduosTable_RowSelected;
                formResiduosTable.PaintText += Color;
                DataContext = formResiduosTable;
                LinkActive.Visibility = Visibility.Hidden;
            }
        }
      
        private void ResiduosTable_RowSelected(object selectedItem)
        {
            TextAddResiduo.Text = "Actualizar";
            TxtIdResiduo.Text = formResiduosTable.RowId;
            TxtNameResiduo.Text = formResiduosTable.RowName;
            TxtDescriptionResiduo.Text = formResiduosTable.RowDescription;
            cmbTipoResiduo.Text = formResiduosTable.RowTipoResiduo;
            cmbGradoPeligrosidad.Text = formResiduosTable.RowGrado;
            cmbEstadoMateria.Text = formResiduosTable.RowEstado;
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
            cmbGradoPeligrosidad.IsEnabled = true;
        }
        
        private void LinkOpenTable(object sender, RoutedEventArgs e) {
            OpenTable();
            TxtNameResiduo.Focus();
        }

        private bool VerificarCampos(){
            if (TxtNameResiduo.Text != "Nombre de Residuo" && TxtDescriptionResiduo.Text != "Descripcion" && cmbTipoResiduo.SelectedIndex != -1 && cmbGradoPeligrosidad.SelectedIndex != -1 && cmbEstadoMateria.SelectedIndex != -1)
            {
                return true;
            }
            else { return false; }
        }
       
        private void ConvertirDatos() {
            nombre = Convert.ToString(TxtNameResiduo.Text);
            descripcion = Convert.ToString(TxtDescriptionResiduo.Text);
            tipoResiduo = Convert.ToInt32(cmbTipoResiduo.SelectedValue);
            gradoPeligro = Convert.ToInt32(cmbGradoPeligrosidad.SelectedValue);
            estadoMateria = Convert.ToInt32(cmbEstadoMateria.SelectedValue);
        }
        
        private void AddResiduo(object sender, RoutedEventArgs e)
        {
            if (VerificarCampos() == true)
            {
                ConvertirDatos();
                ResiduoModel residuoModel = new ResiduoModel();
                if (VerficarEstadoBoton() == true)
                {
                    if (residuoModel.InsertResiduo(nombre,
                        descripcion,
                        tipoResiduo,
                        gradoPeligro,
                        estadoMateria))
                    {
                        RefreshTablaResiduo?.Invoke(this, EventArgs.Empty);
                        PaintAllBox();
                        MessageBox.Show("Se añadió " + nombre + " a la base de datos", "Inserción Exitosa");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error ", "Fracaso de Inserción");
                        PaintAllBox();
                    }
                }
                else
                {
                    int id = Convert.ToInt32(TxtIdResiduo.Text);
                    if (residuoModel.UpdateResiduo(id,
                        nombre, 
                        descripcion, 
                        tipoResiduo, 
                        gradoPeligro, 
                        estadoMateria))
                    {
                        RefreshTablaResiduo?.Invoke(this, EventArgs.Empty);
                        PaintAllBox();
                        cmbGradoPeligrosidad.IsEnabled = false;
                        MessageBox.Show("Se actualizó el ID: " + id);
                    }
                    else {
                        MessageBox.Show("No se pudo actualizar el id: " + id,"Error de Actualización");
                    }
                    
                };

            }
            else { MessageBox.Show("Complete todo los campos", "Casilla Vacía"); }
        }
    }
}
