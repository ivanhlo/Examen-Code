using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioA
{
    // ServiceA --> Clase que recibe las peticiones
    // IServiceA -> Interfaz que muestra los resultados

    public class ServicioA : IServicioA
    {
        public Personaje ObtenerPersonaje()
        {
            throw new NotImplementedException();
        }
    }
}
