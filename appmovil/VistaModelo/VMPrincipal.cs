using appmovil.Datos;
using appmovil.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
namespace appmovil.VistaModelo
{
    public class VMPrincipal:BaseViewModel
    {
        #region VARIABLES
        ObservableCollection<Mplatos> _listaplato;
        string _Texto;
        #endregion
        #region CONSTRUCTOR
        public VMPrincipal(INavigation navigation)
        {
            Navigation = navigation;
            Listarplatos();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<Mplatos> Listaplatos
        {
            get { return _listaplato; }
            set { SetValue(ref _listaplato, value); }
        }
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public void Listarplatos()
        {
            var funcion = new Dplatos();
            Listaplatos=funcion.ListarPlatos();
        }
        public void ProcesoSimple()
        {
            
        }
        #endregion
        #region COMANDOS
         public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
