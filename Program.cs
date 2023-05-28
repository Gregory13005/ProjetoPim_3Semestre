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
    Ouqe nao funciona e esse aqui
        static Dictionary<string, string> users = new Dictionary<string, string>();
        

        static void Main(string[] args)
        {
            Validador objValidador = new Validador();
            Reajuste objReajuste = new Reajuste();
            Decimo objDecimo = new Decimo();
            Ferias objFerias = new Ferias();
            Recisao objRecisao = new Recisao();

            
            

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
                else {}
                
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

                    int opcao = Console.ReadLine();      
                    
                    double salario = '', reajuste = '',salarion = ''; 

                    

                    switch (opcao)
                    {
                        case "1":
                          

                            objReajuste.Meed(salario, reajuste, ref salarion);
                            Console.WriteLine("O novo salario é: " + salarion);                         

                        case "2":
                            objFerias.Clferias(salario, ref vltotal);
                            Console.WriteLine("Calculo de Férias: " + vltotal);
                            
                            break;

                        case "3":
                            objDecimo.terceiro(salario, ref clterceiro);
                            Console.WriteLine("Calculo de Decimo Terceiro: " + clterceiro);
                            
                            break;

                        case "4":
                            
                            objRecisao.Clrecisao(salario, ref AvisoPrevio);
                            Console.WriteLine("O valor da Recisão do Colaborador È R$" + AvisoPrevio);

                            break;
                       
                        case "5":
                            if (opcao == "5")
                            {
                                Environment.Exit(0);
                            }
                            break;
                     
                        default:
                            Console.WriteLine("Opção inválida");
                            
                            break;
                    }

                    s

                   
                  

                   
                }

                
            }
        }

       
    }

  

}


        
        