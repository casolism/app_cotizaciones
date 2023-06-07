using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Servicios.Documento.Design
{
    public  class DecimalToString {
        private static readonly string[] Unidades = {
        "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ",
        "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISÉIS", "DIECISIETE", "DIECIOCHO", "DIECINUEVE"
    };

        private static readonly string[] Decenas = {
        "VEINTE", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA"
    };

        private static readonly string[] Centenas = {
        "CIENTO", "DOSCIENTOS", "TRESCIENTOS", "CUATROCIENTOS", "QUINIENTOS", "SEISCIENTOS", "SETECIENTOS",
        "OCHOCIENTOS", "NOVECIENTOS"
    };

        private static readonly string[] Miles = {
        "", "MIL", "MILLÓN", "MIL MILLONES", "BILLÓN"
    };


        public static string ConvertirNumeroATexto(decimal numero)
        {
            if (numero == 0)
            {
                return "CERO";
            }

            string numeroTexto = string.Empty;

            // Parte entera
            long parteEntera = (long)Math.Truncate(numero);
            if (parteEntera > 0)
            {
                numeroTexto = ConvertirParteEnteraATexto(parteEntera);
                numeroTexto += " PESOS";
            }

            // Parte decimal
            decimal parteDecimal = numero - parteEntera;
            parteDecimal = Math.Round(parteDecimal * 100, 0);

            if (parteDecimal > 0)
            {
                numeroTexto += ", " + parteDecimal.ToString("00") + "/100 M.N.";
            }

            return numeroTexto;
        }

        private static string ConvertirParteEnteraATexto(long numero)
        {
            string parteEnteraTexto = string.Empty;
            int contadorMiles = 0;

            while (numero > 0)
            {
                if (numero % 1000 > 0)
                {
                    if (contadorMiles > 0)
                    {
                        parteEnteraTexto = Miles[contadorMiles] + " " + parteEnteraTexto;
                    }

                    parteEnteraTexto = ConvertirGrupoATexto((int)(numero % 1000)) + " " + parteEnteraTexto;
                }

                numero /= 1000;
                contadorMiles++;
            }

            return parteEnteraTexto.Trim();
        }

        private static string ConvertirGrupoATexto(int numero)
        {
            string grupoTexto = string.Empty;

            // Obtener centenas
            int centenas = numero / 100;
            if (centenas > 0)
            {
                if (centenas == 1 && numero % 100 > 0)
                {
                    grupoTexto += "CIENTO";
                }
                else
                {
                    grupoTexto += Centenas[centenas - 1];
                }
            }

            // Obtener decenas y unidades
            int decenasUnidades = numero % 100;

            if (decenasUnidades >= 20)
            {
                int decenas = decenasUnidades / 10;
                grupoTexto += " " + Decenas[decenas - 2];

                int unidades = decenasUnidades % 10;
                if (unidades > 0)
                {
                    grupoTexto += " " + Unidades[unidades];
                }
            }
            else if (decenasUnidades > 0)
            {
                grupoTexto += " " + Unidades[decenasUnidades];
            }

            return grupoTexto.Trim();
        }
    }

}
