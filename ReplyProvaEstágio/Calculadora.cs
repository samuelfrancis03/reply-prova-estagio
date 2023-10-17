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




        public int Somar() {

            if (_num1 >= 0 && _num2 >= 0)
            {
                return _num1 + _num2;
            }
            else {
                return 0;   
            }
        }

        public int Multiplicar() {

            if (_num2 < 0)
            {
                return 0;
            }
            else {
                return _num1 * _num2;
            }
        }

        public double Descontar() {
            double totalDesconto, valorDesconto;
            valorDesconto = (double) _num2 / 100 * (double) _num1;
            totalDesconto = (double) _num1 - valorDesconto;

            return totalDesconto;
        }

    }
}
