using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace Mail
{
    public class Mensaje
    {
        public string asunto{ get; set; }
        public string cuerpo{ get; set; }
      

        public Contacto destinatario { get; set; } 
        public Contacto remitente { get; set; }

        public Mensaje() { }


    }
}
