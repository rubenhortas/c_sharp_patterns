using System;
using System.Collections.Generic;

namespace Composite
{
    public class EstrategiaCompuestaFijarPrecios : IEstrategiaFijarPreciosVenta
    {
        protected List<IEstrategiaFijarPreciosVenta> estrategiasFijarPreciosVenta;

        public EstrategiaCompuestaFijarPrecios()
        {
            estrategiasFijarPreciosVenta = new List<IEstrategiaFijarPreciosVenta>();

            // Todos los objetos compuestos mantienen una lista de las estrategias que contienen
            AnhadirEstrategia(new EstrategiaFijarPreciosPorcentajeDescuento());
            AnhadirEstrategia(new EstrategiaFijarPreciosDescuentoAbsolutoSobreUmbral());
        }

        public void AnhadirEstrategia(IEstrategiaFijarPreciosVenta estrategiaFijarPreciosVenta)
        {
            estrategiasFijarPreciosVenta.Add(estrategiaFijarPreciosVenta);
        }

        public virtual float GetTotal(Venta venta)
        {
            throw new NotImplementedException();
        }
    }
}
