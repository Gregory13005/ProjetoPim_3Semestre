﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim_3semestre
{
    public class Decimo
    {
        public double decimo(double salario, ref double clterceiro)
        {
            Console.Clear();
            double cterceiro = 1;
            clterceiro = terceiro(salario, cterceiro);

            return clterceiro;
        }
            private double terceiro(double salario,  double cterceiro)
            {
            double slanual, pripar, segupar;
            int meses;
            Console.WriteLine("Digite o Salário do Colaborador: ");
            salario = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de meses que o Colaborador trabalhou: ");
            meses = int.Parse(Console.ReadLine());

           

                if (salario <= 1302)
                {
                    salario -= salario * 0.075;
                }
                else if (salario >= 1303 && salario <= 2571.29)
                {
                    salario -= salario * 0.09;
                }
                else if (salario >= 2571.30 && salario <= 3856.94)
                {
                    salario -= salario * 0.12;
                }
                else if (salario >= 3856.95 && salario <= 7507.49)
                {
                    salario -= salario * 0.14;
                }


                slanual = salario / 12;


                cterceiro = slanual * meses;

                return cterceiro;
            }
            
        

        }
}
