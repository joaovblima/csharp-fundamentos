using System;
using System.Globalization;

namespace Conversor
{
    public static class ConversorDeMoedas
    {

        public static double Calcular(double precoDolar, double quantidadeDolar)
        {
            return precoDolar * quantidadeDolar + (precoDolar * quantidadeDolar * 0.06);
        }
    }
}
