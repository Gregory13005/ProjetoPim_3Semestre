using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace ProjetoPim_3semestre
{
    class Program
    {
    
        static Dictionary<string, string> users = new Dictionary<string, string>();
        

        static void Main(string[] args)
        {
            Validador objValidador = new Validador();
            Reajuste objReajuste = new Reajuste();
            
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("|-----------------------------|");
                Console.WriteLine("| Seja Bem Vindo ao Trikas RH |");
                Console.WriteLine("|  Software de Gestão de Rh   |");
                Console.WriteLine("|_____________________________|");


                Console.WriteLine("\nVamos Começar?\n");
                Console.Write("Digite o seu login: ");
                string login = Console.ReadLine();

                Console.Write("Digite a sua senha: ");
                string senha = Console.ReadLine();

                if (objValidador.Validado(login, senha))
                {
                    Console.WriteLine("Login realizado com sucesso!!!");
                }
                else
                {
                    Console.WriteLine("Usuário não encontrado. Deseja cadastrar um novo usuário?\n");
                    Console.WriteLine("\nDigite 1 Para (Sim) ou 2 Para (Não): \n");

                    string option = Console.ReadLine();
                    if (option.ToUpper() == "1")
                    {
                        objValidador.CadastroU(login, senha);
                        Console.WriteLine("Usuário cadastrado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Tente novamente.");
                    }
                }

                Console.WriteLine("Deseja continuar? (Digite 1 Para (Sim) ou 2 Para (Não)");
                string continueOption = Console.ReadLine();

                if (continueOption.ToUpper() != "1")
                {
                    isRunning = false;
                    break;
                }
                
                Console.Clear();
                //segunda parte do codigo começa a parti desse ponto...

                string opcao;

                Console.WriteLine("Digite a Opção Desejada:\n");
                
                Console.WriteLine("Opção 1: Reajuste Salarial: ");
                Console.WriteLine("Opção 2: Calculo de Férias: ");
                Console.WriteLine("Opção 3: Calculo de Decimo Terceiro: ");
                Console.WriteLine("Opção 4: Recisão Contratual: ");
                opcao = Console.ReadLine();

                string nome, matricula;
                double salario,reajuste ;

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Voce Digitou Reajuste Salarial\n");

                        Console.WriteLine("Digite o Nome do Colaborador: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("Digite o Salario do Colaborador: ");
                        salario = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a Matricula do Colaborador:  ");
                        matricula = Console.ReadLine();

                        Console.WriteLine("Qual Séra o Valor do Reajuste em Porcentos?: ");
                        reajuste = Double.Parse(Console.ReadLine());

                        double salarion = 0;

                        objReajuste.Meed(salario, reajuste,ref salarion);

                        Console.WriteLine("O novo salario é" + salarion);

                        break;


                        //aqui para por enquanto
                    case "2":
                        Console.WriteLine("Calculo de Férias");
                        // Coloque aqui o código para executar a ação do caso 2
                        break;
                    case "3":
                        Console.WriteLine("Calculo de Decimo Terceiro");
                        break;
                    case "4":
                        Console.WriteLine("Recisão Contratual");
                        break;


                    default:
                        Console.WriteLine("Opção inválida");
                        // Coloque aqui o código para lidar com opções inválidas
                        break;
                }





                Console.ReadLine();
            }
        }

       
    }

  

}


        
        