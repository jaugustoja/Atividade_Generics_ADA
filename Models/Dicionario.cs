using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Models
{
    public class Dicionario
    {

        public Dictionary<string, string> dicionario1 = new Dictionary<string, string>();


        public Dicionario()
        {

        }

        public void AdicionarTermos(string termo, string significado)
        {
            if (termo.Contains('*') || termo.Contains('?'))
            {
                Console.WriteLine("Não foi possível adicionar o termo por caracteres inválidos (* ou ?).");
            }
            else
            {
                dicionario1.Add(termo, significado);
                Console.WriteLine("Termo e significado adicionados ao dicionário.");
            }
        }

        public void buscarTermos(string termo)
        {
            int validacaoBusca = 0;
            foreach(char x in termo)
            {
                if (x == '*' || x == '?')
                {
                    validacaoBusca++;
                }
            }
            if (validacaoBusca != 0)
            {
                Console.WriteLine("Busca Inválida!");
                return;
            }
            else
            {
                var listaChaves = dicionario1.Keys.Where(x => x.IndexOf(termo, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                if (listaChaves.Count > 0)
                {
                    foreach (string palavra in listaChaves)
                    {
                        Console.WriteLine(palavra);
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum termo encontrado");
                }
            }

        }

        public void SalvarDados() 
        {
            //Instancia um objeto que grava uma cadeia de caracteres no arquivo dicionario.txt
            using (StreamWriter escrever = new StreamWriter("dicionario.txt"))
            {
                //percore todo o dicionario com os termos e descrições já gravados.
                foreach (var item in dicionario1)
                {
                    //grava no arquivo dicionario pelo objeto escrever, os termos e descrições do dicionario com virgula entre eles. 
                    escrever.WriteLine(item.Key + "," + item.Value);
                }
            }
        }

        public void CarregarDados() 
        {
            //Testa se existe o arquivo dicionario.txt na pasta
            if (File.Exists("dicionario.txt"))
            {
                //Lê as gravações do arquivo dicionario.txt por linha e grava no array string.
                string[] linhas = File.ReadAllLines("dicionario.txt");

                //percorre o array com as linhas do arquivo gravados.
                foreach (string linha in linhas)
                {
                    //Separa as string pela virgula e grava o conteudo do array linhas em outro array.
                    string[] parte = linha.Split(',');
                    //Adiciona ao dicionario1 instanciado, as posições 0 e 1 do array com as strings separadas, chave e valor, que estavam no arquivo dicionario.txt
                    dicionario1.Add(parte[0], parte[1]);
                }
            }
        }

    }
}
