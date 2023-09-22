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
        }
        private void PaintBoxResiduo()
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
            if (string.IsNullOrEmpty(estado)) PaintBoxResiduo();
        }

    }
}
