using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim_3semestre
{
    public class Reajuste
    {
        public double maad(double salario, ref double salarion)
        {
            Console.Clear();
            double ssalarion = 1;
            Meed(salario, ssalarion, ref salarion);
            return salarion;
        }

        private void Meed(double salario, double reajuste, ref double ssalarion)
        {
            Console.WriteLine("Você Digitou Reajuste Salarial...\n");
            Console.WriteLine("Digite o Salário do Colaborador: ");
            salario = Double.Parse(Console.ReadLine());
            Console.WriteLine("Qual será o Valor do Reajuste: ");
            reajuste = Double.Parse(Console.ReadLine());

            reajuste = salario * reajuste;
            ssalarion = salario + reajuste;
        }


    }
}
