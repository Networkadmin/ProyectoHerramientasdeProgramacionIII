using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace Payme.Movil
{
    public class ClasePrincipal
    {
        private ObservableCollection<Evento> lista = new ObservableCollection<Evento>();

        public ObservableCollection<Evento> Lista
        {
            get { return lista; }
            set { lista = value; }
        }
    }
}
