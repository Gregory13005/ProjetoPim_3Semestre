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

            reajuste = salario * reajuste;
            salarion = salario + reajuste;
            

            return salarion;
        }

    }
}
