using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim_3semestre
{
    public class Ferias
    {
        public double Clferias(double salario,ref double vltotal)
        {
            Console.Clear();
            double sldiario = 0,rmferias = 0;
            string nome,matricula;

           
            Console.WriteLine("Digite o Salário do Colaborador: ");
            salario = Double.Parse(Console.ReadLine());
           

            sldiario = salario / 30;

            rmferias = sldiario * 30;

            vltotal = rmferias + (rmferias / 3);



            return vltotal;
        }

    }
}
