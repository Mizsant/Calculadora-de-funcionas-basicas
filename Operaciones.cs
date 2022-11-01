using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3
{
    internal class Operaciones
    {
        public bool Numerico(string num)
        {
            ///en caso de que pongan una letra o palabra no deseada
            try
            {
                double x = Convert.ToInt32(num);
                return true;
            }catch (Exception)
            {
                return false;
            }

        }
        //metodo de sumar, restar, multiplicar y dividir.
        public int suma( int a, int b)
        {
            return a + b;
        }

        public int resta(int a, int b)
        {
            return a - b;
        }

        public int multiplicar(int a, int b)
        {
            return a * b;
        }

        public float divicion(float a, float b)
        {
            return a / b;
        }
    }
}
