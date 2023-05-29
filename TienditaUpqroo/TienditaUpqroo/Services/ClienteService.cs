using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienditaUpqroo.ClienteServices
{
    internal class ClienteService
    {
        public void precioartticulo()

        {
            int artticulo1, articulo2, artticulo3, articulo4, articulo5;
            int artitotal = 0;
            double descuento = 10;


            Console.WriteLine("ingresa precio del primer articulo");
            artticulo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa precio del segundo articulo");
            articulo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa precio del tercer articulo");
            artticulo3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa precio del cuarto articulo");
            articulo4 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa precio del quinto articulo");
            articulo5 = int.Parse(Console.ReadLine());
            artitotal = artticulo1 + articulo2 + artticulo3 + articulo4 + articulo5;
            Console.WriteLine("Pagarás un total de: " + artitotal);
            if (artitotal >= 5000 && artitotal < 5000)
            {
                Console.WriteLine("felicidades tendrás un 10% de descuento :) ");
                Console.WriteLine("con el descuento Pagarás un total de: " + artitotal / descuento);
            }
            if (artitotal >= 8000 && artitotal < 10000)
            {
                Console.WriteLine("felicidades tienes el pago a 3 meses sin intereses ");
            }
            if (artitotal >= 10000)
            {
                Console.WriteLine("puedes escoger entre 1-. 3 meses sin intereses   2-. 6 meses sin intereses");


            }
        }
    }
}