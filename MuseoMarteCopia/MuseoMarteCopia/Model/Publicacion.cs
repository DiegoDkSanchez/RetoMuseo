using System;
using System.Collections.Generic;
using System.Text;

namespace MuseoMarteCopia.Model
{
    public class Publicacion
    {
        public String Descripcion { get; set; }
        public String Img { get; set; }

        public List<Publicacion> GetPublicaciones()
        {
            List<Publicacion> publicaciones = new List<Publicacion>()
            {
                new Publicacion(){Descripcion="¡Bienvenidos este miércoles a la exposición Rosa Mena Valenzuela acompaña a Nicanor Parra en #MARTE!",
                                  Img="https://scontent.xx.fbcdn.net/v/t1.0-9/s720x720/30738772_10155544000106375_8402809343723962368_n.jpg?_nc_cat=0&oh=4ccd477c69f713825f91ff963238a52c&oe=5B5D3E6D"},
                new Publicacion(){Descripcion = "¡Participa este 2 y 3 de mayo en nuestro bazar #DetallesYRegalos en #MARTE! Escribe a mercadeo.marte@gmail.com para obtener mayor información",
                                  Img = "https://scontent.xx.fbcdn.net/v/t1.0-0/p180x540/30739235_10155544000171375_6111654770475270144_n.jpg?_nc_cat=0&oh=ae52dd7f76640a5c0318eef822873884&oe=5B5570B4" },
                new Publicacion(){Descripcion="¡Este lunes 23 de abril te invitamos a disfrutar de Vox Cordis,El Salvador con el concierto Donde hay un sueño, se abren los caminos en los #LunesMusicales en #MARTE!",
                                  Img = "https://scontent.xx.fbcdn.net/v/t1.0-0/p180x540/30743141_10155544000261375_1609490168987779072_n.jpg?_nc_cat=0&oh=03924ee9866dcd93abe5084a880b9cea&oe=5B65C7DB"},
                new Publicacion(){Descripcion="¡Los días soleados se viven en #MARTE! ¿Nos visitas en este martes?",
                                  Img = "https://scontent.xx.fbcdn.net/v/t1.0-9/s720x720/30703723_10155540283981375_6219386392938545152_n.jpg?_nc_cat=0&oh=0855b61300a5fb84df5209e99ed062b1&oe=5B55D545"}
            };
            return publicaciones;
        }
    }
}
