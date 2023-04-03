
using System;

class aula08
{
    static void Main()
    {
        int v1,v2,soma;
        string nome;
        
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine(); //console readline n pucha int

        Console.Write("Digite o 1º Valor: ");
        v1=int.Parse(Console.ReadLine());

        Console.Write("Digite o 2º Valor: ");
        v2=Convert.ToInt32(Console.ReadLine());
        soma=v1+v2;
        Console.Write("então {0}. A Soma dos Produtos ",nome);
        if(v1<0){
            Console.Write("({0})",v1);
        }
        else{
            Console.Write("{0}",v1);
        }
        Console.Write(" + ");
        if(v2<0){
            Console.Write("({0})",v2);
        }
        else{
            Console.Write("{0}",v2);
        }
        Console.Write(" = {0}",soma);
    }

}