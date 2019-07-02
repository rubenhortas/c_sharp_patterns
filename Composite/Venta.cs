using System;

namespace Composite
{
    public class Venta
    {
        private IEstrategiaFijarPreciosVenta estrategiaFijarPreciosVenta;

        public float Total { get; private set; }

        public DateTime Fecha { get; set; }

        public Venta(float totalVenta, IEstrategiaFijarPreciosVenta estrategiaFijarPreciosVenta)
        {
            Fecha = DateTime.Today;
            Total = totalVenta;
            this.estrategiaFijarPreciosVenta = estrategiaFijarPreciosVenta;

            Console.WriteLine(String.Format("Venta de {0}€", totalVenta));
        }

        public void GetTotal()
        {
            float totalDespuesDescuento = estrategiaFijarPreciosVenta.GetTotal(this);
            Console.WriteLine(String.Format("Precio total despues de descuento: {0:00}€", totalDespuesDescuento));
        }
    }
}
