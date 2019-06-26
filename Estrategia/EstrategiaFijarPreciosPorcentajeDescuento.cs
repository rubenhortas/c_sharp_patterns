namespace Estrategia
{
    public class EstrategiaFijarPreciosPorcentajeDescuento : IEstrategiaFijarPreciosVenta
    {
        //Accesible para poder imprimirlo desde el main
        public static float Porcentaje = 15;

        public EstrategiaFijarPreciosPorcentajeDescuento()
        {
        }

        public float GetTotal(Venta venta)
        {
            float totalAntesDescuento = venta.Total;
            return (totalAntesDescuento - (totalAntesDescuento * (Porcentaje / 100)));
        }
    }
}
