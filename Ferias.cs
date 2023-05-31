using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim_3semestre
{
    public class Ferias
    {
        public double vacation(double salario, ref double vltotal)
        {
            Console.Clear();

            double vtotal = 1;
            vltotal = Clferias(salario, vtotal);

            return vltotal;
        }
        
        private double Clferias(double salario, double vtotal)
        {
            
            double sldiario = 0,rmferias = 0;
            string nome,matricula;

           
            Console.WriteLine("Digite o Salário do Colaborador: ");
            salario = Double.Parse(Console.ReadLine());
           

            sldiario = salario / 30;

            rmferias = sldiario * 30;

            vtotal = rmferias + (rmferias / 3);



            return vtotal;
        }

    }
}
