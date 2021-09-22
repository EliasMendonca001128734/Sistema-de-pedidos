using System;
using System.Collections.Generic;
using System.Text;
using Sistema_de_pedidos;


namespace Sistema_de_pedidos
{
    public class Pedidos

    {



        public Pedidos()
        {


            Console.WriteLine("escolha  a cor da blusa");
            List<string> Produtos = new List<string>();
            {
                Console.WriteLine("Blusa Azul R$20");
                Produtos.Add("azul");
                int Azul;
                Azul = 20;

                Console.WriteLine("Blusa Verde R$30");
                Produtos.Add("verde");
                int Verde;
                Verde = 30;

                Console.WriteLine("Blusa Preto R$40");
                Produtos.Add("Preto");
                int Preto;
                Preto = 40;

                Console.WriteLine("Blusa Amarela R$50");
                Produtos.Add("amarela");
                int Amarela;
                Amarela = 50;

                Console.WriteLine("Blusa Vermelha R$60");
                int Vermelha;
                Vermelha = 60;

                Console.WriteLine("Blusa  Rosa R$70");
                Produtos.Add("Rosa");
                int Rosa;
                Rosa = 70;

                Console.WriteLine("Blusa Branca  R$80");
                Produtos.Add("Branca ");
                int Branca;
                Branca = 80;

                switch (Console.ReadLine())
                {
                    case "Azul":
                        Console.WriteLine(Azul);
                        break;
                    case "Verde":
                        Console.WriteLine(Verde);
                        break;
                    case "Preto":
                        Console.WriteLine(Preto);
                        break;
                    case " Amarela":
                        Console.WriteLine(Amarela);
                        break;

                    case " Vermelha":
                        Console.WriteLine(Vermelha);
                        break;

                    case " Branca ":
                        Console.WriteLine(Branca);
                        break;
                    case " Rosa ":
                        Console.WriteLine(Rosa);
                        break;
                      

                }
                
                int total;
                total = Rosa + Branca + Vermelha+Amarela+ Preto+ Verde+ Azul;
                Console.WriteLine("o valor do seu peddio é", total);
                Console.WriteLine("Chame um funcionario caso queira desconto");

                

            };

           
        }



    }
  



}
