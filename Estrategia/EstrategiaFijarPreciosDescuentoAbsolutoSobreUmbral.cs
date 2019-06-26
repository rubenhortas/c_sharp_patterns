namespace Estrategia
{
    public class EstrategiaFijarPreciosDescuentoAbsolutoSobreUmbral : IEstrategiaFijarPreciosVenta
    {
        // Accesibles para poder imprimirlos desde el main
        public static readonly int descuento = 25;
        public static readonly int umbral = 50;

        public EstrategiaFijarPreciosDescuentoAbsolutoSobreUmbral()
        {

        }

        public float GetTotal(Venta venta)
        {
            float totalAntesDescuento = venta.Total;
            if (totalAntesDescuento >= umbral)
            {
                return totalAntesDescuento - descuento;
            }
            else
            {
                return totalAntesDescuento;
            }
        }
    }
}
