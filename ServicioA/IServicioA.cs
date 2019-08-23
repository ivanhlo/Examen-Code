using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServicioA
    {
        [OperationContract]
        //Personaje ObtenerPersonaje(string IdPer);
        Comic ObtenerComic(string IdCom, string filtro);
        //Creador ObtenerCreador(string IdCre);


        // Agregar aquí las operaciones del servicio
    }
    // la clase Personaje va a obtener la información de la tabla personaje
    [DataContract]
    public class Personaje: GestionErrores
    {
        [DataMember]
        public string NomPer { get; set; }
        [DataMember]
        public string Sincro { get; set; }
    }
    // la clase Comic obtiene la información de la tabla comic
    public class Comic: GestionErrores
    {
        [DataMember]
        public string IdCre { get; set; }
        [DataMember]
        public string IdCom { get; set; }
        [DataMember]
        public string TitCom { get; set; }
        [DataMember]
        public string RolCre { get; set; }
        [DataMember]
        public string Sincro { get; set; }
    }
    // la clase Creador obtiene la información de la tabla creador
    public class Creador: GestionErrores
    {
        [DataMember]
        public string NomCre { get; set; }
        [DataMember]
        public string Sincro { get; set; }
    }
    // para heredar la gestión de los errores
    public class GestionErrores
    {
        [DataMember]
        public string CodEr { get; set; }
        [DataMember]
        public string DesEr { get; set; }
    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
