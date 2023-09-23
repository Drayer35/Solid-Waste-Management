﻿using Domain.Model;
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
    /// Lógica de interacción para FormEstadoMateria.xaml
    /// </summary>
    public partial class FormEstadoMateria : UserControl
    {
        public FormEstadoMateria()
        {
            InitializeComponent();
            ToListTableEstado();
        }
        int ColumnId = 1;
        int ColumnDescription = 2;
        private void PaintBoxEstadoMateria()
        {
            TxtNameEstadoMateria.Text = "Nombre de Estado";
            TxtNameEstadoMateria.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A6A6A7"));
        }
        private void TextEstadoMateriaEnter(object sender, EventArgs e)
        {
            if (TxtNameEstadoMateria.Text == "Nombre de Estado") TxtNameEstadoMateria.Text = "";
            TxtNameEstadoMateria.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000012"));
        }
        private void TextEstadoMateriaLeave(object sender, EventArgs e)
        {
            string estado = TxtNameEstadoMateria.Text.Trim(); // Elimina espacios en blanco al principio y al final
            if (string.IsNullOrEmpty(estado)) PaintBoxEstadoMateria();
        }

        private void BtnAddEstadoMateria_Click(object sender, RoutedEventArgs e)
        {
            if (TxtNameEstadoMateria.Text != "Nombre de Estado")
            {
                EstadoMateriaModel estadoMateriaModel = new EstadoMateriaModel();
                if (TextAddEstablecimiento.Text == "Agregar")
                {
                    if (estadoMateriaModel.InserEstado(TxtNameEstadoMateria.Text))
                    {
                        PaintBoxEstadoMateria();
                        ToListTableEstado();
                        MessageBox.Show("Se añadió " + TxtNameEstadoMateria.Text + " a la base de datos", "Inserción Exitosa");
                        
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error ", "Fracaso de Inserción");
                        PaintBoxEstadoMateria();
                    }
                }
                else
                {
                    int id = Convert.ToInt32(TxtIdEstadoMateria.Text);
                    string descripcion = ((string)TxtNameEstadoMateria.Text);
                    estadoMateriaModel.UpdateEstadoMateria(id, descripcion);
                    MessageBox.Show("Se actualizó el ID: " + id);
                    ToListTableEstado();
                    PaintBoxEstadoMateria();
                };

            }
            else { MessageBox.Show("Ingresa el nombre del Estado", "Casilla Vacía"); }
        }
        private void ToListTableEstado()
        {
            EstadoMateriaModel estadoMateriaModel = new EstadoMateriaModel();
            TableEstadoMateria.DataContext = estadoMateriaModel.GetCantidadEstadosMateria();

        }
        private void EditRecord(object sender, RoutedEventArgs e)
        {
            if (TableEstadoMateria.SelectedItems.Count > 0)
            {
                DataGridCellInfo selectedId = TableEstadoMateria.SelectedCells[ColumnId];
                DataGridCellInfo selectedDescription = TableEstadoMateria.SelectedCells[ColumnDescription];
                TxtIdEstadoMateria.Text = ((TextBlock)selectedId.Column.GetCellContent(selectedId.Item)).Text;
                TxtNameEstadoMateria.Text = ((TextBlock)selectedDescription.Column.GetCellContent(selectedDescription.Item)).Text;
                TextAddEstablecimiento.Text = "Guardar";
                TxtNameEstadoMateria.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000012"));
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "");
            }
        }
        private void DeleteRecord(object sender, RoutedEventArgs e)
        {
            DataGridCellInfo selectedId = TableEstadoMateria.SelectedCells[ColumnId];
            DataGridCellInfo selectedName = TableEstadoMateria.SelectedCells[ColumnDescription];
            string cellId = ((TextBlock)selectedId.Column.GetCellContent(selectedId.Item)).Text;
            string cellName = ((TextBlock)selectedName.Column.GetCellContent(selectedName.Item)).Text;
            int id = Convert.ToInt32(cellId);
            string name = Convert.ToString(cellName);
            MessageBoxResult result = MessageBox.Show("Se eliminará " + name + " de la base de datos.", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                EstadoMateriaModel estadoMateriaModel = new EstadoMateriaModel();
                estadoMateriaModel.DeleteEstadoMateria(id);
                ToListTableEstado();
            }
        }

    }

}
