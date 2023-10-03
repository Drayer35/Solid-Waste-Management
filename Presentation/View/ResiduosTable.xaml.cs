using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Lógica de interacción para ResiduosTable.xaml
    /// </summary>
    public partial class ResiduosTable : UserControl
    {
        int ColumnId = 1;
        int ColumnName = 2;
        int ColumnDescription = 3;
        int ColumnTipoResiduo= 4;
        int ColumnGrado = 5;
        int ColumnEstado= 6;

        public string RowId;
        public string RowName;
        public string RowDescription;
        public string RowTipoResiduo;
        public string RowGrado;
        public string RowEstado;

        public event EventHandler PaintText;
        public event Action <object> RowUpdated;

        public ResiduosTable()
        {
            InitializeComponent();
            listar();
        } 
        public void ListTableResiduo(object sender, EventArgs e)
        {
            listar();
        }
        public void listar() {
            ResiduoModel residuoModel = new ResiduoModel();
            TableResiduos.DataContext = residuoModel.SelectResiduo();
        }

        private void EditRecord(object sender, RoutedEventArgs e)
        {
            PaintText?.Invoke(this, e); 
            RowUpdated?.Invoke(TableResiduos.SelectedItem);
            if (TableResiduos.SelectedItems.Count > 0)
            {
                WindowResiduos windowResiduos = new WindowResiduos();
                DataGridCellInfo selectedId = TableResiduos.SelectedCells[ColumnId];
                DataGridCellInfo selectedName = TableResiduos.SelectedCells[ColumnName];
                DataGridCellInfo selectedDescription = TableResiduos.SelectedCells[ColumnDescription];
                DataGridCellInfo selectedTipoResiduo = TableResiduos.SelectedCells[ColumnTipoResiduo];
                DataGridCellInfo selectedGrado = TableResiduos.SelectedCells[ColumnGrado];
                DataGridCellInfo selectedEstado = TableResiduos.SelectedCells[ColumnEstado];


                RowId= ((TextBlock)selectedId.Column.GetCellContent(selectedId.Item)).Text;
                RowName= ((TextBlock)selectedName.Column.GetCellContent(selectedName.Item)).Text;
                RowDescription= ((TextBlock)selectedDescription.Column.GetCellContent(selectedDescription.Item)).Text;
                RowTipoResiduo = ((TextBlock)selectedTipoResiduo.Column.GetCellContent(selectedTipoResiduo.Item)).Text;
                RowGrado = ((TextBlock)selectedGrado.Column.GetCellContent(selectedGrado.Item)).Text;
                RowEstado = ((TextBlock)selectedEstado.Column.GetCellContent(selectedEstado.Item)).Text;
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "");
            }
        }
        private void DeleteRecord(object sender, RoutedEventArgs e)
        {
            DataGridCellInfo selectedId = TableResiduos.SelectedCells[ColumnId];
            DataGridCellInfo selectedName = TableResiduos.SelectedCells[ColumnDescription];
            string cellId = ((TextBlock)selectedId.Column.GetCellContent(selectedId.Item)).Text;
            string cellName = ((TextBlock)selectedName.Column.GetCellContent(selectedName.Item)).Text;
            int id = Convert.ToInt32(cellId);
            string name = Convert.ToString(cellName);
            MessageBoxResult result = MessageBox.Show("Se eliminará " + name + " de la base de datos.", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                ResiduoModel residuoModel = new ResiduoModel();
                residuoModel.DeleteResiduo(id);
                listar();
            }
        }
    }
}
