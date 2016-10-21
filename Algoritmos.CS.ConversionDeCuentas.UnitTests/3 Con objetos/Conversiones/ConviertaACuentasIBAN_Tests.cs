using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConObjetos
{
    [TestClass()]
    public class ConviertaACuentasIBAN_Tests : Escenarios
    {
        private List<string> elResultadoEsperado;
        private IEnumerable<string> lasCuentasNacionales;
        private List<string> elResultadoObtenido;

        [TestMethod()]
        public void ConviertaACuentasIBAN_UnaListaSinCuentas_UnaListaVacia()
        {
            elResultadoEsperado = UnaListaVacia();

            lasCuentasNacionales = UnaListaSinCuentas();
            elResultadoObtenido = Conversiones.ConviertaACuentasIBAN(lasCuentasNacionales);

            CollectionAssert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void ConviertaACuentasIBAN_UnaListaConUnaCuenta_UnaListaConUnaCuentaConvertida()
        {
            elResultadoEsperado = UnaListaConUnaCuentaConvertida();

            lasCuentasNacionales = UnaListaConUnaCuenta();
            elResultadoObtenido = Conversiones.ConviertaACuentasIBAN(lasCuentasNacionales);

            CollectionAssert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void ConviertaACuentasIBAN_VariasCuentas_UnaListaConElMismoNumeroDeCuentas()
        {
            elResultadoEsperado = UnaListaConVariasCuentas();

            lasCuentasNacionales = UnaListaConElMismoNumeroDeCuentas();
            elResultadoObtenido = Conversiones.ConviertaACuentasIBAN(lasCuentasNacionales);

            CollectionAssert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}