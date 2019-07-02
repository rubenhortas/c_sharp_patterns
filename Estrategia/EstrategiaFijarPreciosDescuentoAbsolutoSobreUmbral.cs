namespace Estrategia
{
    public class EstrategiaFijarPreciosDescuentoAbsolutoSobreUmbral : IEstrategiaFijarPreciosVenta
    {
        public EstrategiaFijarPreciosDescuentoAbsolutoSobreUmbral()
        {
        }

        public float GetTotal(Venta venta)
        {
            float totalAntesDescuento = venta.Total;
            if (totalAntesDescuento >= Constants.UMBRAL_GASTO)
            {
                return totalAntesDescuento - Constants.DESCUENTO;
            }
            else
            {
                return totalAntesDescuento;
            }
        }
    }
}
