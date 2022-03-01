using System;
using System.Collections.Generic;
using System.Linq;

namespace AtivSem02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancias das classes de tranferencias e dos Bancos 1 e 2
            TranferenciasBancarias tranferenciasBancarias = new TranferenciasBancarias();
            Banco1 banco1 = new Banco1();
            banco1.id = 1; banco1.nomeBanco = "Banco1";
            Banco2 banco2 = new Banco2();
            banco2.id = 2; banco2.nomeBanco = "Banco2";

            try
            {
                int menu;
                Console.WriteLine("Menu: \n" +
                                  "Digite: 1 para Executar Alunos" +
                                  "\nDigite: 2 para Executar Tranferencia Bancaria" +
                                        "(Banco1 para Banco2)");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    
                    case 1:
                        Alunos alunos = new Alunos(); //Classe Aluno com as propriedades

                        Generics.AlunosInfo(); //Classe Generic passando as informações de 10 alunos

                        break;

                    case 2: 
                        
                        //----------------------Inicioando o Prpgrama Banco--------------------------------


                        //Metodo que realiza a transferencia de banco1 para banco2
                        tranferenciasBancarias.Transferir();
                        break;
                 }

            }
            catch (Exception ex)
            {

                throw new InvalidOperationException("Erro: "+ex.Message);
            }

        }
    }
}
