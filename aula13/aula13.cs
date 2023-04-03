using System;

class aula13
{
    static void Main(){
        var x="variavel";

        x = Console.ReadLine();

        switch(x){
            case "a":
            Console.Write("Opão 1");
            break;
            case "2":
            Console.Write("Int 2");
            break;
            default:
                Console.Write("é isso ai...");
            break;
        }
    }
}