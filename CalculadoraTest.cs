using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matemat.Logica;
using System;

namespace Matemat.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Suma2Numeros()
        {
            // arrange -> prepación
            var numero1 = 7;
            var numero2 = 10;
            var esperado = 17;


            //act -> ejecucion
            var calculadora = new Calculadora();
            var resultado = calculadora.Sumar(numero1, numero2);


            //assert -> esta es la verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [TestMethod]

        public void Dividir2Numeros()
        {
            //arrange
            var numero1 = 30;
            var numero2 = 3;
            var espero = 10;

            //act 
            var miCalculadora = new Calculadora();
            var resul = miCalculadora.Dividir(numero1, numero2);

            //assert -> esta es la verificacion
            Assert.AreEqual(espero, resul);

        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirPara0()
        {
            //arrange
            var num1 = 40;
            var num2 = 0;

            //act 
            var calculadora = new Calculadora();
            var resultado = calculadora.Dividir(num1, num2);

            //assert -> esta es la verificacion
            // Assert.IsTrue(double.IsInfinity(resultado));

        }
        [TestMethod]

        public void DividirResulEntero()
        {
            //arrange
            var nu1 = 20;
            var nu2 = 2;
            var esperores = 10;

            //act 
            var calculadora = new Calculadora();
            var resul = calculadora.Dividir(nu1, nu2);

            //assert -> esta es la verificacion
            Assert.AreEqual(esperores, resul);

         
        }
        [TestMethod]
        public void DividisionConRespDecimal()
        {
            //arrange
            var number1 = 59;
            var number2 = 4;
            var esperodou = 14.75;

            //act 
            var calculadora = new Calculadora();
            var resul = calculadora.Dividir(number1, number2);

            //assert -> esta es la verificacion
            Assert.AreEqual(esperodou, resul);

        }
        [TestMethod]
        public void ObtenerUnNumeroConDecimales()
        {
            //arrange
            var numeropiCon5Deciales = 3.14159;
            var numeropiCon2Decimales = 3.14;

            //act 
            var calculadora = new Calculadora();
            var respuesta = calculadora.TomarDosDecimales(numeropiCon5Deciales);

            //assert -> esta es la verificacion
            Assert.AreEqual(numeropiCon2Decimales, respuesta);

        }

    }

}
