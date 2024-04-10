using System;

namespace BusinessLogicLayer
{
    public class BusinessLogic
    {
        public decimal CalcularAumento(decimal sueldob)
        {
            if (sueldob <= 1000)
                return sueldob * 0.1m;
            else if (sueldob <= 2000)
                return sueldob * 0.2m;
            else if (sueldob <= 4000)
                return sueldob * 0.3m;
            else
                return sueldob * 0.4m;
        }

        public decimal CalcularSueldoNeto(decimal sueldob, decimal montoAumento)
        {
            return sueldob + montoAumento;
        }
    }
}

