using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim_3semestre
{
    public class Recisao
    {
        public double Clrecisao(double salario, ref double clrecisao)
        {
            double meses;
            string v1;
            Console.WriteLine("Digite o Salário do Colaborador: ");
            salario = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite em Meses o Tempo de Contrato do Colaborador: ");
            meses = Double.Parse(Console.ReadLine());

            Console.WriteLine("O Colaborador Fez o Aviso Previo? Se sim Digite 1, ou 2 para Não ");
            v1 = Console.ReadLine();
            if (v1 == "1")
            {

            }

            return clrecisao;
        }

    }
}
