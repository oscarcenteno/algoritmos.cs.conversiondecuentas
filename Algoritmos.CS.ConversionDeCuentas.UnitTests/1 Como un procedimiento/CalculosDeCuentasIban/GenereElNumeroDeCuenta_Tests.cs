﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComoUnProcedimiento 
{
    [TestClass()]
    public class GenereElNumeroDeCuenta_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod()]
        public void GenereElNumeroDeCuenta_NumeroVerificadorEsDiez_NoSePrecedeConCero()
        {
            elResultadoEsperado = "CR1010200009007408120";

            elResultadoObtenido = CalculosDeCuentasIban.GenereElNumeroDeCuentaIBAN("10200009007408120");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void GenereElNumeroDeCuenta_NumeroVerificadorEsMenorADiez_SePrecedeConCero()
        {
            elResultadoEsperado = "CR0910000073919007800";

            elResultadoObtenido = CalculosDeCuentasIban.GenereElNumeroDeCuentaIBAN("10000073919007800");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}