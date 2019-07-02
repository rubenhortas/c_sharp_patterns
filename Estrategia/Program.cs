using System;

namespace Estrategia
{
    class Program
    {
        static void Main(string[] args)
        {
            Venta venta;
            int totalVenta = 100;

            Console.WriteLine(String.Format("Descuento de un {0}%", Constants.PORCENTAJE_DESCUENTO));
            IEstrategiaFijarPreciosVenta estrategiaFijarPreciosProcentajeDescuento = new EstrategiaFijarPreciosPorcentajeDescuento();
            venta = new Venta(totalVenta, estrategiaFijarPreciosProcentajeDescuento);
            venta.GetTotal();

            Console.WriteLine();

            Console.WriteLine(String.Format("Descuento de {0}€ (venta minima de {1}€)", Constants.DESCUENTO, Constants.UMBRAL_GASTO));
            IEstrategiaFijarPreciosVenta estrategiaFijarPreciosDescuentoAbsolutoSobreUmbral = new EstrategiaFijarPreciosDescuentoAbsolutoSobreUmbral();
            venta = new Venta(totalVenta, estrategiaFijarPreciosDescuentoAbsolutoSobreUmbral);
            venta.GetTotal();

            Console.ReadLine();
        }
    }
}
