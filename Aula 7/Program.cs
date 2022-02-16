using System;
using System.IO;

namespace Aula_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Eli\Documents\produtos.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                int contador = 0;
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    string[] linha = s.Split(',');
                    if (contador > 0) {
                        double valor = Math.Round((double.Parse(linha[1]) * double.Parse(linha[2])), 2);
                        Console.WriteLine(String.Format("| {0}| {1} | {2} | {3} |", linha[0], linha[1], linha[2] , valor));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("|| {0} do produto  || {1} || {2} || Valor Total do Estoque ||", linha[0], linha[1], linha[2]));
                        Console.WriteLine("===========================================================");
                        Console.WriteLine(" ");

                    }


                    contador++;
                }

            }
        }
    }
}
