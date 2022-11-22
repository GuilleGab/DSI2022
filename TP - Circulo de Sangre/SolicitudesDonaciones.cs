using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP___Circulo_de_Sangre
{
    public class SolicitudesDonaciones
    {
        public string grupoSangre;
        public int cantSolicitadaDonantes;
        DateTime fechaDeSolicitud;

        public string GrupoSangre { get => grupoSangre; set => grupoSangre = value; }
        public int CantSolicitadaDonantes { get => cantSolicitadaDonantes; set => cantSolicitadaDonantes = value; }
        public DateTime FechaDeSolicitud { get => fechaDeSolicitud; set => fechaDeSolicitud = value; }


        public void cargarSolicitudDonantes()
        {
            Console.WriteLine("Por favor ingrese la fecha para la que solicita donantes");
            fechaDeSolicitud = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el grupo de Sangre que desea solicitar");
            grupoSangre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese la cantidad de donantes que desea solicitar");
            cantSolicitadaDonantes = Convert.ToInt32(Console.ReadLine());

            asignarDonantes();
        }

        public void asignarDonantes()
        {
            Socio socio= new Socio();
            int cantidad;
            if (cantSolicitadaDonantes >= socio.donantes.Count())
            {
                cantidad = socio.donantes.Count();
                //do
                //{
                    foreach (var item in socio.donantes)
                    {
                        Console.WriteLine("Se ha enviado una notificacion al numero de telefono "
                            + item.Telefono + "\t y un email a la direccion de email " + item.Email);
                    }
                //} while (cantidad == 0);
            }
            else
            {
                cantidad = cantSolicitadaDonantes;
                //do
                //{
                    foreach (var item in socio.donantes)
                    {
                        Console.WriteLine("Se ha enviado una notificacion al numero de telefono "
                            + item.Telefono + "\t y un email a la direccion de email " + item.Email);
                    }
                //} while (cantidad == 0);
            }
        }

        
    }
}
