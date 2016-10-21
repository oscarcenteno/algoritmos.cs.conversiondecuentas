using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConObjetos
{
    [TestClass()]
    public class ConviertaACuentasIBAN_Tests : Escenarios
    {
        private List<string> elResultadoEsperado;
        private IEnumerable<string> lasCuentas;
        private List<string> elResultadoObtenido;

        [TestMethod()]
        public void ConviertaACuentasIBAN_UnaListaSinCuentas_UnaListaVacia()
        {
            elResultadoEsperado = UnaListaVacia();

            lasCuentas = UnaListaSinCuentas();
            elResultadoObtenido = Conversiones.ConviertaACuentasIBAN(lasCuentas);

            CollectionAssert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void ConviertaACuentasIBAN_UnaListaConUnaCuenta_UnaListaConUnaConvertida()
        {
            elResultadoEsperado = UnaListaConUnaCuentaConvertida();

            lasCuentas = UnaListaConUnaCuenta();
            elResultadoObtenido = Conversiones.ConviertaACuentasIBAN(lasCuentas);

            CollectionAssert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void ConviertaACuentasIBAN_UnaListaConTresCuentas_UnaListaConTresConvertidas()
        {
            elResultadoEsperado = UnaListaConVariasCuentas();

            lasCuentas = UnaListaConElMismoNumeroDeCuentas();
            elResultadoObtenido = Conversiones.ConviertaACuentasIBAN(lasCuentas);

            CollectionAssert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}