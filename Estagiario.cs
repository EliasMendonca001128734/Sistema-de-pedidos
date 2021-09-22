using System;
using System.Collections.Generic;
using System.Text;
using Sistema_de_pedidos;


namespace sistema_de_pedidos
{
    public class Estagiario
    {
        public Estagiario() {
            //Nome Estagiario
            Funcionario EstagiarioNome = new Funcionario();
            Console.WriteLine(" seu nome é {0} ", EstagiarioNome.nome);

            //matricula Estagiario
            Funcionario EstagiarioMatricula = new Funcionario();
            Console.WriteLine(" seu nome é {0} ", EstagiarioMatricula.matricula);

        }

    }
}