using System;
using System.Collections.Generic;
using System.Text;
using Sistema_de_pedidos;

namespace Sistema_de_pedidos
{
  public  class SistemaDepedisdos
    {



        static void Main(string[] args)
        {    //Boas vindas//
            Console.WriteLine("Olá seja bem vindo!!!");
            Console.WriteLine("Temos as melhores Blusas");

            //indentificando quem é o usuario//
            Console.WriteLine("Tenho cadastro ?");
            Console.WriteLine("Digite 1 para sim");
            Console.WriteLine("Digite 2 para Nao");
            Console.WriteLine("Digite 3 para colaborador");

            //caso ussuario ja tenha cadastro,sera levado a tela de login
            int sim = int.Parse(Console.ReadLine());
            if (sim == 1)
            {    //login
                Console.WriteLine("OK,  falta pouco para voce começar a comprar $$$, informe seu:  ");
                Console.WriteLine(" Login ");
                Console.ReadLine();

                //senha do usuario
                Console.WriteLine("iInforme sua senha ");
                Console.ReadLine();

                //lista produtos
                Pedidos Novo = new Pedidos();
                Console.WriteLine("  {0} ", Novo);
                int Total;
                Total = int.Parse(Console.ReadLine());
               
            }

            //caso nao tenha  login e senha, sera levado a atela para fazer  o cadastro.
            //criando login e senha.
            int nao = int.Parse(Console.ReadLine());
            if (nao == 2)
            {
                Console.WriteLine("Vamos realizar o cadastro!!!");
                Console.WriteLine(" Informe seu nome ");
                Console.ReadLine();
                Console.WriteLine("  Informe sua data de nacimento ");
                int.Parse(Console.ReadLine());

                Console.WriteLine("Tudo certo, agora vamos criar um login @....  ");
                Console.WriteLine(" Login ");
                Console.ReadLine();
                Console.WriteLine("Tudo certo, agora vamos criar uma SEMHA ***** ");
                Console.WriteLine("Senha ");
                Console.ReadLine();

                //lista produtos

                Pedidos Novo = new Pedidos();
                Console.WriteLine("  {0} ", Novo);
            }
               
            //caso seja colabora sera levado para a tela de login de colaborador
            int colaborador = int.Parse(Console.ReadLine());
            if (colaborador == 3)
                Console.WriteLine(" digite o 4 para Gerente ");
            Console.WriteLine(" digite o 5 para Estagiario ");

            {   //gerente
                int Gerente = int.Parse(Console.ReadLine());
                if (Gerente == 4)
                {

                    //nome do funcionario gerente
                    Console.WriteLine("escreva seu nome");
                    Funcionario G1 = new Funcionario();
                    Console.WriteLine("  {0} ", G1.nome);

                    //matricula funcionario gerente
                    Console.WriteLine("sua matricula");
                    Funcionario G2 = new Funcionario();
                    Console.WriteLine("{0} ", G2.matricula);

                    //calculando o deconto
                    Console.WriteLine(" digite o valor do desconto ");
                    int DescontoGerente;
                    DescontoGerente = int.Parse(Console.ReadLine());
                    Console.WriteLine("o valor é ", DescontoGerente);
                    Console.WriteLine("Digite o valor total da compra:");
                    int Total;
                    Total = int.Parse(Console.ReadLine());
                    Console.WriteLine("aguardando o pagamento no valor de: ", DescontoGerente - Total);
                    Console.WriteLine("Agaurdando o pagamento do pedido");

                }

                //estagiario

                int Estagiario = int.Parse(Console.ReadLine());
                if (Estagiario == 5)
                {
                    { //Nome Estagiario
                        Console.WriteLine("escreva seu nome");
                        Funcionario EstagiarioNome = new Funcionario();
                        Console.WriteLine(" seu nome é {0} ", EstagiarioNome.nome);
                        //matricula Estagiario
                        Funcionario EstagiarioMatricula = new Funcionario();
                        Console.WriteLine(" seu nome é {0} ", EstagiarioMatricula.matricula);
                        //calcular desconto
                        int DescontoEstagiario;
                        DescontoEstagiario = 30;
                        Console.WriteLine("o valor é ", DescontoEstagiario);
                        Console.WriteLine("Digite o valor total da compra:");
                        int Total;
                        Total = int.Parse(Console.ReadLine());
                        Console.WriteLine ("aguardando o pagamento no valor de: ", DescontoEstagiario - Total);
                        Console.WriteLine("Agaurdando o pagamento do pedido");
                    }

                }
            }

        }
    }
}

