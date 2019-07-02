namespace Estrategia
{
    public class EstrategiaFijarPreciosPorcentajeDescuento : IEstrategiaFijarPreciosVenta
    {        
        public EstrategiaFijarPreciosPorcentajeDescuento()
        {
        }

        public float GetTotal(Venta venta)
        {
            float totalAntesDescuento = venta.Total;
            return (totalAntesDescuento - (totalAntesDescuento * (Constants.PORCENTAJE_DESCUENTO / 100)));
        }
    }
}
