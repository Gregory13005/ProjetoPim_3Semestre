using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim_3semestre
{
    public class Rescisao
    {
        public double miid(double salario, ref double VlRecisao)
        {
            double vlRescisao = 0;
            VlRecisao = Clrescisao(salario,vlRescisao);

            return VlRecisao;
        }

        private double Clrescisao(double salario,  double vlRescisao)
        {
            Console.Clear();

            string vrsim,vrsim2;
            double sldiario , rmferias, vltotal = 0, FerPro, mesesFer, mesesDec, DecPro, VaPre, TemCas, FatCal, fgts, MulFgt;

            Console.WriteLine("Digite o Salário do Colaborador: ");
            salario = Double.Parse(Console.ReadLine());// salario base

            Console.WriteLine("O colaborador possui férias vencidas? (Digite Sim Ou Não)"); // calcule de ferias
            vrsim = Console.ReadLine();
            if(vrsim == "sim" || vrsim == "Sim" || vrsim == "SIM")
            {
                sldiario = salario / 30;

                rmferias = sldiario * 30;

                vltotal = rmferias + (rmferias / 3);

            }
            else 
            {}
            Console.WriteLine("Digite Quanto meses de ferias proporcionais o colaborador possui: ");
            mesesFer = Double.Parse(Console.ReadLine());

            FerPro = (salario / 12) * mesesFer;// calculo de ferias proporci0nais

            Console.WriteLine("Digite Quanto meses de Decimo Terceiro proporcionais o colaborador possui: ");
            mesesDec = Double.Parse(Console.ReadLine());//calculo de decimo terceiro proporcional

            DecPro = (mesesDec / 12) * salario;

            Console.WriteLine("O Colaborador compriu o aviso previo (Digite Sim ou Não): ");
            vrsim2 = Console.ReadLine();
            if (vrsim == "sim" || vrsim == "Sim" || vrsim == "SIM")
            {
                Console.WriteLine("Digite o Tempo em anos de Carteira do Colaborador: ");
                TemCas= Double.Parse(Console.ReadLine());
                VaPre = salario * (TemCas /12);
            }
            else { }

            vlRescisao = vltotal + FerPro + DecPro;


            return vlRescisao;
        }

    }
}
