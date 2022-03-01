using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    public class Generics
    {
       public static void AlunosInfo()
        {
            Console.Clear();
            //Lista de Alunos usando Generics Referente a Atividade1
            List<Alunos> ListaDeAlunos = new List<Alunos>();
            ListaDeAlunos.Add(new Alunos() { id = 1, nome = "Augusto", idade = 14 });
            ListaDeAlunos.Add(new Alunos() { id = 2, nome = "Roberto", idade = 13 });
            ListaDeAlunos.Add(new Alunos() { id = 3, nome = "Roberson", idade = 12 });
            ListaDeAlunos.Add(new Alunos() { id = 4, nome = "Claudio", idade = 14 });
            ListaDeAlunos.Add(new Alunos() { id = 5, nome = "Afonso", idade = 15 });
            ListaDeAlunos.Add(new Alunos() { id = 6, nome = "João", idade = 14 });
            ListaDeAlunos.Add(new Alunos() { id = 7, nome = "Felipe", idade = 13 });
            ListaDeAlunos.Add(new Alunos() { id = 8, nome = "Mauricio", idade = 15 });
            ListaDeAlunos.Add(new Alunos() { id = 9, nome = "Ricardo", idade = 12 });
            ListaDeAlunos.Add(new Alunos() { id = 10, nome = "Eduardo", idade = 14 });

            //Select na Lista em ordem decrescente por Id
            var selectAlunos = from Lista in ListaDeAlunos


                               where Lista.id != 0
                               orderby Lista.id descending

                               select Lista;

            //Executar a Consulta
            foreach (var result in selectAlunos)
            {
                Console.WriteLine("Lista de Alunos:");
                Console.WriteLine("Id: " + result.id + " Nome do Aluno: " + result.nome + " Idade: " + result.idade);
            }

          
        }
    }
}
