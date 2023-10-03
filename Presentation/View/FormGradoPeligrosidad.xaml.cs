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
    /// Lógica de interacción para FormGradoPeligrosidad.xaml
    /// </summary>
    public partial class FormGradoPeligrosidad : UserControl
    {
        int ColumnId = 1;
        int ColumnDescription = 2;
        public event EventHandler RefreshComboBoxGrado;
        public FormGradoPeligrosidad()
        {
            InitializeComponent();
            ToListTableGrado();
        }

        private void PaintBoxGrado()
        {
            TxtNameGrado.Text = "Grado Peligrosidad";
            TxtNameGrado.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A6A6A7"));
            TextAddGrado.Text = "Agregar";
            TxtIdGrado.Text = "ID";
            
        }
        private void TextGradoEnter(object sender, EventArgs e)
        {
            if (TxtNameGrado.Text == "Grado Peligrosidad") TxtNameGrado.Text = "";
            TxtNameGrado.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000012"));
        }
        private void TextGradoLeave(object sender, EventArgs e)
        {
            string grado = TxtNameGrado.Text.Trim(); // Elimina espacios en blanco al principio y al final
            if (string.IsNullOrEmpty(grado)) PaintBoxGrado();
        }

        private void AddGrado(object sender, RoutedEventArgs e)
        {
            if (TxtNameGrado.Text != "Grado Peligrosidad")
            {
                GradoPeligrosidadModel  gradoPeligrosidadModel  = new GradoPeligrosidadModel();
                if (TextAddGrado.Text == "Agregar")
                {
                    if (gradoPeligrosidadModel.InsertGrado(TxtNameGrado.Text))
                    {
                        PaintBoxGrado();
                        ToListTableGrado();
                        MessageBox.Show("Se añadió " + TxtNameGrado.Text + " a la base de datos", "Inserción Exitosa");
                        RefreshComboBoxGrado?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error ", "Fracaso de Inserción");
                        PaintBoxGrado();
                    }
                }
                else
                {
                    int id = Convert.ToInt32(TxtIdGrado.Text);
                    string descripcion = ((string)TxtNameGrado.Text);
                    gradoPeligrosidadModel.UpdateGrado(id, descripcion);
                    RefreshComboBoxGrado?.Invoke(this, EventArgs.Empty);
                    ToListTableGrado();
                    PaintBoxGrado();
                    MessageBox.Show("Se actualizó el ID: " + id);
                };
            }
            else { MessageBox.Show("Ingresa el nombre del Grado", "Casilla Vacía"); }
        }
        private void ToListTableGrado()
        {
            GradoPeligrosidadModel  gradoPeligrosidadModel = new GradoPeligrosidadModel();  
           
            TableGrado.DataContext = gradoPeligrosidadModel.SelectGrado();
        }

        private void EditRecord(object sender, RoutedEventArgs e)
        {
            if (TableGrado.SelectedItems.Count > 0)
            {
                DataGridCellInfo selectedId = TableGrado.SelectedCells[ColumnId];
                DataGridCellInfo selectedDescription = TableGrado.SelectedCells[ColumnDescription];
                TxtIdGrado.Text = ((TextBlock)selectedId.Column.GetCellContent(selectedId.Item)).Text;
                TxtNameGrado.Text = ((TextBlock)selectedDescription.Column.GetCellContent(selectedDescription.Item)).Text;
                TextAddGrado.Text = "Guardar";
                TxtNameGrado.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000012"));
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "");
            }
        } 

        private void DeleteRecord(object sender, RoutedEventArgs e)
        {
            DataGridCellInfo selectedId = TableGrado.SelectedCells[ColumnId];
            DataGridCellInfo selectedName = TableGrado.SelectedCells[ColumnDescription];
            string cellId = ((TextBlock)selectedId.Column.GetCellContent(selectedId.Item)).Text;
            string cellName = ((TextBlock)selectedName.Column.GetCellContent(selectedName.Item)).Text;
            int id = Convert.ToInt32(cellId);
            string name = Convert.ToString(cellName);
            MessageBoxResult result = MessageBox.Show("Se eliminará " + name + " de la base de datos.", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                GradoPeligrosidadModel gradoPeligrosidadModel = new GradoPeligrosidadModel();
                gradoPeligrosidadModel.DeleteGrado(id);
                RefreshComboBoxGrado?.Invoke(this, EventArgs.Empty);
                PaintBoxGrado();
                ToListTableGrado();
            }
        }
    }
}
