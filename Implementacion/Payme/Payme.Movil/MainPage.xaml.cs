using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Payme.Movil
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
		}
           /*this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            using (BaseDatosDataContext contexto = new BaseDatosDataContext(App.cadenaConexion))
             {
               var query = from p in contexto.Cuenta
                            select p;

                if (query.FirstOrDefault() != new)
                    NavigationService.Navigate(new Uri("/NuevoEvento.xaml", UriKind.Relative));
                else
                    NavigationService.Navigate(new Uri("/CrearCuenta.xaml", UriKind.Relative));
            }
        }

      */
        private void Agregar_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new Uri("/NuevoEvento.xaml", UriKind.Relative));
        }

        private void Consultar_Click(object sender, System.EventArgs e)
        {
        	NavigationService.Navigate(new Uri("/ConsultarEvento.xaml", UriKind.Relative));
        }
    }
}