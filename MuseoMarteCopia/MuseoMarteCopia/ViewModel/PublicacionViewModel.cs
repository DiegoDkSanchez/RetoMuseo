using MuseoMarteCopia.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuseoMarteCopia.ViewModel
{
    public class PublicacionViewModel
    {
        public List<Publicacion> Publicaciones { get; set; }

        public PublicacionViewModel()
        {
            Publicaciones = new Publicacion().GetPublicaciones();
        }
    }
}
