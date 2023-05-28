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
            
             string matricula;

            if (!users.ContainsKey(login))
            {
                Console.WriteLine("Digite seu Login: ");
               login =  Console.ReadLine();
                Console.WriteLine("Digite sua Matricula: ");
               matricula = Console.ReadLine() ;
                Console.WriteLine("Digite sua Senha: ");
                senha = Console.ReadLine();

                Console.Clear();

                Console.WriteLine("Seus Dados São: \n");
                Console.WriteLine("Nome: " + login);
                Console.WriteLine("Matricula: " + matricula);
                Console.WriteLine("Senha: " + senha);



                users.Add(login, senha);
            }
        }

    }
}

