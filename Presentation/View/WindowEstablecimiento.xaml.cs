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
        int ColumnId = 1;
        int ColumnName = 2;
        public event EventHandler RefreshListEstablecimientos;
 
        public WindowEstablecimiento()
        {
            InitializeComponent();
            ToListTableEstablecimiento();
            TxtNameEstablecimiento.Focus();
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
        private void TextEstablecimientoEnter(object sender, EventArgs e)
        {
            if (TxtNameEstablecimiento.Text == "Nombre Establecimiento") TxtNameEstablecimiento.Text = "";
            TxtNameEstablecimiento.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000012"));
        }
        private void TextEstablecimientoLeave(object sender, EventArgs e)
        {
            string establecimiento = TxtNameEstablecimiento.Text.Trim(); // Elimina espacios en blanco al principio y al final
            if (string.IsNullOrEmpty(establecimiento))
            {
                PaintBoxEstablecimiento();
            }
        }
        private void EditRecord(object sender, RoutedEventArgs e)
        {
            if (TableEstablecimientos.SelectedItems.Count > 0)
            {
                DataGridCellInfo selectedId = TableEstablecimientos.SelectedCells[ColumnId];
                DataGridCellInfo selectedName = TableEstablecimientos.SelectedCells[ColumnName];
                TxtIdEstablecimiento.Text = ((TextBlock)selectedId.Column.GetCellContent(selectedId.Item)).Text;
                TxtNameEstablecimiento.Text = ((TextBlock)selectedName.Column.GetCellContent(selectedName.Item)).Text;
                TextAddEstablecimiento.Text = "Guardar";
                TxtNameEstablecimiento.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000012"));
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "");
            }
        }
        private void DeleteRecord(object sender, RoutedEventArgs e)
        {
            DataGridCellInfo selectedId   = TableEstablecimientos.SelectedCells[ColumnId];
            DataGridCellInfo selectedName = TableEstablecimientos.SelectedCells[ColumnName];
            string cellId   = ((TextBlock)selectedId.Column.GetCellContent(selectedId.Item)).Text;
            string cellName = ((TextBlock)selectedName.Column.GetCellContent(selectedName.Item)).Text;
            int id = Convert.ToInt32(cellId);
           string name = Convert.ToString(cellName);
            MessageBoxResult result = MessageBox.Show("Se eliminará "+ name +" de la base de datos.", "Logout", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                EstablecimientoModel establecimientoModel = new EstablecimientoModel();
                establecimientoModel.DeleteEstablecimiento(id);
                PaintBoxEstablecimiento();
                ToListTableEstablecimiento();
            }
        }
        private void AddEstablecimiento(object sender, RoutedEventArgs e)
        {
            if (TxtNameEstablecimiento.Text != "Nombre Establecimiento")
            {
                EstablecimientoModel establecimientoModel = new EstablecimientoModel();
                if (TextAddEstablecimiento.Text == "Agregar")
                {
                    if (establecimientoModel.CreateEstablecimiento(TxtNameEstablecimiento.Text))
                    {

                        ToListTableEstablecimiento();
                        PaintBoxEstablecimiento();
                        MessageBox.Show("Se añadió " + TxtNameEstablecimiento.Text + " a la base de datos", "Inserción Exitosa");
                       
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error ", "Fracaso de Inserción");
                        PaintBoxEstablecimiento();
                    }
                }
                else {
                    int id = Convert.ToInt32(TxtIdEstablecimiento.Text);
                    string name = ((string)TxtNameEstablecimiento.Text);
                    establecimientoModel.UpdateEstablecimiento(id, name);
                    ToListTableEstablecimiento();
                    PaintBoxEstablecimiento();
                    MessageBox.Show("Se actualizó el ID: " + id);
                };
                 
            }
            else { MessageBox.Show("Ingresa el nombre del Establecimiento", "Casilla Vacía"); }
        }
        private void ToListTableEstablecimiento() {
            RefreshListEstablecimientos?.Invoke(this, EventArgs.Empty);
            EstablecimientoModel establecimiento = new EstablecimientoModel();
            TableEstablecimientos.DataContext = establecimiento.ToListEstablecimientos();
        }
        private void PaintBoxEstablecimiento() {
            TxtNameEstablecimiento.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A6A6A7"));
            TxtNameEstablecimiento.Text = "Nombre Establecimiento";
            TxtIdEstablecimiento.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A6A6A7"));
            TxtIdEstablecimiento.Text = "ID";
            TextAddEstablecimiento.Text = "Agregar";

        }
        
        
            

    }
}
