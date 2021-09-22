using System;
using System.Collections.Generic;
using System.Text;
using Sistema_de_pedidos;

namespace Sistema_de_pedidos
{
    public class Gerente
    { //Nome Gerente
        public Gerente()
        {
            Funcionario GerenteNome = new Funcionario();
            Console.WriteLine(" seu nome é {0} ", GerenteNome.nome);

            //matricula funcionario gerente
            Funcionario G2 = new Funcionario();
            Console.WriteLine(" seu nome é {0} ", G2.matricula);

        }
    }

}
