using Mail;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using System.Net.Mail;
using System.Runtime.InteropServices;
using Xunit.Sdk;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mensaje = new Mensaje();
            var contacto_destinatario = new Contacto("juan", "juan@gmail.com");
            var contacto_remitente = new Contacto("Banco", "Santander@gmail.com");
           
            mensaje.destinatario = contacto_destinatario;
            mensaje.remitente = contacto_remitente;
            mensaje.asunto = "Banco Santander";
            mensaje.cuerpo = "Ya tiene disponible su tarjeta";

            Assert.Equal("Banco Santander", mensaje.asunto);
            Assert.Equal("Ya tiene disponible su tarjeta", mensaje.cuerpo);
            Assert.Equal("juan", mensaje.destinatario.nombre);
            Assert.Equal("juan@gmail.com", mensaje.destinatario.mail);
            Assert.Equal("Banco", mensaje.remitente.nombre);
            Assert.Equal("Santander@gmail.com", mensaje.remitente.mail);
        }
        [Fact]
        public void Test2()
        {
            var gestor = new Gestor();
            var mensaje = new Mensaje();

            mensaje.asunto = "juan";
            mensaje.cuerpo = "hola que tal";

            gestor.addEntrada(mensaje);

            Assert.Equal("juan", gestor.entrada[0].asunto);
            Assert.Equal("hola que tal", gestor.entrada[0].cuerpo);
            

            
        }
    }
}