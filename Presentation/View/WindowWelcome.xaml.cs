using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml.Linq;
using Common.Cache;


namespace Presentation.View
{
    public partial class WindowWelcome : Window
    {
        DispatcherTimer timer1 = new DispatcherTimer();
        DispatcherTimer timer2 = new DispatcherTimer();
        public WindowWelcome()
        {
            InitializeComponent();
            insertData();
            timer1.Interval = new TimeSpan(0,0,0,0,30);
            timer2.Interval = new TimeSpan(0, 0, 0, 0, 30);
            timer1.Tick += timer1_Tick;
            timer2.Tick += timer2_Tick;
            this.Opacity = 0;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <1) this.Opacity += 0.05;
            barraCarga.Value += 1;
            porcentaje.Text = barraCarga.Value.ToString() + "%";
            if (barraCarga.Value == 100) {
                porcentaje.Text ="Carga Completada";
                timer1.Stop();
                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e) {
            this.Opacity -= 0.1;
            if (this.Opacity <= 0)
            {
                timer2.Stop();
                this.Close();       
            }
        }
        private void insertData() { 
            txtUserFullName.Text = UserLoginCache.Nombre + " " + UserLoginCache.Apellido;
        }
    }
}
