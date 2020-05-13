using System;
/*

*/
namespace Ferreira.Filipe{
    class Conditional {
        public static void Main(){
            int idade = 25;

//usando IF
            if(idade > 18)
                Console.WriteLine("Maior de idade!");
            else if(idade < 18 && idade > 0)
                Console.WriteLine("Menor de idade!");
            else
                Console.WriteLine("Erro!");

// usando switch
            char Sexo = 'M';
            switch(Sexo){
                case 'M' :
                Console.WriteLine("Masculino!");
                break;
                case 'F':
                    Console.WriteLine("Feminino!");
                    break;
                default:
                    Console.WriteLine("Indefinido!");
                    break;
            }
        }    
    }
}