using System;
using System.Runtime.CompilerServices;

namespace TP___Circulo_de_Sangre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socio socio = new Socio();
            socio.preCargaSocios();
            Menu menu= new Menu();

            menu.menuPrincipal(socio);
            //socio.mostrarListaDonantes();   




            //socio.mostrarSocios();

            
        }


       

    }
}
