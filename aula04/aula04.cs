using System;

class aula04{
    /*Variavel global a classe*/
    static int global_num;
    int global_NOstatic_num;
    static void Main(){
        int num;//Var local
        Console.WriteLine(global_num);
    }

    void teste(){
        int num; //var local
        Console.WriteLine(global_num);
    }
}