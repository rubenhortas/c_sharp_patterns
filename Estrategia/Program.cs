using System;

namespace Estrategia
{
    class Program
    {
        static void Main(string[] args)
        {
            Venta venta;
            int totalVenta = 100;

            Console.WriteLine(String.Format("Descuento de un {0}%", EstrategiaFijarPreciosPorcentajeDescuento.Porcentaje));
            IEstrategiaFijarPreciosVenta estrategiaFijarPreciosProcentajeDescuento = new EstrategiaFijarPreciosPorcentajeDescuento();
            venta = new Venta(totalVenta, estrategiaFijarPreciosProcentajeDescuento);
            venta.GetTotal();

            Console.WriteLine();

            Console.WriteLine(String.Format("Descuento de {0}€ (venta minima de {1}€)", EstrategiaFijarPreciosDescuentoAbsolutoSobreUmbral.descuento, EstrategiaFijarPreciosDescuentoAbsolutoSobreUmbral.umbral));
            IEstrategiaFijarPreciosVenta estrategiaFijarPreciosDescuentoAbsolutoSobreUmbral = new EstrategiaFijarPreciosDescuentoAbsolutoSobreUmbral();
            venta = new Venta(totalVenta, estrategiaFijarPreciosDescuentoAbsolutoSobreUmbral);
            venta.GetTotal();

            Console.ReadLine();
        }
    }
}
