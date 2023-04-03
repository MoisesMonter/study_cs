using System;

class aula03
{
    static void Main(){
        byte n0=10; // 0 e 255
        int num=-10;  //valores inteiros
        char letra='c'; //Armazena um caractere entre os apostrofos
        float valor=5.3f; //valores pontos flutuantes
        string nome="meu nome"; //armazena vários caracteres
        bool n1,n2,n3;
        n1= false;
        n2=true;
        n3=true;
        var aux=100;
        /*Não está especificando o tipo da váriavel, ela vai ser definida na compilação
         no tipo da atribuição que ela tem,
         se na compilação pedir um inteiro e aux=10 então aux é Inteiro
         Var também pode pegar uma variavel ex: aux=nome
         */
        if (aux <10){ 
            Console.WriteLine("VALOR DA VARIAVEL: "+ aux+"...");
        }
        else if(aux == 10){
            Console.WriteLine("VALOR DA VARIAVEL: "+ num+"...");
        }
        else if(aux > 10 && n3 == true){
            Console.WriteLine("Verdadeiro");
        }
        else{
            Console.WriteLine("VALOR DA VARIAVEL: "+ nome+"...");
        }
    }
}