using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TienditaUpqroo.ClienteServices;

namespace TienditaUpqroo.Cliente
{
    internal class Clientes    {

        string Nombre { get; set; }
        string Correo { get; set; }
        string Numero { get; set; }

        public void Imprimirdatos()
        {

            Console.WriteLine("ingresa tu nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("ingresa tu correo");
            Correo = Console.ReadLine();
            Console.WriteLine("ingresa tu numero");
            Numero = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Bienvenido " + Nombre);
            Console.WriteLine("correo : " + Correo);
            Console.WriteLine("Numero : " + Numero);
            ClienteService articulo = new ClienteService();
            articulo.precioartticulo();






        }

    }
}
