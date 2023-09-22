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
        public FormTipoResiduo()
        {
            InitializeComponent();
        }
        private void PaintBoxResiduo()
        {
            TxtNameTipoResiduo.Text = "Tipo de Residuo";
            TxtNameTipoResiduo.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A6A6A7"));
        }
        private void TextTipoResiduoEnter(object sender, EventArgs e)
        {
            if (TxtNameTipoResiduo.Text == "Tipo de Residuo") TxtNameTipoResiduo.Text = "";
            TxtNameTipoResiduo.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000012"));
        }
        private void TextTipoResiduoLeave(object sender, EventArgs e)
        {
            string estado = TxtNameTipoResiduo.Text.Trim(); // Elimina espacios en blanco al principio y al final
            if (string.IsNullOrEmpty(estado)) PaintBoxResiduo();
        }
    }
}
