﻿using System;

namespace Composite
{
    public class EstrategiaCompuestaFijarPreciosLoMejorParaElCliente : EstrategiaCompuestaFijarPrecios
    {
        public override float GetTotal(Venta venta)
        {
            float minTotal = int.MaxValue;
            float total;

            foreach (IEstrategiaFijarPreciosVenta estrategiaFijarPreciosVenta in estrategiasFijarPreciosVenta)
            {
                total = estrategiaFijarPreciosVenta.GetTotal(venta);
                minTotal = Math.Min(total, minTotal);
            }

            return minTotal;
        }
    }
}
