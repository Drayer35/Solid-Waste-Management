using Domain.Model;
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

namespace Presentation.View
{
    /// <summary>
    /// Lógica de interacción para FormTipoResiduo.xaml
    /// </summary>
    public partial class FormTipoResiduo : UserControl
    {
        int ColumnId = 1;
        int ColumnDescription=2;
        public FormTipoResiduo()
        {
            InitializeComponent();
            ToListTableTipoResiduo();
        }
        private void PaintBoxTipoResiduo()
        {
            TxtNameTipoResiduo.Text = "Tipo de Residuo";
            TxtNameTipoResiduo.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A6A6A7"));
            TextAddTipoResiduo.Text = "Agregar";
            TxtIdTipoResiduo.Text = "ID";
        }
        private void TextTipoResiduoEnter(object sender, EventArgs e)
        {
            if (TxtNameTipoResiduo.Text == "Tipo de Residuo") TxtNameTipoResiduo.Text = "";
            TxtNameTipoResiduo.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000012"));
        }
        private void TextTipoResiduoLeave(object sender, EventArgs e)
        {
            string estado = TxtNameTipoResiduo.Text.Trim(); // Elimina espacios en blanco al principio y al final
            if (string.IsNullOrEmpty(estado)) PaintBoxTipoResiduo();
        }


        private void AddTipoResiduo(object sender, RoutedEventArgs e)
        {
            if (TxtNameTipoResiduo.Text != "Tipo de Residuo")
            {
                TipoResiduoModel tipoResiduoModel   = new TipoResiduoModel();   
                if (TextAddTipoResiduo.Text == "Agregar")
                {
                    if (tipoResiduoModel.InsertTipoResiduo(TxtNameTipoResiduo.Text))
                    {
                        PaintBoxTipoResiduo();
                        ToListTableTipoResiduo();
                        MessageBox.Show("Se añadió " + TxtNameTipoResiduo.Text + " a la base de datos", "Inserción Exitosa");

                    }
                    else
                    {
                        MessageBox.Show("Hubo un error ", "Fracaso de Inserción");
                        PaintBoxTipoResiduo();
                    }
                }
                else
                {
                    int id = Convert.ToInt32(TxtIdTipoResiduo.Text);
                    string descripcion = ((string)TxtNameTipoResiduo.Text);
                    tipoResiduoModel.UpdateTipoResiduo(id, descripcion);
                    ToListTableTipoResiduo();
                    PaintBoxTipoResiduo();
                    MessageBox.Show("Se actualizó el ID: " + id);
                 
                };

            }
            else { MessageBox.Show("Ingresa el nombre del Estado", "Casilla Vacía"); }
        }
        private void ToListTableTipoResiduo()
        {
            TipoResiduoModel tipoResiduoModel = new TipoResiduoModel();
            TableTipoResiduo.DataContext = tipoResiduoModel.ToListTipoResiduo();

        }
        private void EditRecord(object sender, RoutedEventArgs e)
        {
            if (TableTipoResiduo.SelectedItems.Count > 0)
            {
                DataGridCellInfo selectedId = TableTipoResiduo.SelectedCells[ColumnId];
                DataGridCellInfo selectedDescription = TableTipoResiduo.SelectedCells[ColumnDescription];
                TxtIdTipoResiduo.Text = ((TextBlock)selectedId.Column.GetCellContent(selectedId.Item)).Text;
                TxtNameTipoResiduo.Text = ((TextBlock)selectedDescription.Column.GetCellContent(selectedDescription.Item)).Text;
                TextAddTipoResiduo.Text = "Guardar";
                TxtNameTipoResiduo.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000012"));
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "");
            }
        }
        private void DeleteRecord(object sender, RoutedEventArgs e)
        {
            DataGridCellInfo selectedId = TableTipoResiduo.SelectedCells[ColumnId];
            DataGridCellInfo selectedName = TableTipoResiduo.SelectedCells[ColumnDescription];
            string cellId = ((TextBlock)selectedId.Column.GetCellContent(selectedId.Item)).Text;
            string cellName = ((TextBlock)selectedName.Column.GetCellContent(selectedName.Item)).Text;
            int id = Convert.ToInt32(cellId);
            string name = Convert.ToString(cellName);
            MessageBoxResult result = MessageBox.Show("Se eliminará " + name + " de la base de datos.", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                TipoResiduoModel tipoResiduoModel = new TipoResiduoModel();
                tipoResiduoModel.DeleteTipoResiduo(id);
                ToListTableTipoResiduo();
            }
        }
    }
}
