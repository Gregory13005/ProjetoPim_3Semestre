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
            Ferias objFerias = new Ferias();
            Decimo objDecimo = new Decimo();
            Rescisao objRecisao = new Rescisao();

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("|--------------------------------------------------------------------------------------------------------------|");
                Console.WriteLine("|                                            Seja Bem Vindo ao ToPay                                       |");
                Console.WriteLine("|                                            Software de Gestão de Rh                                         |");
                Console.WriteLine("|______________________________________________________________________________________________________________|");


                Console.WriteLine("                                                    Vamos Começar?\n");
                Console.Write("Digite o seu Login: ");
                string login = Console.ReadLine();

                Console.Write("Digite a sua Senha: ");
                string senha = Console.ReadLine();

                if (objValidador.Validado(login, senha))
                {
                    Console.WriteLine("\nLogin Realizado com Sucesso!!!\n");
                }
                else
                {
                    Console.WriteLine("Usuário não encontrado. Deseja cadastrar um novo usuário?\n");
                    Console.WriteLine("Digite Sim ou Não: \n");

                    string option = Console.ReadLine();
                    if (option.ToUpper() == "Sim" || option.ToUpper() == "sim" || option.ToUpper() == "SIM")
                    {
                       
                        objValidador.CadastroU(login, senha);
                        Console.WriteLine("Usuário Cadastrado com Sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Tente novamente.");
                    }
                }

                Console.WriteLine("Deseja Continuar? Digite 1 para Sim ou 2 para Não");
                string continueOption = Console.ReadLine();

                if (continueOption.ToUpper() != "1") 
                {
                    isRunning = false;
                    break;
                }
                
                Console.Clear();

                //segunda parte do codigo começa a parti desse ponto...

                string nomecol, matricob;

                Console.WriteLine("Primeiro Digite o Nome do Colaborador: ");
                nomecol = Console.ReadLine();

                Console.WriteLine("Digite a matricula do Colaborador: ");
                matricob = Console.ReadLine();

                bool continuarMenu = true;

                while (continuarMenu)
                {
                    Console.WriteLine("Digite a Opção Desejada:\n");
                    Console.WriteLine("Opção 1: Reajuste Salarial: ");
                    Console.WriteLine("Opção 2: Calculo de Férias: ");
                    Console.WriteLine("Opção 3: Calculo de Decimo Terceiro: ");
                    Console.WriteLine("Opção 4: Rescisão de Contrato: ");
                    Console.WriteLine("Opção 5: Deseja Fechar o Programa?");

                    

                    string opcao = Console.ReadLine();

                    double salario = 0, reajuste = 0, salarioAtua = 0, ferias = 0, clterceiro = 0, rescisao = 0; ;
                    
                    switch (opcao)
                    {

                        case "1":
                            
                            objReajuste.maad(salario,ref salarioAtua);
                            Console.WriteLine("O salário reajustado é de R$: " + salarioAtua);
                            break;

                        case "2":
                            Console.WriteLine("Calculo de Férias");

                            objFerias.vacation(salario, ref ferias);
                            Console.WriteLine("O Valor de Remuneração da Ferias È R$: " +ferias);
                            break;

                        case "3":
                            Console.WriteLine("Calculo de Decimo Terceiro");
                            objDecimo.decimo(salario, ref clterceiro);
                            Console.WriteLine("O Valor de Decimo Terceiro séra de R$: " +clterceiro);
                            break;

                        case "4":
                            
                            objRecisao.miid(salario, ref rescisao);
                            Console.WriteLine("O valor da Rescisão do Colaborador È R$" +rescisao);


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
                        Console.WriteLine("Colaborador: "+nomecol);
                        Console.WriteLine("Matricula: "+matricob);
                        Console.WriteLine("O novo salario é R$: " +salarioAtua);
                        Console.WriteLine("Valor das Férias R$"+ferias);
                        Console.WriteLine("Valor do Decimo Terceiro R$"+clterceiro);
                        Console.WriteLine("Valor da Rescisão R$"+rescisao);
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


        
        