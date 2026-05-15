using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Imperio_da_pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opçao = 0;
            while (opçao != 5)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"
██╗███╗░░░███╗██████╗░███████╗██████╗░██╗░█████╗░  ██████╗░░█████╗░
██║████╗░████║██╔══██╗██╔════╝██╔══██╗██║██╔══██╗  ██╔══██╗██╔══██╗
██║██╔████╔██║██████╔╝█████╗░░██████╔╝██║██║░░██║  ██║░░██║███████║
██║██║╚██╔╝██║██╔═══╝░██╔══╝░░██╔══██╗██║██║░░██║  ██║░░██║██╔══██║
██║██║░╚═╝░██║██║░░░░░███████╗██║░░██║██║╚█████╔╝  ██████╔╝██║░░██║
╚═╝╚═╝░░░░░╚═╝╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═╝░╚════╝░  ╚═════╝░╚═╝░░╚═╝

██████╗░██╗███████╗███████╗░█████╗░
██╔══██╗██║╚════██║╚════██║██╔══██╗
██████╔╝██║░░███╔═╝░░███╔═╝███████║
██╔═══╝░██║██╔══╝░░██╔══╝░░██╔══██║
██║░░░░░██║███████╗███████╗██║░░██║
╚═╝░░░░░╚═╝╚══════╝╚══════╝╚═╝░░╚═╝");
                Console.ResetColor();
                Console.WriteLine("\n 1- cadastro de produtos");
                Console.WriteLine("\n 2- cadastro de clientes");
                Console.WriteLine("\n 3- cadastro de fornecedores");
                Console.WriteLine("\n 4- cadastro de funcionários");
                Console.WriteLine("\n 5- sair");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n digite a opção escolhida: ");
                Console.ResetColor();
                opçao = int.Parse(Console.ReadLine());
                switch (opçao)
                {
                    case 1:
                         cadastroprodutos();
                        break;
                    case 2:
                        cadastroclientes();
                        break;
                    case 3:
                        cadastrofornecedores();
                        break;
                    case 4:
                         cadastrofuncionários();
                        break;
                    case 5:
                        sair();
                        break;
                        
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("opção inválida!!!");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        break;



                }
            }
        }
        static void cadastroprodutos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");
            Console.WriteLine("\n nome do produto: ");
            string nomeproduto = Console.ReadLine();
            Console.WriteLine("\n peso do produto: ");
            double pesoproduto = double.Parse(Console.ReadLine());
            Console.WriteLine("\n digite o valor do produto: ");
            double valordoproduto = double.Parse(Console.ReadLine());
            Console.WriteLine("\n digite a quantidade do produto: ");
            int quantidadedoproduto = int.Parse(Console.ReadLine());
        Console.WriteLine("cadastrado com sucesso!");
            Thread.Sleep(2000);
            Console.Clear () ;

        }

        static void cadastroclientes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗░██████╗
██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝██╔════╝
██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░╚█████╗░
██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░░╚═══██╗
╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗██████╔╝
░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═════╝░");

            Console.WriteLine("\n digite o nome do cliente: ");
            string nomecliente = Console.ReadLine();
            Console.WriteLine("\n digite o endereço do cliente: ");
            string endereçocliente = Console.ReadLine();
            Console.WriteLine("\n digite o telefone do cliente: ");
            int telefonecliente = int.Parse(Console.ReadLine());
            Console.WriteLine("cadastrado com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
        }
        static void cadastrofornecedores()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
███████╗░█████╗░██████╗░███╗░░██╗███████╗░█████╗░███████╗██████╗░░█████╗░██████╗░███████╗░██████╗
██╔════╝██╔══██╗██╔══██╗████╗░██║██╔════╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝
█████╗░░██║░░██║██████╔╝██╔██╗██║█████╗░░██║░░╚═╝█████╗░░██║░░██║██║░░██║██████╔╝█████╗░░╚█████╗░
██╔══╝░░██║░░██║██╔══██╗██║╚████║██╔══╝░░██║░░██╗██╔══╝░░██║░░██║██║░░██║██╔══██╗██╔══╝░░░╚═══██╗
██║░░░░░╚█████╔╝██║░░██║██║░╚███║███████╗╚█████╔╝███████╗██████╔╝╚█████╔╝██║░░██║███████╗██████╔╝
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝░╚════╝░╚══════╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═════╝░");
            Console.WriteLine("\n digite o nome do fornecedor: ");
            string nomefornecedor = Console.ReadLine();
            Console.WriteLine("\n digite o endereço do fornecedor: ");
            string endereçocliente = Console.ReadLine();
            Console.WriteLine("\n digite o telefone do fornecedor: ");
            int telefonefornecedor = int.Parse(Console.ReadLine());
            Console.WriteLine("\n digite o CNPJ do fornecedor: ");
            int CNPJfornecedor = int.Parse(Console.ReadLine());
            Console.WriteLine("\n digite a data de nascimento do fornecedor: ");
            string datanascdofornecedor =Console.ReadLine();
            Console.WriteLine("cadastrado com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
        }
        static void cadastrofuncionários()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
███████╗██╗░░░██╗███╗░░██╗░█████╗░██╗░█████╗░███╗░░██╗░█████╗░██████╗░██╗░█████╗
██╔════╝██║░░░██║████╗░██║██╔══██╗██║██╔══██╗████╗░██║██╔══██╗██╔══██╗██║██╔══██╗
█████╗░░██║░░░██║██╔██╗██║██║░░╚═╝██║██║░░██║██╔██╗██║███████║██████╔╝██║██║░░██║
██╔══╝░░██║░░░██║██║╚████║██║░░██╗██║██║░░██║██║╚████║██╔══██║██╔══██╗██║██║░░██║
██║░░░░░╚██████╔╝██║░╚███║╚█████╔╝██║╚█████╔╝██║░╚███║██║░░██║██║░░██║██║╚█████╔╝╝
╚═╝░░░░░░╚═════╝░╚═╝░░╚══╝░╚════╝░╚═╝░╚════╝░╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░╚════╝░");
            Console.WriteLine("\n digite o nome do funcionário: ");
            string nomefuncionario = Console.ReadLine();
            Console.WriteLine("\n digite a função do funcionário: ");
            string funçaofuncionario = Console.ReadLine();
            Console.WriteLine("\n digite o telefone do funcionário: ");
            long telefonefuncionario = long.Parse(Console.ReadLine());
            Console.WriteLine("\n digite o número do pix do funcionário: ");
            long pixFun = long.Parse(Console.ReadLine());
            Console.WriteLine("cadastrado com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();

        }
        static void sair()
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine(@"
░█████╗░██████╗░██████╗░██╗░██████╗░░█████╗░██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██║██╔════╝░██╔══██╗██╔══██╗██╔══██╗
██║░░██║██████╦╝██████╔╝██║██║░░██╗░███████║██║░░██║██║░░██║
██║░░██║██╔══██╗██╔══██╗██║██║░░╚██╗██╔══██║██║░░██║██║░░██║
╚█████╔╝██████╦╝██║░░██║██║╚██████╔╝██║░░██║██████╔╝╚█████╔╝
░╚════╝░╚═════╝░╚═╝░░╚═╝╚═╝░╚═════╝░╚═╝░░╚═╝╚═════╝░░╚════╝░");


        }


    }
}
