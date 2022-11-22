using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP___Circulo_de_Sangre
{
    public class Donaciones
    {
        DateTime fechaDonacion;
        string apellido;
        string nombre;
        int dni;

        //Socio socio = new Socio();

        public DateTime FechaDonacion { get => fechaDonacion; set => fechaDonacion = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Dni { get => dni; set => dni = value; }

        List<Donaciones> donacion = new List<Donaciones>();  

        public void preCargaDonacion()
        {
            Donaciones donacion1 = new Donaciones();

            donacion1.FechaDonacion = new DateTime(2022, 10, 22);
            donacion1.Apellido = "Gomez";
            donacion1.Nombre = "Carlos";
            donacion1.Dni = 32444565;

            donacion.Add(donacion1);

        }

        

        
        
    }
}
