using System.Collections.Generic;

namespace ConObjetos
{
    public class Escenarios
    {
        protected List<string> UnaListaSinCuentas()
        {
            return new List<string>();
        }

        protected List<string> UnaListaVacia()
        {
            return new List<string>();
        }

        protected List<string> UnaListaConUnaCuenta()
        {
            List<string> lasCuentas = new List<string>();
            lasCuentas.Add("10200009007408120");

            return lasCuentas;
        }

        protected List<string> UnaListaConUnaCuentaConvertida()
        {
            List<string> lasCuentas = new List<string>();
            lasCuentas.Add("CR1010200009007408120");

            return lasCuentas;
        }

        protected List<string> UnaListaConVariasCuentas()
        {
            List<string> lasCuentas = new List<string>();
            lasCuentas.Add("CR1010200009007408120");
            lasCuentas.Add("CR0910000073919007800");
            lasCuentas.Add("CR4410000223423437800");

            return lasCuentas;
        }

        protected List<string> UnaListaConVariasCuentasConvertidas()
        {
            List<string> lasCuentas = new List<string>();
            lasCuentas.Add("10200009007408120");
            lasCuentas.Add("10000073919007800");
            lasCuentas.Add("10000223423437800");

            return lasCuentas;
        }
    }
}