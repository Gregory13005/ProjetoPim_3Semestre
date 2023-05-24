using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim_3semestre
{

    public class Validador
    {

        static Dictionary<string, string> users = new Dictionary<string, string>();

        public bool Validado(string login, string senha)
        {
            if (users.ContainsKey(login))
            {
                return users[login] == senha;
            }

            return false;
        }

        public void CadastroU(string login, string senha)
        {
            string nome, matricula,numero;
            

            if (!users.ContainsKey(login))
            {
                Console.WriteLine("Digite seu Nome:");
               nome =  Console.ReadLine();
                Console.WriteLine("Digite sua Matricula:");
               matricula = Console.ReadLine() ;
                Console.WriteLine("Digite seu Número(Apenas Números):");
                numero = Console.ReadLine();

                Console.WriteLine("Seus Dados São:");
                Console.WriteLine("Nome:" + nome);
                Console.WriteLine("Matricula:" + matricula);
                Console.WriteLine("Número:" + numero);



                users.Add(login, senha);
            }
        }

    }
}

