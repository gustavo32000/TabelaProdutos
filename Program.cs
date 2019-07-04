using System;
using System.IO;
using System.Text;

namespace TabelaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Vamos criar um arquivo de texto para armazenar a matriz de produtos que será criada. Utilizaremos a classe "StreamWriter"
            (Escritor de arquivos). Com o stream você precisa informar o caminho do arquivo e o nome do arquivo. Se desejar acumular texto no arquivo você
            deve passar o último parâmetro como true */

            StreamWriter arq = new StreamWriter(@"c:\gugu\tabela.csv", true, Encoding.UTF32);

            string[,] produtos = {
                                {"produto","quantidade","preço"},
                                {"calça","21","50"},
                                {"meia","10","20"},
                                {"camisa","70","34"},
                                {"sapato","1","500"}
                };

            for (int linha = 0; linha <= 4; linha++)
            {
                for (int coluna = 0; coluna <= 2; coluna++){
                    arq.Write(produtos[linha,coluna]+";");
                }
                arq.WriteLine();
            }
            arq.Close();

        }
    }
}
