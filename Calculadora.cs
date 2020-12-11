
using System;

namespace Matemat.Logica
{
    public class Calculadora
    {
        public int Sumar(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }

        public double Dividir(double dividendo, double divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException();

            return dividendo / divisor;
        }
        public double TomarDosDecimales(double numeropiCon5Deciales)
        {
            //mover la coma  dos veces a la derecha dos veces
            var numeroPaso1 = MoverLaComaAlaDerecha2Veces(piCon5Deciales);
            var numeroPaso2 = TomarParteEntera(numeroPaso1);
            var numeroPaso3 = moverLaComaAlaIzquierda2Veces(numeroPaso2);
            return numeroPaso3
        }
        private double MoverLaComaAlaDerecha2Veces()
    }
}
