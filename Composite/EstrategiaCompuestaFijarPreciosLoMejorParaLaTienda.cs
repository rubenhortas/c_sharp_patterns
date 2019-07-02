using System;

namespace Composite
{
    public class EstrategiaCompuestaFijarPreciosLoMejorParaLaTienda : EstrategiaCompuestaFijarPrecios
    {
        public override float GetTotal(Venta venta)
        {
            float max = 0;
            float total;

            foreach (IEstrategiaFijarPreciosVenta estrategiaFijarPreciosVenta in estrategiasFijarPreciosVenta)
            {
                total = estrategiaFijarPreciosVenta.GetTotal(venta);
                max = Math.Max(total, max);
            }

            return max;
        }
    }
}
