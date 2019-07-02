using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Venta venta;
            int totalVenta = 100;

            Console.WriteLine("Lo mejor para el cliente");
            EstrategiaCompuestaFijarPreciosLoMejorParaElCliente estrategiaCompuestaFijarPreciosLoMejorParaElCliente = new EstrategiaCompuestaFijarPreciosLoMejorParaElCliente();
            venta = new Venta(totalVenta, estrategiaCompuestaFijarPreciosLoMejorParaElCliente);
            venta.GetTotal();

            Console.WriteLine();

            Console.WriteLine("Lo mejor para la tienda");
            EstrategiaCompuestaFijarPreciosLoMejorParaLaTienda estrategiaCompuestaFijarPreciosLoMejorParaLaTienda = new EstrategiaCompuestaFijarPreciosLoMejorParaLaTienda();
            venta = new Venta(totalVenta, estrategiaCompuestaFijarPreciosLoMejorParaLaTienda);
            venta.GetTotal();

            Console.ReadLine();
        }
    }
}
