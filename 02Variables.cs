using System;
/*
Variáveis são referências  nomiadas que criamos para associar a valores
*/
namespace Ferreira.Filipe{
    class Variables{
        public static void Main(){
            //declaração de variáveis
            char Sexo = 'M';
            string Nome = "Filipe ferreira";
            int Idade = 25;
            double altura = 1.73;

            Console.WriteLine(@"Meu nome é {0} tenho {1} anos e tenho altura de {2}", Nome, Idade, altura);

        }
    }    
}