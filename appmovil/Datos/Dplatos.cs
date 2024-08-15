using appmovil.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace appmovil.Datos
{
    public class Dplatos
    {
        public ObservableCollection<Mplatos> ListarPlatos()
        {
            return new ObservableCollection<Mplatos>()
            {
                new Mplatos()
                {
                    descripcion="Plato 1",
                    precio ="S/. 15.00",
                    icono="https://s3.abcstatics.com/media/gurmesevilla/2012/01/comida-rapida-casera.jpg"
                },
                new Mplatos()
                {
                    descripcion="Plato 1",
                    precio ="S/. 15.00",
                    icono="https://www.saborusa.com/ni/wp-content/uploads/sites/19/2019/11/Calma-tus-antojos-con-deliciosas-y-rapidas-recetas-Foto-destacada.png"
                }
            };
        }
    }
}
