using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplyProvaEstágio
{
    internal class Calculadora
    {

        private int _num1;
        private int _num2;



        public Calculadora(int _num1, int _num2) { 
            
            this._num1 = _num1;
            this._num2 = _num2;
        }




        public int Somar(int num1, int num2) {

            if (num1 >= 0 && num2 >= 0)
            {
                return num1 + num2;
            }
            else {
                return 0;   
            }
        }

        public int Multiplicar(int num1, int num2) {

            if (num2 < 0)
            {
                return 0;
            }
            else {
                return num1 * num2;
            }
        }

        public int Descontar(int num1, int num2) {
            int totalDesconto;
            totalDesconto = (num2 * num2) - num1;

            return totalDesconto;
        }

    }
}
