using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesUtiles
{
    public class Utilerias
    {
        public static bool ValidandoMonto(string cadena)
        {
            foreach(char c in cadena)
            {
                if (char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }


        public static bool ValidandoCantidadCuotas(int cuotas)
        {
            if (cuotas >= 1 && cuotas <= 36)
                return true;
            return false;
        }


        public static Double CalcularPorcentajeInteres(int cuotas)
        {
            if (cuotas >= 13 && cuotas <= 23)
                return 0.20;
            else if (cuotas >= 24 && cuotas <= 36)
                return 0.35;
            return 0.10;
        }


        public static int CalcularCuotaLimpia(int monto, int cantidadCuotas)
        {
            int cuotaLimpia = (monto / cantidadCuotas);
            return cuotaLimpia;
        }


        public static Double CalcularCuotaConIntereses(int cuota, Double porcentaje)
        {
            Double cuotaInteres = cuota + (cuota * porcentaje);
            return cuotaInteres;
        }


        public static int CalcularMontoFinal(int cuotaInteres, int cantidadC)
        {
            int montoFinal = cuotaInteres * cantidadC;
            return montoFinal;
        }
    }
}
