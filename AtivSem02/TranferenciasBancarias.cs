using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    public class TranferenciasBancarias : IBancos
    {
        Banco1 banco1 = new Banco1();
        Banco2 banco2 = new Banco2();
      
	
        public double Transferir()
        {
            Console.Clear();
            double ValorTransferir;

            Console.WriteLine("Qual o valor do deposito?");
            ValorTransferir = Convert.ToDouble(Console.ReadLine());

            banco1.saldo -= ValorTransferir;
            banco2.saldo += ValorTransferir;

            Console.WriteLine(banco2.nomeBanco + "Recebeu o Saldo de R$: "+ banco2.saldo.ToString("F2") +
                              "\n" + banco1.nomeBanco + "Debitou o Saldo de R$: "+ banco1.saldo.ToString("F2"));


            return ValorTransferir;

        }

    }
}
