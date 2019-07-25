using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;


namespace Desafio_sexta_26_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // console que faça a leitura de um json
            //mapeia os objetos e imprime na tela       
            // 
            //apos a leitura dos dados o app devera dar as seguintes opções para o usuario
            //remover um registro
            //salvar alteração em um novo arquivo json e manter o original intacto
            //
            Pessoas p = new Pessoas();


            string path = @"C:\Users\Treinamento 4\Desktop\exercicio_estudo\Trabalho.json";
            var file = File.ReadAllText(path);
            var lstResults = JsonConvert.DeserializeObject<List<Pessoas>>(file);


            // p.ImprimePessoas(p);

            //efetuando a impressão do arquivo
            foreach (var printf in lstResults)
            {
                Console.WriteLine(printf.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("DESEJA REMOVER ALGUM REGISTRO ? SIM OU NÃO");
            string decisao = Console.Readline().ToUpper();

            while (decisao != "SIM" || decisao != "NÃO")
            {
                global::System.Console.WriteLine("OPÇÃO INVALIDA! DIGITE SIM OU NÃO");
                decisao = Console.Readline().ToUpper();

            }

            if (decisao == "SIM")
            {
                global::System.Console.WriteLine("QUANTOS REGISTROS DESEJA REMOVER ?");
                int decisaotwo = int.Parse(Console.ReadLine());

                for (int i = 0; i <= decisaotwo; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"DIGITE {i} PARA VISUALIZAR A PAGINA {i}");

                }
                //// teste remove
                //var itemToRemove = resultlist.Single(r => r.Id == 2);
                //resultList.Remove(itemToRemove);

                //var itemToRemove = resultlist.SingleOrDefault(r => r.Id == 2);
                //if (itemToRemove != null)
                //    resultList.Remove(itemToRemove);


            }
        }
    }
}
