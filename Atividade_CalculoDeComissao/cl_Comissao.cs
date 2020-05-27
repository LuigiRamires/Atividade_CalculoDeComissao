using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_CalculoDeComissao
{
    class cl_Comissao
    {
        private double catA = 5;  // Declara-se 3 variáveis imutáveis do tipo double.
        private double catB = 10;
        private double catC = 20;

        public double CalcularComissao(double ValorDeVenda, double CategoriaVendedor)
        {
            double valorComissao; // Criou-se um método com suas instruções onde há uma estrutura condicional

            if (CategoriaVendedor == 0)
            {
                valorComissao = ValorDeVenda * (catA / 100);
            }
            else if (CategoriaVendedor == 1)
            {
                valorComissao = ValorDeVenda * (catB / 100);
            }
            else
            {
                valorComissao = ValorDeVenda * (catC / 100);
            }
            return valorComissao; // retorna-se o valor da variável declarada acima.
        }
    }
}
