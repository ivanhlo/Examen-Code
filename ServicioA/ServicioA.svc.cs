using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Newtonsoft.Json;

namespace ServicioA
{
    /*  Descripción:    
        ServiceA:       Clase que recibe las peticiones
        IServiceA:      Interfaz que muestra los resultados
    */
    /*-------------------------------------------------------------------------------------------------------------------------------------------------------
    C O M I C S: Lista de comics filtrados por personajes (Iron Man: 1009368; Captain America: 1009220)
    requestURL: st1 + idLista + st3 (donde idLista es el idLista de la entidListaad: Personaje, Comic o Creador)
    Para:
        id = 1009368  ->  Iron Man
        id = 1009220  ->  Captain America

        entidad = "character"
        entidad = "comic"
        entidad = "creator"

        role  = "editor"
        role  = "colorist"
        role  = "writer"

    request URL (IRONMAN):    https://gateway.marvel.com:443/v1/public/characters/1009368/comics?ts=1&apikey=a90d074cc0483b65fe3c15a6c9970912&hash=792414c616577193fbe3817ba81822a8
    request URL (CAPAMERICA): https://gateway.marvel.com:443/v1/public/characters/1009220/comics?ts=1&apikey=a90d074cc0483b65fe3c15a6c9970912&hash=792414c616577193fbe3817ba81822a8

    request URL (IRONMAN):    https://gateway.marvel.com:443/v1/public/characters/1009368?ts=1&apikey=a90d074cc0483b65fe3c15a6c9970912&hash=792414c616577193fbe3817ba81822a8
    request URL (CAPAMERICA): https://gateway.marvel.com:443/v1/public/characters/1009220?ts=1&apikey=a90d074cc0483b65fe3c15a6c9970912&hash=792414c616577193fbe3817ba81822a8

    --------------------------------------------------------------------------------------------------------------------------------------------------------*/
    public class ServicioA : IServicioA
    {
        public Comic ObtenerComic(string IdPer, string filtro)
        {
            /*
            var cadena = "";
            switch (filtro)
            {
                case "character":
                    cadena = "https://gateway.marvel.com:443/v1/public/characters/" + IdPer + "?ts=1&apikey=a90d074cc0483b65fe3c15a6c9970912&hash=792414c616577193fbe3817ba81822a8";
                    break;
                case "comic":
                    cadena = "https://gateway.marvel.com:443/v1/public/characters/" + IdPer + "/comics?ts=1&apikey=a90d074cc0483b65fe3c15a6c9970912&hash=792414c616577193fbe3817ba81822a8";
                    break;
                case "creator":
                    cadena = "https://gateway.marvel.com:443/v1/public/characters/" + IdPer + "/comics?ts=1&apikey=a90d074cc0483b65fe3c15a6c9970912&hash=792414c616577193fbe3817ba81822a8";
                    break;
            }
            string url = cadena;
            var arrayDatos = new WebClient().DownloadString(url);
            dynamic json = JsonConvert.DeserializeObject(arrayDatos);
            */
            /*if (filtro == "character")
            {
                string idLista = "";
                var numElem = 1;
                foreach (var result in json.data.results)
                {
                    Console.WriteLine(result.id);
                    if (numElem > 1)
                    {
                        idLista = idLista + "," + result.id;
                    }
                    else
                    {
                        idLista = result.id;
                    }
                    numElem++;
                }

                return new Comic() { IdCre = "Pedro", IdCom = idLista, TitCom = "o", RolCre = "l", Sincro = "a" };
            }
            else
            {
                return new Comic() { CodEr = "404", DesEr = "No se encontró" };
            }*/
            //throw new NotImplementedException();
            if (IdPer == "1009368" && filtro == "comic")
            {
                return new Comic() { IdCre = "Pedro", IdCom = "idLista", TitCom = "o", RolCre = "l", Sincro = "a" };
            }
            else
            {
                return new Comic() { CodEr = "404", DesEr = "No se encontró" };
            }

            
        }
        /*
        public Creador ObtenerCreador(string IdCre)
        {
            return new Creador() { NomCre = "", Sincro = "" };
            //throw new NotImplementedException();
        }

        public Personaje ObtenerPersonaje(string IdPer)
        {
            return new Personaje() { NomPer = "", Sincro = "" };
            //throw new NotImplementedException();
        }*/
    }
}
