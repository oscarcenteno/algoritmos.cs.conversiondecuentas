using System.Collections.Generic;

namespace ComoUnProcedimiento
{
    public class Conversiones
    {
        // En el trabajo con listas busquemos mantener la claridad y facilidad de debug
        public static List<string> ConviertaACuentasIBAN(IEnumerable<string> lasCuentas)
        {
            List<string> lasCuentasConvertidas = new List<string>();

            foreach (string laCuenta in lasCuentas)
            {
                string laCuentaConvertida;
                laCuentaConvertida = CalculosDeCuentasIban.GenereElNumeroDeCuentaIBAN(laCuenta);

                lasCuentasConvertidas.Add(laCuentaConvertida);
            }

            return lasCuentasConvertidas;
        }
    }
}

// Nota: 
//  El procedimiento anterior se puede realizar de la misma manera con LinQ:
//  return lasCuentas.Select((laCuenta) => CalculosDeCuentasIban.GenereElNumeroDeCuentaIBAN(laCuenta));