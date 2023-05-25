using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Data;

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

                bool continuarMenu = true;

                while (continuarMenu)
                {
                    Console.WriteLine("Digite a Opção Desejada:\n");
                    Console.WriteLine("Opção 1: Reajuste Salarial: ");
                    Console.WriteLine("Opção 2: Calculo de Férias: ");
                    Console.WriteLine("Opção 3: Calculo de Decimo Terceiro: ");
                    Console.WriteLine("Opção 4: Recisão Contratual: ");
                    Console.WriteLine("Opção 5: Deseja Fechar o Programa?");

                    string opcao = Console.ReadLine();

                    double salario = 0, reajuste = 0,salarion = 0; ;

                    switch (opcao)
                    {
                        case "1":
                            
                            objReajuste.Meed(salario, reajuste, ref salarion);
                            Console.WriteLine("O novo salario é: " + salarion);
                            break;

                        case "2":
                            Console.WriteLine("Calculo de Férias");
                            // Coloque aqui o código para executar a ação do caso 2
                            break;

                        case "3":
                            Console.WriteLine("Calculo de Decimo Terceiro");
                            // Coloque aqui o código para executar a ação do caso 3
                            break;

                        case "4":
                            Console.WriteLine("Recisão Contratual");
                            // Coloque aqui o código para executar a ação do caso 4
                            break;
                       
                        case "5":
                            if (opcao == "5")
                            {
                                Environment.Exit(0);
                            }
                            break;
                     
                        default:
                            Console.WriteLine("Opção inválida");
                            // Coloque aqui o código para lidar com opções inválidas
                            break;
                    }

                    Console.WriteLine("Deseja Visualizar o Dados, Se Sim Digite 1 ou 2 para Fechar: ");
                    string v2 = Console.ReadLine();

                    if (v2 == "1")
                    {
                        Console.Clear();

                        Console.WriteLine("\nEsses São os Dados do Colaborador: \n");

                        Console.WriteLine("O novo salario é: " + salarion);

                    }
                    else
                    {                        
                        continuarMenu = false;
                    }
                }

                
            }
        }

       
    }

  

}


        
        