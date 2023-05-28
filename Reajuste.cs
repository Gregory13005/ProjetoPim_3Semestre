using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim_3semestre
{
    public class Reajuste
    {
        public double Meed(double salario, double reajuste,ref double salarion)
        {
            Console.Clear();
            string nome, matricula;

            Console.WriteLine("Voce Digitou Reajuste Salárial...\n");

           
            Console.WriteLine("Digite o Salário do Colaborador: ");
            salario = Double.Parse(Console.ReadLine());
            

            Console.WriteLine("Qual Séra o Valor do Reajuste: ");
            reajuste = Double.Parse(Console.ReadLine());


            reajuste = salario * reajuste;
            salarion = salario + reajuste;
            

            return salarion;
        }

    }
}
