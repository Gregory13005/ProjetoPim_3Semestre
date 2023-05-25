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
            
            double sldiario = 0,rmferias = 0;
            string nome,matricula;

           
            Console.WriteLine("Digite o Salario do Colaborador: ");
            salario = Double.Parse(Console.ReadLine());
           

            sldiario = salario / 30;

            rmferias = sldiario * 30;

            vltotal = rmferias + (rmferias / 3);



            return vltotal;
        }

    }
}
