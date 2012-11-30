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
    public partial class CrearCuenta : PhoneApplicationPage
    {
        public CrearCuenta()
        {
            InitializeComponent();
        }
		
		 private void Guardar_Click(object sender, System.EventArgs e)
        {
            
			NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

		 private void Cancelar_Click(object sender, System.EventArgs e)
		 {
		 	// TODO: Agregar implementación de controlador de eventos aquí.
		 }

         private void Frecuencia_TextChanged(object sender, TextChangedEventArgs e)
         {
         }

     
    }
}