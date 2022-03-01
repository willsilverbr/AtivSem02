using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    interface IBancos
    {
        public double Transferir(double ValorTransferirido)
        {
            

            return ValorTransferirido;
        }

        
        public void ReceberTransferencia(double ValorReceber)
        {
            
        }

    }
}
