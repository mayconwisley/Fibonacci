using System;

namespace Fibonacci
{
    class ValidarNumero
    {
        string strValor = string.Empty;
        int posicao = 0;

        public string Validar(string valor)
        {
            try
            {
                foreach (char x in valor)
                {
                    posicao = "1234567890".IndexOf(x);
                    if (posicao >= 0)
                    {
                        strValor = strValor + x;
                    }
                }
                return strValor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Zero(string valor)
        {
            strValor = valor;
            if (valor == "")
            {
                strValor = "0";
            }
            return strValor;
        }
    }
}
